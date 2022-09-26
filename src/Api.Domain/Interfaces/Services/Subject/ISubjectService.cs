using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Subject
{
    public interface ISubjectService
    {
        Task<SubjectEntity> Get(Guid GUID);
        Task<IEnumerable<SubjectEntity>> GetAll();
    }
}
