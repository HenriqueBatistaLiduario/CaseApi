using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Course
{
    public interface ICourseService
    {
        Task<CourseEntity> Get(Guid GUID);
        Task<IEnumerable<CourseEntity>> GetAll();
    }
}
