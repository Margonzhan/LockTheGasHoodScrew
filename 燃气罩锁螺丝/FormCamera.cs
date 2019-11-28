using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLCamera;
using HalconDotNet;
using System.IO;
using HalconModle;
namespace 燃气罩锁螺丝
{
    public partial class FormCamera : Form
    {
        Task m_taskCameraPaly;
        System.Threading.CancellationTokenSource cancellationTokenSource;

        CameraBase Camera;
        ShapeModle ShapeModle;
        HObject m_image = new HObject();
        public FormCamera(CameraBase cameraBase,ShapeModle shapeModle)
        {
            InitializeComponent();
            this.FormClosing += FormCamera_FormClosing;
            Camera = cameraBase;
            ShapeModle = shapeModle;
            ShapeModle.Dock = DockStyle.Fill;           
            tabPage_Model.Controls.Add(ShapeModle);
        }

        private void FormCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cancellationTokenSource!=null)
            {
                cancellationTokenSource.Cancel();
                m_taskCameraPaly.Wait();
            }
            tabPage_Model.Controls.Remove(ShapeModle);


        }

        private void btn_SnapOnce_Click(object sender, EventArgs e)
        {
            try
            {
                m_image = Camera.SnapShot();
                hDisplay1.HImageX = m_image;
                GC.Collect(3, GCCollectionMode.Forced);
            }
            catch(Exception ex)
            {

            }
           
            
        }

        private void btn_SnapContinue_Click(object sender, EventArgs e)
        {
            if (btn_SnapContinue.Text == "视频播放")
            {
                cancellationTokenSource = new System.Threading.CancellationTokenSource();                
                    m_taskCameraPaly = new Task(() =>
                    {
                        while (!cancellationTokenSource.IsCancellationRequested)
                        {

                            m_image=  Camera.SnapShot();
                            hDisplay1.BeginInvoke(new Action(() => { hDisplay1.HImageX = m_image; }));                            
                            GC.Collect(2);
                            System.Threading.Thread.Sleep(20);
                        }
                    }, cancellationTokenSource.Token);
                    m_taskCameraPaly.Start();
                    btn_SnapContinue.Text = "停止";
                    btn_SnapOnce.Enabled = false;               
            }
            else
            {
                cancellationTokenSource.Cancel();
                btn_SnapContinue.Text = "视频播放";
                btn_SnapOnce.Enabled = true;
            }
        }

        private void btn_SaveImage_Click(object sender, EventArgs e)
        {
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "Images";
            if (!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);
            HOperatorSet.WriteImage(m_image, "bmp", 0, filepath+"\\" +DateTime.Now.ToString("yyyy_MM_dd hh_mm_ss")+ ".bmp");           
        }

        private void btn_CalibrateForm_Click(object sender, EventArgs e)
        {
            FormCalibrate form = new FormCalibrate(HardWareManager.Instance.YaskawaRobot,ShapeModle, Camera);
            form.Show();
        }
    }
}
