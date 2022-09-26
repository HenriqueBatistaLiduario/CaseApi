using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Subject;

namespace Api.Service.Services
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
    }
}
