namespace AnBTech.RestAPI
{
    partial class FrmDeviceMag
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeviceModelNm = new System.Windows.Forms.TextBox();
            this.txtDeviceNm = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grdDevice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "장비관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "모델명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "장비명";
            // 
            // txtDeviceModelNm
            // 
            this.txtDeviceModelNm.Location = new System.Drawing.Point(59, 34);
            this.txtDeviceModelNm.Name = "txtDeviceModelNm";
            this.txtDeviceModelNm.Size = new System.Drawing.Size(157, 21);
            this.txtDeviceModelNm.TabIndex = 3;
            // 
            // txtDeviceNm
            // 
            this.txtDeviceNm.Location = new System.Drawing.Point(269, 34);
            this.txtDeviceNm.Name = "txtDeviceNm";
            this.txtDeviceNm.Size = new System.Drawing.Size(157, 21);
            this.txtDeviceNm.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "조회";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "장비등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grdDevice
            // 
            this.grdDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDevice.Location = new System.Drawing.Point(14, 68);
            this.grdDevice.Name = "grdDevice";
            this.grdDevice.RowTemplate.Height = 23;
            this.grdDevice.Size = new System.Drawing.Size(692, 459);
            this.grdDevice.TabIndex = 8;
            // 
            // FrmDeviceMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 543);
            this.Controls.Add(this.grdDevice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDeviceNm);
            this.Controls.Add(this.txtDeviceModelNm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeviceMag";
            this.Text = "FrmDeviceMag";
            ((System.ComponentModel.ISupportInitialize)(this.grdDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeviceModelNm;
        private System.Windows.Forms.TextBox txtDeviceNm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdDevice;
    }
}