namespace 燃气罩锁螺丝
{
    partial class FormParam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btv_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmUD_hMakeUp = new System.Windows.Forms.NumericUpDown();
            this.nmUD_instanceLittle = new System.Windows.Forms.NumericUpDown();
            this.nmUD_instanceMiddle = new System.Windows.Forms.NumericUpDown();
            this.nmUD_instanceMax = new System.Windows.Forms.NumericUpDown();
            this.nmUD_instanceOffset = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nmUD_vMakeUp = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_hMakeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceLittle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_vMakeUp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "水平方向补偿：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "小号产品螺丝孔间距：";
            // 
            // btv_save
            // 
            this.btv_save.Location = new System.Drawing.Point(309, 314);
            this.btv_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btv_save.Name = "btv_save";
            this.btv_save.Size = new System.Drawing.Size(109, 44);
            this.btv_save.TabIndex = 1;
            this.btv_save.Text = "更改";
            this.btv_save.UseVisualStyleBackColor = true;
            this.btv_save.Click += new System.EventHandler(this.btv_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "中号产品螺丝孔间距：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "大号产品螺丝孔间距：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "螺丝孔间距误差：";
            // 
            // nmUD_hMakeUp
            // 
            this.nmUD_hMakeUp.Location = new System.Drawing.Point(192, 32);
            this.nmUD_hMakeUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmUD_hMakeUp.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmUD_hMakeUp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nmUD_hMakeUp.Name = "nmUD_hMakeUp";
            this.nmUD_hMakeUp.Size = new System.Drawing.Size(135, 28);
            this.nmUD_hMakeUp.TabIndex = 3;
            this.nmUD_hMakeUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmUD_hMakeUp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nmUD_instanceLittle
            // 
            this.nmUD_instanceLittle.Location = new System.Drawing.Point(192, 128);
            this.nmUD_instanceLittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmUD_instanceLittle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmUD_instanceLittle.Name = "nmUD_instanceLittle";
            this.nmUD_instanceLittle.Size = new System.Drawing.Size(135, 28);
            this.nmUD_instanceLittle.TabIndex = 3;
            this.nmUD_instanceLittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmUD_instanceMiddle
            // 
            this.nmUD_instanceMiddle.Location = new System.Drawing.Point(192, 176);
            this.nmUD_instanceMiddle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmUD_instanceMiddle.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmUD_instanceMiddle.Name = "nmUD_instanceMiddle";
            this.nmUD_instanceMiddle.Size = new System.Drawing.Size(135, 28);
            this.nmUD_instanceMiddle.TabIndex = 3;
            this.nmUD_instanceMiddle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmUD_instanceMax
            // 
            this.nmUD_instanceMax.Location = new System.Drawing.Point(192, 224);
            this.nmUD_instanceMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmUD_instanceMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmUD_instanceMax.Name = "nmUD_instanceMax";
            this.nmUD_instanceMax.Size = new System.Drawing.Size(135, 28);
            this.nmUD_instanceMax.TabIndex = 3;
            this.nmUD_instanceMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmUD_instanceOffset
            // 
            this.nmUD_instanceOffset.Location = new System.Drawing.Point(192, 272);
            this.nmUD_instanceOffset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmUD_instanceOffset.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmUD_instanceOffset.Name = "nmUD_instanceOffset";
            this.nmUD_instanceOffset.Size = new System.Drawing.Size(135, 28);
            this.nmUD_instanceOffset.TabIndex = 3;
            this.nmUD_instanceOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "mm/毫米";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "mm/毫米";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "mm/毫米";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "mm/毫米";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "mm/毫米";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "垂直方向补偿：";
            // 
            // nmUD_vMakeUp
            // 
            this.nmUD_vMakeUp.Location = new System.Drawing.Point(192, 80);
            this.nmUD_vMakeUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmUD_vMakeUp.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmUD_vMakeUp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.nmUD_vMakeUp.Name = "nmUD_vMakeUp";
            this.nmUD_vMakeUp.Size = new System.Drawing.Size(135, 28);
            this.nmUD_vMakeUp.TabIndex = 3;
            this.nmUD_vMakeUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmUD_vMakeUp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 4;
            this.label12.Text = "mm/毫米";
            // 
            // FormParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 373);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmUD_instanceOffset);
            this.Controls.Add(this.nmUD_instanceMax);
            this.Controls.Add(this.nmUD_instanceMiddle);
            this.Controls.Add(this.nmUD_vMakeUp);
            this.Controls.Add(this.nmUD_instanceLittle);
            this.Controls.Add(this.nmUD_hMakeUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btv_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormParam";
            this.Text = "FormParam";
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_hMakeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceLittle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_instanceOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD_vMakeUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btv_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmUD_hMakeUp;
        private System.Windows.Forms.NumericUpDown nmUD_instanceLittle;
        private System.Windows.Forms.NumericUpDown nmUD_instanceMiddle;
        private System.Windows.Forms.NumericUpDown nmUD_instanceMax;
        private System.Windows.Forms.NumericUpDown nmUD_instanceOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmUD_vMakeUp;
        private System.Windows.Forms.Label label12;
    }
}