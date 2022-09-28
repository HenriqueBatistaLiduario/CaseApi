using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Bill;

namespace Service.Services
{
    public class BillService : IBillService
    {
        private IRepository<BillEntity> _repository;

        public BillService(IRepository<BillEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid GUID)
        {
            return await _repository.DeleteAsync(GUID);
        }

        public async Task<BillEntity> Get(Guid GUID) //Trazer boletim conforme Guid do próprio boletim. Faz mais sentido trazer o boletim passando o GUID ou matrícula do aluno.
        {
            return await _repository.SelectAsync(GUID);
        }

        public async Task<IEnumerable<BillEntity>> GetAll() //Listar todos os boletins da base (SELECT sem WHERE)
        {
            return await _repository.SelectAsync();
        }

        public async Task<BillEntity> Post(BillEntity bulletins)
        {
            // Regras/condições para que um registro seja salvo na base. 
            //Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            if (bulletins.BLTPERIOD == "2021")
            {
                return null;
            }
            return await _repository.InsertAsync(bulletins);
        }

        public async Task<BillEntity> Put(BillEntity bulletins)
        {
            return await _repository.UpdateAsync(bulletins);
        }
    }
}
