namespace CoffeeManagement.Views.DetailViews
{
	partial class WorkTrackingAdmin
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
			this._backgroundUserLoadder = new System.ComponentModel.BackgroundWorker();
			this._btnSave = new System.Windows.Forms.Button();
			this._tbNote = new System.Windows.Forms.RichTextBox();
			this._cb3 = new System.Windows.Forms.CheckBox();
			this._sbSearchbox = new CoffeeManagement.Views.CustomControls.SearchBox();
			this._cb2 = new System.Windows.Forms.CheckBox();
			this._listUsers = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this._lbSalary = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this._lbWorkCount = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this._dpickerTo = new System.Windows.Forms.DateTimePicker();
			this._dpickerFrom = new System.Windows.Forms.DateTimePicker();
			this._gvShifts = new System.Windows.Forms.DataGridView();
			this._cb1 = new System.Windows.Forms.CheckBox();
			this._lbUserRole = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._lbDate = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._lbUsername = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._btnStats = new System.Windows.Forms.Button();
			this._backgroundStats = new System.ComponentModel.BackgroundWorker();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._gvShifts)).BeginInit();
			this.SuspendLayout();
			// 
			// _backgroundUserLoadder
			// 
			this._backgroundUserLoadder.DoWork += new System.ComponentModel.DoWorkEventHandler(this._backgroundUserLoadder_DoWork);
			this._backgroundUserLoadder.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._backgroundUserLoadder_RunWorkerCompleted);
			// 
			// _btnSave
			// 
			this._btnSave.BackColor = System.Drawing.Color.Transparent;
			this._btnSave.FlatAppearance.BorderSize = 0;
			this._btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnSave.Image = global::CoffeeManagement.Properties.Resources.save;
			this._btnSave.Location = new System.Drawing.Point(461, 75);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(90, 40);
			this._btnSave.TabIndex = 27;
			this._btnSave.Text = "Lưu";
			this._btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnSave.UseVisualStyleBackColor = false;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// _tbNote
			// 
			this._tbNote.Location = new System.Drawing.Point(92, 75);
			this._tbNote.Name = "_tbNote";
			this._tbNote.Size = new System.Drawing.Size(353, 65);
			this._tbNote.TabIndex = 26;
			this._tbNote.Text = "";
			// 
			// _cb3
			// 
			this._cb3.AutoSize = true;
			this._cb3.Location = new System.Drawing.Point(450, 43);
			this._cb3.Name = "_cb3";
			this._cb3.Size = new System.Drawing.Size(48, 17);
			this._cb3.TabIndex = 25;
			this._cb3.Text = "Ca 3";
			this._cb3.UseVisualStyleBackColor = true;
			// 
			// _sbSearchbox
			// 
			this._sbSearchbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._sbSearchbox.AutoSize = true;
			this._sbSearchbox.BackColor = System.Drawing.Color.White;
			this._sbSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._sbSearchbox.Location = new System.Drawing.Point(3, 30);
			this._sbSearchbox.Name = "_sbSearchbox";
			this._sbSearchbox.SearchContent = "";
			this._sbSearchbox.Size = new System.Drawing.Size(242, 28);
			this._sbSearchbox.TabIndex = 20;
			// 
			// _cb2
			// 
			this._cb2.AutoSize = true;
			this._cb2.Location = new System.Drawing.Point(391, 43);
			this._cb2.Name = "_cb2";
			this._cb2.Size = new System.Drawing.Size(48, 17);
			this._cb2.TabIndex = 25;
			this._cb2.Text = "Ca 2";
			this._cb2.UseVisualStyleBackColor = true;
			// 
			// _listUsers
			// 
			this._listUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._listUsers.FormattingEnabled = true;
			this._listUsers.Location = new System.Drawing.Point(3, 63);
			this._listUsers.Name = "_listUsers";
			this._listUsers.Size = new System.Drawing.Size(242, 485);
			this._listUsers.TabIndex = 20;
			this._listUsers.SelectedIndexChanged += new System.EventHandler(this._listUsers_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._listUsers);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this._sbSearchbox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 566);
			this.panel1.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Danh sách nhân viên";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.72727F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 572);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this._btnStats);
			this.panel2.Controls.Add(this._lbSalary);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this._lbWorkCount);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this._dpickerTo);
			this.panel2.Controls.Add(this._dpickerFrom);
			this.panel2.Controls.Add(this._gvShifts);
			this.panel2.Controls.Add(this._btnSave);
			this.panel2.Controls.Add(this._tbNote);
			this.panel2.Controls.Add(this._cb3);
			this.panel2.Controls.Add(this._cb2);
			this.panel2.Controls.Add(this._cb1);
			this.panel2.Controls.Add(this._lbUserRole);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this._lbDate);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this._lbUsername);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(257, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(674, 566);
			this.panel2.TabIndex = 22;
			// 
			// _lbSalary
			// 
			this._lbSalary.AutoSize = true;
			this._lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbSalary.Location = new System.Drawing.Point(427, 197);
			this._lbSalary.Name = "_lbSalary";
			this._lbSalary.Size = new System.Drawing.Size(15, 16);
			this._lbSalary.TabIndex = 33;
			this._lbSalary.Text = "_";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(329, 197);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(92, 16);
			this.label12.TabIndex = 34;
			this.label12.Text = "Lương cơ bản:";
			// 
			// _lbWorkCount
			// 
			this._lbWorkCount.AutoSize = true;
			this._lbWorkCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbWorkCount.Location = new System.Drawing.Point(95, 197);
			this._lbWorkCount.Name = "_lbWorkCount";
			this._lbWorkCount.Size = new System.Drawing.Size(15, 16);
			this._lbWorkCount.TabIndex = 31;
			this._lbWorkCount.Text = "_";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(18, 197);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(79, 16);
			this.label10.TabIndex = 32;
			this.label10.Text = "Tổng số ca:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(313, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 16);
			this.label5.TabIndex = 30;
			this.label5.Text = "Đến:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(50, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 16);
			this.label3.TabIndex = 30;
			this.label3.Text = "Từ:";
			// 
			// _dpickerTo
			// 
			this._dpickerTo.Location = new System.Drawing.Point(351, 159);
			this._dpickerTo.Name = "_dpickerTo";
			this._dpickerTo.Size = new System.Drawing.Size(200, 20);
			this._dpickerTo.TabIndex = 29;
			// 
			// _dpickerFrom
			// 
			this._dpickerFrom.Location = new System.Drawing.Point(92, 159);
			this._dpickerFrom.Name = "_dpickerFrom";
			this._dpickerFrom.Size = new System.Drawing.Size(200, 20);
			this._dpickerFrom.TabIndex = 29;
			this._dpickerFrom.ValueChanged += new System.EventHandler(this._dpickerFrom_ValueChanged);
			// 
			// _gvShifts
			// 
			this._gvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvShifts.Location = new System.Drawing.Point(15, 226);
			this._gvShifts.Name = "_gvShifts";
			this._gvShifts.Size = new System.Drawing.Size(646, 322);
			this._gvShifts.TabIndex = 28;
			// 
			// _cb1
			// 
			this._cb1.AutoSize = true;
			this._cb1.Location = new System.Drawing.Point(332, 42);
			this._cb1.Name = "_cb1";
			this._cb1.Size = new System.Drawing.Size(48, 17);
			this._cb1.TabIndex = 25;
			this._cb1.Text = "Ca 1";
			this._cb1.UseVisualStyleBackColor = true;
			// 
			// _lbUserRole
			// 
			this._lbUserRole.AutoSize = true;
			this._lbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbUserRole.Location = new System.Drawing.Point(329, 11);
			this._lbUserRole.Name = "_lbUserRole";
			this._lbUserRole.Size = new System.Drawing.Size(116, 16);
			this._lbUserRole.TabIndex = 24;
			this._lbUserRole.Text = "nhân viên pha chế";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(254, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 16);
			this.label4.TabIndex = 24;
			this.label4.Text = "Chức vụ:";
			// 
			// _lbDate
			// 
			this._lbDate.AutoSize = true;
			this._lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbDate.Location = new System.Drawing.Point(89, 42);
			this._lbDate.Name = "_lbDate";
			this._lbDate.Size = new System.Drawing.Size(72, 16);
			this._lbDate.TabIndex = 24;
			this._lbDate.Text = "29/11/2113";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 75);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 16);
			this.label9.TabIndex = 24;
			this.label9.Text = "Ghi chú";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(254, 42);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 16);
			this.label8.TabIndex = 24;
			this.label8.Text = "Đi làm:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 16);
			this.label6.TabIndex = 24;
			this.label6.Text = "Hôm nay:";
			// 
			// _lbUsername
			// 
			this._lbUsername.AutoSize = true;
			this._lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbUsername.Location = new System.Drawing.Point(89, 11);
			this._lbUsername.Name = "_lbUsername";
			this._lbUsername.Size = new System.Drawing.Size(91, 16);
			this._lbUsername.TabIndex = 24;
			this._lbUsername.Text = "Nguyễn văn a";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 16);
			this.label2.TabIndex = 24;
			this.label2.Text = "Nhân viên:";
			// 
			// _btnStats
			// 
			this._btnStats.BackColor = System.Drawing.Color.Transparent;
			this._btnStats.FlatAppearance.BorderSize = 0;
			this._btnStats.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnStats.Image = global::CoffeeManagement.Properties.Resources.view_24;
			this._btnStats.Location = new System.Drawing.Point(571, 151);
			this._btnStats.Name = "_btnStats";
			this._btnStats.Size = new System.Drawing.Size(90, 40);
			this._btnStats.TabIndex = 35;
			this._btnStats.Text = "Xem";
			this._btnStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnStats.UseVisualStyleBackColor = false;
			this._btnStats.Click += new System.EventHandler(this._btnStats_Click);
			// 
			// _backgroundStats
			// 
			this._backgroundStats.DoWork += new System.ComponentModel.DoWorkEventHandler(this._backgroundStats_DoWork);
			this._backgroundStats.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._backgroundStats_RunWorkerCompleted);
			// 
			// WorkTrackingAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "WorkTrackingAdmin";
			this.Size = new System.Drawing.Size(934, 572);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._gvShifts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker _backgroundUserLoadder;
		private System.Windows.Forms.Button _btnSave;
		private System.Windows.Forms.RichTextBox _tbNote;
		private System.Windows.Forms.CheckBox _cb3;
		private CustomControls.SearchBox _sbSearchbox;
		private System.Windows.Forms.CheckBox _cb2;
		private System.Windows.Forms.ListBox _listUsers;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox _cb1;
		private System.Windows.Forms.Label _lbUserRole;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label _lbDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label _lbUsername;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label _lbSalary;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label _lbWorkCount;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker _dpickerTo;
		private System.Windows.Forms.DateTimePicker _dpickerFrom;
		private System.Windows.Forms.DataGridView _gvShifts;
		private System.Windows.Forms.Button _btnStats;
		private System.ComponentModel.BackgroundWorker _backgroundStats;
	}
}
