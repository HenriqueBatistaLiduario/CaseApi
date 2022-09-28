using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Course;

namespace Service.Services
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

        public async Task<CourseEntity> Post(CourseEntity courses)
        {
            // // Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            // if (course.STDFULLNAME == "Teste")
            // {
            //     return null;
            // }
            return await _repository.InsertAsync(courses);
        }

        public async Task<CourseEntity> Put(CourseEntity courses)
        {
            return await _repository.UpdateAsync(courses);
        }

        public async Task<bool> Delete(Guid GUID)
        {
            return await _repository.DeleteAsync(GUID);
        }
    }
}
