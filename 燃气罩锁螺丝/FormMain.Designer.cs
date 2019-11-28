namespace 燃气罩锁螺丝
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripM_Camera = new System.Windows.Forms.ToolStripMenuItem();
            this.参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_productType = new System.Windows.Forms.TextBox();
            this.txt_instanceScrew = new System.Windows.Forms.TextBox();
            this.txt_vOffset = new System.Windows.Forms.TextBox();
            this.txt_hOffset = new System.Windows.Forms.TextBox();
            this.txt_vRanging3 = new System.Windows.Forms.TextBox();
            this.txt_vRanging2 = new System.Windows.Forms.TextBox();
            this.txt_vRanging1 = new System.Windows.Forms.TextBox();
            this.txt_hRanging = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.hDisplay1 = new HalWindow.HDisplay();
            this.gB_RunMessage = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripM_Camera,
            this.参数ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(911, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripM_Camera
            // 
            this.toolStripM_Camera.Name = "toolStripM_Camera";
            this.toolStripM_Camera.Size = new System.Drawing.Size(51, 24);
            this.toolStripM_Camera.Text = "相机";
            this.toolStripM_Camera.Click += new System.EventHandler(this.toolStripM_Camera_Click);
            // 
            // 参数ToolStripMenuItem
            // 
            this.参数ToolStripMenuItem.Name = "参数ToolStripMenuItem";
            this.参数ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.参数ToolStripMenuItem.Text = "参数";
            this.参数ToolStripMenuItem.Click += new System.EventHandler(this.参数ToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gB_RunMessage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(911, 595);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.hDisplay1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(901, 437);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_productType);
            this.panel1.Controls.Add(this.txt_instanceScrew);
            this.panel1.Controls.Add(this.txt_vOffset);
            this.panel1.Controls.Add(this.txt_hOffset);
            this.panel1.Controls.Add(this.txt_vRanging3);
            this.panel1.Controls.Add(this.txt_vRanging2);
            this.panel1.Controls.Add(this.txt_vRanging1);
            this.panel1.Controls.Add(this.txt_hRanging);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 433);
            this.panel1.TabIndex = 0;
            // 
            // txt_productType
            // 
            this.txt_productType.Location = new System.Drawing.Point(128, 506);
            this.txt_productType.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_productType.Name = "txt_productType";
            this.txt_productType.ReadOnly = true;
            this.txt_productType.Size = new System.Drawing.Size(161, 25);
            this.txt_productType.TabIndex = 3;
            // 
            // txt_instanceScrew
            // 
            this.txt_instanceScrew.Location = new System.Drawing.Point(128, 451);
            this.txt_instanceScrew.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_instanceScrew.Name = "txt_instanceScrew";
            this.txt_instanceScrew.ReadOnly = true;
            this.txt_instanceScrew.Size = new System.Drawing.Size(161, 25);
            this.txt_instanceScrew.TabIndex = 3;
            // 
            // txt_vOffset
            // 
            this.txt_vOffset.Location = new System.Drawing.Point(128, 396);
            this.txt_vOffset.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_vOffset.Name = "txt_vOffset";
            this.txt_vOffset.ReadOnly = true;
            this.txt_vOffset.Size = new System.Drawing.Size(161, 25);
            this.txt_vOffset.TabIndex = 3;
            // 
            // txt_hOffset
            // 
            this.txt_hOffset.Location = new System.Drawing.Point(128, 341);
            this.txt_hOffset.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_hOffset.Name = "txt_hOffset";
            this.txt_hOffset.ReadOnly = true;
            this.txt_hOffset.Size = new System.Drawing.Size(161, 25);
            this.txt_hOffset.TabIndex = 3;
            // 
            // txt_vRanging3
            // 
            this.txt_vRanging3.Location = new System.Drawing.Point(128, 286);
            this.txt_vRanging3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_vRanging3.Name = "txt_vRanging3";
            this.txt_vRanging3.ReadOnly = true;
            this.txt_vRanging3.Size = new System.Drawing.Size(161, 25);
            this.txt_vRanging3.TabIndex = 3;
            // 
            // txt_vRanging2
            // 
            this.txt_vRanging2.Location = new System.Drawing.Point(128, 231);
            this.txt_vRanging2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_vRanging2.Name = "txt_vRanging2";
            this.txt_vRanging2.ReadOnly = true;
            this.txt_vRanging2.Size = new System.Drawing.Size(161, 25);
            this.txt_vRanging2.TabIndex = 3;
            // 
            // txt_vRanging1
            // 
            this.txt_vRanging1.Location = new System.Drawing.Point(128, 176);
            this.txt_vRanging1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_vRanging1.Name = "txt_vRanging1";
            this.txt_vRanging1.ReadOnly = true;
            this.txt_vRanging1.Size = new System.Drawing.Size(161, 25);
            this.txt_vRanging1.TabIndex = 3;
            // 
            // txt_hRanging
            // 
            this.txt_hRanging.Location = new System.Drawing.Point(128, 121);
            this.txt_hRanging.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_hRanging.Name = "txt_hRanging";
            this.txt_hRanging.ReadOnly = true;
            this.txt_hRanging.Size = new System.Drawing.Size(161, 25);
            this.txt_hRanging.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "产品型号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "垂直位移：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "螺丝孔间距：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "垂直测距3：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "水平位移：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "垂直测距2：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "垂直测距1：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "水平测距：";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(19, 16);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(248, 79);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "开始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // hDisplay1
            // 
            this.hDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hDisplay1.HImageX = null;
            this.hDisplay1.HRegionXList = null;
            this.hDisplay1.HStringXList = null;
            this.hDisplay1.IsCancelImageMove = false;
            this.hDisplay1.Location = new System.Drawing.Point(307, 6);
            this.hDisplay1.Margin = new System.Windows.Forms.Padding(5);
            this.hDisplay1.Name = "hDisplay1";
            this.hDisplay1.Size = new System.Drawing.Size(588, 425);
            this.hDisplay1.TabIndex = 1;
            // 
            // gB_RunMessage
            // 
            this.gB_RunMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gB_RunMessage.Location = new System.Drawing.Point(5, 444);
            this.gB_RunMessage.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gB_RunMessage.Name = "gB_RunMessage";
            this.gB_RunMessage.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gB_RunMessage.Size = new System.Drawing.Size(901, 148);
            this.gB_RunMessage.TabIndex = 1;
            this.gB_RunMessage.TabStop = false;
            this.gB_RunMessage.Text = "消息记录：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1800000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "FormMain";
            this.Text = "锁螺丝机";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripM_Camera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox gB_RunMessage;
        private HalWindow.HDisplay hDisplay1;
        private System.Windows.Forms.ToolStripMenuItem 参数ToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_productType;
        private System.Windows.Forms.TextBox txt_instanceScrew;
        private System.Windows.Forms.TextBox txt_vRanging2;
        private System.Windows.Forms.TextBox txt_vRanging1;
        private System.Windows.Forms.TextBox txt_hRanging;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vOffset;
        private System.Windows.Forms.TextBox txt_vRanging3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}

