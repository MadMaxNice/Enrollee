using System;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Coursework___enrollment_entrants__
{
	public partial class Form_Lobby : MetroForm
	{
		public Form_Lobby()
		{
			InitializeComponent();

			dataGridView1.CellContentDoubleClick += DataGridView1_CellContentDoubleClick;

			Class_Function.load_base();
			Class_Function.print_Grid(dataGridView1);
			Class_Function.FillComboBox(comboBox_Class, comboBox_Specialty);
			//Фильтр
			#region
			comboBox_Specialty.SelectedIndex = 0;
			comboBox_Class.SelectedIndex = 0;
			comboBox__Benefits.SelectedIndex = 2;
			comboBox_Specialty.SelectedIndexChanged += ComboBox_Specialty_SelectedIndexChanged;
			comboBox_Class.SelectedIndexChanged += ComboBox_Class_SelectedIndexChanged;
			comboBox__Benefits.SelectedIndexChanged += ComboBox__Benefits_SelectedIndexChanged;
			textBox_Year.TextChanged += TextBox_Year_TextChanged;
		}
		private void TextBox_Year_TextChanged(object sender, EventArgs e)
		{
			search_lobby();
		}
		private void ComboBox__Benefits_SelectedIndexChanged(object sender, EventArgs e)
		{
			search_lobby();
		}
		private void ComboBox_Class_SelectedIndexChanged(object sender, EventArgs e)
		{
			search_lobby();
		}
		private void ComboBox_Specialty_SelectedIndexChanged(object sender, EventArgs e)
		{
			search_lobby();
		}
		#endregion
		private void DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			Class_Function.temp_id_change = Convert.ToInt32(dataGridView1[8, dataGridView1.CurrentRow.Index].Value);
			//Class_Function.temp_row_change = dataGridView1.CurrentRow.Index;
			Class_Function.temp_row_change = dataGridView1.CurrentRow.Index;
			Form_Change_Enrollee obj_Form_Change = new Form_Change_Enrollee();
			obj_Form_Change.ShowDialog();
			search_lobby();
		}
		private void Entrance_Click(object sender, EventArgs e)
		{
			Form_Add_Enrollee obj_Add = new Form_Add_Enrollee();
			obj_Add.ShowDialog();
			search_lobby();
		}
		private void Lobby_Load(object sender, EventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Class_Function.update_grid(dataGridView1);
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void button_change_Click(object sender, EventArgs e)
		{
			try
			{
				Class_Function.temp_id_change = Convert.ToInt32(dataGridView1[8, dataGridView1.CurrentRow.Index].Value);
				Class_Function.temp_row_change = dataGridView1.CurrentRow.Index;
				Form_Change_Enrollee obj_Form_Change = new Form_Change_Enrollee();
				obj_Form_Change.ShowDialog();
				search_lobby();
			}
			catch
			{
				MessageBox.Show("Выберите поле для изменения.");

			}
			search_lobby();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			search_lobby();
		}

		private void button_drop_Click(object sender, EventArgs e)
		{
			textBox_Name.Text = "";
			textBox_SurName.Text = "";
			textBox_Patronymic.Text = "";
			textBox_Year.Text = "";
			comboBox_Class.SelectedIndex = 0;
			comboBox_Specialty.SelectedIndex = 0;
			comboBox__Benefits.SelectedIndex = 2;
			Class_Function.update_grid(dataGridView1);
		}
		private void button_search_switch_Click(object sender, EventArgs e)
		{
			if (SearchBox.Visible == true) { SearchBox.Visible = false; return; }
			if (SearchBox.Visible == false) { SearchBox.Visible = true; return; }
		}
		private void search_lobby()
		{
			Class_Function.update_grid(dataGridView1);
			Class_Function.filter(dataGridView1, textBox_Name, textBox_SurName, textBox_Patronymic, textBox_Year, comboBox_Specialty, comboBox_Class, comboBox__Benefits);

		}

		private void button_Enroll_Click(object sender, EventArgs e)
		{
			Form_Enrollee obj_Enroll = new Form_Enrollee();
			obj_Enroll.ShowDialog();
		}

		private void button_report_Click(object sender, EventArgs e)
		{
	
		Class_Report.Report();
	
		}

		private void button_next_Click(object sender, EventArgs e)
		{
			search_lobby();
		}

		private void button_exit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
