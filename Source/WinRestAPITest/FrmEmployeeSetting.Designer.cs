namespace AnBTech.RestAPI
{
	partial class FrmEmployeeSetting
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
			this.txtTeamName = new System.Windows.Forms.TextBox();
			this.lblTeamName = new System.Windows.Forms.Label();
			this.cboProjectName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTeamName
			// 
			this.txtTeamName.Location = new System.Drawing.Point(16, 34);
			this.txtTeamName.Name = "txtTeamName";
			this.txtTeamName.Size = new System.Drawing.Size(145, 21);
			this.txtTeamName.TabIndex = 5;
			// 
			// lblTeamName
			// 
			this.lblTeamName.AutoSize = true;
			this.lblTeamName.Location = new System.Drawing.Point(14, 78);
			this.lblTeamName.Name = "lblTeamName";
			this.lblTeamName.Size = new System.Drawing.Size(41, 12);
			this.lblTeamName.TabIndex = 3;
			this.lblTeamName.Text = "부서명";
			// 
			// cboProjectName
			// 
			this.cboProjectName.FormattingEnabled = true;
			this.cboProjectName.Location = new System.Drawing.Point(16, 93);
			this.cboProjectName.Name = "cboProjectName";
			this.cboProjectName.Size = new System.Drawing.Size(145, 20);
			this.cboProjectName.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "사원 성명";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(246, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "직급";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(246, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "구분";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "입사일";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(248, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(145, 20);
			this.comboBox1.TabIndex = 6;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(248, 93);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(145, 20);
			this.comboBox2.TabIndex = 6;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 149);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(145, 21);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(67, 183);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 30);
			this.btnCreate.TabIndex = 10;
			this.btnCreate.Text = "등록";
			this.btnCreate.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(162, 183);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 30);
			this.btnUpdate.TabIndex = 10;
			this.btnUpdate.Text = "수정";
			this.btnUpdate.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(260, 183);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 30);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// FrmEmployeeSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 225);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTeamName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTeamName);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.cboProjectName);
			this.Name = "FrmEmployeeSetting";
			this.Text = "사원 신규 등록 및 수정";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTeamName;
		private System.Windows.Forms.Label lblTeamName;
		private System.Windows.Forms.ComboBox cboProjectName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnCancel;
	}
}