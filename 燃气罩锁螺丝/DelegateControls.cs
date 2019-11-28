using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonFunc;
using ViewROI;
using HalWindow;
using System.Drawing;
using HalconDotNet;
using System.Windows.Forms;

namespace 燃气罩锁螺丝
{
    class DelegateControls:Singleton<DelegateControls>
    {
        public Dictionary<string, RichTextBoxZd> RichTextBoxZds = new Dictionary<string, RichTextBoxZd>();
        public Dictionary<string, HDisplay> HDisplays = new Dictionary<string, HDisplay>();
        public Dictionary<string, TextBox> TxtBoxs = new Dictionary<string, TextBox>();
        public void DelegateRichTextBoxZd(string richtextboxzdname,string info,Color? color=null, bool isappend=true)
        {
            if (!RichTextBoxZds.ContainsKey(richtextboxzdname))
                return;
            RichTextBoxZd _richTextBoxZd = RichTextBoxZds[richtextboxzdname];    
            if (_richTextBoxZd.InvokeRequired)
            {
                _richTextBoxZd.BeginInvoke(new Action(() => 
                {
                    if (isappend)
                    {
                        _richTextBoxZd.Append(info, color);
                    }
                    else
                    {
                        _richTextBoxZd.ClearAll();
                        _richTextBoxZd.Append(info, color);
                    }
                        
                }));
            }
            else
                if (isappend)
                {
                    _richTextBoxZd.Append(info, color);
                }
                else
                {
                    _richTextBoxZd.ClearAll();
                    _richTextBoxZd.Append(info, color);
                }
        }
        public void DelegateHdisplay(string hdisplayname,HObject image,List<RegionX> hRegions)
        {
            if (!HDisplays.ContainsKey(hdisplayname))
                return;
            HDisplay hDisplay = HDisplays[hdisplayname];
            if(hDisplay.InvokeRequired)
            {
                hDisplay.BeginInvoke(new Action(() => 
                {
                    hDisplay.HImageX = image;
                    hDisplay.HRegionXList = hRegions;
                }));
            }
            else
            {
                hDisplay.HImageX = image;
                hDisplay.HRegionXList = hRegions;
            }
        }
        public void DelegateTextbox(string textboxname,string info)
        {
            if (!TxtBoxs.ContainsKey(textboxname))
                return;
            TextBox textBox = TxtBoxs[textboxname];
            if(textBox.InvokeRequired)
            {
                textBox.BeginInvoke(new Action(() => 
                {
                    textBox.Text = info;
                }));

            }
            else
            {
                textBox.Text = info;
            }
        }
    }
}
