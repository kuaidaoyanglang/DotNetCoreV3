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
    /// Ϊʲô���Կ�ƽ̨��
    /// ��Ϊ΢����˿�����linux���е�clr
    ///
    /// aspnet3.0 core������ʱ��̬����
    /// ��װnuget����Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
    ///
    /// TempData���л��ǣ�ֻ���ǻ������ͣ�int���ͣ��ֵ����ͣ��������Զ�������
    /// asp.net mvcͨ�����������ֿռ�
    ///ȱ�㣺
    ///    ������������������е�࣬�޷�������������
    /// 
    /// asp.net core mvcֻ�ܲ�������·�ɣ�
    ///    �߶ȿɶ��ƣ������ܣ��������������������ǰǰ���ݣ�
    ///
    /// �ܵ�����ģ��-�м��
    /// Startup--Configָ���˴���ܵ�
    /// ��ΪHttp����ܵ��أ�
    /// ���Ƕ�httpһ�����Ĵ����������
    /// ���Ǹ���һ��HttpContext��Ȼ��һ��һ���Ĵ������յõ�һ�����
    /// ȫ�µĹܵ�ģ�ͣ�
    /// Ĭ�������ֻ��һ��404
    /// Ȼ����Ϳ�����������Ĵ���UseEndPoint�����������ǰ��Handler��ֻ����ҵ����
    /// foreach (var component in _components.Reverse())//��תί���б�
    ///{
    ///    app = component(app);
    ///    //ί��3 404��Ϊ�������ã�����ί��3�����ö���-��Ϊ����ȥ����ί�У���Ϊ��ί��2�Ĳ�����
    ///    //���յõ�ί��1�����ò���
    ///    //��������HttpContext��������ί��1�����
    ///}
    /// ��ʵRequestBuilder֮�����һ��RequestDelegate
    /// Ĭ������£��ܵ��ǿյģ�����404�����Ը�������������������ִ�У�һ��ȫ�ɿ����߶���ִ��
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
