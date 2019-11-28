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
using HalconModle;
using HalconDotNet;
using System.IO;
namespace 燃气罩锁螺丝
{
    public partial class FormCalibrate : Form
    {
        YaskawaRobot Robot;
        CameraBase m_Camera;
        ShapeModle m_ShapeModle;
     
        public FormCalibrate(YaskawaRobot Robot, ShapeModle shapeModle, CameraBase cameraBase)
        {
            InitializeComponent();
            this.Robot = Robot;
            m_ShapeModle = shapeModle;
            m_Camera = cameraBase;
            Init();
        }
        private void Init()
        {
            HTuple cameraX = new HTuple();
            HTuple cameraY = new HTuple();
            HTuple robotX = new HTuple();
            HTuple robotY = new HTuple();
            string _path = AppDomain.CurrentDomain.BaseDirectory + "CalibrateData";
            
            HOperatorSet.ReadTuple( _path + "\\cameraX.tup",out cameraX);
            HOperatorSet.ReadTuple( _path + "\\cameraY.tup", out cameraY);
            HOperatorSet.ReadTuple( _path + "\\robotX.tup", out robotX);
            HOperatorSet.ReadTuple( _path + "\\robotY.tup", out robotY);
            for (int i = 0; i < 9; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(dGV_RobotPos);
                dataGridViewRow.Cells[0].Value = i.ToString();
                dataGridViewRow.Cells[1].Value = robotX[i].S;
                dataGridViewRow.Cells[2].Value = robotY[i].S;
                dGV_RobotPos.Rows.Add(dataGridViewRow);

            }
            for (int i = 0; i < 9; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(dGV_CameraPos);
                dataGridViewRow.Cells[0].Value = i.ToString();
                dataGridViewRow.Cells[1].Value = cameraX[i].S;
                dataGridViewRow.Cells[2].Value = cameraY[i].S;
                dGV_CameraPos.Rows.Add(dataGridViewRow);
            }
        }
        private async void btn_GetRobPos_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = null;
            if (dGV_RobotPos.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一行来更新点位数据");
                return;
            }
            dataGridViewRow = dGV_RobotPos.SelectedRows[0];
            RobotPos robotPos = await Robot.GetRobotCPoint();
            if(robotPos==null)
            {
                return;
            }
            dataGridViewRow.Cells[1].Value = robotPos.X;
            dataGridViewRow.Cells[2].Value = robotPos.Y;
        }

        private void btn_SavePos_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calibrate_Click(object sender, EventArgs e)
        {
            double[] point_x = new double[9];
            double[] point_y = new double[9];
            double[] pixel_x = new double[9];
            double[] pixel_y = new double[9];
            for (int i = 0; i < 9; i++)
            {
                DataGridViewRow dataGridViewRow = dGV_RobotPos.Rows[i];
                if (dataGridViewRow.Cells[1].Value == null || dataGridViewRow.Cells[2].Value == null)
                {
                    MessageBox.Show($"机器人第{(i + 1).ToString()}行点位信息为空", "提示");
                    return;
                }
                point_x[i] = double.Parse(dataGridViewRow.Cells[1].Value.ToString());
                point_y[i] = double.Parse(dataGridViewRow.Cells[2].Value.ToString());
                DataGridViewRow dataGridViewRow1 = dGV_CameraPos.Rows[i];
                if (dataGridViewRow1.Cells[1].Value == null || dataGridViewRow1.Cells[2].Value == null)
                {
                    MessageBox.Show($"相机第{(i + 1).ToString()}行点位信息为空", "提示");
                    return;
                }
                pixel_x[i] = double.Parse(dataGridViewRow1.Cells[1].Value.ToString());
                pixel_y[i] = double.Parse(dataGridViewRow1.Cells[2].Value.ToString());
            }
          HTuple   calibratedata = Calib9(point_x, point_y, pixel_x, pixel_y);
            VisionManager.Instance.Calibrate.CalibrateData = calibratedata;
        }
        private HTuple Calib9(double[] point_x, double[] point_y, double[] pixel_x, double[] pixel_y)
        {
            HTuple x = new HTuple(point_x);
            HTuple y = new HTuple(point_y);
            HTuple pix_x = new HTuple(pixel_x);
            HTuple pix_y = new HTuple(pixel_y);
            HTuple hom2d = null;
            HOperatorSet.VectorToHomMat2d(pixel_x, pixel_y, x, y, out hom2d);
            return hom2d;
        }
        private void btn_GetTargetPos_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = null;
            if (dGV_CameraPos.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择一行来更新点位数据");
                return;
            }
            dataGridViewRow = dGV_CameraPos.SelectedRows[0];
            HObject _image = m_Camera.SnapShot();
            m_ShapeModle.BackImage = _image;
            ModleFindResult result = m_ShapeModle.FindSimple();
            if (result != null)
            {
                dataGridViewRow.Cells[1].Value = result.Row.ToString();
                dataGridViewRow.Cells[2].Value = result.Column.ToString();
            }
        }

        private void btn_SaveCalibrate_Click(object sender, EventArgs e)
        {
            HTuple calibratedata = VisionManager.Instance.Calibrate.CalibrateData;
            if (calibratedata != null)
            {
                string filepath = AppDomain.CurrentDomain.BaseDirectory + "CalibrateData";
                if (!System.IO.Directory.Exists(filepath))
                    System.IO.Directory.CreateDirectory(filepath);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "tup";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                string filename = saveFileDialog.FileName;
                HOperatorSet.WriteTuple(calibratedata, filename);
            }
        }
        double offx = 0;
        double offy = 0;
        private async void button1_Click(object sender, EventArgs e)
        {
            HTuple calibratedata = VisionManager.Instance.Calibrate.CalibrateData;
            if (calibratedata != null)
            {
                HOperatorSet.AffineTransPoint2d(calibratedata, 1024, 1536, out HTuple x, out HTuple y);
                // RobotPos robotPos = AbbRobot.GetRobotPos();
                double robotY, robotZ;
                FormToolPosition form = new FormToolPosition();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    robotY = form.RobotY;
                    robotZ = form.RobotZ;
                }
                else
                    return;
                offx = robotY - x;
                offy = robotZ - y;
                HTuple hTuple = new HTuple();
                hTuple.Append(offx);
                hTuple.Append(offy);
                string _path = AppDomain.CurrentDomain.BaseDirectory + "CalibrateData";
                VisionManager.Instance.Calibrate.ToolOffsetX = offx;
                VisionManager.Instance.Calibrate.ToolOffsetY = offy;
                if (!Directory.Exists(_path))
                {
                    Directory.CreateDirectory(_path);
                }
                HOperatorSet.WriteTuple(hTuple, _path + "\\tooloffset.tup");
               // HOperatorSet.WriteTuple(hTuple, _path + "\\tooloffset.tup");
               // HOperatorSet.WriteTuple(hTuple, _path + "\\tooloffset.tup");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HTuple calibratedata = VisionManager.Instance.Calibrate.CalibrateData;
            if (calibratedata != null)
            {
                HObject _image = m_Camera.SnapShot();
                m_ShapeModle.BackImage = _image;
                ModleFindResult result = m_ShapeModle.FindSimple();
                if (result != null)
                {
                    HOperatorSet.AffineTransPoint2d(calibratedata, result.Row, result.Column, out HTuple x, out HTuple y);
                    HOperatorSet.AffineTransPoint2d(calibratedata, 1024, 1536, out HTuple _x, out HTuple _y);
                    double ox = _x - x + offx;
                    double oy = _y - y + offy;
                    VisionManager.Instance.Calibrate.ToolOffsetX = ox;
                    VisionManager.Instance.Calibrate.ToolOffsetY = oy;
                    // Robot.RelativeMove(ox, oy);
                }
            }

        }
        private void btn_SavePointData_Click(object sender, EventArgs e)
        {
            HTuple cameraX = new HTuple();
            HTuple cameraY = new HTuple();
            HTuple robotX = new HTuple();
            HTuple robotY = new HTuple();

            for (int i = 0; i < 9; i++)
            {
                DataGridViewRow dataGridViewRow = dGV_RobotPos.Rows[i];
                if (dataGridViewRow.Cells[1].Value == null || dataGridViewRow.Cells[2].Value == null)
                {
                    MessageBox.Show($"机器人第{(i + 1).ToString()}行点位信息为空", "提示");
                    return;
                }
                robotX.Append(dataGridViewRow.Cells[1].Value.ToString());
                robotY.Append(dataGridViewRow.Cells[2].Value.ToString());
            }
            for (int i = 0; i < 9; i++)
            {
                DataGridViewRow dataGridViewRow = dGV_CameraPos.Rows[i];
                if (dataGridViewRow.Cells[1].Value == null || dataGridViewRow.Cells[2].Value == null)
                {
                    MessageBox.Show($"机器人第{(i + 1).ToString()}行点位信息为空", "提示");
                    return;
                }
                cameraX.Append(dataGridViewRow.Cells[1].Value.ToString());
                cameraY.Append(dataGridViewRow.Cells[2].Value.ToString());
            }
            string _path = AppDomain.CurrentDomain.BaseDirectory + "CalibrateData";
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            HOperatorSet.WriteTuple(cameraX, _path + "\\cameraX.tup");
            HOperatorSet.WriteTuple(cameraY, _path + "\\cameraY.tup");
            HOperatorSet.WriteTuple(robotX, _path + "\\robotX.tup");
            HOperatorSet.WriteTuple(robotY, _path + "\\robotY.tup");
        }
    }
}
