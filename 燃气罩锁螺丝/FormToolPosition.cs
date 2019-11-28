using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 燃气罩锁螺丝
{
    public partial class FormToolPosition : Form
    {
        public double RobotY
        {
            get;private set;
        }
        public double RobotZ
        {
            get;private  set;
        }
        public FormToolPosition()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_robotY.Text))
                MessageBox.Show("Robot_Y 不能为空", "提示");
            if(!double.TryParse(txt_robotY.Text,out double y))
                MessageBox.Show("Robot_Y 值不是有效数据","提示");
            if (string.IsNullOrEmpty(txt_robotZ.Text))
                MessageBox.Show("Robot_Z 不能为空", "提示");
            if (!double.TryParse(txt_robotZ.Text, out double z))
                MessageBox.Show("Robot_Z 值不是有效数据", "提示");

            RobotY = y;
            RobotZ = z;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
