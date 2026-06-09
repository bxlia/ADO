namespace Academy
{
	partial class DisciplineForm
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
			this.labelDisciplineName = new System.Windows.Forms.Label();
			this.tbDisciplineName = new System.Windows.Forms.TextBox();
			this.labelNumberOfLessons = new System.Windows.Forms.Label();
			this.tbNumberOfLessons = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelDisciplineName
			// 
			this.labelDisciplineName.AutoSize = true;
			this.labelDisciplineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelDisciplineName.Location = new System.Drawing.Point(314, 9);
			this.labelDisciplineName.Name = "labelDisciplineName";
			this.labelDisciplineName.Size = new System.Drawing.Size(414, 42);
			this.labelDisciplineName.TabIndex = 17;
			this.labelDisciplineName.Text = "Название дисциплины";
			// 
			// tbDisciplineName
			// 
			this.tbDisciplineName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbDisciplineName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbDisciplineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbDisciplineName.Location = new System.Drawing.Point(12, 65);
			this.tbDisciplineName.MaxLength = 50;
			this.tbDisciplineName.Name = "tbDisciplineName";
			this.tbDisciplineName.Size = new System.Drawing.Size(1016, 49);
			this.tbDisciplineName.TabIndex = 18;
			// 
			// labelNumberOfLessons
			// 
			this.labelNumberOfLessons.AutoSize = true;
			this.labelNumberOfLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNumberOfLessons.Location = new System.Drawing.Point(389, 130);
			this.labelNumberOfLessons.Name = "labelNumberOfLessons";
			this.labelNumberOfLessons.Size = new System.Drawing.Size(245, 42);
			this.labelNumberOfLessons.TabIndex = 19;
			this.labelNumberOfLessons.Text = "Номер урока";
			// 
			// tbNumberOfLessons
			// 
			this.tbNumberOfLessons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbNumberOfLessons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbNumberOfLessons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbNumberOfLessons.Location = new System.Drawing.Point(12, 194);
			this.tbNumberOfLessons.MaxLength = 50;
			this.tbNumberOfLessons.Name = "tbNumberOfLessons";
			this.tbNumberOfLessons.Size = new System.Drawing.Size(1016, 49);
			this.tbNumberOfLessons.TabIndex = 20;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOK.Location = new System.Drawing.Point(685, 313);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(170, 49);
			this.btnOK.TabIndex = 21;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(861, 313);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(170, 49);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// DisciplineForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 374);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.tbNumberOfLessons);
			this.Controls.Add(this.labelNumberOfLessons);
			this.Controls.Add(this.tbDisciplineName);
			this.Controls.Add(this.labelDisciplineName);
			this.Name = "DisciplineForm";
			this.Text = "DisciplineForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDisciplineName;
		private System.Windows.Forms.TextBox tbDisciplineName;
		private System.Windows.Forms.Label labelNumberOfLessons;
		private System.Windows.Forms.TextBox tbNumberOfLessons;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}