using BnBCheckIn_Client.Helper;
using BnBCheckIn_Client.Service.IService;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Pages.Authentication
{
    public partial class Register
    {
        [Inject]
        public IAuthenticationService authenticationService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IJSRuntime jsRuntime { get; set; }

        private UserRequestDTO RegisUser = new UserRequestDTO();

        private bool IsProcessing { get; set; } = false;

        private bool RegistrationErrors { get; set; } = false;

        public IEnumerable<string> Errors { get; set; }

        //---------------------------------------------------

        private async Task RegisterUser()
        {
            RegistrationErrors = false;
            IsProcessing = true;
            var result = await authenticationService.RegisterUser(RegisUser);
            if (result.IsRegistrationSuccessful)
            {
                IsProcessing = false;
                await jsRuntime.SweetAlertSuccess("U bent nu geregistreerd als nieuwe gebruiker.\nLog in om verder te gaan.");
                navManager.NavigateTo("/login");
            }
            else
            {
                IsProcessing = false;
                Errors = result.Errors;
                RegistrationErrors = true;
                await jsRuntime.SweetAlertError("Er is iets misgegaan bij de registratie. Probeer opnieuw.");
            }
        }
    }
}
