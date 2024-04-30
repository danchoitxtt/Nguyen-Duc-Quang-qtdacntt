namespace CoffeeManagement.Views.DetailViews
{
	partial class UserManager
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._cbLevel = new System.Windows.Forms.ComboBox();
			this._btnDelete = new System.Windows.Forms.Button();
			this._btnSave = new System.Windows.Forms.Button();
			this._tbDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._tbUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this._tbFullName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnAdd = new System.Windows.Forms.Button();
			this._listUsers = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 24);
			this.label5.TabIndex = 31;
			this.label5.Text = "Tên đăng nhập";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 30;
			this.label4.Text = "Chức vụ";
			// 
			// _cbLevel
			// 
			this._cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cbLevel.FormattingEnabled = true;
			this._cbLevel.Location = new System.Drawing.Point(127, 111);
			this._cbLevel.Name = "_cbLevel";
			this._cbLevel.Size = new System.Drawing.Size(292, 21);
			this._cbLevel.TabIndex = 23;
			// 
			// _btnDelete
			// 
			this._btnDelete.BackColor = System.Drawing.Color.Transparent;
			this._btnDelete.FlatAppearance.BorderSize = 0;
			this._btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnDelete.Image = global::CoffeeManagement.Properties.Resources.delete;
			this._btnDelete.Location = new System.Drawing.Point(310, 227);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(90, 40);
			this._btnDelete.TabIndex = 26;
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
			this._btnSave.Location = new System.Drawing.Point(214, 227);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(90, 40);
			this._btnSave.TabIndex = 25;
			this._btnSave.Text = "Save";
			this._btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnSave.UseVisualStyleBackColor = false;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _tbDescription
			// 
			this._tbDescription.Location = new System.Drawing.Point(127, 142);
			this._tbDescription.Multiline = true;
			this._tbDescription.Name = "_tbDescription";
			this._tbDescription.Size = new System.Drawing.Size(292, 78);
			this._tbDescription.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "Mô tả";
			// 
			// _tbUsername
			// 
			this._tbUsername.Location = new System.Drawing.Point(127, 85);
			this._tbUsername.Name = "_tbUsername";
			this._tbUsername.Size = new System.Drawing.Size(292, 20);
			this._tbUsername.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 28;
			this.label2.Text = "Tên đăng nhập";
			// 
			// _tbFullName
			// 
			this._tbFullName.Location = new System.Drawing.Point(127, 58);
			this._tbFullName.Name = "_tbFullName";
			this._tbFullName.Size = new System.Drawing.Size(292, 20);
			this._tbFullName.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 29;
			this.label1.Text = "Họ tên";
			// 
			// _btnAdd
			// 
			this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnAdd.BackColor = System.Drawing.Color.Transparent;
			this._btnAdd.FlatAppearance.BorderSize = 0;
			this._btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAdd.Image = global::CoffeeManagement.Properties.Resources.add;
			this._btnAdd.Location = new System.Drawing.Point(166, 471);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(90, 40);
			this._btnAdd.TabIndex = 19;
			this._btnAdd.Text = "Add";
			this._btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnAdd.UseVisualStyleBackColor = false;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// _listUsers
			// 
			this._listUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._listUsers.FormattingEnabled = true;
			this._listUsers.Location = new System.Drawing.Point(14, 58);
			this._listUsers.Name = "_listUsers";
			this._listUsers.Size = new System.Drawing.Size(242, 407);
			this._listUsers.TabIndex = 20;
			this._listUsers.SelectedIndexChanged += new System.EventHandler(this._listUsers_SelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 527);
			this.tableLayoutPanel1.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this._listUsers);
			this.panel1.Controls.Add(this._btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(269, 521);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this._tbDescription);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this._cbLevel);
			this.panel2.Controls.Add(this._tbFullName);
			this.panel2.Controls.Add(this._btnDelete);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this._btnSave);
			this.panel2.Controls.Add(this._tbUsername);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(278, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(638, 521);
			this.panel2.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(26, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(170, 24);
			this.label6.TabIndex = 32;
			this.label6.Text = "Thông tin tài khoản";
			// 
			// UserManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "UserManager";
			this.Size = new System.Drawing.Size(919, 527);
			this.Load += new System.EventHandler(this.UserManagement_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox _cbLevel;
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label6;
	}
}
