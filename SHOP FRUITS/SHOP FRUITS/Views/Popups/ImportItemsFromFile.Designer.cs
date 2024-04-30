namespace CoffeeManagement.Views.Popups
{
	partial class ImportItemsFromFile
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
			this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._tbFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this._btnBrowse = new System.Windows.Forms.Button();
			this._gvItems = new System.Windows.Forms.DataGridView();
			this._btnImport = new System.Windows.Forms.Button();
			this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.label2 = new System.Windows.Forms.Label();
			this._lbTotal = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._gvItems)).BeginInit();
			this.SuspendLayout();
			// 
			// _openFileDialog
			// 
			this._openFileDialog.DefaultExt = "*.xls, *.xlsx";
			this._openFileDialog.Multiselect = true;
			// 
			// _tbFilePath
			// 
			this._tbFilePath.Location = new System.Drawing.Point(54, 16);
			this._tbFilePath.Name = "_tbFilePath";
			this._tbFilePath.Size = new System.Drawing.Size(360, 20);
			this._tbFilePath.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tệp";
			// 
			// _btnBrowse
			// 
			this._btnBrowse.FlatAppearance.BorderSize = 0;
			this._btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnBrowse.Image = global::CoffeeManagement.Properties.Resources.folder;
			this._btnBrowse.Location = new System.Drawing.Point(420, 9);
			this._btnBrowse.Name = "_btnBrowse";
			this._btnBrowse.Size = new System.Drawing.Size(99, 32);
			this._btnBrowse.TabIndex = 2;
			this._btnBrowse.Text = "Chọn tệp";
			this._btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnBrowse.UseVisualStyleBackColor = true;
			this._btnBrowse.Click += new System.EventHandler(this._btnBrowse_Click);
			// 
			// _gvItems
			// 
			this._gvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvItems.Location = new System.Drawing.Point(25, 52);
			this._gvItems.Name = "_gvItems";
			this._gvItems.Size = new System.Drawing.Size(567, 315);
			this._gvItems.TabIndex = 3;
			// 
			// _btnImport
			// 
			this._btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnImport.FlatAppearance.BorderSize = 0;
			this._btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnImport.Image = global::CoffeeManagement.Properties.Resources.import_records;
			this._btnImport.Location = new System.Drawing.Point(493, 378);
			this._btnImport.Name = "_btnImport";
			this._btnImport.Size = new System.Drawing.Size(99, 40);
			this._btnImport.TabIndex = 4;
			this._btnImport.Text = "Nhập";
			this._btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnImport.UseVisualStyleBackColor = true;
			this._btnImport.Click += new System.EventHandler(this._btnImport_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 378);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tổng:";
			// 
			// _lbTotal
			// 
			this._lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._lbTotal.AutoSize = true;
			this._lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbTotal.Location = new System.Drawing.Point(71, 378);
			this._lbTotal.Name = "_lbTotal";
			this._lbTotal.Size = new System.Drawing.Size(83, 16);
			this._lbTotal.TabIndex = 5;
			this._lbTotal.Text = "0 mặt hàng";
			// 
			// ImportItemsFromFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 430);
			this.Controls.Add(this._lbTotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._btnImport);
			this.Controls.Add(this._gvItems);
			this.Controls.Add(this._btnBrowse);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._tbFilePath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ImportItemsFromFile";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nhập mặt hàng từ file";
			((System.ComponentModel.ISupportInitialize)(this._gvItems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog _openFileDialog;
		private System.Windows.Forms.TextBox _tbFilePath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _btnBrowse;
		private System.Windows.Forms.DataGridView _gvItems;
		private System.Windows.Forms.Button _btnImport;
		private System.ComponentModel.BackgroundWorker _backgroundWorker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label _lbTotal;
	}
}