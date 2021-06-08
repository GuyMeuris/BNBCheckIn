using BnBCheckIn_Client.Helper;
using BnBCheckIn_Client.Service.IService;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BnBCheckIn_Client.Pages.Authentication
{
    public partial class Login
    {
        [Inject]
        public IAuthenticationService authenticationService { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IJSRuntime jsRuntime { get; set; }

        private AuthenticationDTO AuthUser = new ();

        private bool IsProcessing { get; set; } = false;

        private bool AuthenticationError { get; set; } = false;

        public string Error { get; set; }

        public string ReturnUrl { get; set; }

        //---------------------------------------------------

        private async Task AuthenticateUser()
        {
            AuthenticationError = false;
            IsProcessing = true;
            var result = await authenticationService.Login(AuthUser);
            if (result.IsAuthenticationSuccessful)
            {
                IsProcessing = false;

                // when logged in, return to previous page or the main page
                var absoluteUri = new Uri(navManager.Uri);
                var queryParam = HttpUtility.ParseQueryString(absoluteUri.Query);
                ReturnUrl = queryParam["returnUrl"];
                if (string.IsNullOrEmpty(ReturnUrl))
                {
                    navManager.NavigateTo("/");
                }
                else
                {
                    navManager.NavigateTo("/" + ReturnUrl);
                }             
            }
            else
            {
                IsProcessing = false;
                Error = result.ErrorMessage;
                AuthenticationError = true;
                await jsRuntime.SweetAlertError("Er is iets misgegaan tijdens het inloggen. Probeer opnieuw.");
            }
        }
    }
}
