namespace CoffeeManagement.Views
{
    partial class MasterView
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
			this.panel2 = new System.Windows.Forms.Panel();
			this._btnMenu = new System.Windows.Forms.Button();
			this._lbHello = new System.Windows.Forms.Label();
			this._lbScreenName = new System.Windows.Forms.Label();
			this._pMain = new System.Windows.Forms.Panel();
			this._menuLayout = new System.Windows.Forms.FlowLayoutPanel();
			this._menuSaleStatistics = new System.Windows.Forms.Button();
			this._menuItemsManager = new System.Windows.Forms.Button();
			this._menuUserManager = new System.Windows.Forms.Button();
			this._menuSaleManager = new System.Windows.Forms.Button();
			this._menuWorkTracking = new System.Windows.Forms.Button();
			this._menuLogOut = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this._menuLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this._btnMenu);
			this.panel2.Controls.Add(this._lbHello);
			this.panel2.Controls.Add(this._lbScreenName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 36);
			this.panel2.TabIndex = 0;
			// 
			// _btnMenu
			// 
			this._btnMenu.BackColor = System.Drawing.Color.Transparent;
			this._btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this._btnMenu.FlatAppearance.BorderSize = 0;
			this._btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnMenu.Image = global::CoffeeManagement.Properties.Resources.menu_32;
			this._btnMenu.Location = new System.Drawing.Point(0, 0);
			this._btnMenu.Name = "_btnMenu";
			this._btnMenu.Size = new System.Drawing.Size(36, 36);
			this._btnMenu.TabIndex = 1;
			this._btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._btnMenu.UseVisualStyleBackColor = false;
			this._btnMenu.Click += new System.EventHandler(this._btnMenu_Click);
			// 
			// _lbHello
			// 
			this._lbHello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._lbHello.AutoSize = true;
			this._lbHello.BackColor = System.Drawing.Color.Transparent;
			this._lbHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbHello.Location = new System.Drawing.Point(890, 10);
			this._lbHello.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this._lbHello.Name = "_lbHello";
			this._lbHello.Size = new System.Drawing.Size(91, 16);
			this._lbHello.TabIndex = 0;
			this._lbHello.Text = "Chào Admin";
			this._lbHello.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lbScreenName
			// 
			this._lbScreenName.AutoSize = true;
			this._lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbScreenName.Location = new System.Drawing.Point(42, 6);
			this._lbScreenName.Name = "_lbScreenName";
			this._lbScreenName.Size = new System.Drawing.Size(0, 24);
			this._lbScreenName.TabIndex = 1;
			// 
			// _pMain
			// 
			this._pMain.BackColor = System.Drawing.Color.LightGray;
			this._pMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this._pMain.Location = new System.Drawing.Point(0, 36);
			this._pMain.Margin = new System.Windows.Forms.Padding(0);
			this._pMain.Name = "_pMain";
			this._pMain.Size = new System.Drawing.Size(984, 625);
			this._pMain.TabIndex = 4;
			this._pMain.Click += new System.EventHandler(this._pMain_Click);
			// 
			// _menuLayout
			// 
			this._menuLayout.BackColor = System.Drawing.Color.WhiteSmoke;
			this._menuLayout.Controls.Add(this._menuSaleStatistics);
			this._menuLayout.Controls.Add(this._menuItemsManager);
			this._menuLayout.Controls.Add(this._menuUserManager);
			this._menuLayout.Controls.Add(this._menuSaleManager);
			this._menuLayout.Controls.Add(this._menuWorkTracking);
			this._menuLayout.Controls.Add(this._menuLogOut);
			this._menuLayout.Dock = System.Windows.Forms.DockStyle.Left;
			this._menuLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this._menuLayout.Location = new System.Drawing.Point(0, 36);
			this._menuLayout.Margin = new System.Windows.Forms.Padding(0);
			this._menuLayout.Name = "_menuLayout";
			this._menuLayout.Size = new System.Drawing.Size(198, 625);
			this._menuLayout.TabIndex = 5;
			this._menuLayout.Visible = false;
			// 
			// _menuSaleStatistics
			// 
			this._menuSaleStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._menuSaleStatistics.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._menuSaleStatistics.FlatAppearance.BorderSize = 0;
			this._menuSaleStatistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._menuSaleStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._menuSaleStatistics.Image = global::CoffeeManagement.Properties.Resources.sale_statistics;
			this._menuSaleStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuSaleStatistics.Location = new System.Drawing.Point(3, 3);
			this._menuSaleStatistics.Name = "_menuSaleStatistics";
			this._menuSaleStatistics.Size = new System.Drawing.Size(190, 40);
			this._menuSaleStatistics.TabIndex = 0;
			this._menuSaleStatistics.Tag = "Sale";
			this._menuSaleStatistics.Text = "Thống kê bán hàng";
			this._menuSaleStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuSaleStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._menuSaleStatistics.UseVisualStyleBackColor = true;
			this._menuSaleStatistics.Visible = false;
			this._menuSaleStatistics.Click += new System.EventHandler(this.OnMenuButtonClick);
			// 
			// _menuItemsManager
			// 
			this._menuItemsManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._menuItemsManager.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._menuItemsManager.FlatAppearance.BorderSize = 0;
			this._menuItemsManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._menuItemsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._menuItemsManager.Image = global::CoffeeManagement.Properties.Resources.material_state;
			this._menuItemsManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuItemsManager.Location = new System.Drawing.Point(3, 49);
			this._menuItemsManager.Name = "_menuItemsManager";
			this._menuItemsManager.Size = new System.Drawing.Size(190, 40);
			this._menuItemsManager.TabIndex = 2;
			this._menuItemsManager.Tag = "Sale";
			this._menuItemsManager.Text = "Quản lý mặt hàng";
			this._menuItemsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuItemsManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._menuItemsManager.UseVisualStyleBackColor = true;
			this._menuItemsManager.Visible = false;
			this._menuItemsManager.Click += new System.EventHandler(this.OnMenuButtonClick);
			// 
			// _menuUserManager
			// 
			this._menuUserManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._menuUserManager.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._menuUserManager.FlatAppearance.BorderSize = 0;
			this._menuUserManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._menuUserManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._menuUserManager.Image = global::CoffeeManagement.Properties.Resources.user_32;
			this._menuUserManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuUserManager.Location = new System.Drawing.Point(3, 95);
			this._menuUserManager.Name = "_menuUserManager";
			this._menuUserManager.Size = new System.Drawing.Size(190, 40);
			this._menuUserManager.TabIndex = 8;
			this._menuUserManager.Tag = "Sale";
			this._menuUserManager.Text = "Quản lý tài khoản";
			this._menuUserManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuUserManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._menuUserManager.UseVisualStyleBackColor = true;
			this._menuUserManager.Visible = false;
			this._menuUserManager.Click += new System.EventHandler(this.OnMenuButtonClick);
			// 
			// _menuSaleManager
			// 
			this._menuSaleManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._menuSaleManager.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._menuSaleManager.FlatAppearance.BorderSize = 0;
			this._menuSaleManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._menuSaleManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._menuSaleManager.Image = global::CoffeeManagement.Properties.Resources.sale;
			this._menuSaleManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuSaleManager.Location = new System.Drawing.Point(3, 141);
			this._menuSaleManager.Name = "_menuSaleManager";
			this._menuSaleManager.Size = new System.Drawing.Size(190, 40);
			this._menuSaleManager.TabIndex = 4;
			this._menuSaleManager.Tag = "Sale";
			this._menuSaleManager.Text = "Quản lý bán hàng";
			this._menuSaleManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuSaleManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._menuSaleManager.UseVisualStyleBackColor = true;
			this._menuSaleManager.Visible = false;
			this._menuSaleManager.Click += new System.EventHandler(this.OnMenuButtonClick);
			// 
			// _menuWorkTracking
			// 
			this._menuWorkTracking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._menuWorkTracking.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._menuWorkTracking.FlatAppearance.BorderSize = 0;
			this._menuWorkTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._menuWorkTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._menuWorkTracking.Image = global::CoffeeManagement.Properties.Resources.work_tracking;
			this._menuWorkTracking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuWorkTracking.Location = new System.Drawing.Point(3, 187);
			this._menuWorkTracking.Name = "_menuWorkTracking";
			this._menuWorkTracking.Size = new System.Drawing.Size(190, 40);
			this._menuWorkTracking.TabIndex = 5;
			this._menuWorkTracking.Tag = "";
			this._menuWorkTracking.Text = "Chấm công";
			this._menuWorkTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuWorkTracking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._menuWorkTracking.UseVisualStyleBackColor = true;
			this._menuWorkTracking.Visible = false;
			this._menuWorkTracking.Click += new System.EventHandler(this.OnMenuButtonClick);
			// 
			// _menuLogOut
			// 
			this._menuLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
			this._menuLogOut.FlatAppearance.BorderSize = 0;
			this._menuLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._menuLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._menuLogOut.Image = global::CoffeeManagement.Properties.Resources.log_out;
			this._menuLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuLogOut.Location = new System.Drawing.Point(3, 233);
			this._menuLogOut.Name = "_menuLogOut";
			this._menuLogOut.Size = new System.Drawing.Size(190, 40);
			this._menuLogOut.TabIndex = 7;
			this._menuLogOut.Tag = "LogOut";
			this._menuLogOut.Text = "Đăng xuất";
			this._menuLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._menuLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._menuLogOut.UseVisualStyleBackColor = true;
			this._menuLogOut.Click += new System.EventHandler(this.OnMenuButtonClick);
			// 
			// MasterView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 661);
			this.Controls.Add(this._menuLayout);
			this.Controls.Add(this._pMain);
			this.Controls.Add(this.panel2);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MasterView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CFM - QUẢN LÝ QUÁN CÀ PHÊ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterView_FormClosing);
			this.Load += new System.EventHandler(this.MasterView_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this._menuLayout.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label _lbHello;
        private System.Windows.Forms.Label _lbScreenName;
        private System.Windows.Forms.Panel _pMain;
        private System.Windows.Forms.Button _btnMenu;
        private System.Windows.Forms.FlowLayoutPanel _menuLayout;
        private System.Windows.Forms.Button _menuSaleManager;
		private System.Windows.Forms.Button _menuWorkTracking;
        private System.Windows.Forms.Button _menuLogOut;
		private System.Windows.Forms.Button _menuSaleStatistics;
		private System.Windows.Forms.Button _menuItemsManager;
        private System.Windows.Forms.Button _menuUserManager;



    }
}