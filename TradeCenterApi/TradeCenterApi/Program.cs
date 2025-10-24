
using Microsoft.Data.SqlClient;
using System.Data;
using TradeCenterApi.Repository.Implements;
using TradeCenterApi.Repository.Interfaces;

namespace TradeCenterApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddSwaggerGen();

            builder.Services.AddTransient<IUsuarioQueries, UsuarioQueries>();
            builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddTransient<ITcgQueries, TcgQueries>();
            builder.Services.AddTransient<IDetalleIntercambioQueries, DetalleIntercambioQueries>();
            builder.Services.AddTransient<IResenaQueries, ResenaQueries>();
            builder.Services.AddTransient<IResenaRepository, ResenaRepository>();
            builder.Services.AddTransient<IIntercambioRepository, IntercambioRepository>();
            builder.Services.AddTransient<IColeccionUsuarioQueries, ColeccionUsuarioQueries>();
            builder.Services.AddTransient<ICartaQueries, CartaQueries>();
            builder.Services.AddTransient<ICartaRepository, CartaRepository>();


            builder.Services.AddScoped<IDbConnection>(options =>
            {
                string connectionString = builder.Configuration.GetConnectionString("sql");
                return new SqlConnection(connectionString);
            });

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
