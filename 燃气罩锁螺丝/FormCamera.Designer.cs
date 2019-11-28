namespace 燃气罩锁螺丝
{
    partial class FormCamera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_View = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CalibrateForm = new System.Windows.Forms.Button();
            this.btn_SaveImage = new System.Windows.Forms.Button();
            this.btn_SnapContinue = new System.Windows.Forms.Button();
            this.btn_SnapOnce = new System.Windows.Forms.Button();
            this.hDisplay1 = new HalWindow.HDisplay();
            this.tabPage_Model = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage_View.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_View);
            this.tabControl1.Controls.Add(this.tabPage_Model);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 720);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_View
            // 
            this.tabPage_View.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_View.Location = new System.Drawing.Point(4, 25);
            this.tabPage_View.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_View.Name = "tabPage_View";
            this.tabPage_View.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_View.Size = new System.Drawing.Size(915, 691);
            this.tabPage_View.TabIndex = 0;
            this.tabPage_View.Text = "View";
            this.tabPage_View.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hDisplay1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 683);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_CalibrateForm);
            this.panel1.Controls.Add(this.btn_SaveImage);
            this.panel1.Controls.Add(this.btn_SnapContinue);
            this.panel1.Controls.Add(this.btn_SnapOnce);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 625);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 54);
            this.panel1.TabIndex = 1;
            // 
            // btn_CalibrateForm
            // 
            this.btn_CalibrateForm.Location = new System.Drawing.Point(674, 15);
            this.btn_CalibrateForm.Name = "btn_CalibrateForm";
            this.btn_CalibrateForm.Size = new System.Drawing.Size(139, 29);
            this.btn_CalibrateForm.TabIndex = 1;
            this.btn_CalibrateForm.Text = "标定";
            this.btn_CalibrateForm.UseVisualStyleBackColor = true;
            this.btn_CalibrateForm.Click += new System.EventHandler(this.btn_CalibrateForm_Click);
            // 
            // btn_SaveImage
            // 
            this.btn_SaveImage.Location = new System.Drawing.Point(473, 15);
            this.btn_SaveImage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaveImage.Name = "btn_SaveImage";
            this.btn_SaveImage.Size = new System.Drawing.Size(139, 29);
            this.btn_SaveImage.TabIndex = 0;
            this.btn_SaveImage.Text = "保存图片";
            this.btn_SaveImage.UseVisualStyleBackColor = true;
            this.btn_SaveImage.Click += new System.EventHandler(this.btn_SaveImage_Click);
            // 
            // btn_SnapContinue
            // 
            this.btn_SnapContinue.Location = new System.Drawing.Point(265, 15);
            this.btn_SnapContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SnapContinue.Name = "btn_SnapContinue";
            this.btn_SnapContinue.Size = new System.Drawing.Size(139, 29);
            this.btn_SnapContinue.TabIndex = 0;
            this.btn_SnapContinue.Text = "视频播放";
            this.btn_SnapContinue.UseVisualStyleBackColor = true;
            this.btn_SnapContinue.Click += new System.EventHandler(this.btn_SnapContinue_Click);
            // 
            // btn_SnapOnce
            // 
            this.btn_SnapOnce.Location = new System.Drawing.Point(67, 15);
            this.btn_SnapOnce.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SnapOnce.Name = "btn_SnapOnce";
            this.btn_SnapOnce.Size = new System.Drawing.Size(139, 29);
            this.btn_SnapOnce.TabIndex = 0;
            this.btn_SnapOnce.Text = "单次取象";
            this.btn_SnapOnce.UseVisualStyleBackColor = true;
            this.btn_SnapOnce.Click += new System.EventHandler(this.btn_SnapOnce_Click);
            // 
            // hDisplay1
            // 
            this.hDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hDisplay1.HImageX = null;
            this.hDisplay1.HRegionXList = null;
            this.hDisplay1.HStringXList = null;
            this.hDisplay1.IsCancelImageMove = false;
            this.hDisplay1.Location = new System.Drawing.Point(5, 5);
            this.hDisplay1.Margin = new System.Windows.Forms.Padding(5);
            this.hDisplay1.Name = "hDisplay1";
            this.hDisplay1.Size = new System.Drawing.Size(897, 611);
            this.hDisplay1.TabIndex = 2;
            // 
            // tabPage_Model
            // 
            this.tabPage_Model.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Model.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_Model.Name = "tabPage_Model";
            this.tabPage_Model.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_Model.Size = new System.Drawing.Size(915, 691);
            this.tabPage_Model.TabIndex = 1;
            this.tabPage_Model.Text = "Model";
            this.tabPage_Model.UseVisualStyleBackColor = true;
            // 
            // FormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 720);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCamera";
            this.Text = "FormCamera";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_View.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_View;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SaveImage;
        private System.Windows.Forms.Button btn_SnapContinue;
        private System.Windows.Forms.Button btn_SnapOnce;
        private System.Windows.Forms.TabPage tabPage_Model;
        private System.Windows.Forms.Button btn_CalibrateForm;
        private HalWindow.HDisplay hDisplay1;
    }
}