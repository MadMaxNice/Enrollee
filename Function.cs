using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

using MetroFramework.Controls;


namespace Coursework___enrollment_entrants__
{
	class Class_Function
	{
		#region
		static public int temp_id_change { get; set; } = 0;
		static public int temp_row_change = 0;
		static protected List<object> array_Specialty_Name = new List<object>();
		static protected List<object> array_Specialty_ID = new List<object>();
		static protected List<object> array_Specialty_Class = new List<object>();
		static protected List<object> array_Specialty_Amount = new List<object>();
		static private List<object> array_Enrollee_ID = new List<object>();
		static private List<string> array_Enrollee_Name = new List<string>();
		static private List<string> array_Enrollee_SurName = new List<string>();
		static private List<string> array_Enrollee_Patronymic = new List<string>();
		static private List<object> array_Enrollee_Class = new List<object>();
		static protected List<object> array_Enrollee_Average_Score = new List<object>();
		static private List<object> array_Enrollee_Benefits = new List<object>();
		static private List<object> array_Enrollee_Year = new List<object>();
		static private List<string> array_Enrollee_Specialty = new List<string>();
		static private List<object> array_Class_Class = new List<object>();
		static private List<int> array_Enroll_list = new List<int>();
		#endregion
		static private void clear_list()
		{
			array_Enrollee_Name.Clear();
			array_Specialty_Name.Clear();
			array_Specialty_ID.Clear();
			array_Specialty_Class.Clear();
			array_Specialty_Amount.Clear();
			array_Enrollee_ID.Clear();
			array_Enrollee_SurName.Clear();
			array_Enrollee_Patronymic.Clear();
			array_Enrollee_Class.Clear();
			array_Enrollee_Average_Score.Clear();
			array_Enrollee_Benefits.Clear();
			array_Enrollee_Year.Clear();
			array_Enrollee_Specialty.Clear();
			array_Class_Class.Clear();
			array_Enroll_list.Clear();
		}
		public static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Enrollee.db");
		static public void clear_DataGrid(DataGridView Grid)
		{
			Grid.Rows.Clear();
		}
		static public void load_base()
		{
			clear_list();
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
			connection.Open();
			SQLiteCommand obj_Table_Specialty = new SQLiteCommand("SELECT * FROM Table_Specialty;", connection);
			SQLiteCommand obj_Table_Class = new SQLiteCommand("SELECT * FROM Table_Class;", connection);
			SQLiteCommand obj_Table_Enrollee = new SQLiteCommand("SELECT * FROM Table_Enrollee;", connection);
			SQLiteDataReader Reader_Specialty = obj_Table_Specialty.ExecuteReader();
			SQLiteDataReader Reader_Class = obj_Table_Class.ExecuteReader();
			SQLiteDataReader Reader_Enrollee = obj_Table_Enrollee.ExecuteReader();
			#region
			foreach (DbDataRecord record in Reader_Specialty)
			{
				array_Specialty_Name.Add(record["Name_Specialty"]);
				array_Specialty_ID.Add(record["ID_Specialty"]);
				array_Specialty_Class.Add(record["Class"]);
				array_Specialty_Amount.Add(record["amount"]);
			}
			#endregion
			#region
			foreach (DbDataRecord record in Reader_Class)
			{
				array_Class_Class.Add(record["ID_Class"]);

			}
			#endregion
			#region
			foreach (DbDataRecord record in Reader_Enrollee)
			{
				array_Enrollee_ID.Add(record["ID"]);
				array_Enrollee_Name.Add(record["Name"].ToString());
				array_Enrollee_SurName.Add(record["SurName"].ToString());
				array_Enrollee_Patronymic.Add(record["Patronymic"].ToString());
				array_Enrollee_Specialty.Add(record["Specialty"].ToString());
				array_Enrollee_Average_Score.Add(record["Average_Score"]);
				array_Enrollee_Class.Add(record["Class"]);
				array_Enrollee_Benefits.Add(record["Benefits"]);
				array_Enrollee_Year.Add(record["Year"]);
			}
			#endregion
			connection.Close();
		}
		static public void FillComboBox(MetroComboBox cmb, MetroComboBox cmb2)
		{

			/*Вывод в комбобоксы значений*/
			for (int i = 0; i < array_Class_Class.Count; i++) cmb.Items.Add(array_Class_Class[i]);

			for (int i = 0; i < array_Specialty_ID.Count; i++) cmb2.Items.Add(array_Specialty_Name[i] + " " + array_Specialty_Class[i] + " класс");
		}
		static public void FillComboBox(MetroComboBox cmb)
		{
			for (int i = 0; i < array_Specialty_ID.Count; i++) cmb.Items.Add(array_Specialty_Name[i] + " " + array_Specialty_Class[i] + " класс");
		}
		static public void FillForm_change(MetroTextBox Name, MetroTextBox SurName, MetroTextBox Patronymic, MetroComboBox Specialty, MetroTextBox Average_Score, MetroComboBox Class, CheckBox Benefits)
		{
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
			connection.Open();
			SQLiteCommand obj_change_Enrollee = new SQLiteCommand("SELECT * FROM Table_Enrollee where ID=" + temp_id_change + ";", connection);
			SQLiteDataReader Reader_Enrollee = obj_change_Enrollee.ExecuteReader();
			foreach (DbDataRecord record in Reader_Enrollee)
			{
				Name.Text = (record["Name"]).ToString();
				SurName.Text = (record["SurName"]).ToString();
				Patronymic.Text = (record["Patronymic"]).ToString();
				Average_Score.Text = (record["Average_Score"]).ToString();
				Benefits.Checked = (bool)(record["Benefits"]);
				Class.Text = (record["Class"]).ToString();
				int temp_specialty = int.Parse(record["Specialty"].ToString());
				Specialty.SelectedIndex = temp_specialty - 1;
				Specialty.Text = array_Specialty_Name[temp_specialty - 1].ToString();
			}

			connection.Close();


		}
		static public bool add_Enrollee(MetroTextBox Name, MetroTextBox SurName, MetroTextBox Patronymic, MetroComboBox Specialty, MetroTextBox Average_Score, MetroComboBox Class, CheckBox Benefits)
		{
			bool status = false;
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", Class_Function.dbPath));
			connection.Open();
			using (SQLiteCommand command = new SQLiteCommand("INSERT INTO 'Table_Enrollee' ('Name', 'Surname', 'Patronymic','Specialty','Average_Score','Class','Benefits','Year') VALUES (@Name, @Surname, @Patronymic, @Specialty, @Average_Score, @Class, @Benefits, @Year);", connection))
			{
				try
				{
					command.Parameters.AddWithValue("@Name", Name.Text);
					command.Parameters.AddWithValue("@Surname", SurName.Text);
					command.Parameters.AddWithValue("@Patronymic", Patronymic.Text);
					command.Parameters.AddWithValue("@Specialty", array_Specialty_ID[Specialty.SelectedIndex]);
					command.Parameters.AddWithValue("@Average_Score", Average_Score.Text);
					command.Parameters.AddWithValue("@Class", Class.SelectedItem);
					command.Parameters.AddWithValue("@Benefits", (bool)Benefits.Checked);
					command.Parameters.AddWithValue("@Year", DateTime.Now.Year);
					command.ExecuteNonQuery();
					status = true;
				}
				catch
				{
					MessageBox.Show("Неудачно. Проверьте введенную информацию.");
				}
			}
			connection.Close();
			return status;
		}
		static public bool change_Enrollee(MetroTextBox Name, MetroTextBox SurName, MetroTextBox Patronymic, MetroComboBox Specialty, MetroTextBox Average_Score, MetroComboBox Class, CheckBox Benefits)
		{
			bool status = false;

			try
			{
				SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
				connection.Open();
				using (SQLiteCommand obj_Table_Enrollee = new SQLiteCommand("UPDATE Table_Enrollee SET Name=@Name, SurName=@SurName, Patronymic=@Patronymic, Specialty=@Specialty , Average_Score=@Average_Score,Class=@Class, Benefits=@Benefits  where ID=@IDS;", connection))
				{
					obj_Table_Enrollee.Parameters.AddWithValue("@IDS", temp_id_change);
					obj_Table_Enrollee.Parameters.AddWithValue("@Name", Name.Text);
					obj_Table_Enrollee.Parameters.AddWithValue("@Surname", SurName.Text);
					obj_Table_Enrollee.Parameters.AddWithValue("@Patronymic", Patronymic.Text);
					obj_Table_Enrollee.Parameters.AddWithValue("@Specialty", array_Specialty_ID[Specialty.SelectedIndex]);
					obj_Table_Enrollee.Parameters.AddWithValue("@Average_Score", Average_Score.Text);
					obj_Table_Enrollee.Parameters.AddWithValue("@Class", Class.SelectedItem);
					obj_Table_Enrollee.Parameters.AddWithValue("@Benefits", (bool)Benefits.Checked);
					obj_Table_Enrollee.ExecuteNonQuery();
					status = true;
				}

			}
			catch
			{
				MessageBox.Show("Не удалось Проверьте введенные данные.");
			}

			return status;
		}
		static public void print_Grid(DataGridView Grid)
		{
			try
			{
				for (int i = 0; i < array_Enrollee_ID.Count; i++)
				{

					//MessageBox.Show(temp.ToString());
					Grid.Rows.Add(
						array_Enrollee_SurName[i],
						array_Enrollee_Name[i],
						array_Enrollee_Patronymic[i],
						array_Specialty_Name[int.Parse(array_Enrollee_Specialty[i]) - 1] + " " + array_Enrollee_Class[i] + " класс",//Сюда массив
						array_Enrollee_Average_Score[i],
						array_Enrollee_Class[i],
						array_Enrollee_Benefits[i],
						array_Enrollee_Year[i],
						array_Enrollee_ID[i]
								 );
				}
			}
			finally
			{

			}
		}
		static public bool dialog_warning_destroy(string text, MetroTextBox Name, MetroTextBox SurName, MetroTextBox Patronymic)
		{
			bool status = false;
			DialogResult result = MessageBox.Show(text + " " + SurName.Text + " " + Name.Text + " " + Patronymic.Text + " ?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				status = true;
				SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
				connection.Open();
				SQLiteCommand obj_delete_Enrollee = new SQLiteCommand("DELETE FROM Table_Enrollee where ID=" + temp_id_change + ";", connection);
				obj_delete_Enrollee.ExecuteNonQuery();
				connection.Close();
			}
			else if (result == DialogResult.No)
			{
				status = false;
			}
			return status;
		}
		static public void update_grid(DataGridView Grid)
		{
			clear_DataGrid(Grid);
			load_base();
			print_Grid(Grid);
		}
		static public void filter(DataGridView dataGridView, MetroTextBox Name, MetroTextBox SurName, MetroTextBox Patronymic, MetroTextBox Year, MetroComboBox Specialty, MetroComboBox Class, MetroComboBox Benefits)
		{
			foreach (DataGridViewRow row in dataGridView.Rows)
			{

				if (Name.Text.Length > 0)
					if (row.Cells[1].Value.ToString() != Name.Text) row.Visible = false;
				if (SurName.Text.Length > 0)
					if (row.Cells[0].Value.ToString() != SurName.Text) row.Visible = false;
				if (Patronymic.Text.Length > 0)
					if (row.Cells[2].Value.ToString() != Patronymic.Text) row.Visible = false;
				if (Specialty.SelectedItem.ToString() != "Все специальности")
					if (row.Cells[3].Value.ToString() != Specialty.SelectedItem.ToString()) row.Visible = false;
				if (Class.SelectedItem.ToString() != "Все")
					if (row.Cells[5].Value.ToString() != Class.SelectedItem.ToString()) row.Visible = false;
				if (Benefits.SelectedItem.ToString() != "Все")
					if (Convert.ToInt32(row.Cells[6].Value) != Benefits.SelectedIndex) row.Visible = false;
				if (Year.Text.Length > 0)
					if (row.Cells[7].Value.ToString() != Year.Text) row.Visible = false;
			}


		}
		#region
		static public void Enroll(MetroComboBox Specialty, ProgressBar Bar)
		{
			SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
			connection.Open();
			clear_list();
			int select_combobox_index = Specialty.SelectedIndex + 1;
			int amount_sql = 0;
			int amount_sql_enroll = 0;
			int amount = amount_sql - amount_sql_enroll;
			SQLiteCommand SQL_Amount = new SQLiteCommand("select amount from Table_Specialty where (ID_Specialty=" + select_combobox_index + ");", connection);
			SQLiteCommand SQL_Enrolled = new SQLiteCommand("select count (Enrolled) from Table_Enrollee where (Enrolled=1) AND (Specialty=" + select_combobox_index + ") AND (Year=" + DateTime.Now.Year + ");", connection);
			amount_sql_enroll = Convert.ToInt32(SQL_Enrolled.ExecuteScalar());
			SQLiteDataReader Reader_Amount = SQL_Amount.ExecuteReader();
			foreach (DbDataRecord record in Reader_Amount)
			{
				amount_sql = Convert.ToInt32(record["amount"]);
			}
			if (amount_sql > amount_sql_enroll)
			{
				Bar.Maximum = amount_sql - 1;
				SQLiteCommand SQL_Enroll_Benefits = new SQLiteCommand("select ID, Average_Score FROM Table_Enrollee where (Specialty=" + select_combobox_index + ") AND (Enrolled=0) AND (Year=" + DateTime.Now.Year + ") AND (Benefits=1);", connection);
				SQLiteDataReader Reader_Benefits = SQL_Enroll_Benefits.ExecuteReader();
				foreach (DbDataRecord record in Reader_Benefits)
				{
					array_Enroll_list.Add(Convert.ToInt32(record["ID"]));
				}
				SQL_Update(connection, Bar, amount_sql_enroll, SQL_Enrolled);
				array_Enroll_list.Clear();
				amount_sql_enroll = Convert.ToInt32(SQL_Enrolled.ExecuteScalar());
				amount = amount_sql - amount_sql_enroll;
				SQLiteCommand SQL_Enroll_Average = new SQLiteCommand("select ID, Average_Score, Benefits FROM Table_Enrollee where (Specialty=" + select_combobox_index + ") AND (Enrolled=0) AND (Year=" + DateTime.Now.Year + ") order by Average_Score desc limit 0," + amount + ";", connection);
				SQLiteDataReader Reader_Average = SQL_Enroll_Average.ExecuteReader();

				foreach (DbDataRecord record in Reader_Average)
				{
					array_Enroll_list.Add(Convert.ToInt32(record["ID"]));
				}
				SQL_Update(connection, Bar, amount_sql_enroll, SQL_Enrolled);
				amount_sql_enroll = Convert.ToInt32(SQL_Enrolled.ExecuteScalar());
				if (amount_sql == amount_sql_enroll)
					MessageBox.Show("Абитуриенты зачислены");
				if (amount_sql > amount_sql_enroll)
					MessageBox.Show("Абитуриенты зачислены, но остались свободные места");
			}
			else
				MessageBox.Show("Все " + amount_sql + " мест заполнены.");
			connection.Close();
			load_base();
		}
		static private void SQL_Update(SQLiteConnection connection, ProgressBar Bar, int amount, SQLiteCommand SQL_Enrolled)
		{
			Bar.Value = amount;
			using (SQLiteCommand obj_Table_Enrollee = new SQLiteCommand("UPDATE Table_Enrollee set Enrolled=1 where ID=@ID;", connection))
			{
				for (int i = 0; i < array_Enroll_list.Count; i++)
				{
					Bar.Value = amount;
					obj_Table_Enrollee.Parameters.AddWithValue("@ID", array_Enroll_list[i]);
					obj_Table_Enrollee.ExecuteNonQuery();
					amount = Convert.ToInt32(SQL_Enrolled.ExecuteScalar());
				}
			}
		}
		#endregion
		static public bool autorization(MetroTextBox T_login, MetroTextBox T_password)
		{
			bool check = false;

			using (SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath))) 
			using (SQLiteCommand command = new SQLiteCommand("select * from Table_User where (Login=@Login) AND (Password=@Password);", connection))
			{
				command.Parameters.AddWithValue("@Login", T_login.Text);
				command.Parameters.AddWithValue("@Password", T_password.Text);
				connection.Open();
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
						check = true;
				}
				connection.Close();
			}
				if (check == false)
			{
				MessageBox.Show("Неверный логин или пароль!");

			}
			return check;
		}

	}
}
