using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace BnBCheckIn_Client.Pages.Authentication
{
    public partial class RedirectToLogin
    {
        [Inject]
        public NavigationManager navManager { get; set; } 
        [CascadingParameter]
        public Task<AuthenticationState> authenticationState{ get; set; }

        protected override async Task OnInitializedAsync()
        {
            var returnUrl = navManager.ToBaseRelativePath(navManager.Uri);
            if (string.IsNullOrEmpty(returnUrl))
            {
                navManager.NavigateTo("login", true);
            }
            else
            {
                navManager.NavigateTo($"login?returnUrl={returnUrl}", true);
            }
        }
    }
}
