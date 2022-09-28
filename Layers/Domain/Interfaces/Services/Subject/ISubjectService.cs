using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces.Services.Subject
{
    public interface ISubjectService
    {

        Task<SubjectEntity> Get(Guid GUID);
        Task<IEnumerable<SubjectEntity>> GetAll();
        Task<SubjectEntity> Post(SubjectEntity courses);
        Task<SubjectEntity> Put(SubjectEntity courses);
        Task<bool> Delete(Guid GUID);
    }
}
