namespace CoffeeManagement.Views.DetailViews
{
	partial class ItemManagerView
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
			this.label1 = new System.Windows.Forms.Label();
			this._gvItems = new System.Windows.Forms.DataGridView();
			this._btnDelete = new System.Windows.Forms.Button();
			this._btnEdit = new System.Windows.Forms.Button();
			this._btnAdd = new System.Windows.Forms.Button();
			this._btnImport = new System.Windows.Forms.Button();
			this._reloadDataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this._sbSearchBox = new CoffeeManagement.Views.CustomControls.SearchBox();
			((System.ComponentModel.ISupportInitialize)(this._gvItems)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Danh sách mặt hàng";
			// 
			// _gvItems
			// 
			this._gvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._gvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._gvItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this._gvItems.Location = new System.Drawing.Point(28, 63);
			this._gvItems.Name = "_gvItems";
			this._gvItems.Size = new System.Drawing.Size(750, 348);
			this._gvItems.TabIndex = 2;
			this._gvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._gvItems_CellClick);
			// 
			// _btnDelete
			// 
			this._btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnDelete.FlatAppearance.BorderSize = 0;
			this._btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnDelete.Image = global::CoffeeManagement.Properties.Resources.delete;
			this._btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnDelete.Location = new System.Drawing.Point(688, 435);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(90, 40);
			this._btnDelete.TabIndex = 15;
			this._btnDelete.Text = "Xóa";
			this._btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnDelete.UseVisualStyleBackColor = true;
			this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
			// 
			// _btnEdit
			// 
			this._btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnEdit.FlatAppearance.BorderSize = 0;
			this._btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnEdit.Image = global::CoffeeManagement.Properties.Resources.edit;
			this._btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnEdit.Location = new System.Drawing.Point(562, 435);
			this._btnEdit.Name = "_btnEdit";
			this._btnEdit.Size = new System.Drawing.Size(120, 40);
			this._btnEdit.TabIndex = 16;
			this._btnEdit.Text = "Chỉnh sửa";
			this._btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnEdit.UseVisualStyleBackColor = true;
			this._btnEdit.Click += new System.EventHandler(this._btnEdit_Click);
			// 
			// _btnAdd
			// 
			this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnAdd.FlatAppearance.BorderSize = 0;
			this._btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAdd.Image = global::CoffeeManagement.Properties.Resources.add;
			this._btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnAdd.Location = new System.Drawing.Point(423, 435);
			this._btnAdd.Name = "_btnAdd";
			this._btnAdd.Size = new System.Drawing.Size(120, 40);
			this._btnAdd.TabIndex = 17;
			this._btnAdd.Text = "Thêm mới";
			this._btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnAdd.UseVisualStyleBackColor = true;
			this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
			// 
			// _btnImport
			// 
			this._btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._btnImport.FlatAppearance.BorderSize = 0;
			this._btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnImport.Image = global::CoffeeManagement.Properties.Resources.import;
			this._btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this._btnImport.Location = new System.Drawing.Point(297, 435);
			this._btnImport.Name = "_btnImport";
			this._btnImport.Size = new System.Drawing.Size(120, 40);
			this._btnImport.TabIndex = 18;
			this._btnImport.Text = "Nhập từ file";
			this._btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnImport.UseVisualStyleBackColor = true;
			this._btnImport.Click += new System.EventHandler(this._btnImport_Click);
			// 
			// _sbSearchBox
			// 
			this._sbSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._sbSearchBox.AutoSize = true;
			this._sbSearchBox.BackColor = System.Drawing.Color.White;
			this._sbSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._sbSearchBox.Location = new System.Drawing.Point(423, 18);
			this._sbSearchBox.Name = "_sbSearchBox";
			this._sbSearchBox.SearchContent = "";
			this._sbSearchBox.Size = new System.Drawing.Size(355, 26);
			this._sbSearchBox.TabIndex = 1;
			// 
			// ItemManagerView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._btnImport);
			this.Controls.Add(this._btnAdd);
			this.Controls.Add(this._btnEdit);
			this.Controls.Add(this._btnDelete);
			this.Controls.Add(this._gvItems);
			this.Controls.Add(this._sbSearchBox);
			this.Controls.Add(this.label1);
			this.Name = "ItemManagerView";
			this.Size = new System.Drawing.Size(800, 500);
			this.Load += new System.EventHandler(this.ItemManagerView_Load);
			this.Leave += new System.EventHandler(this.ItemManagerView_Leave);
			((System.ComponentModel.ISupportInitialize)(this._gvItems)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private CustomControls.SearchBox _sbSearchBox;
		private System.Windows.Forms.DataGridView _gvItems;
		private System.Windows.Forms.Button _btnDelete;
		private System.Windows.Forms.Button _btnEdit;
		private System.Windows.Forms.Button _btnAdd;
		private System.Windows.Forms.Button _btnImport;
		private System.ComponentModel.BackgroundWorker _reloadDataBackgroundWorker;
	}
}
