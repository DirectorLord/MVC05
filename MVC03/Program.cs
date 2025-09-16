using BLL.Services;
using DAL.Context.Configurations;
using DAL.Reporsitories;
using Microsoft.EntityFrameworkCore;

namespace MVC03;
public class Program
{
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddScoped<IDepartmentService, DepartmentService>();
        builder.Services.AddScoped<IdepartmentRepository, deparmentRepository>();
        //builder.Services.AddScoped<IdepartmentRepository, deparmentRepository>();
        //builder.Services.AddScoped<CompanyDBContext>(provider =>
        //{
        //    var builder = new DbContextOptionsBuilder<CompanyDBContext>();
        //    builder.UseSqlServer("");
        //    return new CompanyDBContext(builder.Options);
        //});
        builder.Services.AddDbContext<CompanyDBContext>(options =>
        {
            var _ = builder.Configuration["ConnectionsString:DefaultConnection"];
            options.UseSqlServer();
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");

            app.UseHsts();


            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();


            app.Run();

        }
    }
}