using Week6_Q_InjectDep.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Week6_Q_InjectDep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Ajout des services de contrôleur
            builder.Services.AddControllers();

            // Ajout du service ISalaryCalculator
            // builder.Services.AddScoped<ISalaryCalculator, MonthlySalaryCalculator>();
            builder.Services.AddScoped<ISalaryCalculator, QuarterlySalaryCalculator>();

            var app = builder.Build();

            // Configuration de l'application pour utiliser les contrôleurs
            app.MapControllers();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
