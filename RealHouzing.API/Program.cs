using RealHouzing.BusinessLayer.Abstract;
using RealHouzing.BusinessLayer.Concrete;
using RealHouzing.DataAccessLayer.Abstract;
using RealHouzing.DataAccessLayer.Concrete;
using RealHouzing.DataAccessLayer.EntityFramework;
using System.Text.Json.Serialization;

namespace RealHouzing.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

            builder.Services.AddScoped<IProductDAL, EFProductDAL>();
            builder.Services.AddScoped<IProductService, ProductManager>();

            builder.Services.AddControllersWithViews()
    .AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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