using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFunc;
using CLCamera;
using System.Drawing;

namespace 燃气罩锁螺丝
{
  public   class HardWareManager:Singleton<HardWareManager>
    {
        YaskawaRobot m_yaskawaRobot;
        CameraBase m_camera;
        XinJiePlc m_xinjiePlc;
        public YaskawaRobot YaskawaRobot
        {
            get { return m_yaskawaRobot; }
        }
        public CameraBase Cmaera
        {
            get { return m_camera; }
        }
        public XinJiePlc XinJiePlc
        {
            get { return m_xinjiePlc; }
        }
        public void Init()
        {
            m_yaskawaRobot= new YaskawaRobot("192.168.255.1", 80);
            
            m_camera = new HaiKangCamera("camera", CameraConnectType.GigEVision2);
            try
            {
                m_camera.OpenCamera();
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "successfull to open camera");

            }
            catch (Exception ex)
            {
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", ex.Message, Color.Red);
            }
           
            try
            {
                m_xinjiePlc = new XinJiePlc("192.168.6.10", 8001, "192.168.6.6", 502);
                m_xinjiePlc.Connect();
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "successfull to connnect PLC");

            }
            catch (Exception ex)
            {
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", ex.Message, Color.Red);
            }

        }
    }
}
