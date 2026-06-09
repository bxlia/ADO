using Academy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class DisciplineForm : Form
	{
		Models.Discipline discipline;
		public DisciplineForm()
		{
			InitializeComponent();
			this.Text = "Добавление дисциплины";
		}
		public DisciplineForm(int id) : this()
		{
			this.Text = "Редактирование дисциплины";
			DataTable data = DataBase.Connector.Load
				(
					"*", "Disciplines", $"discipline_id={id}"
				);
			discipline = new Models.Discipline(data.Rows[0].ItemArray);
		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
			if (discipline == null)
				discipline = new Models.Discipline(0, tbDisciplineName.Text, tbNumberOfLessons.Text);
			else
				discipline.discipline_name = tbDisciplineName.Text;

			if (discipline.id == 0)
				discipline.id = Convert.ToInt32
					(
						DataBase.Connector.Scalar
						(
							$"INSERT Disciplines({discipline.GetNames()}) VALUES({discipline.GetValues()});SELECT SCOPE_IDENTITY()"
						)
					);
			else
				DataBase.Connector.Update
					(
						"Dirsciplines", discipline.GetUpdateExpression(), $"discipline_id={discipline.id}"
					);
		}
	}
}
