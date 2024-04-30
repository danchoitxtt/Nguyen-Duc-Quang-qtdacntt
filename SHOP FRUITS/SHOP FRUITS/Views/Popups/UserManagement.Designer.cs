namespace CoffeeManagement.Views.Popups
{
    partial class UserManagement
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
			this._listUsers = new System.Windows.Forms.ListBox();
			this._cbLevel = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._btnDelete = new System.Windows.Forms.Button();
			this._btnSave = new System.Windows.Forms.Button();
			this._btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _tbDescription
			// 
			this._tbDescription.Location = new System.Drawing.Point(326, 111);
			this._tbDescription.Multiline = true;
			this._tbDescription.Name = "_tbDescription";
			this._tbDescription.Size = new System.Drawing.Size(208, 79);
			this._tbDescription.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(239, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mô tả";
			// 
			// _tbUsername
			// 
			this._tbUsername.Location = new System.Drawing.Point(326, 55);
			this._tbUsername.Name = "_tbUsername";
			this._tbUsername.Size = new System.Drawing.Size(208, 20);
			this._tbUsername.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(239, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Tên đăng nhập";
			// 
			// _tbFullName
			// 
			this._tbFullName.Location = new System.Drawing.Point(326, 28);
			this._tbFullName.Name = "_tbFullName";
			this._tbFullName.Size = new System.Drawing.Size(208, 20);
			this._tbFullName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(239, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Họ tên";
			// 
			// _listUsers
			// 
			this._listUsers.FormattingEnabled = true;
			this._listUsers.Location = new System.Drawing.Point(25, 56);
			this._listUsers.Name = "_listUsers";
			this._listUsers.Size = new System.Drawing.Size(181, 134);
			this._listUsers.TabIndex = 1;
			this._listUsers.SelectedIndexChanged += new System.EventHandler(this._listUsers_SelectedIndexChanged);
			// 
			// _cbLevel
			// 
			this._cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbLevel.FormattingEnabled = true;
			this._cbLevel.Location = new System.Drawing.Point(326, 81);
			this._cbLevel.Name = "_cbLevel";
			this._cbLevel.Size = new System.Drawing.Size(208, 21);
			this._cbLevel.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(239, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Chức vụ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Tên đăng nhập";
			// 
			// _btnDelete
			// 
			this._btnDelete.BackColor = System.Drawing.Color.Transparent;
			this._btnDelete.FlatAppearance.BorderSize = 0;
			this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnDelete.Image = global::CoffeeManagement.Properties.Resources.delete;
			this._btnDelete.Location = new System.Drawing.Point(444, 196);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(90, 40);
			this._btnDelete.TabIndex = 7;
			this._btnDelete.Text = "Delete";
			this._btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnDelete.UseVisualStyleBackColor = false;
			this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
			// 
			// _btnSave
			// 
			this._btnSave.BackColor = System.Drawing.Color.Transparent;
			this._btnSave.FlatAppearance.BorderSize = 0;
			this._btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSave.Image = global::CoffeeManagement.Properties.Resources.save;
			this._btnSave.Location = new System.Drawing.Point(348, 196);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(90, 40);
			this._btnSave.TabIndex = 6;
			this._btnSave.Text = "Save";
			this._btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnSave.UseVisualStyleBackColor = false;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _btnAdd
			// 
			this._btnAdd.BackColor = System.Drawing.Color.Transparent;
			this._btnAdd.FlatAppearance.BorderSize = 0;
			this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAdd.Image = global::CoffeeManagement.Properties.Resources.add;
			this._btnAdd.Location = new System.Drawing.Point(116, 196);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(90, 40);
			this._btnAdd.TabIndex = 0;
			this._btnAdd.Text = "Add";
			this._btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnAdd.UseVisualStyleBackColor = false;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// UserManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(553, 260);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._cbLevel);
			this.Controls.Add(this._btnDelete);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._tbDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._tbUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._tbFullName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._btnAdd);
			this.Controls.Add(this._listUsers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "UserManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Quản lý tài khoản";
			this.Load += new System.EventHandler(this.UserManagement_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnDelete;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.TextBox _tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.ListBox _listUsers;
        private System.Windows.Forms.ComboBox _cbLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}