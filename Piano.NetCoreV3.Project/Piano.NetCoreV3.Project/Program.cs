using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Piano.NetCoreV3.Project
{
    /// <summary>
    /// 为什么可以跨平台？
    /// 因为微软出了可以在linux运行的clr
    ///
    /// aspnet3.0 core的运行时动态编译
    /// 安装nuget包：Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
    ///
    /// TempData序列化是，只能是基础类型，int类型，字典类型，不能是自定义类型
    /// asp.net mvc通过区域来区分空间
    ///缺点：
    ///    大包大揽，事情做的有点多，无法做到轻量级；
    /// 
    /// asp.net core mvc只能采用特性路由；
    ///    高度可定制，高性能，组件化，轻量级，不向前前兼容；
    ///
    /// 管道处理模型-中间件
    /// Startup--Config指定了处理管道
    /// 何为Http请求管道呢？
    /// 就是对http一连串的处理请求过程
    /// 就是给你一个HttpContext，然后一步一步的处理，最终得到一个结果
    /// 全新的管道模型：
    /// 默认情况，只有一个404
    /// 然后你就可以增加请求的处理（UseEndPoint），这就是以前的Handler。只包含业务处理
    /// 
    /// </summary>
    public class Program
    {
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
