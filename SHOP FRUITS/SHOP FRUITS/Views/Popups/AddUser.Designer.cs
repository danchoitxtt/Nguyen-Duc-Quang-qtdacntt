namespace CoffeeManagement.Views.Popups
{
    partial class AddUser
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
			this._tbDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._tbUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._tbFullName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._tbPassword = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this._cbLevel = new System.Windows.Forms.ComboBox();
			this._picNotAvailable = new System.Windows.Forms.PictureBox();
			this._btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._picNotAvailable)).BeginInit();
			this.SuspendLayout();
			// 
			// _tbDescription
			// 
			this._tbDescription.Location = new System.Drawing.Point(112, 138);
			this._tbDescription.Multiline = true;
			this._tbDescription.Name = "_tbDescription";
			this._tbDescription.Size = new System.Drawing.Size(181, 82);
			this._tbDescription.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Mô tả";
			// 
			// _tbUsername
			// 
			this._tbUsername.Location = new System.Drawing.Point(112, 59);
			this._tbUsername.Name = "_tbUsername";
			this._tbUsername.Size = new System.Drawing.Size(181, 20);
			this._tbUsername.TabIndex = 1;
			this._tbUsername.Validated += new System.EventHandler(this._tbUsername_Validated);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Tên đăng nhập";
			// 
			// _tbFullName
			// 
			this._tbFullName.Location = new System.Drawing.Point(112, 33);
			this._tbFullName.Name = "_tbFullName";
			this._tbFullName.Size = new System.Drawing.Size(181, 20);
			this._tbFullName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Họ tên";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Mật khẩu";
			// 
			// _tbPassword
			// 
			this._tbPassword.Location = new System.Drawing.Point(112, 85);
			this._tbPassword.Name = "_tbPassword";
			this._tbPassword.Size = new System.Drawing.Size(181, 20);
			this._tbPassword.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Chức vụ";
			// 
			// _cbLevel
			// 
			this._cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbLevel.FormattingEnabled = true;
			this._cbLevel.Location = new System.Drawing.Point(112, 111);
			this._cbLevel.Name = "_cbLevel";
			this._cbLevel.Size = new System.Drawing.Size(181, 21);
			this._cbLevel.TabIndex = 3;
			// 
			// _picNotAvailable
			// 
			this._picNotAvailable.Image = global::CoffeeManagement.Properties.Resources.invalid;
			this._picNotAvailable.Location = new System.Drawing.Point(299, 59);
			this._picNotAvailable.Name = "_picNotAvailable";
			this._picNotAvailable.Size = new System.Drawing.Size(24, 24);
			this._picNotAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this._picNotAvailable.TabIndex = 24;
			this._picNotAvailable.TabStop = false;
			this._picNotAvailable.Visible = false;
			// 
			// _btnSave
			// 
			this._btnSave.BackColor = System.Drawing.Color.Transparent;
			this._btnSave.FlatAppearance.BorderSize = 0;
			this._btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSave.Image = global::CoffeeManagement.Properties.Resources.save;
			this._btnSave.Location = new System.Drawing.Point(203, 226);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(90, 40);
			this._btnSave.TabIndex = 5;
			this._btnSave.Text = "Add";
			this._btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnSave.UseVisualStyleBackColor = false;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// AddUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 296);
			this.Controls.Add(this._picNotAvailable);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._cbLevel);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._tbDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._tbPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._tbUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._tbFullName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm tài khoản";
			this.Load += new System.EventHandler(this.AddUser_Load);
			((System.ComponentModel.ISupportInitialize)(this._picNotAvailable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.TextBox _tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbLevel;
        private System.Windows.Forms.PictureBox _picNotAvailable;
    }
}