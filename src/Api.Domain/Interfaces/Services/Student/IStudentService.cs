using System;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Student
{
    public interface IStudentService
    {
        Task<StudentEntity> Get(Guid GUID);
        Task<StudentEntity> Post(StudentEntity student);
        Task<StudentEntity> Put(StudentEntity student);
        Task<bool> Delete(Guid GUID);
    }
}
