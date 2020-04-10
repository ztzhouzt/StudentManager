using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace StudentManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            //CreateDefaultBuilder 默认的主机生成器 
            //CreateDefaultBuilder 会加载一些默认配置
            //如：环境变量(DOTNET开头)、加载命令行参数、加载应用配置、配置的默认日志组件
            WebHost.CreateDefaultBuilder(args)
           
            //调用这里面的一些扩展方法，进行自定义的配置
            //其中一个默认的配置，启用了kestrel
                .UseStartup<Startup>();


    }
}
