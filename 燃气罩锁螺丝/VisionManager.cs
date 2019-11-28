using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFunc;
using HalconModle;
using CLCamera;
using System.IO;
using HalconDotNet;
using System.Drawing;

namespace 燃气罩锁螺丝
{
   public  class VisionManager:Singleton<VisionManager>
    {
        
        ShapeModle m_shapeModle;
        Calibrate m_calibrate;
        
        public ShapeModle ShapeModle
        {
            get { return m_shapeModle; }
        }
        public Calibrate Calibrate
        {
            get { return m_calibrate; }
            
        }
        public void Init()
        {
           

            m_shapeModle = new ShapeModle();
            if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory+ "Model"))
            {
                FileOperate.Log.WriteString("shap modle file not exist");
                return;
            }
            try
            {
                m_shapeModle.LoadModle(AppDomain.CurrentDomain.BaseDirectory + "Model");
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "successfull to load shape Model");
            }
            catch (Exception ex)
            {
                FileOperate.Log.WriteString($"failed to load shape modle ,{ex.Message}");
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "failed to load shape modle",Color.Red);

            }
            m_calibrate = new Calibrate();

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "CalibrateData\\calibratedata.tup"))
            {
                FileOperate.Log.WriteString("calibratedata file not exist");
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "failed to load calibratedata,the file not exist", Color.Red);

                return;
            }
            m_calibrate.LoadCalibrateData(AppDomain.CurrentDomain.BaseDirectory + "CalibrateData\\calibratedata.tup");
            DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "successfull to load calibrate data");

            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "CalibrateData\\tooloffset.tup"))
            {
                FileOperate.Log.WriteString("tooloffset  file not exist");
                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "failed to load tooloffset,the file not exist", Color.Red);

                return;
            }
            m_calibrate.LoadToolOffset(AppDomain.CurrentDomain.BaseDirectory + "CalibrateData\\tooloffset.tup");
            DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "successfull to load tool offset data");



        }
    }
    public class Calibrate
    {
        HTuple calibratedata ;//标定数据
        HTuple tooloffsetX;//工具坐标x
        HTuple tooloffsetY;//工具坐标y
        HTuple toolX;//标定时X坐标
        HTuple toolY;//标定时Y坐标
        public HTuple CalibrateData
        {
            get { return calibratedata; }
            set { calibratedata = value; }
        }
        public HTuple ToolOffsetX
        {
            get { return tooloffsetX; }
            set { tooloffsetX = value; }
        }
        public HTuple ToolOffsetY
        {
            get { return tooloffsetY; }
            set { tooloffsetY = value; }
        }
        public HTuple ToolX
        {
            get { return toolX; }
            set { toolX = value;  }
        }
        public HTuple ToolY
        {
            get { return toolY; }
            set { toolY = value; }
        }
        public void LoadCalibrateData(string path)
        {
            if(!File.Exists(path))
            {
                FileOperate.Log.WriteString($"fill to load calibrate data,can not find file {path}");
            }
            try
            {
                HOperatorSet.ReadTuple(path, out calibratedata);
            }
            catch (Exception ex)
            {
                FileOperate.Log.WriteString($"fill to load calibrate data,{ex.Message}");

            }

        }
        public void LoadToolOffset(string path)
        {
            if (!File.Exists(path))
            {
                FileOperate.Log.WriteString($"fill to load ToolOffset data,can not find file {path}");
            }
            try
            {
                HOperatorSet.ReadTuple(path, out HTuple  data);
                if (data.Length != 2)
                    throw new Exception("tool offset data count error");
                tooloffsetX = data[0];
                tooloffsetY = data[1];
            }
            catch (Exception ex)
            {
                FileOperate.Log.WriteString($"fill to load ToolOffset data,{ex.Message}");

            }
        }
        public void GetRobotpoint(HTuple imageX,HTuple imageY,ref HTuple robotoffsetX,ref HTuple robotoffsetY)
        {
            HOperatorSet.AffineTransPoint2d(calibratedata, imageX, imageY, out HTuple x, out HTuple y);
            HOperatorSet.AffineTransPoint2d(calibratedata, 1024, 1536, out HTuple _x, out HTuple _y);
            robotoffsetX = _x - x + tooloffsetX;
            robotoffsetY = _y - y + tooloffsetY;
        }
    }
}
