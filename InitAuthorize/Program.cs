using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitAuthorize
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!RegistryOperate.CheckKeyExist("zdsoftware"))
            {

                RegistryOperate.CreateKey("zdsoftware");
                string s = string.Empty;
                Encrypt("temporary", ref s);
                RegistryOperate.WriteSubKey("zdsoftware", "permission", s);
                Encrypt("0", ref s);
                RegistryOperate.WriteSubKey("zdsoftware", "runtime", s);

            }
        }
        private static  void Encrypt(string data, ref string rtn)
        {
            byte[] d = Encoding.Default.GetBytes(data);
            for (int i = 0; i < d.Length; i++)
            {
                d[i] += 1;
            }
            rtn = Encoding.Default.GetString(d);
        }
        private static  void Decrypt(string data, ref string rtn)
        {
            byte[] d = Encoding.Default.GetBytes(data);
            for (int i = 0; i < d.Length; i++)
            {
                d[i] -= 1;
            }
            rtn = Encoding.Default.GetString(d);
        }
    }
}
