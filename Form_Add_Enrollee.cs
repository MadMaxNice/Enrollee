using System;
using System.Collections.Generic;

using MetroFramework.Forms;

namespace Coursework___enrollment_entrants__
{
	public partial class Form_Add_Enrollee : MetroForm
	{ 	
		public Form_Add_Enrollee()
		{
			InitializeComponent();
			Class_Function.load_base();
			Class_Function.FillComboBox(comboBox_Class, comboBox_Specialty);
			
		}

		private void print_combobox(List<string> list)
		{
			for (int i = 0; i < list.Count; i++) comboBox_Specialty.Items.Add(list[i]);
		}
		private void button1_Click(object sender, EventArgs e)
		{
			bool status=Class_Function.add_Enrollee(textBox_Name, textBox_SurName, textBox_Patronymic, comboBox_Specialty, textBox_Average_Score, comboBox_Class, checkBox__Benefits);
			if (status == true) Close();
		}


		private void Form_Add_Enrollee_Load(object sender, EventArgs e)
		{
		
		}
	}


}
