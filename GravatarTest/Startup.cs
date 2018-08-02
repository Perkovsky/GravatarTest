using System.IO;
using GravatarTest.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace GravatarTest
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepository, MemoryRepository>();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // подключаем файлы по умолчанию
            app.UseDefaultFiles();
            // подключаем статические файлы
            app.UseStaticFiles();
            // добавляем поддержку каталога node_modules
            app.UseFileServer(new FileServerOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "node_modules")),
                RequestPath = "/node_modules",
                EnableDirectoryBrowsing = false
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}
