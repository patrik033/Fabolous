using BussinessLogicLibrary;
using DatabaseAccessLibrary;
using Microsoft.EntityFrameworkCore;


namespace FabolousUI
{
    public partial class Program
    {
        static Garage_Functions garage_Functions = new Garage_Functions();
        public static Parking_Garage garage = new Parking_Garage();
        
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<FabolousDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            //garage = garage_Functions.InstanciateGarage(100);
            //garage = garage_Functions.GetParkedVehicles(garage);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
