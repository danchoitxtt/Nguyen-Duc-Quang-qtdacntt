namespace CoffeeManagement.Views
{
	partial class Login
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
			this._tbUsername = new System.Windows.Forms.TextBox();
			this._tbPassword = new System.Windows.Forms.TextBox();
			this._lbAppName = new System.Windows.Forms.Label();
			this._btnLogin = new System.Windows.Forms.Button();
			this._btnExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(135, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Tên đăng nhập";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(135, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Mật khẩu";
			// 
			// _tbUsername
			// 
			this._tbUsername.Location = new System.Drawing.Point(222, 95);
			this._tbUsername.Name = "_tbUsername";
			this._tbUsername.Size = new System.Drawing.Size(181, 20);
			this._tbUsername.TabIndex = 0;
			// 
			// _tbPassword
			// 
			this._tbPassword.Location = new System.Drawing.Point(222, 124);
			this._tbPassword.Name = "_tbPassword";
			this._tbPassword.PasswordChar = '●';
			this._tbPassword.Size = new System.Drawing.Size(181, 20);
			this._tbPassword.TabIndex = 1;
			// 
			// _lbAppName
			// 
			this._lbAppName.AutoSize = true;
			this._lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbAppName.Location = new System.Drawing.Point(134, 25);
			this._lbAppName.Name = "_lbAppName";
			this._lbAppName.Size = new System.Drawing.Size(309, 24);
			this._lbAppName.TabIndex = 8;
			this._lbAppName.Text = "CFM - QUẢN LÝ QUÁN CÀ PHÊ";
			this._lbAppName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _btnLogin
			// 
			this._btnLogin.FlatAppearance.BorderSize = 0;
			this._btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnLogin.Image = global::CoffeeManagement.Properties.Resources.login;
			this._btnLogin.Location = new System.Drawing.Point(215, 161);
			this._btnLogin.Name = "_btnLogin";
			this._btnLogin.Size = new System.Drawing.Size(104, 40);
			this._btnLogin.TabIndex = 2;
			this._btnLogin.Text = "Đăng nhập";
			this._btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnLogin.UseVisualStyleBackColor = true;
			this._btnLogin.VisibleChanged += new System.EventHandler(this._btnLogin_VisibleChanged);
			this._btnLogin.Click += new System.EventHandler(this._btnLogin_Click);
			// 
			// _btnExit
			// 
			this._btnExit.FlatAppearance.BorderSize = 0;
			this._btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnExit.Image = global::CoffeeManagement.Properties.Resources.exit;
			this._btnExit.Location = new System.Drawing.Point(325, 161);
			this._btnExit.Name = "_btnExit";
			this._btnExit.Size = new System.Drawing.Size(78, 40);
			this._btnExit.TabIndex = 3;
			this._btnExit.Text = "Thoát";
			this._btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnExit.UseVisualStyleBackColor = true;
			this._btnExit.Click += new System.EventHandler(this._btnExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::CoffeeManagement.Properties.Resources.user;
			this.pictureBox1.Location = new System.Drawing.Point(16, 66);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(107, 98);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 234);
			this.Controls.Add(this._lbAppName);
			this.Controls.Add(this._tbPassword);
			this.Controls.Add(this._tbUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnLogin);
			this.Controls.Add(this._btnExit);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
			this.Load += new System.EventHandler(this.Login_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button _btnExit;
		private System.Windows.Forms.Button _btnLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _tbUsername;
		private System.Windows.Forms.TextBox _tbPassword;
		private System.Windows.Forms.Label _lbAppName;
		private System.ComponentModel.BackgroundWorker _backgroundWorker;
	}
}