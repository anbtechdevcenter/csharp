namespace AnBTech.RestAPI
{
    partial class FrmMainViewList
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
            this.tabMainMenu = new System.Windows.Forms.TabControl();
            this.tabStafe = new System.Windows.Forms.TabPage();
            this.tabBoard = new System.Windows.Forms.TabPage();
            this.tabStafeSubMenu = new System.Windows.Forms.TabControl();
            this.tabStaffManage = new System.Windows.Forms.TabPage();
            this.tabWorkMange = new System.Windows.Forms.TabPage();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFreeBoard = new System.Windows.Forms.TabPage();
            this.tabAnbBoard = new System.Windows.Forms.TabPage();
            this.listStaffView = new System.Windows.Forms.ListView();
            this.listWorkView = new System.Windows.Forms.ListView();
            this.tabMainMenu.SuspendLayout();
            this.tabStafe.SuspendLayout();
            this.tabBoard.SuspendLayout();
            this.tabStafeSubMenu.SuspendLayout();
            this.tabStaffManage.SuspendLayout();
            this.tabWorkMange.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainMenu
            // 
            this.tabMainMenu.Controls.Add(this.tabStafe);
            this.tabMainMenu.Controls.Add(this.tabBoard);
            this.tabMainMenu.Controls.Add(this.tabManage);
            this.tabMainMenu.Controls.Add(this.tabManager);
            this.tabMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainMenu.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabMainMenu.ItemSize = new System.Drawing.Size(64, 40);
            this.tabMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMainMenu.Name = "tabMainMenu";
            this.tabMainMenu.SelectedIndex = 0;
            this.tabMainMenu.Size = new System.Drawing.Size(833, 542);
            this.tabMainMenu.TabIndex = 0;
            // 
            // tabStafe
            // 
            this.tabStafe.Controls.Add(this.tabStafeSubMenu);
            this.tabStafe.Location = new System.Drawing.Point(4, 44);
            this.tabStafe.Name = "tabStafe";
            this.tabStafe.Padding = new System.Windows.Forms.Padding(3);
            this.tabStafe.Size = new System.Drawing.Size(825, 494);
            this.tabStafe.TabIndex = 0;
            this.tabStafe.Text = "STAFE";
            this.tabStafe.UseVisualStyleBackColor = true;
            // 
            // tabBoard
            // 
            this.tabBoard.Controls.Add(this.tabControl1);
            this.tabBoard.Location = new System.Drawing.Point(4, 44);
            this.tabBoard.Name = "tabBoard";
            this.tabBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoard.Size = new System.Drawing.Size(825, 494);
            this.tabBoard.TabIndex = 1;
            this.tabBoard.Text = "게시판";
            this.tabBoard.UseVisualStyleBackColor = true;
            // 
            // tabStafeSubMenu
            // 
            this.tabStafeSubMenu.Controls.Add(this.tabStaffManage);
            this.tabStafeSubMenu.Controls.Add(this.tabWorkMange);
            this.tabStafeSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStafeSubMenu.ItemSize = new System.Drawing.Size(60, 28);
            this.tabStafeSubMenu.Location = new System.Drawing.Point(3, 3);
            this.tabStafeSubMenu.Name = "tabStafeSubMenu";
            this.tabStafeSubMenu.SelectedIndex = 0;
            this.tabStafeSubMenu.Size = new System.Drawing.Size(819, 488);
            this.tabStafeSubMenu.TabIndex = 0;
            this.tabStafeSubMenu.SelectedIndexChanged += new System.EventHandler(this.tabSubMenu_SelectedIndexChanged);
            // 
            // tabStaffManage
            // 
            this.tabStaffManage.Controls.Add(this.listStaffView);
            this.tabStaffManage.Location = new System.Drawing.Point(4, 32);
            this.tabStaffManage.Name = "tabStaffManage";
            this.tabStaffManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaffManage.Size = new System.Drawing.Size(811, 452);
            this.tabStaffManage.TabIndex = 0;
            this.tabStaffManage.Text = "직원관리";
            this.tabStaffManage.UseVisualStyleBackColor = true;
            // 
            // tabWorkMange
            // 
            this.tabWorkMange.Controls.Add(this.listWorkView);
            this.tabWorkMange.Location = new System.Drawing.Point(4, 32);
            this.tabWorkMange.Name = "tabWorkMange";
            this.tabWorkMange.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkMange.Size = new System.Drawing.Size(811, 452);
            this.tabWorkMange.TabIndex = 1;
            this.tabWorkMange.Text = "근태관리";
            this.tabWorkMange.UseVisualStyleBackColor = true;
            // 
            // tabManage
            // 
            this.tabManage.Location = new System.Drawing.Point(4, 44);
            this.tabManage.Name = "tabManage";
            this.tabManage.Size = new System.Drawing.Size(825, 494);
            this.tabManage.TabIndex = 2;
            this.tabManage.Text = "관리";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 44);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(825, 494);
            this.tabManager.TabIndex = 3;
            this.tabManager.Text = "관리자";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFreeBoard);
            this.tabControl1.Controls.Add(this.tabAnbBoard);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFreeBoard
            // 
            this.tabFreeBoard.Location = new System.Drawing.Point(4, 22);
            this.tabFreeBoard.Name = "tabFreeBoard";
            this.tabFreeBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabFreeBoard.Size = new System.Drawing.Size(811, 462);
            this.tabFreeBoard.TabIndex = 0;
            this.tabFreeBoard.Text = "자유게시판";
            this.tabFreeBoard.UseVisualStyleBackColor = true;
            // 
            // tabAnbBoard
            // 
            this.tabAnbBoard.Location = new System.Drawing.Point(4, 22);
            this.tabAnbBoard.Name = "tabAnbBoard";
            this.tabAnbBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnbBoard.Size = new System.Drawing.Size(811, 462);
            this.tabAnbBoard.TabIndex = 1;
            this.tabAnbBoard.Text = "에이앤비테크";
            this.tabAnbBoard.UseVisualStyleBackColor = true;
            // 
            // listStaffView
            // 
            this.listStaffView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStaffView.GridLines = true;
            this.listStaffView.Location = new System.Drawing.Point(3, 3);
            this.listStaffView.Name = "listStaffView";
            this.listStaffView.Size = new System.Drawing.Size(805, 446);
            this.listStaffView.TabIndex = 0;
            this.listStaffView.UseCompatibleStateImageBehavior = false;
            this.listStaffView.View = System.Windows.Forms.View.Details;
            // 
            // listWorkView
            // 
            this.listWorkView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWorkView.Location = new System.Drawing.Point(3, 3);
            this.listWorkView.Name = "listWorkView";
            this.listWorkView.Size = new System.Drawing.Size(805, 446);
            this.listWorkView.TabIndex = 0;
            this.listWorkView.UseCompatibleStateImageBehavior = false;
            this.listWorkView.View = System.Windows.Forms.View.Details;
            // 
            // FrmMainViewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 542);
            this.Controls.Add(this.tabMainMenu);
            this.Name = "FrmMainViewList";
            this.Text = "ANBTECH";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainViewList_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainViewList_Load);
            this.tabMainMenu.ResumeLayout(false);
            this.tabStafe.ResumeLayout(false);
            this.tabBoard.ResumeLayout(false);
            this.tabStafeSubMenu.ResumeLayout(false);
            this.tabStaffManage.ResumeLayout(false);
            this.tabWorkMange.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainMenu;
        private System.Windows.Forms.TabPage tabStafe;
        private System.Windows.Forms.TabControl tabStafeSubMenu;
        private System.Windows.Forms.TabPage tabStaffManage;
        private System.Windows.Forms.TabPage tabWorkMange;
        private System.Windows.Forms.TabPage tabBoard;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFreeBoard;
        private System.Windows.Forms.TabPage tabAnbBoard;
        private System.Windows.Forms.ListView listStaffView;
        private System.Windows.Forms.ListView listWorkView;
    }
}