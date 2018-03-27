using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Coursework___enrollment_entrants__
{
	public partial class Form_Autorisation : MetroForm
	{
		public Form_Autorisation()
		{
			InitializeComponent();
			textbox_login.Text = "Логин";
			textbox_password.Text = "Пароль";
			textbox_login.ForeColor = System.Drawing.Color.Gray;
			textbox_password.ForeColor = System.Drawing.Color.Gray;
			textbox_login.Enter += Textbox_login_Enter;
			textbox_password.Enter += Textbox_password_Enter;
		}
		private void Textbox_password_Enter(object sender, EventArgs e)
		{
			textbox_password.Text = null;
			textbox_password.ForeColor = System.Drawing.Color.Black;
		}
		private void Textbox_login_Enter(object sender, EventArgs e)
		{
			textbox_login.Text = null;
			textbox_login.ForeColor = System.Drawing.Color.Black;
		}
		private void Entrance_Click(object sender, EventArgs e)
		{
			if (Class_Function.autorization(textbox_login, textbox_password)==true)
				{
				Form_Lobby obj_Lobby = new Form_Lobby();
				obj_Lobby.ShowDialog();
				}
		}
		private void button2_Click(object sender, EventArgs e)
		{
		Close();	
		}
		private void button1_Click(object sender, EventArgs e)
		{
		}
		private void button_help_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("help.chm");
			}
			catch
			{
				MessageBox.Show("Файл справки не найден");	
			}
		}
	}
}
