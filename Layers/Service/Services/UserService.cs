using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.User;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;

        public UserService(IRepository<UserEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        //Retornando os métodos criados na Data
        public async Task<bool> Delete(Guid GUID)
        {
            return await _repository.DeleteAsync(GUID);
        }

        public async Task<UserEntity> Get(Guid GUID)
        {
            return await _repository.SelectAsync(GUID);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<UserEntity> Post(UserEntity users)
        {
            // Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            if (users.USERNAME == "Teste")
            {
                return null;
            }
            return await _repository.InsertAsync(users);
        }

        public async Task<UserEntity> Put(UserEntity users)
        {
            return await _repository.UpdateAsync(users);
        }
    }
}
