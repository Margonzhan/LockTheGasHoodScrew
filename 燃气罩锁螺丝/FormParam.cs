using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileOperate;
using CommonFunc;
namespace 燃气罩锁螺丝
{
    public partial class FormParam : Form
    {
        public FormParam()
        {
            InitializeComponent();
            nmUD_hMakeUp.Enabled = false;
            nmUD_vMakeUp.Enabled = false;
            nmUD_instanceLittle.Enabled = false;
            nmUD_instanceMax.Enabled = false;
            nmUD_instanceMiddle.Enabled = false;
            nmUD_instanceOffset.Enabled = false;

            nmUD_hMakeUp.Value = Param.Instance.HMakeUp;
            nmUD_vMakeUp.Value = Param.Instance.VMakeUp;
            nmUD_instanceLittle.Value = Param.Instance.InstanceLittle;
            nmUD_instanceMiddle.Value = Param.Instance.InstanceMiddle;
            nmUD_instanceMax.Value = Param.Instance.InstanceMax;
            nmUD_instanceOffset.Value = Param.Instance.InstanceOffset;
        }

        private void btv_save_Click(object sender, EventArgs e)
        {
            if(btv_save.Text=="更改")
            {
                nmUD_hMakeUp.Enabled = true;
                nmUD_vMakeUp.Enabled = true;
                nmUD_instanceLittle.Enabled = true;
                nmUD_instanceMax.Enabled = true;
                nmUD_instanceMiddle.Enabled = true;
                nmUD_instanceOffset.Enabled = true;
                btv_save.Text = "保存";
            }
            else
            {
                if(nmUD_instanceMiddle.Value+ nmUD_instanceOffset.Value*2> nmUD_instanceMax.Value)
                {
                    MessageBox.Show("中号产品与大号产品孔间距设置不合理", "错误提示");
                    return;
                }
                if (nmUD_instanceMiddle.Value - nmUD_instanceOffset.Value * 2 < nmUD_instanceLittle.Value)
                {
                    MessageBox.Show("中号产品与小号产品孔间距设置不合理", "错误提示");
                    return;
                }
                if (DialogResult.OK== MessageBox.Show("确认修改参数？","提示"))
                {
                      Param.Instance.HMakeUp   = (int)nmUD_hMakeUp.Value ;
                      Param.Instance.VMakeUp = (int)nmUD_vMakeUp.Value;
                      Param.Instance.InstanceLittle  = (int)nmUD_instanceLittle.Value;
                      Param.Instance.InstanceMiddle  = (int)nmUD_instanceMiddle.Value;
                      Param.Instance.InstanceMax     = (int)nmUD_instanceMax.Value   ;
                      Param.Instance.InstanceOffset  = (int)nmUD_instanceOffset.Value;
                    Param.Instance.SaveParam(AppDomain.CurrentDomain.BaseDirectory+"Parameter");
                    btv_save.Text = "更改";
                }
                
            }
        }

    
    }
    public class Param:Singleton<Param>
    {
        /// <summary>
        /// 角度测量时量测距点水平间距
        /// </summary>
        public int InstanceAngle { get; set; } = 400;

        /// <summary>
        /// 水平补偿
        /// </summary>
        public int HMakeUp { get; set; } = 0;
        /// <summary>
        /// 垂直补偿
        /// </summary>
        public int VMakeUp { get; set; } = 0;

        /// <summary>
        /// 小号产品两固定螺丝孔间距
        /// </summary>
        public int InstanceLittle { get; set; } = 0;
        /// <summary>
        /// 中号产品两固定螺丝孔间距
        /// </summary>
        public int InstanceMiddle { get; set; } = 0;
        /// <summary>
        /// 大号产品两固定螺丝孔间距
        /// </summary>
        public int InstanceMax { get; set; }=0;
        /// <summary>
        /// 螺丝孔间距允许误差
        /// </summary>
        public int InstanceOffset { get; set; }=0;
        public void LoadParam(string filepath)
        {
            if(!File.Exists(filepath))
            {
                throw new FileNotFoundException($"找不到文件 {filepath}");
            }
            try
            {
                INI ini = new INI();
                StringBuilder stringBuilder = new StringBuilder();
                ini.IniRead("Param", "VMakeUp", stringBuilder, filepath);
                VMakeUp = int.Parse(stringBuilder.ToString());

                ini.IniRead("Param", "HMakeUp", stringBuilder, filepath);
                HMakeUp = int.Parse(stringBuilder.ToString());

                ini.IniRead("Param", "InstanceLittle", stringBuilder, filepath);
                InstanceLittle = int.Parse(stringBuilder.ToString());

                ini.IniRead("Param", "InstanceMiddle", stringBuilder, filepath);
                InstanceMiddle = int.Parse(stringBuilder.ToString());

                ini.IniRead("Param", "InstanceMax", stringBuilder, filepath);
                InstanceMax = int.Parse(stringBuilder.ToString());

                ini.IniRead("Param", "InstanceOffset", stringBuilder, filepath);
                InstanceOffset = int.Parse(stringBuilder.ToString());
            }
            catch(Exception ex)
            {
                throw new Exception($"读取参数文件异常，请检查{filepath}文件中，各参数格式是否正确");
            }
            
        }
        public void SaveParam(string filepath)
        {
            if(!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            INI ini = new INI();
            ini.IniWrite("Param", "HMakeUp", HMakeUp.ToString(), filepath + "\\Param.ini");
            ini.IniWrite("Param", "VMakeUp", VMakeUp.ToString(), filepath + "\\Param.ini");
            ini.IniWrite("Param", "InstanceLittle", InstanceLittle.ToString(), filepath + "\\Param.ini");
            ini.IniWrite("Param", "InstanceMiddle", InstanceMiddle.ToString(), filepath + "\\Param.ini");
            ini.IniWrite("Param", "InstanceMax", InstanceMax.ToString(), filepath + "\\Param.ini");
            ini.IniWrite("Param", "InstanceOffset", InstanceOffset.ToString(), filepath + "\\Param.ini");
        }
    }
}
