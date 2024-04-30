namespace CoffeeManagement.Views.CustomControls
{
    partial class WorkTrackingTopControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.noteTB = new System.Windows.Forms.TextBox();
            this.thirdShiftCB = new System.Windows.Forms.CheckBox();
            this.secondShiftCB = new System.Windows.Forms.CheckBox();
            this.firstShiftCB = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.positionLB = new System.Windows.Forms.Label();
            this.fullNameLB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.noteTB);
            this.panel1.Controls.Add(this.thirdShiftCB);
            this.panel1.Controls.Add(this.secondShiftCB);
            this.panel1.Controls.Add(this.firstShiftCB);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.positionLB);
            this.panel1.Controls.Add(this.fullNameLB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 150);
            this.panel1.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(453, 111);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(62, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // noteTB
            // 
            this.noteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTB.Location = new System.Drawing.Point(103, 112);
            this.noteTB.Name = "noteTB";
            this.noteTB.Size = new System.Drawing.Size(344, 22);
            this.noteTB.TabIndex = 5;
            this.noteTB.Text = "Ghi chú";
            // 
            // thirdShiftCB
            // 
            this.thirdShiftCB.AutoSize = true;
            this.thirdShiftCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdShiftCB.Location = new System.Drawing.Point(240, 80);
            this.thirdShiftCB.Name = "thirdShiftCB";
            this.thirdShiftCB.Size = new System.Drawing.Size(54, 20);
            this.thirdShiftCB.TabIndex = 4;
            this.thirdShiftCB.Text = "Ca 3";
            this.thirdShiftCB.UseVisualStyleBackColor = true;
            // 
            // secondShiftCB
            // 
            this.secondShiftCB.AutoSize = true;
            this.secondShiftCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondShiftCB.Location = new System.Drawing.Point(170, 80);
            this.secondShiftCB.Name = "secondShiftCB";
            this.secondShiftCB.Size = new System.Drawing.Size(54, 20);
            this.secondShiftCB.TabIndex = 4;
            this.secondShiftCB.Text = "Ca 2";
            this.secondShiftCB.UseVisualStyleBackColor = true;
            // 
            // firstShiftCB
            // 
            this.firstShiftCB.AutoSize = true;
            this.firstShiftCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstShiftCB.Location = new System.Drawing.Point(103, 80);
            this.firstShiftCB.Name = "firstShiftCB";
            this.firstShiftCB.Size = new System.Drawing.Size(54, 20);
            this.firstShiftCB.TabIndex = 4;
            this.firstShiftCB.Text = "Ca 1";
            this.firstShiftCB.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(103, 48);
            this.dateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(92, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // positionLB
            // 
            this.positionLB.AutoSize = true;
            this.positionLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLB.Location = new System.Drawing.Point(360, 16);
            this.positionLB.Name = "positionLB";
            this.positionLB.Size = new System.Drawing.Size(63, 16);
            this.positionLB.TabIndex = 1;
            this.positionLB.Text = "Chức vụ";
            // 
            // fullNameLB
            // 
            this.fullNameLB.AutoSize = true;
            this.fullNameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLB.Location = new System.Drawing.Point(100, 16);
            this.fullNameLB.Name = "fullNameLB";
            this.fullNameLB.Size = new System.Drawing.Size(78, 16);
            this.fullNameLB.TabIndex = 1;
            this.fullNameLB.Text = "Tên Ai Đó";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ghi chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đi Làm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hôm nay: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên:";
            // 
            // WorkTrackingDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WorkTrackingDetailControl";
            this.Size = new System.Drawing.Size(530, 150);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fullNameLB;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label positionLB;
        private System.Windows.Forms.CheckBox thirdShiftCB;
        private System.Windows.Forms.CheckBox secondShiftCB;
        private System.Windows.Forms.CheckBox firstShiftCB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox noteTB;
    }
}
