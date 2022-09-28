using Service.Services;
using Domain.Interfaces.Services.User;
using Domain.Interfaces.Services.Bill;
using Domain.Interfaces.Services.Course;
using Domain.Interfaces.Services.Subject;
using Domain.Interfaces.Services.Student;
using Microsoft.Extensions.DependencyInjection;

namespace Cross.DependencyInjection
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
