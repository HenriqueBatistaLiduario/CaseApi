using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Subject;

namespace Service.Services
{
    public class SubjectService : ISubjectService
    {
        private IRepository<SubjectEntity> _repository;

        public SubjectService(IRepository<SubjectEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        public async Task<SubjectEntity> Get(Guid GUID) //Trazer dados conforme Guid.
        {
            return await _repository.SelectAsync(GUID);
        }

        public async Task<IEnumerable<SubjectEntity>> GetAll() //Listar todas as disciplinas da base (SELECT sem WHERE)
        {
            return await _repository.SelectAsync();
        }

        public async Task<SubjectEntity> Post(SubjectEntity subjects)
        {
            // // Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            // if (course.STDFULLNAME == "Teste")
            // {
            //     return null;
            // }
            return await _repository.InsertAsync(subjects);
        }

        public async Task<SubjectEntity> Put(SubjectEntity subjects)
        {
            return await _repository.UpdateAsync(subjects);
        }

        public async Task<bool> Delete(Guid GUID)
        {
            return await _repository.DeleteAsync(GUID);
        }
    }
}
