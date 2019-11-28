using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Communication;
namespace 燃气罩锁螺丝
{
   public  class YaskawaRobot
    {
        #region 字段定义
        private IPAddress m_ipaddress;
        private uint m_port = 80;

        TcpClientCommunicate NetClient;
        #endregion
        #region 属性

        #endregion
        public YaskawaRobot(string ipaddress,uint port)
        {
            IPAddress iPAddress ;
            if (!IPAddress.TryParse(ipaddress, out  iPAddress))
            {
                throw new FormatException($"{ipaddress} 为无效IP地址");
            }
            m_ipaddress = iPAddress;
            m_port = port;
            NetClient = new TcpClientCommunicate("192.168.255.10",9000,m_ipaddress.ToString(), port);
        }
        /// <summary>
        /// 获取机器人工具中心位置信息
        /// </summary>
        /// <returns></returns>
        public async Task<RobotPos> GetRobotCPoint()
        {
            string rtn;
            try
            {
                await ConnectRobot();
                SendString("CONNECT Robot_access\r\n");
                rtn = await WaitRobotFedback();

                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception("");
                }


                SendString("HOSTCTRL_REQUEST RPOSC 4\r");
                rtn = await WaitRobotFedback();
                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception("");
                }
                SendString("1,0\r");
                rtn = await WaitRobotFedback();
                NetClient.DisConnect();
                if(!rtn.EndsWith("0\r\0"))
                {
                    throw new Exception(" error Get position info ");
                }
                string[] data = rtn.Split(',');
                RobotPos robotPos = new RobotPos();
                robotPos.X = double.Parse(data[0]);
                robotPos.Y = double.Parse(data[1]);
                robotPos.Z = double.Parse(data[2]);
                return robotPos;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public async Task<RobotPos> GetRobotPoint(int index)
        {
            string rtn;
            try
            {
                await ConnectRobot();
                SendString("CONNECT Robot_access\r\n");
                rtn = await WaitRobotFedback();

                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception("");
                }
                SendString($"HOSTCTRL_REQUEST SAVEV {index.ToString().Length+3 }\r");
                rtn = await WaitRobotFedback();
                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception("");
                }
                string kkk = $"5,{index.ToString()}\r";
                SendString($"4,{index.ToString()}\r");
                rtn = await WaitRobotFedback();
                NetClient.DisConnect();
                if (!rtn.EndsWith("0\r\0"))
                {
                    throw new Exception(" error Get position info ");
                }
                string[] data = rtn.Split(',');
                RobotPos robotPos = new RobotPos();
                robotPos.X = double.Parse(data[0]);
                robotPos.Y = double.Parse(data[1]);
                robotPos.Z = double.Parse(data[2]);
                return robotPos;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        /// <summary>
        /// 获取B型变量的值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public async Task<string> GetTypeBData(uint index)
        {
            string rtn;
            try
            {
                await ConnectRobot();
                SendString("CONNECT Robot_access\r\n");
                rtn = await WaitRobotFedback();

                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception($" error Get Type B{index} info,cannot connect robot ");
                   
                }

                
                SendString($"HOSTCTRL_REQUEST SAVEV {index.ToString().Length+3 }\r");
                rtn = await WaitRobotFedback();
                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception($" error Get Type B{index} info ");
                }
                SendString($"0,{index.ToString()}\r");
                rtn = await WaitRobotFedback();
                NetClient.DisConnect();
                return rtn;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }

        }
        /// <summary>
        /// 设置点位信息
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
  
        public async Task SetRobotPoint(uint index,string pointinfo)
        {
            string rtn;
            try
            {
                await ConnectRobot();
                SendString("CONNECT Robot_access\r\n");
                rtn = await WaitRobotFedback();

                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    System.Windows.Forms.MessageBox.Show("error connect");
                    return ;
                }


                SendString($"HOSTCTRL_REQUEST LOADV {  index.ToString().Length+ pointinfo.Length + 13 }\r");
                rtn = await WaitRobotFedback();
                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    System.Windows.Forms.MessageBox.Show("error command");
                    return ;
                }
                SendString($"4,{index},1,0,{pointinfo},0,0\r\n");
                rtn = await WaitRobotFedback();
                NetClient.DisConnect();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return ;
            }
        }
        public async Task SetTypeBData(uint index ,string  datainfo)
        {
            string rtn;
            try
            {
                await ConnectRobot();
                SendString("CONNECT Robot_access\r\n");
                rtn = await WaitRobotFedback();

                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception("faield to connect robot");             
                }


                SendString($"HOSTCTRL_REQUEST LOADV {index.ToString().Length+ datainfo.Length + 4 }\r");
                rtn = await WaitRobotFedback();
                if (!rtn.Contains("OK"))
                {
                    NetClient.DisConnect();
                    throw new Exception("faield to send command to robot");
                    
                }
                SendString($"0,{index},{datainfo}\r");
                rtn = await WaitRobotFedback();
                NetClient.DisConnect();
            }
            catch (Exception ex)
            {
                throw new Exception("get robot B data faield,"+ex.Message);
                
            }
        }
        private async Task ConnectRobot()
        {
            try
            {
                NetClient.Connect();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }
        private void SendString(string data)
        {           
            try
            {
                NetClient.SendString(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async Task<string> WaitRobotFedback()
        {
            string data = string.Empty;
            byte[] rtn = await NetClient.ReadAll();
            data = Encoding.Default.GetString(rtn);
            return data;
        }
    }
    public class RobotPos
    {
        public double X = 0;
        public double Y = 0;
        public double Z = 0;
    }
}
