using System;
using System.Text;
using System.Security.Cryptography;

namespace netcoreWebapi
{
    public class CryptoUtils
    {
	public static string CalcMD5Hex(string input)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                return new string(hash.Select(x => x.ToString("x2")).ToArray());
            }
        }

            return s.ToString();
        }
    }
}

