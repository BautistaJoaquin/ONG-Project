using System.Threading.Tasks;
using OngProject.Application.DTOs;
using OngProject.Application.DTOs.Identity;

namespace OngProject.Application.Interfaces.Identity
{
    public interface IIdentityService
    {
        Task<string> Register(AuthRequestDto requestDto);

        Task<AuthResponseDto> Login(AuthRequestDto requestDto);

        Task<CurrentUserDto> Me();

        Task<string> GetEmail(string id);

        Task<string> GetUserRol(string id);

        Task Delete(string id);
    }
}