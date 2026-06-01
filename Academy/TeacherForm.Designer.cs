namespace Academy
{
	partial class TeacherForm
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
			this.labelWorkSince = new System.Windows.Forms.Label();
			this.labelRate = new System.Windows.Forms.Label();
			this.tbWorkSince = new System.Windows.Forms.TextBox();
			this.tbRate = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelWorkSince
			// 
			this.labelWorkSince.AutoSize = true;
			this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkSince.Location = new System.Drawing.Point(8, 520);
			this.labelWorkSince.Name = "labelWorkSince";
			this.labelWorkSince.Size = new System.Drawing.Size(270, 42);
			this.labelWorkSince.TabIndex = 16;
			this.labelWorkSince.Text = "Опыт работы: ";
			// 
			// labelRate
			// 
			this.labelRate.AutoSize = true;
			this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRate.Location = new System.Drawing.Point(8, 594);
			this.labelRate.Name = "labelRate";
			this.labelRate.Size = new System.Drawing.Size(204, 42);
			this.labelRate.TabIndex = 18;
			this.labelRate.Text = "Зарплата: ";
			// 
			// tbWorkSince
			// 
			this.tbWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbWorkSince.Location = new System.Drawing.Point(264, 517);
			this.tbWorkSince.Name = "tbWorkSince";
			this.tbWorkSince.Size = new System.Drawing.Size(480, 49);
			this.tbWorkSince.TabIndex = 17;
			// 
			// tbRate
			// 
			this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbRate.Location = new System.Drawing.Point(194, 594);
			this.tbRate.Name = "tbRate";
			this.tbRate.Size = new System.Drawing.Size(551, 49);
			this.tbRate.TabIndex = 19;
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1147, 670);
			this.Controls.Add(this.tbRate);
			this.Controls.Add(this.labelRate);
			this.Controls.Add(this.tbWorkSince);
			this.Controls.Add(this.labelWorkSince);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Load += new System.EventHandler(this.TeacherForm_Load);
			this.Controls.SetChildIndex(this.labelWorkSince, 0);
			this.Controls.SetChildIndex(this.tbWorkSince, 0);
			this.Controls.SetChildIndex(this.labelRate, 0);
			this.Controls.SetChildIndex(this.tbRate, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelWorkSince;
		private System.Windows.Forms.Label labelRate;
		private System.Windows.Forms.TextBox tbWorkSince;
		private System.Windows.Forms.TextBox tbRate;
	}
}