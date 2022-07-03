using Microsoft.Extensions.FileProviders;

namespace Webgentle.BookStore
{
    public class Startup
    {
        public  void ConfigureServices(IServiceCollection services)
        {
            /*
            services.AddMvc();//MVC
            services.AddControllers();//WebAPI
            services.AddControllersWithViews();//MVC
            services.AddRazorPages();
            */
            services.AddControllersWithViews();
        }
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*
            app.Use( async(context,next) =>
            {
                await context.Response.WriteAsync("Hello From my First middleware\n");
                await next(context);
                await context.Response.WriteAsync("Second Message From my First middleware\n");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello From my Second middleware\n");
                await next(context);
                await context.Response.WriteAsync("Second Message From my Second middleware\n");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Hello From my Third middleware *\n");
                await next();
            });
            */
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "MyStaticFiles")),
                RequestPath = "/MyStaticFiles"
            });
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                /*
                endpoints.MapGet("/", async context =>
                {
                    
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Hello From Development\n");
                        app.UseDeveloperExceptionPage();
                    }
                    else if (env.IsProduction())
                    {
                        await context.Response.WriteAsync("Hello From Production\n");
                    }
                    else if (env.IsStaging())
                    {
                        await context.Response.WriteAsync("Hello From Staging\n");
                    }
                    else
                    {
                        await context.Response.WriteAsync(env.EnvironmentName);
                    }
                    
                    await context.Response.WriteAsync("Hello World");
                });
                */
                endpoints.MapDefaultControllerRoute();

            });
            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/piyush", async context =>
                {
                    await context.Response.WriteAsync("Hello Piyush\n");
                });
            });
            */
        }
    }
}
