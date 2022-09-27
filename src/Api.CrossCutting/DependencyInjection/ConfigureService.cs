using Api.Service.Services;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Interfaces.Services.Bill;
using Api.Domain.Interfaces.Services.Course;
using Api.Domain.Interfaces.Services.Subject;
using Api.Domain.Interfaces.Services.Student;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService //Os serviços de todas as entidades podem ser configurados aqui, para fins de injeção de dependência.
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();
            serviceCollection.AddTransient<IBillService, BillService>();
            serviceCollection.AddTransient<ICourseService, CourseService>();
            serviceCollection.AddTransient<ISubjectService, SubjectService>();
            serviceCollection.AddTransient<IStudentService, StudentService>();
        }
    }
}
