namespace AnBTech.RestAPI
{
    partial class FrmBookMag
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSearchBookNm = new System.Windows.Forms.TextBox();
            this.grdBook = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "도서명";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "도서등록";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtSearchBookNm
            // 
            this.txtSearchBookNm.Location = new System.Drawing.Point(59, 34);
            this.txtSearchBookNm.Name = "txtSearchBookNm";
            this.txtSearchBookNm.Size = new System.Drawing.Size(307, 21);
            this.txtSearchBookNm.TabIndex = 4;
            // 
            // grdBook
            // 
            this.grdBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBook.Location = new System.Drawing.Point(14, 65);
            this.grdBook.Name = "grdBook";
            this.grdBook.RowTemplate.Height = 23;
            this.grdBook.Size = new System.Drawing.Size(654, 414);
            this.grdBook.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(603, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 19);
            this.button3.TabIndex = 6;
            this.button3.Text = "도서대여";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmBookMag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grdBook);
            this.Controls.Add(this.txtSearchBookNm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBookMag";
            this.Text = "BookManageMag";
            ((System.ComponentModel.ISupportInitialize)(this.grdBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSearchBookNm;
        private System.Windows.Forms.DataGridView grdBook;
        private System.Windows.Forms.Button button3;
    }
}