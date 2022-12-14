using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntity> Get(Guid GUID);
        Task<IEnumerable<UserEntity>> GetAll();
        Task<UserEntity> Post(UserEntity user);
        Task<UserEntity> Put(UserEntity user);
        Task<bool> Delete(Guid GUID);
    }
}
