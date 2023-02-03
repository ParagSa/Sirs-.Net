namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Default}/{action=Index}/{id?}");
            //app.MapControllerRoute(
            //    name: "default2",
            //    pattern: "{controller=Default}/{action=Index}/{id?}/{x?}");
            //app.MapControllerRoute(
            //    name: "default3",
            //    pattern: "{controller=Default}/{action=Index}/{x?}");

            // /default/Index/10
            // /Employees/Display/10
            // /Products/Display/10
            // /Employees/Edit/10
            // /Employees/Delete/10


            app.Run();
        }
    }
}