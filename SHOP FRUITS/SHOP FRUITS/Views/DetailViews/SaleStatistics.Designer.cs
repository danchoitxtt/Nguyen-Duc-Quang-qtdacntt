namespace CoffeeManagement.Views.DetailViews
{
	partial class SaleStatistics
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
			this._dpickerFrom = new System.Windows.Forms.DateTimePicker();
			this._dpickerTo = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this._btnShow = new System.Windows.Forms.Button();
			this._gvStats = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._lbIncome = new System.Windows.Forms.Label();
			this._lbProfits = new System.Windows.Forms.Label();
			this._backgroundShowStats = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this._gvStats)).BeginInit();
			this.SuspendLayout();
			// 
			// _dpickerFrom
			// 
			this._dpickerFrom.Location = new System.Drawing.Point(89, 28);
			this._dpickerFrom.Name = "_dpickerFrom";
			this._dpickerFrom.Size = new System.Drawing.Size(200, 20);
			this._dpickerFrom.TabIndex = 0;
			this._dpickerFrom.ValueChanged += new System.EventHandler(this._dpickerFrom_ValueChanged);
			// 
			// _dpickerTo
			// 
			this._dpickerTo.Location = new System.Drawing.Point(396, 28);
			this._dpickerTo.Name = "_dpickerTo";
			this._dpickerTo.Size = new System.Drawing.Size(200, 20);
			this._dpickerTo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Từ ngày";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(342, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tới ngày";
			// 
			// _btnShow
			// 
			this._btnShow.FlatAppearance.BorderSize = 0;
			this._btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._btnShow.Image = global::CoffeeManagement.Properties.Resources.view_24;
			this._btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnShow.Location = new System.Drawing.Point(622, 23);
			this._btnShow.Name = "_btnShow";
			this._btnShow.Size = new System.Drawing.Size(110, 31);
			this._btnShow.TabIndex = 21;
			this._btnShow.Text = "Thống kê";
			this._btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnShow.UseVisualStyleBackColor = true;
			this._btnShow.Click += new System.EventHandler(this._btnShow_Click);
			// 
			// _gvStats
			// 
			this._gvStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvStats.Location = new System.Drawing.Point(23, 94);
			this._gvStats.Name = "_gvStats";
			this._gvStats.Size = new System.Drawing.Size(758, 445);
			this._gvStats.TabIndex = 22;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(37, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(135, 20);
			this.label3.TabIndex = 23;
			this.label3.Text = "Tổng doanh thu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(342, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 20);
			this.label4.TabIndex = 23;
			this.label4.Text = "Lợi nhuận";
			// 
			// _lbIncome
			// 
			this._lbIncome.AutoSize = true;
			this._lbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbIncome.Location = new System.Drawing.Point(178, 67);
			this._lbIncome.Name = "_lbIncome";
			this._lbIncome.Size = new System.Drawing.Size(15, 20);
			this._lbIncome.TabIndex = 23;
			this._lbIncome.Text = "-";
			// 
			// _lbProfits
			// 
			this._lbProfits.AutoSize = true;
			this._lbProfits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbProfits.Location = new System.Drawing.Point(436, 67);
			this._lbProfits.Name = "_lbProfits";
			this._lbProfits.Size = new System.Drawing.Size(15, 20);
			this._lbProfits.TabIndex = 23;
			this._lbProfits.Text = "-";
			// 
			// _backgroundShowStats
			// 
			this._backgroundShowStats.DoWork += new System.ComponentModel.DoWorkEventHandler(this._backgroundShowStats_DoWork);
			this._backgroundShowStats.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this._backgroundShowStats_RunWorkerCompleted);
			// 
			// SaleStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label4);
			this.Controls.Add(this._lbProfits);
			this.Controls.Add(this._lbIncome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._gvStats);
			this.Controls.Add(this._btnShow);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._dpickerTo);
			this.Controls.Add(this._dpickerFrom);
			this.Name = "SaleStatistics";
			this.Size = new System.Drawing.Size(800, 600);
			((System.ComponentModel.ISupportInitialize)(this._gvStats)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker _dpickerFrom;
		private System.Windows.Forms.DateTimePicker _dpickerTo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button _btnShow;
		private System.Windows.Forms.DataGridView _gvStats;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label _lbIncome;
		private System.Windows.Forms.Label _lbProfits;
		private System.ComponentModel.BackgroundWorker _backgroundShowStats;
	}
}
