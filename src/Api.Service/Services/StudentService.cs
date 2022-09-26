using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Student;

namespace Api.Service.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<StudentEntity> _repository;

        public StudentService(IRepository<StudentEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        //Retornando os métodos criados na Api.Data
        public async Task<bool> Delete(Guid GUID)
        {
            return await _repository.DeleteAsync(GUID);
        }

        public async Task<StudentEntity> Get(Guid GUID)
        {
            return await _repository.SelectAsync(GUID);
        }

        public async Task<StudentEntity> Post(StudentEntity student)
        {
            // Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            if (student.STDFULLNAME == "Teste")
            {
                return null;
            }
            return await _repository.InsertAsync(student);
        }

        public async Task<StudentEntity> Put(StudentEntity student)
        {
            return await _repository.UpdateAsync(student);
        }
    }
}
