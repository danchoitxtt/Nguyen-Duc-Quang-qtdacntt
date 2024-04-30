namespace CoffeeManagement.Views.CustomControls
{
	partial class SearchBox
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
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.SearchButton = new System.Windows.Forms.PictureBox();
			this.ClearButton = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ClearButton)).BeginInit();
			this.SuspendLayout();
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchTextBox.BackColor = System.Drawing.Color.White;
			this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchTextBox.Location = new System.Drawing.Point(30, 6);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(296, 15);
			this.SearchTextBox.TabIndex = 3;
			this.SearchTextBox.WordWrap = false;
			this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
			// 
			// SearchButton
			// 
			this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SearchButton.Image = global::CoffeeManagement.Properties.Resources.search_16;
			this.SearchButton.Location = new System.Drawing.Point(4, 3);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(20, 20);
			this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.SearchButton.TabIndex = 7;
			this.SearchButton.TabStop = false;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			this.SearchButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchButton_MouseDown);
			this.SearchButton.MouseLeave += new System.EventHandler(this.SearchButton_MouseLeave);
			this.SearchButton.MouseHover += new System.EventHandler(this.SearchButton_MouseHover);
			this.SearchButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SearchButton_MouseUp);
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.Image = global::CoffeeManagement.Properties.Resources.clear_16;
			this.ClearButton.Location = new System.Drawing.Point(332, 3);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(20, 20);
			this.ClearButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ClearButton.TabIndex = 8;
			this.ClearButton.TabStop = false;
			this.ClearButton.Visible = false;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			this.ClearButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClearButton_MouseDown);
			this.ClearButton.MouseLeave += new System.EventHandler(this.ClearButton_MouseLeave);
			this.ClearButton.MouseHover += new System.EventHandler(this.ClearButton_MouseHover);
			this.ClearButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClearButton_MouseUp);
			// 
			// SearchBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.SearchTextBox);
			this.Name = "SearchBox";
			this.Size = new System.Drawing.Size(355, 26);
			((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ClearButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.PictureBox SearchButton;
		private System.Windows.Forms.PictureBox ClearButton;

	}
}
