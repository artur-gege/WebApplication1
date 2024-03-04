namespace WebApplication1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration config)
        {
            if (env.IsDevelopment()) 
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Its default route");
                });

                endpoints.MapGet("/about", async context =>
                {
                    await context.Response.WriteAsync("Its about route");
                });

            });

        }

    }

}
