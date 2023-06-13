
using System;
using System.Collections.Generic;
using Wisej.Web;
using Wisej.Web.Ext.MobileIntegration;

namespace ConnectDBTest
{
	public partial class Page1 : Page
	{

		List<StudentModel> studentdata = new List<StudentModel>();
		DataAccess db = new DataAccess();
		public Page1()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AlertBox.Show("hello");
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			studentdata = db.GetStudents();
			dataGridView1.DataSource = studentdata;
		}
	}
}
