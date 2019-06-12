using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ZSZ.Common
{
    /// <summary>
    /// 通用工具类
    /// </summary>
    public static class CommonHelper
    {
        /// <summary>
        /// 将字符串转换为Md5编码的字符串
        /// </summary>
        /// <param name="str">需要转换的字符串</param>
        /// <returns></returns>
        public static string CalcMD5(this string str)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(str);
            return CalcMD5(bytes);
        }

        /// <summary>
        /// 将字节数组转换为对应的Md5编码的字符串
        /// </summary>
        /// <param name="bytes">需要转换的字节数组</param>
        /// <returns></returns>
        public static string CalcMD5(byte[] bytes)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeBytes = md5.ComputeHash(bytes);
                string result = "";
                for (int i = 0; i < computeBytes.Length; i++)
                {
                    result += computeBytes[i].ToString("X").Length == 1 ? "0" +
                   computeBytes[i].ToString("X") : computeBytes[i].ToString("X");
                }
                return result;
            }
        }

        /// <summary>
        /// 将数据流转换为Md5编码的字符串
        /// </summary>
        /// <param name="stream">需要转换的数据流</param>
        /// <returns></returns>
        public static string CalcMD5(Stream stream)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] computeBytes = md5.ComputeHash(stream);
                string result = "";
                for (int i = 0; i < computeBytes.Length; i++)
                {
                    result += computeBytes[i].ToString("X").Length == 1 ? "0" +
                   computeBytes[i].ToString("X") : computeBytes[i].ToString("X");
                }
                return result;
            }
        }

        /// <summary>
        /// 获得一个制定长度的验证码
        /// </summary>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public static string GetVerifyCode(int len)
        {
            char[] codes = { 'a', 'c', 'd', 'e', 'f', 'h', 'j', 'k', 'm', 'n',
                'p', 'r', 's', 't', 'w', 'x', 'y', '3', '4', '5', '7', '8' };

            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = random.Next(codes.Length);
                char code = codes[index];
                sb.Append(code);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="toMailAddress">接收邮件的邮箱</param>
        /// <param name="verifyCode">验证码</param>
        public static void SendMail(string toMailAddress,string verifyCode)
        {
            using (MailMessage mailMessage = new MailMessage())
            using (SmtpClient smtpClient = new SmtpClient("smtp.163.com"))
            {
                mailMessage.To.Add(toMailAddress);
                mailMessage.Body = "尊敬的用户，您好，欢迎注册，验证码为"+verifyCode+",请在注册页" +
                    "面输入该验证码完成注册，请勿将验证码泄露给他人";
                mailMessage.From = new MailAddress("19934512006@163.com");
                mailMessage.Subject = "交接内容";
                //smtpClient.EnableSsl = true;//如果启用了 ssl，并且不支持非安全连接，还需要设置 smptClient. EnableSsl=true; 只
                //要支持 ssl 建议都开启 ssl，这样数据传输更安全。
                smtpClient.Credentials = new System.Net.NetworkCredential("19934512006@163.com", "aevej7v9");//如果启用了“客户端授权码”，要用授权码代替密码
                smtpClient.Send(mailMessage);
            }
        }
    }
}
