namespace CoffeeManagement.Views.Popups
{
	partial class PaymentConfirm
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.topPanel = new System.Windows.Forms.Panel();
			this.expandLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._tbBillPretotal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._lbTableNames = new System.Windows.Forms.Label();
			this.discountPanel = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this._tbFinalTotal = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this._tbDiscount = new System.Windows.Forms.TextBox();
			this.bottomPanel = new System.Windows.Forms.Panel();
			this._tbReturnChanges = new System.Windows.Forms.TextBox();
			this._tbReceive = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnPay = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.topPanel.SuspendLayout();
			this.discountPanel.SuspendLayout();
			this.bottomPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.topPanel);
			this.flowLayoutPanel1.Controls.Add(this.discountPanel);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 261);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.expandLabel);
			this.topPanel.Controls.Add(this.label5);
			this.topPanel.Controls.Add(this._tbBillPretotal);
			this.topPanel.Controls.Add(this.label2);
			this.topPanel.Controls.Add(this.label4);
			this.topPanel.Controls.Add(this.label1);
			this.topPanel.Controls.Add(this._lbTableNames);
			this.topPanel.Location = new System.Drawing.Point(3, 3);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(281, 72);
			this.topPanel.TabIndex = 0;
			// 
			// expandLabel
			// 
			this.expandLabel.AutoSize = true;
			this.expandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.expandLabel.Location = new System.Drawing.Point(120, 56);
			this.expandLabel.Name = "expandLabel";
			this.expandLabel.Size = new System.Drawing.Size(68, 16);
			this.expandLabel.TabIndex = 8;
			this.expandLabel.Text = "▼ Mở rộng";
			this.expandLabel.Click += new System.EventHandler(this.expandLabel_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(37, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Khuyến mãi";
			// 
			// _tbBillPretotal
			// 
			this._tbBillPretotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbBillPretotal.Location = new System.Drawing.Point(123, 27);
			this._tbBillPretotal.Name = "_tbBillPretotal";
			this._tbBillPretotal.ReadOnly = true;
			this._tbBillPretotal.Size = new System.Drawing.Size(50, 22);
			this._tbBillPretotal.TabIndex = 6;
			this._tbBillPretotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tổng tiền";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(174, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "000 VNĐ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bàn số";
			// 
			// _lbTableNames
			// 
			this._lbTableNames.AutoSize = true;
			this._lbTableNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbTableNames.Location = new System.Drawing.Point(120, 5);
			this._lbTableNames.Name = "_lbTableNames";
			this._lbTableNames.Size = new System.Drawing.Size(0, 16);
			this._lbTableNames.TabIndex = 2;
			// 
			// discountPanel
			// 
			this.discountPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.discountPanel.Controls.Add(this.label14);
			this.discountPanel.Controls.Add(this.label13);
			this.discountPanel.Controls.Add(this.label11);
			this.discountPanel.Controls.Add(this._tbFinalTotal);
			this.discountPanel.Controls.Add(this.label12);
			this.discountPanel.Controls.Add(this._tbDiscount);
			this.discountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.discountPanel.Location = new System.Drawing.Point(3, 81);
			this.discountPanel.Name = "discountPanel";
			this.discountPanel.Size = new System.Drawing.Size(281, 56);
			this.discountPanel.TabIndex = 1;
			this.discountPanel.Visible = false;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(18, 35);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(96, 16);
			this.label14.TabIndex = 2;
			this.label14.Text = "Số tiền phải trả";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(173, 35);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 16);
			this.label13.TabIndex = 3;
			this.label13.Text = "000 VNĐ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(37, 5);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(77, 16);
			this.label11.TabIndex = 4;
			this.label11.Text = "Khuyến mãi";
			// 
			// _tbFinalTotal
			// 
			this._tbFinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbFinalTotal.Location = new System.Drawing.Point(123, 32);
			this._tbFinalTotal.Name = "_tbFinalTotal";
			this._tbFinalTotal.ReadOnly = true;
			this._tbFinalTotal.Size = new System.Drawing.Size(50, 22);
			this._tbFinalTotal.TabIndex = 6;
			this._tbFinalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(173, 5);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(20, 16);
			this.label12.TabIndex = 5;
			this.label12.Text = "%";
			// 
			// _tbDiscount
			// 
			this._tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbDiscount.Location = new System.Drawing.Point(123, 2);
			this._tbDiscount.Name = "_tbDiscount";
			this._tbDiscount.Size = new System.Drawing.Size(50, 22);
			this._tbDiscount.TabIndex = 7;
			this._tbDiscount.Text = "0";
			this._tbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._tbDiscount.TextChanged += new System.EventHandler(this.discountRatio_TextChanged);
			// 
			// bottomPanel
			// 
			this.bottomPanel.Controls.Add(this._tbReturnChanges);
			this.bottomPanel.Controls.Add(this._tbReceive);
			this.bottomPanel.Controls.Add(this.label10);
			this.bottomPanel.Controls.Add(this.label7);
			this.bottomPanel.Controls.Add(this.label9);
			this.bottomPanel.Controls.Add(this.label8);
			this.bottomPanel.Controls.Add(this._btnCancel);
			this.bottomPanel.Controls.Add(this._btnPay);
			this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomPanel.Location = new System.Drawing.Point(0, 139);
			this.bottomPanel.Name = "bottomPanel";
			this.bottomPanel.Size = new System.Drawing.Size(284, 122);
			this.bottomPanel.TabIndex = 1;
			// 
			// _tbReturnChanges
			// 
			this._tbReturnChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbReturnChanges.Location = new System.Drawing.Point(126, 35);
			this._tbReturnChanges.Name = "_tbReturnChanges";
			this._tbReturnChanges.ReadOnly = true;
			this._tbReturnChanges.Size = new System.Drawing.Size(50, 22);
			this._tbReturnChanges.TabIndex = 9;
			this._tbReturnChanges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _tbReceive
			// 
			this._tbReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbReceive.Location = new System.Drawing.Point(126, 5);
			this._tbReceive.Name = "_tbReceive";
			this._tbReceive.Size = new System.Drawing.Size(50, 22);
			this._tbReceive.TabIndex = 10;
			this._tbReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this._tbReceive.TextChanged += new System.EventHandler(this.givenCash_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(176, 38);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 16);
			this.label10.TabIndex = 5;
			this.label10.Text = "000 VNĐ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(176, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "000 VNĐ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(22, 38);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(95, 16);
			this.label9.TabIndex = 7;
			this.label9.Text = "Tiền cần trả lại";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(3, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Số tiền khách đưa";
			// 
			// _btnCancel
			// 
			this._btnCancel.FlatAppearance.BorderSize = 0;
			this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnCancel.Image = global::CoffeeManagement.Properties.Resources.invalid;
			this._btnCancel.Location = new System.Drawing.Point(170, 70);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(75, 40);
			this._btnCancel.TabIndex = 3;
			this._btnCancel.Text = "Hủy";
			this._btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// _btnPay
			// 
			this._btnPay.FlatAppearance.BorderSize = 0;
			this._btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnPay.Image = global::CoffeeManagement.Properties.Resources.print;
			this._btnPay.Location = new System.Drawing.Point(28, 70);
			this._btnPay.Name = "_btnPay";
			this._btnPay.Size = new System.Drawing.Size(133, 40);
			this._btnPay.TabIndex = 4;
			this._btnPay.Text = "Thanh Toán";
			this._btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnPay.UseVisualStyleBackColor = true;
			this._btnPay.Click += new System.EventHandler(this.payBillBtn_Click);
			// 
			// PaymentConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.bottomPanel);
			this.Controls.Add(this.flowLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PaymentConfirm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Xác nhận thanh toán";
			this.TopMost = true;
			this.flowLayoutPanel1.ResumeLayout(false);
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			this.discountPanel.ResumeLayout(false);
			this.discountPanel.PerformLayout();
			this.bottomPanel.ResumeLayout(false);
			this.bottomPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Button _btnPay;
		private System.Windows.Forms.Panel topPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _lbTableNames;
		private System.Windows.Forms.TextBox _tbBillPretotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label expandLabel;
		private System.Windows.Forms.TextBox _tbReturnChanges;
		private System.Windows.Forms.TextBox _tbReceive;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel discountPanel;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox _tbFinalTotal;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox _tbDiscount;
	}
}