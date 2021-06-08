using Blazored.LocalStorage;
using BnBCheckIn_Client.Service.IService;
using Common;
using Microsoft.AspNetCore.Components.Authorization;
using ModelsDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _client;

        private readonly ILocalStorageService _localStorage;

        private readonly AuthenticationStateProvider _authStateProvider;

        public AuthenticationService(HttpClient client, 
                                ILocalStorageService localStorage, 
                                    AuthenticationStateProvider authStateProvider)
        {
            _client = client;
            _localStorage = localStorage;
            _authStateProvider = authStateProvider;
        }

        public async Task<AuthenticationResponseDTO> Login(AuthenticationDTO authenticationDTO)
        {
            var content = JsonConvert.SerializeObject(authenticationDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/account/signin", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AuthenticationResponseDTO>(contentTemp);
            if (response.IsSuccessStatusCode)
            {
                await _localStorage.SetItemAsync(LocalStorage.LS_Token, result.Token);
                await _localStorage.SetItemAsync(LocalStorage.LS_UserDetails, result.contactDTO);
                ((AuthStateProvider)_authStateProvider).NotifyUserLoggedIn(result.Token);
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);
                return new AuthenticationResponseDTO { IsAuthenticationSuccessful = true };
            }
            else
            {
                return result;
            }
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync(LocalStorage.LS_Token);
            await _localStorage.RemoveItemAsync(LocalStorage.LS_UserDetails);
            ((AuthStateProvider)_authStateProvider).NotifyUserLoggedOut();
            _client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegistrationResponseDTO> RegisterUser(UserRequestDTO userRequestDTO)
        {
            var content = JsonConvert.SerializeObject(userRequestDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("api/account/signup", bodyContent);
            var contentTemp = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RegistrationResponseDTO>(contentTemp);
            if (response.IsSuccessStatusCode)
            {
                return new RegistrationResponseDTO { IsRegistrationSuccessful = true };
            }
            else
            {
                return result;
            }
        }
    }
}
