using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.Student;

namespace Service.Services
{
    public class StudentService : IStudentService
    {
        private IRepository<StudentEntity> _repository;

        public StudentService(IRepository<StudentEntity> repository) //Injeção de dependência 
        {
            _repository = repository;
        }

        //Retornando os métodos criados na Data
        public async Task<bool> Delete(Guid GUID)
        {
            return await _repository.DeleteAsync(GUID);
        }

        public async Task<StudentEntity> Get(Guid GUID)
        {
            return await _repository.SelectAsync(GUID);
        }

        public async Task<StudentEntity> Post(StudentEntity students)
        {
            // Exemplo de regra de negócio se optar por definir aqui (embora não seja o melhor local)...
            if (students.STDFULLNAME == "Teste")
            {
                return null;
            }
            return await _repository.InsertAsync(students);
        }

        public async Task<StudentEntity> Put(StudentEntity students)
        {
            return await _repository.UpdateAsync(students);
        }
    }
}
