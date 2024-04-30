namespace CoffeeManagement.Views.Popups
{
	partial class JoinTable
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
			this._tbOldTable = new System.Windows.Forms.TextBox();
			this._cbNewTable = new System.Windows.Forms.ComboBox();
			this._btnOk = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bàn cũ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Bàn gộp thêm";
			// 
			// _tbOldTable
			// 
			this._tbOldTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._tbOldTable.Location = new System.Drawing.Point(110, 22);
			this._tbOldTable.Name = "_tbOldTable";
			this._tbOldTable.ReadOnly = true;
			this._tbOldTable.Size = new System.Drawing.Size(155, 22);
			this._tbOldTable.TabIndex = 1;
			this._tbOldTable.Text = "Bàn 01";
			this._tbOldTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _cbNewTable
			// 
			this._cbNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._cbNewTable.FormattingEnabled = true;
			this._cbNewTable.Location = new System.Drawing.Point(110, 62);
			this._cbNewTable.Name = "_cbNewTable";
			this._cbNewTable.Size = new System.Drawing.Size(154, 24);
			this._cbNewTable.TabIndex = 2;
			// 
			// _btnOk
			// 
			this._btnOk.FlatAppearance.BorderSize = 0;
			this._btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnOk.Image = global::CoffeeManagement.Properties.Resources.valid;
			this._btnOk.Location = new System.Drawing.Point(47, 107);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(92, 40);
			this._btnOk.TabIndex = 3;
			this._btnOk.Text = "Xác nhận";
			this._btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnOk.UseVisualStyleBackColor = true;
			this._btnOk.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// _btnCancel
			// 
			this._btnCancel.FlatAppearance.BorderSize = 0;
			this._btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnCancel.Image = global::CoffeeManagement.Properties.Resources.invalid;
			this._btnCancel.Location = new System.Drawing.Point(160, 107);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(75, 40);
			this._btnCancel.TabIndex = 4;
			this._btnCancel.Text = "Hủy";
			this._btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// JoinTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 168);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._btnOk);
			this.Controls.Add(this._cbNewTable);
			this.Controls.Add(this._tbOldTable);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "JoinTable";
			this.Text = "Gộp bàn";
			this.Load += new System.EventHandler(this.JoinTable_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox _tbOldTable;
		private System.Windows.Forms.ComboBox _cbNewTable;
		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.Button _btnCancel;
	}
}