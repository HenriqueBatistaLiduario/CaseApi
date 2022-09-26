using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;

        public UserService(IRepository<UserEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        //Retornando os métodos criados na Api.Data
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

        public async Task<UserEntity> Post(UserEntity user)
        {
            // Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            if (user.USERNAME == "Teste")
            {
                return null;
            }
            return await _repository.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
