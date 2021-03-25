using MarketWatch.Application.DTOs.Requests;
using System.Threading.Tasks;

namespace MarketWatch.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<string> Register(RegisterRequest request);
        Task<string> Login(LoginRequest request);
    }
}
