using Microsoft.EntityFrameworkCore;
using MVC2.Models;

namespace MVC2.Data
{
    public static class PopulaDb
    {
        public static void CreateDBIfNotExists(IApplicationBuilder app)
        {
            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    PopulaDb.IncluiDadosDB(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error ocurred creating the DB");
                }
            }
        }

        public static void IncluiDadosDB(AppDbContext context)
        {
            System.Console.WriteLine("Aplicando Migrations...");
            context.Database.Migrate();
            if(!context.Produtos.Any())
            {
                System.Console.WriteLine("Criando dados...");
                context.Produtos.AddRange(
                    new Produto("Luvas de goleiro", "Futebol", 25),
                    new Produto("Bola de Basquete", "Basquete", 48.95m),
                    new Produto("Bola de Futebol", "Futebol", 19.50m),
                    new Produto("Meias Grandes", "Futebol", 29.95m),
                    new Produto("Cesta para Quadra", "Basquete", 50)
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Dados já existem...");
            }
        }
    }
}