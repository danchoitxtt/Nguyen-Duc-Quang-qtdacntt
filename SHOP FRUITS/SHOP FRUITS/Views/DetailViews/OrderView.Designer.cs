namespace CoffeeManagement.Views.DetailViews
{
	partial class OrderView
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
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this._btnEndShift = new System.Windows.Forms.Button();
			this._listTables = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this._btnMergeBill = new System.Windows.Forms.Button();
			this._btnDelete = new System.Windows.Forms.Button();
			this._btnPay = new System.Windows.Forms.Button();
			this._btnPrint = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this._lbTotalPrice = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._gvOrder = new System.Windows.Forms.DataGridView();
			this._lbTableNames = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this._sbSearchItems = new CoffeeManagement.Views.CustomControls.SearchBox();
			this.label3 = new System.Windows.Forms.Label();
			this._gvItems = new System.Windows.Forms.DataGridView();
			this._itemBackgroundLoader = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._gvOrder)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._gvItems)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(170, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "HÓA ĐƠN";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 600);
			this.tableLayoutPanel1.TabIndex = 17;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._btnEndShift);
			this.panel1.Controls.Add(this._listTables);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(193, 594);
			this.panel1.TabIndex = 5;
			// 
			// _btnEndShift
			// 
			this._btnEndShift.FlatAppearance.BorderSize = 0;
			this._btnEndShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnEndShift.Image = global::CoffeeManagement.Properties.Resources.end_shift;
			this._btnEndShift.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnEndShift.Location = new System.Drawing.Point(3, 5);
			this._btnEndShift.Name = "_btnEndShift";
			this._btnEndShift.Size = new System.Drawing.Size(112, 40);
			this._btnEndShift.TabIndex = 24;
			this._btnEndShift.Text = "Kết ca";
			this._btnEndShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnEndShift.UseVisualStyleBackColor = true;
			this._btnEndShift.Click += new System.EventHandler(this._btnEndShift_Click);
			// 
			// _listTables
			// 
			this._listTables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._listTables.FormattingEnabled = true;
			this._listTables.Location = new System.Drawing.Point(3, 72);
			this._listTables.Name = "_listTables";
			this._listTables.Size = new System.Drawing.Size(190, 514);
			this._listTables.TabIndex = 4;
			this._listTables.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this._listTables_ItemCheck);
			this._listTables.SelectedIndexChanged += new System.EventHandler(this._listTables_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Danh sách bàn";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this._btnMergeBill);
			this.panel2.Controls.Add(this._btnDelete);
			this.panel2.Controls.Add(this._btnPay);
			this.panel2.Controls.Add(this._btnPrint);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this._lbTotalPrice);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this._gvOrder);
			this.panel2.Controls.Add(this._lbTableNames);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(202, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(442, 594);
			this.panel2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(3, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 24);
			this.label4.TabIndex = 22;
			this.label4.Text = "Bàn:";
			// 
			// _btnMergeBill
			// 
			this._btnMergeBill.Enabled = false;
			this._btnMergeBill.FlatAppearance.BorderSize = 0;
			this._btnMergeBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnMergeBill.Image = global::CoffeeManagement.Properties.Resources.plus_24px;
			this._btnMergeBill.Location = new System.Drawing.Point(325, 36);
			this._btnMergeBill.Name = "_btnMergeBill";
			this._btnMergeBill.Size = new System.Drawing.Size(114, 31);
			this._btnMergeBill.TabIndex = 23;
			this._btnMergeBill.Text = "Gộp thêm bàn";
			this._btnMergeBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnMergeBill.UseVisualStyleBackColor = true;
			this._btnMergeBill.Click += new System.EventHandler(this._btnMergeBill_Click);
			// 
			// _btnDelete
			// 
			this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._btnDelete.Enabled = false;
			this._btnDelete.FlatAppearance.BorderSize = 0;
			this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnDelete.Image = global::CoffeeManagement.Properties.Resources.delete;
			this._btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnDelete.Location = new System.Drawing.Point(326, 546);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(116, 40);
			this._btnDelete.TabIndex = 21;
			this._btnDelete.Text = "Xóa hóa đơn";
			this._btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnDelete.UseVisualStyleBackColor = true;
			this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
			// 
			// _btnPay
			// 
			this._btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnPay.Enabled = false;
			this._btnPay.FlatAppearance.BorderSize = 0;
			this._btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnPay.Image = global::CoffeeManagement.Properties.Resources.pay;
			this._btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnPay.Location = new System.Drawing.Point(210, 546);
			this._btnPay.Name = "_btnPay";
			this._btnPay.Size = new System.Drawing.Size(110, 40);
			this._btnPay.TabIndex = 20;
			this._btnPay.Text = "Thanh toán";
			this._btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnPay.UseVisualStyleBackColor = true;
			this._btnPay.Click += new System.EventHandler(this._btnPay_Click);
			// 
			// _btnPrint
			// 
			this._btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnPrint.Enabled = false;
			this._btnPrint.FlatAppearance.BorderSize = 0;
			this._btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnPrint.Image = global::CoffeeManagement.Properties.Resources.print;
			this._btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnPrint.Location = new System.Drawing.Point(94, 546);
			this._btnPrint.Name = "_btnPrint";
			this._btnPrint.Size = new System.Drawing.Size(110, 40);
			this._btnPrint.TabIndex = 19;
			this._btnPrint.Text = "In hóa đơn";
			this._btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnPrint.UseVisualStyleBackColor = true;
			this._btnPrint.Visible = false;
			this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(389, 519);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 24);
			this.label7.TabIndex = 18;
			this.label7.Text = "VNĐ";
			// 
			// _lbTotalPrice
			// 
			this._lbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbTotalPrice.Location = new System.Drawing.Point(240, 519);
			this._lbTotalPrice.Name = "_lbTotalPrice";
			this._lbTotalPrice.Size = new System.Drawing.Size(143, 24);
			this._lbTotalPrice.TabIndex = 17;
			this._lbTotalPrice.Text = "0";
			this._lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(139, 519);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 24);
			this.label6.TabIndex = 16;
			this.label6.Text = "Tổng tiền:";
			// 
			// _gvOrder
			// 
			this._gvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvOrder.Location = new System.Drawing.Point(3, 70);
			this._gvOrder.Name = "_gvOrder";
			this._gvOrder.Size = new System.Drawing.Size(439, 430);
			this._gvOrder.TabIndex = 8;
			this._gvOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gvOrder_CellContentDoubleClick);
			this._gvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gvOrder_CellContentDoubleClick);
			// 
			// _lbTableNames
			// 
			this._lbTableNames.AutoSize = true;
			this._lbTableNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbTableNames.Location = new System.Drawing.Point(68, 43);
			this._lbTableNames.Name = "_lbTableNames";
			this._lbTableNames.Size = new System.Drawing.Size(0, 24);
			this._lbTableNames.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this._sbSearchItems);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this._gvItems);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(650, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(343, 594);
			this.panel3.TabIndex = 7;
			// 
			// _sbSearchItems
			// 
			this._sbSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._sbSearchItems.AutoSize = true;
			this._sbSearchItems.BackColor = System.Drawing.Color.White;
			this._sbSearchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._sbSearchItems.Location = new System.Drawing.Point(0, 36);
			this._sbSearchItems.Name = "_sbSearchItems";
			this._sbSearchItems.SearchContent = "";
			this._sbSearchItems.Size = new System.Drawing.Size(340, 28);
			this._sbSearchItems.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(110, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 24);
			this.label3.TabIndex = 17;
			this.label3.Text = "CHỌN MÓN";
			// 
			// _gvItems
			// 
			this._gvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvItems.Location = new System.Drawing.Point(0, 70);
			this._gvItems.Name = "_gvItems";
			this._gvItems.Size = new System.Drawing.Size(340, 516);
			this._gvItems.TabIndex = 7;
			this._gvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gvItems_CellDoubleClick);
			// 
			// OrderView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "OrderView";
			this.Size = new System.Drawing.Size(996, 600);
			this.Load += new System.EventHandler(this.OrderView_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._gvOrder)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._gvItems)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckedListBox _listTables;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView _gvOrder;
		private System.Windows.Forms.Label _lbTableNames;
		private System.Windows.Forms.Panel panel3;
		private CustomControls.SearchBox _sbSearchItems;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView _gvItems;
		private System.Windows.Forms.Button _btnDelete;
		private System.Windows.Forms.Button _btnPay;
		private System.Windows.Forms.Button _btnPrint;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label _lbTotalPrice;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.BackgroundWorker _itemBackgroundLoader;
		private System.Windows.Forms.Button _btnMergeBill;
		private System.Windows.Forms.Button _btnEndShift;
	}
}
