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
	public partial class TeacherForm : HumanForm
	{
		public TeacherForm()
		{
			InitializeComponent();
		}

		protected override void btnOK_Click(object sender, EventArgs e)
		{
			base.btnOK_Click(sender, e);
			//student = new Models.Student(human, (int)cbGroup.SelectedValue);
			//DataBase.Connector.Insert($"INSERT Students({student.GetNames()}) VALUES({student.GetValues()})");
		}

		private void TeacherForm_Load(object sender, EventArgs e)
		{

		}
	}
}
