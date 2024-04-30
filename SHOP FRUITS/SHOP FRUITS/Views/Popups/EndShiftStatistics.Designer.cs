namespace CoffeeManagement.Views.Popups
{
    partial class EndShiftStatistics
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
			this._lbTotalWithDiscount = new System.Windows.Forms.Label();
			this._lbPreTotal = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._lbDateTime = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this._gvStats = new System.Windows.Forms.DataGridView();
			this._btnEndShift = new System.Windows.Forms.Button();
			this._btnStatsByBills = new System.Windows.Forms.Button();
			this._btnStatByItems = new System.Windows.Forms.Button();
			this._backgroundStatsByBills = new System.ComponentModel.BackgroundWorker();
			this._backgroundBillLoader = new System.ComponentModel.BackgroundWorker();
			this._backgroundStatsByItems = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this._gvStats)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tổng doanh thu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Thực thu";
			// 
			// _lbTotalWithDiscount
			// 
			this._lbTotalWithDiscount.AutoSize = true;
			this._lbTotalWithDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbTotalWithDiscount.Location = new System.Drawing.Point(153, 51);
			this._lbTotalWithDiscount.Name = "_lbTotalWithDiscount";
			this._lbTotalWithDiscount.Size = new System.Drawing.Size(0, 20);
			this._lbTotalWithDiscount.TabIndex = 2;
			// 
			// _lbPreTotal
			// 
			this._lbPreTotal.AutoSize = true;
			this._lbPreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbPreTotal.Location = new System.Drawing.Point(153, 23);
			this._lbPreTotal.Name = "_lbPreTotal";
			this._lbPreTotal.Size = new System.Drawing.Size(0, 20);
			this._lbPreTotal.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(326, 23);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày";
			// 
			// _lbDateTime
			// 
			this._lbDateTime.AutoSize = true;
			this._lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbDateTime.Location = new System.Drawing.Point(405, 23);
			this._lbDateTime.Name = "_lbDateTime";
			this._lbDateTime.Size = new System.Drawing.Size(0, 20);
			this._lbDateTime.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(326, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Phải nộp";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(405, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 20);
			this.label8.TabIndex = 7;
			// 
			// _gvStats
			// 
			this._gvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvStats.Location = new System.Drawing.Point(30, 144);
			this._gvStats.Name = "_gvStats";
			this._gvStats.Size = new System.Drawing.Size(535, 260);
			this._gvStats.TabIndex = 8;
			// 
			// _btnEndShift
			// 
			this._btnEndShift.FlatAppearance.BorderSize = 0;
			this._btnEndShift.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnEndShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnEndShift.Image = global::CoffeeManagement.Properties.Resources.end_shift;
			this._btnEndShift.Location = new System.Drawing.Point(475, 410);
			this._btnEndShift.Name = "_btnEndShift";
			this._btnEndShift.Size = new System.Drawing.Size(90, 40);
			this._btnEndShift.TabIndex = 10;
			this._btnEndShift.Text = "Kết ca";
			this._btnEndShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnEndShift.UseVisualStyleBackColor = true;
			this._btnEndShift.Click += new System.EventHandler(this._btnEndShift_Click);
			// 
			// _btnStatsByBills
			// 
			this._btnStatsByBills.BackColor = System.Drawing.Color.Silver;
			this._btnStatsByBills.FlatAppearance.BorderSize = 0;
			this._btnStatsByBills.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnStatsByBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnStatsByBills.Image = global::CoffeeManagement.Properties.Resources.sale;
			this._btnStatsByBills.Location = new System.Drawing.Point(196, 94);
			this._btnStatsByBills.Name = "_btnStatsByBills";
			this._btnStatsByBills.Size = new System.Drawing.Size(160, 40);
			this._btnStatsByBills.TabIndex = 9;
			this._btnStatsByBills.Text = "Theo hóa đơn";
			this._btnStatsByBills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnStatsByBills.UseVisualStyleBackColor = false;
			this._btnStatsByBills.Click += new System.EventHandler(this._btnStatsByBills_Click);
			// 
			// _btnStatByItems
			// 
			this._btnStatByItems.BackColor = System.Drawing.Color.Silver;
			this._btnStatByItems.FlatAppearance.BorderSize = 0;
			this._btnStatByItems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this._btnStatByItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnStatByItems.Image = global::CoffeeManagement.Properties.Resources.material_statistics;
			this._btnStatByItems.Location = new System.Drawing.Point(30, 94);
			this._btnStatByItems.Name = "_btnStatByItems";
			this._btnStatByItems.Size = new System.Drawing.Size(160, 40);
			this._btnStatByItems.TabIndex = 9;
			this._btnStatByItems.Text = "Theo mặt hàng";
			this._btnStatByItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnStatByItems.UseVisualStyleBackColor = false;
			this._btnStatByItems.Click += new System.EventHandler(this._btnStats_Click);
			// 
			// _backgroundBillLoader
			// 
			this._backgroundBillLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadAllBillBackground_DoWork);
			this._backgroundBillLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadAllBillBackground_RunWorkerCompleted);
			// 
			// _backgroundStatsByItems
			// 
			this._backgroundStatsByItems.DoWork += new System.ComponentModel.DoWorkEventHandler(this._statsByItemBackground_DoWork);
			this._backgroundStatsByItems.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._statsByItemBackground_RunWorkerCompleted);
			// 
			// EndShiftStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 475);
			this.Controls.Add(this._btnEndShift);
			this.Controls.Add(this._btnStatsByBills);
			this.Controls.Add(this._btnStatByItems);
			this.Controls.Add(this._gvStats);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this._lbDateTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this._lbPreTotal);
			this.Controls.Add(this._lbTotalWithDiscount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "EndShiftStatistics";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thống kê & kết ca";
			this.Load += new System.EventHandler(this.EndShiftStatistics_Load);
			((System.ComponentModel.ISupportInitialize)(this._gvStats)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lbTotalWithDiscount;
        private System.Windows.Forms.Label _lbPreTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _lbDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView _gvStats;
        private System.Windows.Forms.Button _btnStatByItems;
        private System.Windows.Forms.Button _btnStatsByBills;
        private System.Windows.Forms.Button _btnEndShift;
		private System.ComponentModel.BackgroundWorker _backgroundStatsByBills;
		private System.ComponentModel.BackgroundWorker _backgroundBillLoader;
		private System.ComponentModel.BackgroundWorker _backgroundStatsByItems;
    }
}