using Academy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class DirectionForm : Form
	{
		Models.Direction direction;
		public DirectionForm()
		{
			InitializeComponent();
			this.Text = "Добавление направления";
		}
		public DirectionForm(int id) : this()
		{
			this.Text = "Редактирование направления";
			DataTable data = DataBase.Connector.Load
				(
					"*", "Directions", $"direction_id={id}"
				);
			direction = new Models.Direction(data.Rows[0].ItemArray);
		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
			if (direction == null)
				direction = new Models.Direction(0, tbDirectionName.Text);
			else
				direction.direction_name = tbDirectionName.Text;

			if (direction.id == 0)
				direction.id = Convert.ToInt32
					(
						DataBase.Connector.Scalar
						(
							$"INSERT Directions({direction.GetNames()}) VALUES({direction.GetValues()});SELECT SCOPE_IDENTITY()"
						)
					);
			else
				DataBase.Connector.Update
					(
						"Directions", direction.GetUpdateExpression(), $"direction_id={direction.id}"
					);
		}
	}
}
