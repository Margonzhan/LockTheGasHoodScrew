using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitAuthorize
{
    /// <summary>
    /// 此类只在sofeware表下一级进行读写
    /// </summary>
 public   static  class RegistryOperate
    {
        public static bool CheckKeyExist(string keyname)
        {
            RegistryKey key = Registry.LocalMachine;
            RegistryKey software = key.OpenSubKey("SOFTWARE", true);
            RegistryKey target = software.OpenSubKey(keyname, true);
           
            if (target == null)
            {
                
                    return false;
            }
                

            return true;
        }
        public static void ReadSubKey(string fatherkeyname,string subkeyname,ref string value)
        {
            if(CheckKeyExist(fatherkeyname))
            {
              object rtn=  Registry.LocalMachine.OpenSubKey("SOFTWARE", true).OpenSubKey(fatherkeyname, true).GetValue(subkeyname, null);

                if (rtn == null)
                    return ;
                value = rtn.ToString();
            }
        }
        public static void WriteSubKey(string fatherkeyname, string subkeyname,  string value)
        {
            if (CheckKeyExist(fatherkeyname))
            {
                Registry.LocalMachine.OpenSubKey("SOFTWARE", true).OpenSubKey(fatherkeyname, true).SetValue(subkeyname, value);

            }
        }
        public static void CreateKey(string keyname)
        {
            RegistryKey key = Registry.LocalMachine;
            try
            {            
                
                key.CreateSubKey("SOFTWARE\\"+keyname , RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            catch (Exception ex)
            {
                throw new Exception($"创建R表失败");
            }
            finally
            {
                key.Close();
            }
        }
        public static void DeletateKey(string keyname)
        {
            RegistryKey key = Registry.LocalMachine;
            RegistryKey software = key.OpenSubKey("SOFTWARE", true);
            software.DeleteSubKey(keyname, false);
        }
    }
}
