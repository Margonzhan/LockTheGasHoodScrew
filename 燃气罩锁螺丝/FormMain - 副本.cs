using HalconDotNet;
using HalconModle;
using HalWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace 燃气罩锁螺丝
{
    public partial class FormMain : Form
    {
        RichTextBoxZd RichTextBoxZd = new RichTextBoxZd();
        CancellationTokenSource tokenSource;
        Task task;
        const int RuntimeLimit = 300;
        public FormMain()
        {
            InitializeComponent();

            if(GetPermission()!="forever")
            {
                int runtime = GetRunTime();
                if (runtime >= RuntimeLimit)
                {
                    MessageBox.Show("产品已过试用期，请联系供应商进行处理", "提示");
                    Application.Exit();
                }
            }
            timer1.Enabled = true;
            Init();

            Param.Instance.LoadParam(AppDomain.CurrentDomain.BaseDirectory + "Parameter\\Param.ini");
            VisionManager.Instance.Init();
            HardWareManager.Instance.Init();
            
        }
        private void Init()
        {
            RichTextBoxZd.Dock = DockStyle.Fill;
            gB_RunMessage.Controls.Add(RichTextBoxZd);
            DelegateControls.Instance.RichTextBoxZds.Add("FormMain_RichTextBoxZd", RichTextBoxZd);
            DelegateControls.Instance.HDisplays.Add("FormMain_hDisplay1", hDisplay1);

            DelegateControls.Instance.TxtBoxs.Add("FormMain_txt_hRanging",  txt_hRanging);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_txt_vRanging1", txt_vRanging1);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_txt_vRanging2", txt_vRanging2);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_txt_vRanging3", txt_vRanging3);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_txt_hOffset",   txt_hOffset);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_txt_vOffset", txt_vOffset);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_instanceScrew", txt_instanceScrew);
            DelegateControls.Instance.TxtBoxs.Add("FormMain_productType",   txt_productType);
        }
        MainStep Step;
        double lengthY = 0;
        double lengthX = 0;
        private async void MainProc()
        {
            Step = MainStep.CheckInPlace;
            float verticalOffset=0;
            double angle = 0;
            float instance1 = 0;
            float instance2 = 0;
            float instance3=0;
            
            RobotPos robotPos1=new RobotPos();
            RobotPos robotPos2=new RobotPos();
            while (!tokenSource.IsCancellationRequested)
            {
                
                try
                {

               
                switch(Step)
                {
                    case MainStep.CheckInPlace:
                        
                        bool isInPlace = await HardWareManager.Instance.XinJiePlc.ReadM(100);
                        if(!isInPlace)
                        {
                            break;
                        }
                        DelegateControls.Instance.DelegateTextbox("FormMain_txt_hRanging",  null);
                        DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging1", null);
                        DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging2", null);
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging3", null);
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_hOffset",   null);
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_vOffset", null);
                            DelegateControls.Instance.DelegateTextbox("FormMain_instanceScrew", null);
                        DelegateControls.Instance.DelegateTextbox("FormMain_productType", null);
                            verticalOffset = await HardWareManager.Instance.XinJiePlc.ReadD(510);//读取横向偏移量
                    
                            if(Math.Abs( verticalOffset)>80)
                            {
                                DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "水平方向偏移超限", Color.Red);
                                break;
                            }
                            
                        DelegateControls.Instance.DelegateTextbox("FormMain_txt_hRanging", verticalOffset.ToString());                        
                            HardWareManager.Instance.XinJiePlc.SetM(101, true);
                            //   await HardWareManager.Instance.YaskawaRobot.SetRobotPoint(100, $"0,{verticalOffset} ,0,0,0,0");
                            DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "水平测距完成");

                            Step = MainStep.GetAngleInstance;
                        break;
                        case MainStep.GetAngleInstance:
                            bool getInstance = await HardWareManager.Instance.XinJiePlc.ReadM(110);
                            if (!getInstance)
                                break;
                            instance1 = await HardWareManager.Instance.XinJiePlc.ReadD(500);
                            instance2 = await HardWareManager.Instance.XinJiePlc.ReadD(502);
                            HardWareManager.Instance.XinJiePlc.SetM(111, true);

                            instance1 = -instance1;
                            instance2 = -instance2;
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging1", instance1.ToString());
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging2", instance2.ToString());
                            await HardWareManager.Instance.YaskawaRobot.SetRobotPoint(13, $"{instance1},{verticalOffset},0,0,0,{0}");
                            Thread.Sleep(300);
                            await HardWareManager.Instance.YaskawaRobot.SetRobotPoint(14, $"{instance1},{verticalOffset},0,0,0,{0}");
                            Thread.Sleep(300);
                            await HardWareManager.Instance.YaskawaRobot.SetRobotPoint(15, $"{instance2},{verticalOffset},0,0,0,{0}");
                            Thread.Sleep(300);

                            await HardWareManager.Instance.YaskawaRobot.SetTypeBData(3, "1");
                            DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "垂直测距完成");

                            Step = MainStep.GetHolePoint2;
                            break;
                    case MainStep.GetInstance://获取两个差距值，用来计算角度
                            //bool getInstance1 = await HardWareManager.Instance.XinJiePlc.ReadM(120);
                            //if (!getInstance1)
                            //    break;
                            //instance3 = await HardWareManager.Instance.XinJiePlc.ReadD(504);
                            //instance3 = -instance3;
                            //HardWareManager.Instance.XinJiePlc.SetM(121, true);
                            //DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging3", instance3.ToString());

                            //Step = MainStep.GetHolePoint2;
                            break;
                    
                  

                         
                    case MainStep.GetHolePoint1:
                        string rtn =await  HardWareManager.Instance.YaskawaRobot.GetTypeBData(1);
                        if(rtn!="2\r\0")
                        {
                            break;
                        }


                            bool getInstance1 = await HardWareManager.Instance.XinJiePlc.ReadM(120);
                            if (!getInstance1)
                                break;
                            instance3 = await HardWareManager.Instance.XinJiePlc.ReadD(504);
                           // instance3 = -instance3;
                            HardWareManager.Instance.XinJiePlc.SetM(121, true);
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_vRanging3", instance3.ToString());


                            HObject _image = HardWareManager.Instance.Cmaera.SnapShot();


                            robotPos1 =await  GetHolePoint(_image);
                          //  length = 700 - length;
                            await HardWareManager.Instance.YaskawaRobot.SetRobotPoint(100, $"{-lengthX},{-lengthY},{instance3},0,0,{0}");
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_hOffset", (lengthY).ToString());
                            DelegateControls.Instance.DelegateTextbox("FormMain_txt_vOffset", (lengthX).ToString());

                            await HardWareManager.Instance.YaskawaRobot.SetTypeBData(2, "2");

                            DelegateControls.Instance.DelegateTextbox("FormMain_instanceScrew", Math.Abs(robotPos1.Y - robotPos2.Y).ToString());
                           

                            if ((robotPos1.Y - robotPos2.Y) < Param.Instance.InstanceMax+Param.Instance.InstanceOffset
                                && (robotPos1.Y - robotPos2.Y) > Param.Instance.InstanceMax - Param.Instance.InstanceOffset)
                        {
                                DelegateControls.Instance.DelegateTextbox("FormMain_productType", "大号产品");

                                await HardWareManager.Instance.YaskawaRobot.SetTypeBData(5, "3");
                        }
                        else if (Math.Abs(robotPos1.Y - robotPos2.Y) < Param.Instance.InstanceLittle+Param.Instance.InstanceOffset
                                && (robotPos1.Y - robotPos2.Y) > Param.Instance.InstanceLittle - Param.Instance.InstanceOffset)
                        {
                                DelegateControls.Instance.DelegateTextbox("FormMain_productType", "小号产品");

                                await HardWareManager.Instance.YaskawaRobot.SetTypeBData(5, "1");
                        }
                        else if(Math.Abs(robotPos1.Y - robotPos2.Y) < Param.Instance.InstanceMiddle + Param.Instance.InstanceOffset
                                && (robotPos1.Y - robotPos2.Y) > Param.Instance.InstanceMiddle - Param.Instance.InstanceOffset)
                        {
                                DelegateControls.Instance.DelegateTextbox("FormMain_productType", "中号产品");

                                await HardWareManager.Instance.YaskawaRobot.SetTypeBData(5, "2");
                        }
                        else
                            {
                                throw new Exception("螺丝孔位置 无法匹配产品");
                            }
                            DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "第二次拍照完成");

                            Step = MainStep.CheckInPlace;
                        break;
                    case MainStep.GetHolePoint2:
                        rtn = await HardWareManager.Instance.YaskawaRobot.GetTypeBData(1);
                        if (rtn != "1\r\0")
                        {
                            break;
                        }
                        _image = HardWareManager.Instance.Cmaera.SnapShot();

                            robotPos2 = await GetHolePoint(_image);
                            await HardWareManager.Instance.YaskawaRobot.SetTypeBData(2, "1");
                            Step = MainStep.GetHolePoint1;
                            DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "第一次拍照完成");

                            break;


                            //VisionManager.Instance.ShapeModle.BackImage = _image.Clone();

                            //ModleFindResult result = VisionManager.Instance.ShapeModle.FindSimple();
                            //if (result != null)
                            //{

                            //    HTuple hommate2d;
                            //    HOperatorSet.VectorAngleToRigid(0, 0, 0, result.Row, result.Column, result.Angle, out hommate2d);
                            //    HOperatorSet.AffineTransContourXld(result.ModleRegion, out HObject hObject, hommate2d);
                            //    RegionX regionX = new RegionX(hObject, "green");
                            //    DelegateControls.Instance.DelegateHdisplay("FormMain_hDisplay1", _image, new List<HalWindow.RegionX>() { regionX });


                            //    HTuple _x = new HTuple();
                            //    HTuple _y = new HTuple();
                            //    VisionManager.Instance.Calibrate.GetRobotpoint(result.Row, result.Column, ref _x, ref _y);


                            //    robotPos2 = await HardWareManager.Instance.YaskawaRobot.GetRobotCPoint();
                            //    robotPos2.Y += _x;
                            //    robotPos2.Z += _y;
                            //    await HardWareManager.Instance.YaskawaRobot.SetTypeBData(2, "1");
                            //}
                            //else
                            //{
                            //    DelegateControls.Instance.DelegateHdisplay("FormMain_hDisplay1", _image, null);
                            //    DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "第一次取像未能找到第一个螺丝孔");
                            //    HardWareManager.Instance.XinJiePlc.SetM(125, true);
                            //    Step = MainStep.CheckInPlace;
                            //    break;
                            //}
                            //await HardWareManager.Instance.YaskawaRobot.SetTypeBData(2, "1");
                            //Step = MainStep.GetHolePoint1;
                            //DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", "第一次拍照完成");

                            //break;

                    }
                }
                catch (Exception ex)
                {
                    HardWareManager.Instance.XinJiePlc.SetM(125, true);

                    DelegateControls.Instance.DelegateRichTextBoxZd("FormMain_RichTextBoxZd", ex.Message);
                    Step = MainStep.CheckInPlace;
                }
                Thread.Sleep(100);
            }
        }
         enum MainStep
        {
            CheckInPlace,//判断产品是否到位
            GetAngleInstance,//用来计算产品旋转角度
            GetHolePoint1,//获取第一个螺丝孔的位置
            GetHolePoint2,//获取第二个螺丝孔的位置
            GetInstance,//获取产品到机械手距离
        }
        private async Task<RobotPos>  GetHolePoint(HObject image)
        {
            try
            {
                DelegateControls.Instance.DelegateHdisplay("FormMain_hDisplay1", image, null);
                HOperatorSet.Threshold(image, out HObject region1, 0, 60);
                HOperatorSet.Connection(region1, out HObject connectionregion);
                HOperatorSet.OpeningCircle(connectionregion, out HObject regionopening, 5.5);
                HOperatorSet.SelectShape(regionopening, out HObject selectedregion, "area", "and", 20000, 99999);
                HOperatorSet.SelectShape(selectedregion, out selectedregion, "circularity", "and", 0.5, 1);
                HOperatorSet.ReduceDomain(image, selectedregion, out HObject imagereduced);
                HOperatorSet.Threshold(imagereduced, out HObject region2, 0, 9);
                HOperatorSet.Connection(region2, out HObject connectionregion2);
                HOperatorSet.ErosionCircle(connectionregion2, out HObject erosionregion, 1.5);
                HOperatorSet.SelectShape(erosionregion, out HObject selectregiion2, "area", "and", 1500, 6500);
                HOperatorSet.AreaCenter(selectregiion2, out HTuple area, out HTuple r, out HTuple c);
                HOperatorSet.ShapeTrans(selectregiion2, out HObject regiiontrans, "outer_circle");
                RegionX regionX = new RegionX(regiiontrans, "green");
                DelegateControls.Instance.DelegateHdisplay("FormMain_hDisplay1", image, new List<HalWindow.RegionX>() { regionX });

                HTuple _x = new HTuple();
                HTuple _y = new HTuple();
                VisionManager.Instance.Calibrate.GetRobotpoint(r, c, ref _x,ref _y);
                 lengthY = _x+Param.Instance.HMakeUp;
                lengthX = _y + Param.Instance.VMakeUp;
                RobotPos robotPos = await HardWareManager.Instance.YaskawaRobot.GetRobotCPoint();
                
               // RobotPos robotPos = new RobotPos();
                robotPos.Y += _x;
                robotPos.Z += _y;
                return robotPos;
            }
            catch(Exception ex)
            {
                HOperatorSet.WriteImage(image, "bmp", 0, AppDomain.CurrentDomain.BaseDirectory + "Images\\Ng.bmp");
                throw new Exception("GetHolePoint exception:第二次取像未找到螺丝孔位置" );
            }
           
            
        }
    

        private void toolStripM_Camera_Click(object sender, EventArgs e)
        {
            FormCamera form = new FormCamera(HardWareManager.Instance.Cmaera, VisionManager.Instance.ShapeModle);
            form.Show();
        }

        private  void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "开始")
            {
                if(task==null||task.IsCanceled||task.Status==TaskStatus.RanToCompletion)
                {
                    tokenSource = new CancellationTokenSource();
                    task = new Task(MainProc);
                }                
                task.Start();

                btn_start.Text = "停止";
            }
            else
            {
                tokenSource.Cancel();
                btn_start.Text = "开始";
            }
        }      

        private void 参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParam formParam = new FormParam();
            formParam.Show();
        }
        private void Encrypt(string data,ref string rtn)
        {
            byte[] d=  Encoding.Default.GetBytes(data);
            for (int i = 0; i < d.Length; i++)
            {
                d[i] += 1;
            }
            rtn= Encoding.Default.GetString(d);
        }
        private void Decrypt(string data, ref string rtn)
        {
            byte[] d = Encoding.Default.GetBytes(data);
            for (int i = 0; i < d.Length; i++)
            {
                d[i] -= 1;
            }
            rtn = Encoding.Default.GetString(d);
        }

        private string GetPermission()
        {
            string permission=string.Empty;
            RegistryOperate.ReadSubKey("zdsoftware", "permission", ref permission);
            if(!string.IsNullOrEmpty(permission))
            {
                string p = string.Empty;
                Decrypt(permission, ref p);
                permission = p;
            }
            return permission;

        }
        private int GetRunTime()
        {
            string runtime = string.Empty;
            RegistryOperate.ReadSubKey("zdsoftware", "runtime", ref runtime);
            if (!string.IsNullOrEmpty(runtime))
            {
                string p = string.Empty;
                Decrypt(runtime, ref p);
                runtime = p;
                return int.Parse(runtime);
            }
            return 0;
        }
        private async  void button1_Click_1(object sender, EventArgs e)
        {
            HObject _image = HardWareManager.Instance.Cmaera.SnapShot();
            VisionManager.Instance.ShapeModle.BackImage = _image.Clone();
            //DelegateControls.Instance.
            ModleFindResult result = VisionManager.Instance.ShapeModle.FindSimple();

            // return;
            if (result != null)
            {

                HTuple hommate2d;
                HOperatorSet.VectorAngleToRigid(0, 0, 0, result.Row, result.Column, result.Angle, out hommate2d);
                HOperatorSet.AffineTransContourXld(result.ModleRegion, out HObject hObject, hommate2d);
                RegionX regionX = new RegionX(hObject, "green");
                DelegateControls.Instance.DelegateHdisplay("FormMain_hDisplay1", _image, new List<HalWindow.RegionX>() { regionX });
                HTuple calibratedata = VisionManager.Instance.Calibrate.CalibrateData;

                HTuple _x = new HTuple();
                HTuple _y = new HTuple();
                HOperatorSet.AffineTransPoint2d(calibratedata, result.Row, result.Column, out HTuple x, out HTuple y);
                HOperatorSet.AffineTransPoint2d(calibratedata, 1024, 1536, out _x, out _y);
                double ox = -x + _x + VisionManager.Instance.Calibrate.ToolOffsetX;
                double oy = -y + _y + VisionManager.Instance.Calibrate.ToolOffsetY;
                RobotPos robotPos = await HardWareManager.Instance.YaskawaRobot.GetRobotCPoint();
                double x1 = ox + robotPos.Y;
                double x2 = oy + robotPos.Z;
            }
         }
  
     

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                string value=string.Empty;
                RegistryOperate.ReadSubKey("zdsoftware", "allow", ref value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string data = string.Empty;
            Encrypt("forever", ref data);
            RegistryOperate.WriteSubKey("zdsoftware", "permission", data);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           int runtime=  GetRunTime();
            if(runtime>=RuntimeLimit)
            {
                timer1.Enabled = false;
                MessageBox.Show("产品已过试用期，请联系供应商进行处理", "提示");
                Application.Exit();
            }
            runtime += 1;
            string t = string.Empty;
            Encrypt(runtime.ToString(), ref t);
            RegistryOperate.WriteSubKey("zdsoftware", "runtime", t);
        }
    }
}
