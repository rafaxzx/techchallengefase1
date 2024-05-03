
using Microsoft.EntityFrameworkCore;
using TechChallengeFase1.Entities;
using TechChallengeFase1.Interfaces;
using TechChallengeFase1.Repository;
using TechChallengeFase1.Services;

namespace TechChallengeFase1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Criar o configuration builder
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("ConnectionString"));
            }, ServiceLifetime.Scoped);

            //Add depedencies injection
            builder.Services.AddScoped<IRepository<Contact>, ContactRepository>();
            builder.Services.AddScoped<IRepository<DDD>, DDDRepository>();
            builder.Services.AddScoped<IService<DDD>, DDDService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
