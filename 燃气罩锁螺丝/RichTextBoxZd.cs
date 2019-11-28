﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 燃气罩锁螺丝
{
    public partial class RichTextBoxZd : UserControl
    {
        public RichTextBoxZd()
        {
            InitializeComponent();
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Multiline = true;
            richTextBox.ReadOnly = true;
            richTextBox.Font=new Font("宋体", 9, FontStyle.Bold);
        }
        public void ClearAll()
        {
            richTextBox.Clear();
        }
        /// <summary>
        /// append info at the end
        /// </summary>
        /// <param name="txt">the text to append</param>
        /// <param name="color">the text color</param>
        /// <param name="size">the text size</param>
        public void Append(string txt,Color? color=null,int size=9)
        {
            richTextBox.SuspendLayout();
            int length = richTextBox.Text.Length;
            string time = DateTime.Now.ToString("yyyy_MM_dd  hh:MM:ss") + "  ";
            richTextBox.AppendText(time+txt+"\r");
            richTextBox.Select(length, length + txt.Length+time.Length);
            richTextBox.SelectionColor = color ?? Color.Black;
            richTextBox.SelectionFont = new Font("宋体", size, FontStyle.Bold);
            richTextBox.ScrollToCaret();
            richTextBox.ResumeLayout();
        }
    }
}
