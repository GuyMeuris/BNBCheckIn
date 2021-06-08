using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BnBCheckIn_Client.Service.IService
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDTO> RegisterUser(UserRequestDTO userRequestDTO);

        Task<AuthenticationResponseDTO> Login(AuthenticationDTO autheticationDTO);

        Task Logout();
    }
}
