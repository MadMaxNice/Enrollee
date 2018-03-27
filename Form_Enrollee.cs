using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Coursework___enrollment_entrants__
{
	public partial class Form_Enrollee : MetroForm
	{
		public Form_Enrollee()
		{
			InitializeComponent();
			Class_Function.load_base();
			Class_Function.FillComboBox(comboBox_Specialty);
			comboBox_Specialty.SelectedIndex = 0;
		}

		private void button_Enroll_Click(object sender, EventArgs e)
		{

			Class_Function.Enroll(comboBox_Specialty,progressBar1);
		}

		private void Form_Enrollee_Load(object sender, EventArgs e)
		{

		}
	}
}
