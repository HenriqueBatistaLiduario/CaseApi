using System.Threading.Tasks;
using Domain.DTOs;
using Domain.Entities;

namespace Domain.Interfaces.Services.User
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto user);
    }
}
