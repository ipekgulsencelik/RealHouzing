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

            builder.Services.AddControllersWithViews();
            
            builder.Services.AddDbContext<Context>();

            builder.Services.AddScoped<ICategoryDAL, EFCategoryDAL>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

            builder.Services.AddScoped<IProductDAL, EFProductDAL>();
            builder.Services.AddScoped<IProductService, ProductManager>();

            builder.Services.AddScoped<IOptionDAL, EFOptionDAL>();
            builder.Services.AddScoped<IOptionService, OptionManager>();

            builder.Services.AddScoped<IContactDAL, EFContactDAL>();
            builder.Services.AddScoped<IContactService, ContactManager>();

            builder.Services.AddScoped<IContactInformationDAL, EFContactInformationDAL>();
            builder.Services.AddScoped<IContactInformationService, ContactInformationManager>();

            builder.Services.AddScoped<IMapDAL, EFMapDAL>();
            builder.Services.AddScoped<IMapService, MapManager>();

            builder.Services.AddScoped<IAboutDAL, EFAboutDAL>();
            builder.Services.AddScoped<IAboutService, AboutManager>();

            builder.Services.AddScoped<IBlogDAL, EFBlogDAL>();
            builder.Services.AddScoped<IBlogService, BlogManager>();

            builder.Services.AddScoped<IBuyLeaseDAL, EFBuyLeaseDAL>();
            builder.Services.AddScoped<IBuyLeaseService, BuyLeaseManager>();

            builder.Services.AddScoped<IServiceDAL, EFServiceDAL>();
            builder.Services.AddScoped<IServiceService, ServiceManager>();

            builder.Services.AddScoped<ISubscribeDAL, EFSubscribeDAL>();
            builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

            builder.Services.AddScoped<ITeamDAL, EFTeamDAL>();
            builder.Services.AddScoped<ITeamService, TeamManager>();

            builder.Services.AddScoped<ITestimonialDAL, EFTestimonialDAL>();
            builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

            builder.Services.AddScoped<IVideoDAL, EFVideoDAL>();
            builder.Services.AddScoped<IVideoService, VideoManager>();

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