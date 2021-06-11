using Common;
using BNBCheckInServer.Service.IService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Data;

namespace BNBCheckInServer.Service
{
    // Class for seeding the client user roles and creating an admin user (hard coded)
    public class UserRolesConfiguration : IUserRolesConfiguration
    {
        private readonly BnBDbContext _context;

        private readonly UserManager<Contact> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesConfiguration(BnBDbContext context, 
                            UserManager<Contact> userManager, 
                                    RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void InitializeUserRoles()
        {
            try
            {
                if (_context.Database.GetPendingMigrations().Count() > 0)
                {
                    _context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "The pending migrations failed to migrate to the database!");
                throw;
            }

            if (!_context.Roles.Any(x => x.Name == RoleDefinition.Role_Admin))
            {
                _roleManager.CreateAsync(new IdentityRole(RoleDefinition.Role_Admin.ToString())).GetAwaiter().GetResult();
            }

            if (!_context.Roles.Any(x => x.Name == RoleDefinition.Role_User))
            {
                _roleManager.CreateAsync(new IdentityRole(RoleDefinition.Role_User.ToString())).GetAwaiter().GetResult();
            }

            if (!_context.Roles.Any(x => x.Name == RoleDefinition.Role_Visitor))
            {
                _roleManager.CreateAsync(new IdentityRole(RoleDefinition.Role_Visitor.ToString())).GetAwaiter().GetResult();
            }

            var adminRole = _context.Roles.FirstOrDefault(r => r.Name == RoleDefinition.Role_Admin);

            if (!_context.UserRoles.Any(ur => ur.RoleId == adminRole.Id))
            {
                _userManager.CreateAsync(new Contact
                {
                    UserName = "bnbadmin@gmail.com",
                    Email = "bnbadmin@gmail.com",
                    EmailConfirmed = true

                }, "BbAdmin123+").GetAwaiter().GetResult();

                Contact user = _context.Users.FirstOrDefault(u => u.Email == "bnbadmin@gmail.com");
                _userManager.AddToRoleAsync(user, RoleDefinition.Role_Admin).GetAwaiter().GetResult();
            }
        }
    }
}
