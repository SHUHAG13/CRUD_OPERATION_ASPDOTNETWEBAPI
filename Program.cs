using CollegeApp.Services;
using Microsoft.EntityFrameworkCore;

namespace CollegeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers()
                .AddNewtonsoftJson(); 

            
            builder.Services.AddDbContext<StudentDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDbConnection")));

          
            builder.Services.AddScoped<IStudentService, StudentService>();

           
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}
