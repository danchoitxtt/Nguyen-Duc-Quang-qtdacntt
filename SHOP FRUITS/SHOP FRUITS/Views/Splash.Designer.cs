namespace CoffeeManagement.Views
{
    partial class Splash
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
			this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.button1 = new System.Windows.Forms.Button();
			this._lbStatus = new System.Windows.Forms.Label();
			this._lbAppName = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.button1.Location = new System.Drawing.Point(496, 246);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = global::CoffeeManagement.Properties.Resources.Cancel;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// _lbStatus
			// 
			this._lbStatus.AutoSize = true;
			this._lbStatus.BackColor = System.Drawing.Color.Transparent;
			this._lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this._lbStatus.Location = new System.Drawing.Point(37, 175);
			this._lbStatus.Name = "_lbStatus";
			this._lbStatus.Size = new System.Drawing.Size(56, 13);
			this._lbStatus.TabIndex = 1;
			this._lbStatus.Text = "Đang tải...";
			// 
			// _lbAppName
			// 
			this._lbAppName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._lbAppName.BackColor = System.Drawing.Color.Transparent;
			this._lbAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._lbAppName.ForeColor = System.Drawing.Color.Maroon;
			this._lbAppName.Location = new System.Drawing.Point(34, 139);
			this._lbAppName.Name = "_lbAppName";
			this._lbAppName.Size = new System.Drawing.Size(556, 36);
			this._lbAppName.TabIndex = 2;
			this._lbAppName.Text = "Coffee Manager";
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CoffeeManagement.Properties.Resources.splash1;
			this.ClientSize = new System.Drawing.Size(590, 333);
			this.Controls.Add(this._lbAppName);
			this.Controls.Add(this._lbStatus);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash";
			this.Load += new System.EventHandler(this.Splash_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label _lbStatus;
        private System.Windows.Forms.Label _lbAppName;
    }
}

