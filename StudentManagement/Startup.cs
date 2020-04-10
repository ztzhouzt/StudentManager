using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace StudentManagement
{
    public class Startup
    {
        /// <summary>
        /// 配置
        /// </summary>
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region

            //app.Use(async (context, next) =>
            //{
            //    //进程名
            //    //var processName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            //    //var configValue = _configuration["myKey"];

            //    context.Response.ContentType = "text/plain;charset=utf-8";

            //    logger.LogInformation("M1: 传入请求");

            //    await context.Response.WriteAsync("第一个中间件");
            //    await next();

            //    logger.LogInformation("M1: 传出响应");
            //});

            //app.Use(async (context, next) =>
            //{

            //    logger.LogInformation("M2: 传入请求");
            //    await next();
            //    logger.LogInformation("M2: 传出响应");
            //});

            #endregion

            #region

            ////DefaultFilesOptions options = new DefaultFilesOptions();
            ////options.DefaultFileNames.Clear();
            ////options.DefaultFileNames.Add("mydefault.html");

            ////添加默认文件中间件
            //app.UseDefaultFiles(options);

            ////添加静态文件中间件
            //app.UseStaticFiles();

            #endregion

            //FileServerOptions options = new FileServerOptions();
            //options.DefaultFilesOptions.DefaultFileNames.Clear();
            //options.DefaultFilesOptions.DefaultFileNames.Add("mydefault.html");
            //app.UseFileServer(options);

            //app.UseFileServer();

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                //throw new Exception("你的请求在管道中发生了一些错误。");
                //"Hosting ENVIRONMENT:" + env.EnvironmentName
                await context.Response.WriteAsync("Hello World");
            });
        }
    }
}
