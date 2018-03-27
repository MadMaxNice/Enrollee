namespace Coursework___enrollment_entrants__
{
	partial class Form_Enrollee
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
			System.Windows.Forms.Label label_Specialty;
			this.button_Enroll = new System.Windows.Forms.Button();
			this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
			this.comboBox_Specialty = new MetroFramework.Controls.MetroComboBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			label_Specialty = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// label_Specialty
			// 
			label_Specialty.AutoSize = true;
			label_Specialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			label_Specialty.Location = new System.Drawing.Point(23, 60);
			label_Specialty.Name = "label_Specialty";
			label_Specialty.Size = new System.Drawing.Size(156, 24);
			label_Specialty.TabIndex = 11;
			label_Specialty.Text = "Специальность:";
			// 
			// button_Enroll
			// 
			this.button_Enroll.BackColor = System.Drawing.Color.White;
			this.button_Enroll.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_Enroll.FlatAppearance.BorderSize = 2;
			this.button_Enroll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_Enroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_Enroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_Enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Enroll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Enroll.Location = new System.Drawing.Point(275, 168);
			this.button_Enroll.Name = "button_Enroll";
			this.button_Enroll.Size = new System.Drawing.Size(105, 30);
			this.button_Enroll.TabIndex = 25;
			this.button_Enroll.Text = "Зачислить";
			this.button_Enroll.UseVisualStyleBackColor = false;
			this.button_Enroll.Click += new System.EventHandler(this.button_Enroll_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(27, 107);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(603, 23);
			this.progressBar1.TabIndex = 28;
			// 
			// comboBox_Specialty
			// 
			this.comboBox_Specialty.FormattingEnabled = true;
			this.comboBox_Specialty.ItemHeight = 23;
			this.comboBox_Specialty.Location = new System.Drawing.Point(185, 60);
			this.comboBox_Specialty.Name = "comboBox_Specialty";
			this.comboBox_Specialty.Size = new System.Drawing.Size(445, 29);
			this.comboBox_Specialty.TabIndex = 29;
			this.comboBox_Specialty.UseSelectable = true;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(610, 193);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(51, 29);
			this.pictureBox4.TabIndex = 50;
			this.pictureBox4.TabStop = false;
			// 
			// Form_Enrollee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 221);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.comboBox_Specialty);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button_Enroll);
			this.Controls.Add(label_Specialty);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_Enrollee";
			this.Text = "Зачисление абитуриентов";
			this.Load += new System.EventHandler(this.Form_Enrollee_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_Enroll;
		private MetroFramework.Controls.MetroProgressBar progressBar1;
		private MetroFramework.Controls.MetroComboBox comboBox_Specialty;
		private System.Windows.Forms.PictureBox pictureBox4;
	}
}