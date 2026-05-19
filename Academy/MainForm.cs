using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using DBtools;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;
		public MainForm()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			//dgvStudents.DataSource = connector.Load("SELECT * FROM Students");
			dgvStudents.DataSource = connector.Select
				(
				"stud_id,last_name,first_name,middle_name,birth_date,group_name,direction_name",
				"students,groups,directions",
				"[group]=group_id and direction=direction_id"
				);
			toolStripStatusLabel.Text = $"Количество записей: {dgvStudents.RowCount - 1}";
		}

		private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
