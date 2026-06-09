using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DBtools;

namespace AcademyWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Connector connector;
		DataGrid[] tables;
		public MainWindow()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			tables = new DataGrid[] { dgStudents, dgGroups, dgDirections, dgDisiplines, dgTeachers };
		}

		private void tabControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			int i = (sender as TabControl).SelectedIndex;
			tables[i].ItemsSource = connector.Load($"SELECT * FROM {(tabControl.Items[i] as TabItem).Header}").DefaultView;
		}
	}
}
