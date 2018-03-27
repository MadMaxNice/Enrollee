using System;
using MetroFramework.Forms;
namespace Coursework___enrollment_entrants__
{
	public partial class Form_Change_Enrollee : MetroForm
	{

		public Form_Change_Enrollee()
		{
			InitializeComponent();
	
			Class_Function.load_base();
			Class_Function.FillComboBox(comboBox_Class, comboBox_Specialty);
			Class_Function.FillForm_change(textBox_Name, textBox_SurName, textBox_Patronymic, comboBox_Specialty, textBox_Average_Score, comboBox_Class, checkBox__Benefits);
		}

		private void button_Change_Enrollee_Click(object sender, EventArgs e)
		{
			bool status = Class_Function.change_Enrollee(textBox_Name, textBox_SurName, textBox_Patronymic, comboBox_Specialty, textBox_Average_Score, comboBox_Class, checkBox__Benefits);
			if (status == true) Close();
		}

		private void button_delete_Enrollee_Click(object sender, EventArgs e)
		{
			bool temp = Class_Function.dialog_warning_destroy("Вы уверены, что хотите удалить заявку абитуриента", textBox_Name, textBox_SurName, textBox_Patronymic);
			if (temp == true) Close();
	
		}
	}
}
