using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Communication;
namespace 燃气罩锁螺丝
{
  public   class XinJiePlc
    {
        TcpClientCommunicate client;
        public XinJiePlc (string localIp,uint localPort,string remoteIp,uint remotePort)
        {
            client = new TcpClientCommunicate(localIp, localPort, remoteIp, remotePort);
        }
        public void Connect()
        {
            try
            {
                client.Connect();
            }
            catch(Exception ex)
            {
                throw new Exception("PLC 链接失败");
            }
            
        }
        public void DisConnect()
        {
            client.DisConnect();
        }
        /// <summary>
        /// crc校验
        /// </summary>
        /// <param name="W"></param>
        
        private  byte[] TCRC( byte[] W)
        {
            int i, j, m, n;
            int  crc_reg = 0xffff, k=0;
            for (i = 0; i < W.Length; i++)
            {
                crc_reg ^= W[i];
                for (j = 0; j < 8; j++)
                {
                    k = crc_reg & 0x01;
                    crc_reg = crc_reg >> 1;
                    if (k != 0)
                        crc_reg ^=  0xa001;
                }
            }
            byte[] rtn = new byte[W.Length+2];
            W.CopyTo(rtn, 0);
            rtn[W.Length] = Convert.ToByte((crc_reg &0xff00)>>8);
            rtn[W.Length + 1] = Convert.ToByte(crc_reg &0xff);
            return rtn;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">M寄存器索引</param>
        /// <returns>M寄存器状态</returns>
        public async Task<bool> ReadM(short index)
        {
            byte[] data = new byte[12] ;
            data[0] = 0x01;
            data[1] = 0x02;
            data[2] = 0x00;
            data[3] = 0x00;
            data[4] = 0x00;
            data[5] = 0x06;
            data[6] = 0x01;
            data[7] = 0x01;
            data[8] = Convert.ToByte(index >> 8);
            data[9] = Convert.ToByte(index & 0xff);
            data[10] = 0x00;
            data[11] = 0x01;
          // byte[] senddata= TCRC(data);
            client.SendBytes(data);
            byte[] rtn= await client.ReadAll();
            return Convert.ToBoolean( rtn[9]);          
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public async void SetM(uint index,bool value)
        {
            byte[] data = new byte[12];
            data[0] = 0x01;
            data[1] = 0x02;
            data[2] = 0x00;
            data[3] = 0x00;
            data[4] = 0x00;
            data[5] = 0x06;
            data[6] = 0x01;
            data[7] = 0x05;
            data[8] = Convert.ToByte(index >> 8);
            data[9] = Convert.ToByte(index & 0xff);
            data[10] = Convert.ToByte(value?0xff:0x00);
            data[11] = 0x00;
            
            client.SendBytes(data);
            byte[] dd=await client.ReadAll();
        }
        public async Task<float>  ReadD(short index)
        {
            byte[] data = new byte[12];
            data[0] = 0x01;
            data[1] = 0x02;
            data[2] = 0x00;
            data[3] = 0x00;
            data[4] = 0x00;
            data[5] = 0x06;
            data[6] = 0x01;
            data[7] = 0x03;            
            data[8] = Convert.ToByte(index >> 8);
            data[9] = Convert.ToByte(index & 0xff);
            data[10] = 0x00;
            data[11] = 0x02;    
            client.SendBytes(data);
            byte[] rtn = await client.ReadAll();
            short lenth = rtn[8];        
          string s1=  Convert.ToString(rtn[9], 16).ToUpper().PadLeft(2, '0');
            string s2 = Convert.ToString(rtn[10], 16).ToUpper().PadLeft(2,'0');
            string s3 = Convert.ToString(rtn[11], 16).ToUpper().PadLeft(2, '0');
            string s4 = Convert.ToString(rtn[12], 16).ToUpper().PadLeft(2, '0');
            //string s = "0x" + s3 + s4 + s1 + s2;
            int k = Convert.ToInt32("0x" +s3+s4+ s1 + s2, 16);
            return  (float)k / 100;

        }
        public void WriteD(short index,short value)
        {
            byte[] data = new byte[12];
            data[0] = 0x01;
            data[1] = 0x02;
            data[2] = 0x00;
            data[3] = 0x00;
            data[4] = 0x00;
            data[5] = 0x06;
            data[6] = 0x01;
            data[7] = 0x06;
            data[8] = Convert.ToByte(index >> 8);
            data[9] = Convert.ToByte(index & 0xff);
            data[10] =Convert.ToByte(value >> 8);
            data[11] = Convert.ToByte(value & 0xff);
            client.SendBytes(data);
        }
    }
}
