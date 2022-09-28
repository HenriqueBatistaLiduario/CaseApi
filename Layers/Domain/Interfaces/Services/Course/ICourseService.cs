using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces.Services.Course
{
    public interface ICourseService
    {
        Task<CourseEntity> Get(Guid GUID);
        Task<IEnumerable<CourseEntity>> GetAll();
        Task<CourseEntity> Post(CourseEntity courses);
        Task<CourseEntity> Put(CourseEntity courses);
        Task<bool> Delete(Guid GUID);
    }
}
