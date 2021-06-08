using BnBCheckIn_Client.Service.IService;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Pages.Authentication
{
    public partial class Logout
    {
        [Inject]
        public IAuthenticationService authenticationService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await authenticationService.Logout();
            navManager.NavigateTo("/");
        }
    }
}
