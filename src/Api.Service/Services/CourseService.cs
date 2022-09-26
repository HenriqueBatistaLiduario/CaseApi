using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Course;

namespace Api.Service.Services
{
    public class CourseService : ICourseService
    {
        private IRepository<CourseEntity> _repository;

        public CourseService(IRepository<CourseEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        public async Task<CourseEntity> Get(Guid GUID) //Trazer dados conforme Guid.
        {
            return await _repository.SelectAsync(GUID);
        }

        public async Task<IEnumerable<CourseEntity>> GetAll() //Listar todos os cursos da base (SELECT sem WHERE)
        {
            return await _repository.SelectAsync();
        }
    }
}
