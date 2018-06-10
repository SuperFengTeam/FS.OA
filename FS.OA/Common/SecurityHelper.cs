using System;
using System.Security.Cryptography;
using System.Text;

namespace FS.OA.Common
{
    public class SecurityHelper
    {
        /// <summary>
        /// 创建加密随机数
        /// </summary>
        /// <returns>加密随机数</returns>
        public static string CreateRNG(int length)
        {
            //使用加密服务提供程序 (CSP) 提供的实现来实现加密随机数生成器 (RNG)
            var provider = new RNGCryptoServiceProvider();

            var salt = new byte[length];

            //加密随机数生成
            provider.GetBytes(salt);

            //加密随机数
            return Convert.ToBase64String(salt);
        }

        /// <summary>
        /// SHA256加密字符串(44位)
        /// </summary>
        /// <param name="data">源字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string SHA256_44(string data)
        {
            byte[] result;

            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                result = sha256.ComputeHash(Encoding.GetEncoding(65001).GetBytes(data));
            }

            //加密后的字符串
            return Convert.ToBase64String(result);
        }
    }
}
