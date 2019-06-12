using Autofac;
using CaptchaGen;
using CodeCarvings.Piczard;
using CodeCarvings.Piczard.Filters.Watermarks;
using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZSZ.Common;
using ZSZ.Service;

namespace CommonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string codes = CommonHelper.GetVerifyCode(4);

            //using (MailMessage mailMessage = new MailMessage())
            //using (SmtpClient smtpClient = new SmtpClient("smtp.163.com"))
            //{
            //    mailMessage.To.Add("395208782@qq.com");
            //    mailMessage.Body = "京东物流SOP，京东无界，菜鸟电子面单,申通直接对接，顺丰直接对接，圆通直接对接，韵达直接对接";
            //    mailMessage.From = new MailAddress("19934512006@163.com");
            //    mailMessage.Subject = "交接内容";
            //    smtpClient.Credentials = new System.Net.NetworkCredential("19934512006@163.com", "aevej7v9");//如果启用了“客户端授权码”，要用授权码代替密码
            //    smtpClient.Send(mailMessage);
            //}

            /*缩略图代码
            ImageProcessingJob jobThumb = new ImageProcessingJob();
            jobThumb.Filters.Add(new FixedResizeConstraint(200, 200));//设置缩略图尺寸
            jobThumb.SaveProcessedImageToFileSystem(@"D:\s.png", @"D:\suolue.png");
            */

            /*为图片添加水印代码
            ImageWatermark imageWatermark = new ImageWatermark(@"D:\logo.png");//水印图片的路径
            imageWatermark.ContentAlignment = System.Drawing.ContentAlignment.BottomRight;//设置水印的位置
            imageWatermark.Alpha = 50;//设置水印的透明度
            ImageProcessingJob jobThumb = new ImageProcessingJob();
            jobThumb.Filters.Add(imageWatermark);//添加水印
            jobThumb.SaveProcessedImageToFileSystem(@"D:\s.png", @"D:\shuiyintest.png");
            */

            /*生成图片验证码代码
            using (MemoryStream ms = ImageFactory.GenerateImage(CommonHelper.GetVerifyCode(4), 45, 60, 15, 15))
            using (FileStream fs = File.OpenWrite(@"D:\yanzhengma.png"))
            {
                ms.CopyTo(fs);
            }*/

            //log4net基本应用
            //log4net.Config.XmlConfigurator.Configure();

            //ILog log = LogManager.GetLogger(typeof(Program));
            //log.Debug("飞行高度10000米");
            //log.Error("快没油啦");
            //log.Fatal("已经没有油啦！！！！");

            //try
            //{
            //    SqlConnection conn = new SqlConnection();
            //    conn.Open();
            //}
            //catch (Exception ex)
            //{
            //    log.Error("连接数据库异常：" + ex);
            //}

            //autofac基本使用
            ////首先创建一个容器
            //ContainerBuilder builder = new ContainerBuilder();
            ////获取实现类所在的程序集
            //Assembly assembly = Assembly.Load("ZSZ.Service");
            ////从实现类所在的程序集中进行注册，
            //builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().SingleInstance().PropertiesAutowired();
            //IContainer container = builder.Build();
            //IPersonService person = container.Resolve<IPersonService>();
            //person.AddNew("123", "2352354");
            //using (ZSZDBContext ctx = new ZSZDBContext())
            //{
            //    ctx.Database.Delete();
            //    ctx.Database.Create();
            //}

            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
