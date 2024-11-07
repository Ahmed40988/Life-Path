using Microsoft.EntityFrameworkCore;
using Data; // Assuming your DbContext class is in this namespace

namespace Lifecare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Get the connection string from appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("con");

            // Register Caredbcontext with the DI system using the connection string
            // على فرض إنك بتستخدم SQL Server كمزود قاعدة بيانات
            builder.Services.AddDbContext<Caredbcontext>(options =>
                options.UseSqlServer(connectionString, sqlOptions =>
                    sqlOptions.MigrationsAssembly("Dal"))); // تحديد تجميعة الهجرات


            // Add services to the container
            builder.Services.AddControllers();

            // Add Swagger for API documentation
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline
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
