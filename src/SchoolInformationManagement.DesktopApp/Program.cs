using Microsoft.Extensions.DependencyInjection;
using SchoolInformationManagement.Business.Abstract;
using SchoolInformationManagement.Business.Concrete;
using SchoolInformationManagement.DataAccess.Abstract;
using SchoolInformationManagement.DataAccess.Concrete; // IServiceCollection'ı kullanmak için gerekli

namespace SchoolInformationManagement.DesktopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Service collection oluştur
            var services = new ServiceCollection();

            // Dependencies ekleyin
            ConfigureServices(services);

            // Service provider oluştur
            var serviceProvider = services.BuildServiceProvider();
            var principalService = serviceProvider.GetRequiredService<IPrincipalService>();
            var schoolExitService = serviceProvider.GetRequiredService<ISchoolEntryExitService>();
            var classService = serviceProvider.GetRequiredService<IClassService>();
            var teacherService = serviceProvider.GetRequiredService<ITeacherService>();
            var studentService = serviceProvider.GetRequiredService<IStudentService>();
            var classAssignment = serviceProvider.GetRequiredService<IClassAssignmentService>();
            var parentsService = serviceProvider.GetRequiredService<IParentService>();

            // Form1'ı oluştururken IPrincipalService'i sağla
            Application.Run(new Login(principalService, schoolExitService, classService, teacherService, studentService, classAssignment, parentsService));
        }

        static void ConfigureServices(IServiceCollection services)
        {
            // IPrincipalService'in uygulamasını ekleyin (gerçek uygulamaya göre değiştirin)
            services.AddScoped<IPrincipalService, PrincipalManager>();
            services.AddScoped<IPrincipalDal, PrincipalDal>();
            services.AddScoped<ISchoolEntryExitService, SchoolEntryExitManager>();
            services.AddScoped<ISchoolEntryExitDal, SchoolEntryExitDal>();
            services.AddScoped<IClassService, ClassManager>();
            services.AddScoped<IClassDal, ClassDal>();
            services.AddScoped<ITeacherService, TeacherManager>();
            services.AddScoped<ITeacherDal, TeacherDal>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<IStudentDal, StudentDal>();
            services.AddScoped<IClassAssignmentService, ClassAssignmentManager>();
            services.AddScoped<IClassAssignmentDal, ClassAssignmentDal>();
            services.AddScoped<IParentService, ParentManager>();
            services.AddScoped<IParentDal, ParentDal>();
        }
    }
}
