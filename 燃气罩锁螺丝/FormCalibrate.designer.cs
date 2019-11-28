namespace 燃气罩锁螺丝
{
    partial class FormCalibrate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gB_RobotPos = new System.Windows.Forms.GroupBox();
            this.dGV_RobotPos = new System.Windows.Forms.DataGridView();
            this.C_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_Operate = new System.Windows.Forms.GroupBox();
            this.btn_SavePointData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_SaveCalibrate = new System.Windows.Forms.Button();
            this.btn_CalibrateCam = new System.Windows.Forms.Button();
            this.btn_GetTargetPos = new System.Windows.Forms.Button();
            this.btn_GetRobPos = new System.Windows.Forms.Button();
            this.gB_CameraPos = new System.Windows.Forms.GroupBox();
            this.dGV_CameraPos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gB_RobotPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RobotPos)).BeginInit();
            this.gB_Operate.SuspendLayout();
            this.gB_CameraPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CameraPos)).BeginInit();
            this.SuspendLayout();
            // 
            // gB_RobotPos
            // 
            this.gB_RobotPos.Controls.Add(this.dGV_RobotPos);
            this.gB_RobotPos.Location = new System.Drawing.Point(8, 126);
            this.gB_RobotPos.Margin = new System.Windows.Forms.Padding(2);
            this.gB_RobotPos.Name = "gB_RobotPos";
            this.gB_RobotPos.Padding = new System.Windows.Forms.Padding(2);
            this.gB_RobotPos.Size = new System.Drawing.Size(260, 258);
            this.gB_RobotPos.TabIndex = 9;
            this.gB_RobotPos.TabStop = false;
            this.gB_RobotPos.Text = "RobotPos";
            // 
            // dGV_RobotPos
            // 
            this.dGV_RobotPos.AllowUserToAddRows = false;
            this.dGV_RobotPos.AllowUserToDeleteRows = false;
            this.dGV_RobotPos.AllowUserToResizeColumns = false;
            this.dGV_RobotPos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_RobotPos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_RobotPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_RobotPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Index,
            this.C_PosX,
            this.C_PosY});
            this.dGV_RobotPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_RobotPos.Location = new System.Drawing.Point(2, 16);
            this.dGV_RobotPos.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_RobotPos.Name = "dGV_RobotPos";
            this.dGV_RobotPos.RowHeadersVisible = false;
            this.dGV_RobotPos.RowTemplate.Height = 27;
            this.dGV_RobotPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_RobotPos.Size = new System.Drawing.Size(256, 240);
            this.dGV_RobotPos.TabIndex = 0;
            // 
            // C_Index
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C_Index.DefaultCellStyle = dataGridViewCellStyle2;
            this.C_Index.Frozen = true;
            this.C_Index.HeaderText = "Index";
            this.C_Index.Name = "C_Index";
            this.C_Index.Width = 60;
            // 
            // C_PosX
            // 
            this.C_PosX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C_PosX.DefaultCellStyle = dataGridViewCellStyle3;
            this.C_PosX.HeaderText = "X";
            this.C_PosX.Name = "C_PosX";
            // 
            // C_PosY
            // 
            this.C_PosY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C_PosY.DefaultCellStyle = dataGridViewCellStyle4;
            this.C_PosY.HeaderText = "Y";
            this.C_PosY.Name = "C_PosY";
            // 
            // gB_Operate
            // 
            this.gB_Operate.Controls.Add(this.btn_SavePointData);
            this.gB_Operate.Controls.Add(this.button1);
            this.gB_Operate.Controls.Add(this.btn_SaveCalibrate);
            this.gB_Operate.Controls.Add(this.btn_CalibrateCam);
            this.gB_Operate.Controls.Add(this.btn_GetTargetPos);
            this.gB_Operate.Controls.Add(this.btn_GetRobPos);
            this.gB_Operate.Location = new System.Drawing.Point(8, 9);
            this.gB_Operate.Margin = new System.Windows.Forms.Padding(2);
            this.gB_Operate.Name = "gB_Operate";
            this.gB_Operate.Padding = new System.Windows.Forms.Padding(2);
            this.gB_Operate.Size = new System.Drawing.Size(528, 113);
            this.gB_Operate.TabIndex = 11;
            this.gB_Operate.TabStop = false;
            this.gB_Operate.Text = "Operate";
            // 
            // btn_SavePointData
            // 
            this.btn_SavePointData.Location = new System.Drawing.Point(311, 69);
            this.btn_SavePointData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SavePointData.Name = "btn_SavePointData";
            this.btn_SavePointData.Size = new System.Drawing.Size(89, 33);
            this.btn_SavePointData.TabIndex = 13;
            this.btn_SavePointData.Text = "SavePointData";
            this.btn_SavePointData.UseVisualStyleBackColor = true;
            this.btn_SavePointData.Click += new System.EventHandler(this.btn_SavePointData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "CalibTool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SaveCalibrate
            // 
            this.btn_SaveCalibrate.Location = new System.Drawing.Point(162, 69);
            this.btn_SaveCalibrate.Name = "btn_SaveCalibrate";
            this.btn_SaveCalibrate.Size = new System.Drawing.Size(89, 33);
            this.btn_SaveCalibrate.TabIndex = 11;
            this.btn_SaveCalibrate.Text = "SaveCalData";
            this.btn_SaveCalibrate.UseVisualStyleBackColor = true;
            this.btn_SaveCalibrate.Click += new System.EventHandler(this.btn_SaveCalibrate_Click);
            // 
            // btn_CalibrateCam
            // 
            this.btn_CalibrateCam.Location = new System.Drawing.Point(311, 18);
            this.btn_CalibrateCam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CalibrateCam.Name = "btn_CalibrateCam";
            this.btn_CalibrateCam.Size = new System.Drawing.Size(89, 33);
            this.btn_CalibrateCam.TabIndex = 10;
            this.btn_CalibrateCam.Text = "CalibrateCam";
            this.btn_CalibrateCam.UseVisualStyleBackColor = true;
            this.btn_CalibrateCam.Click += new System.EventHandler(this.btn_Calibrate_Click);
            // 
            // btn_GetTargetPos
            // 
            this.btn_GetTargetPos.Location = new System.Drawing.Point(162, 18);
            this.btn_GetTargetPos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GetTargetPos.Name = "btn_GetTargetPos";
            this.btn_GetTargetPos.Size = new System.Drawing.Size(89, 33);
            this.btn_GetTargetPos.TabIndex = 10;
            this.btn_GetTargetPos.Text = "GetTargetPos";
            this.btn_GetTargetPos.UseVisualStyleBackColor = true;
            this.btn_GetTargetPos.Click += new System.EventHandler(this.btn_GetTargetPos_Click);
            // 
            // btn_GetRobPos
            // 
            this.btn_GetRobPos.Location = new System.Drawing.Point(21, 18);
            this.btn_GetRobPos.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GetRobPos.Name = "btn_GetRobPos";
            this.btn_GetRobPos.Size = new System.Drawing.Size(89, 33);
            this.btn_GetRobPos.TabIndex = 10;
            this.btn_GetRobPos.Text = "GetRobPos";
            this.btn_GetRobPos.UseVisualStyleBackColor = true;
            this.btn_GetRobPos.Click += new System.EventHandler(this.btn_GetRobPos_Click);
            // 
            // gB_CameraPos
            // 
            this.gB_CameraPos.Controls.Add(this.dGV_CameraPos);
            this.gB_CameraPos.Location = new System.Drawing.Point(275, 126);
            this.gB_CameraPos.Margin = new System.Windows.Forms.Padding(2);
            this.gB_CameraPos.Name = "gB_CameraPos";
            this.gB_CameraPos.Padding = new System.Windows.Forms.Padding(2);
            this.gB_CameraPos.Size = new System.Drawing.Size(260, 258);
            this.gB_CameraPos.TabIndex = 9;
            this.gB_CameraPos.TabStop = false;
            this.gB_CameraPos.Text = "CameraPos";
            // 
            // dGV_CameraPos
            // 
            this.dGV_CameraPos.AllowUserToAddRows = false;
            this.dGV_CameraPos.AllowUserToDeleteRows = false;
            this.dGV_CameraPos.AllowUserToResizeColumns = false;
            this.dGV_CameraPos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_CameraPos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGV_CameraPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_CameraPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dGV_CameraPos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_CameraPos.Location = new System.Drawing.Point(2, 16);
            this.dGV_CameraPos.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_CameraPos.Name = "dGV_CameraPos";
            this.dGV_CameraPos.RowHeadersVisible = false;
            this.dGV_CameraPos.RowTemplate.Height = 27;
            this.dGV_CameraPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_CameraPos.Size = new System.Drawing.Size(256, 240);
            this.dGV_CameraPos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "X";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "Y";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormCalibrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 395);
            this.Controls.Add(this.gB_Operate);
            this.Controls.Add(this.gB_CameraPos);
            this.Controls.Add(this.gB_RobotPos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalibrate";
            this.Text = "FormRobot";
            this.gB_RobotPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_RobotPos)).EndInit();
            this.gB_Operate.ResumeLayout(false);
            this.gB_CameraPos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_CameraPos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gB_RobotPos;
        private System.Windows.Forms.DataGridView dGV_RobotPos;
        private System.Windows.Forms.GroupBox gB_Operate;
        private System.Windows.Forms.Button btn_GetRobPos;
        private System.Windows.Forms.Button btn_CalibrateCam;
        private System.Windows.Forms.Button btn_SaveCalibrate;
        private System.Windows.Forms.GroupBox gB_CameraPos;
        private System.Windows.Forms.DataGridView dGV_CameraPos;
        private System.Windows.Forms.Button btn_GetTargetPos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_SavePointData;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PosX;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PosY;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}