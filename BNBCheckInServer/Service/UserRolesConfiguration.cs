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
    public class UserRolesConfiguration : IUserRolesConfiguration
    {
        private readonly BnBDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        public UserRolesConfiguration(BnBDbContext context, 
                            UserManager<IdentityUser> userManager, 
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

            if (_context.Roles.Any()) 
            {
                _roleManager.CreateAsync(new IdentityRole(RoleDefinition.Role_Admin.ToString())).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(RoleDefinition.Role_User.ToString())).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(RoleDefinition.Role_Visitor.ToString())).GetAwaiter().GetResult();
            };

            _userManager.CreateAsync(new IdentityUser
            {
                UserName = "bnbadmin@gmail.com",
                Email = "bnbadmin@gmail.com",
                EmailConfirmed = true
                
            }, "BbAdmin123+").GetAwaiter().GetResult();

            IdentityUser user = _context.Users.FirstOrDefault(u => u.Email == "bnbadmin@gmail.com");
            _userManager.AddToRoleAsync(user, RoleDefinition.Role_Admin).GetAwaiter().GetResult();
        }
    }
}
