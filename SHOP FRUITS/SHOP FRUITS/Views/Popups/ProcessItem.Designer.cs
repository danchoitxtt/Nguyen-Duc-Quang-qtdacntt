namespace CoffeeManagement.Views.Popups
{
	partial class ProcessItem
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._tbName = new System.Windows.Forms.TextBox();
			this._cbUnits = new System.Windows.Forms.ComboBox();
			this._tbOriginalPrice = new System.Windows.Forms.TextBox();
			this._tbSalingPrice = new System.Windows.Forms.TextBox();
			this._btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đồ uống:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Đơn vị:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Giá gốc:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Giá bán:";
			// 
			// _tbName
			// 
			this._tbName.Location = new System.Drawing.Point(105, 28);
			this._tbName.Name = "_tbName";
			this._tbName.Size = new System.Drawing.Size(188, 20);
			this._tbName.TabIndex = 2;
			// 
			// _cbUnits
			// 
			this._cbUnits.FormattingEnabled = true;
			this._cbUnits.Location = new System.Drawing.Point(105, 56);
			this._cbUnits.Name = "_cbUnits";
			this._cbUnits.Size = new System.Drawing.Size(188, 21);
			this._cbUnits.TabIndex = 3;
			// 
			// _tbOriginalPrice
			// 
			this._tbOriginalPrice.Location = new System.Drawing.Point(105, 84);
			this._tbOriginalPrice.Name = "_tbOriginalPrice";
			this._tbOriginalPrice.Size = new System.Drawing.Size(188, 20);
			this._tbOriginalPrice.TabIndex = 4;
			// 
			// _tbSalingPrice
			// 
			this._tbSalingPrice.Location = new System.Drawing.Point(105, 111);
			this._tbSalingPrice.Name = "_tbSalingPrice";
			this._tbSalingPrice.Size = new System.Drawing.Size(188, 20);
			this._tbSalingPrice.TabIndex = 5;
			// 
			// _btnSave
			// 
			this._btnSave.Image = global::CoffeeManagement.Properties.Resources.save;
			this._btnSave.Location = new System.Drawing.Point(203, 158);
			this._btnSave.Name = "_btnSave";
			this._btnSave.Size = new System.Drawing.Size(90, 40);
			this._btnSave.TabIndex = 6;
			this._btnSave.Text = "Lưu";
			this._btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnSave.UseVisualStyleBackColor = true;
			this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
			// 
			// ProcessItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 237);
			this.Controls.Add(this._btnSave);
			this.Controls.Add(this._tbSalingPrice);
			this.Controls.Add(this._tbOriginalPrice);
			this.Controls.Add(this._cbUnits);
			this.Controls.Add(this._tbName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ProcessItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm mặt hàng";
			this.Load += new System.EventHandler(this.ProcessItem_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox _tbName;
		private System.Windows.Forms.ComboBox _cbUnits;
		private System.Windows.Forms.TextBox _tbOriginalPrice;
		private System.Windows.Forms.TextBox _tbSalingPrice;
		private System.Windows.Forms.Button _btnSave;
	}
}