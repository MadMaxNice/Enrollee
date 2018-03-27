using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;
namespace Coursework___enrollment_entrants__
{
	class Class_Report:Class_Function
	{
	static	Word._Application oWord = new Word.Application();
		static private List<int> List_Enrollee = new List<int>();
		static private List<int> List_Benefits = new List<int>();
		static public void Report()
		{
			try
			{
				string report_text = "В " + DateTime.Now.Year + " году было доступно для поступления " + Convert.ToInt32(array_Specialty_Amount.Count) + " специальностей. \n";
				List_Enrollee.Clear();
				List_Benefits.Clear();
				load_base();
				SQLiteConnection connection = new SQLiteConnection(string.Format("Data Source={0};", dbPath));
				connection.Open();
				SQLiteCommand SQL_Enroll_Count = new SQLiteCommand("select count (Enrolled) FROM Table_Enrollee where (Specialty=@Specialty) AND (Enrolled=1) AND (Year=" + DateTime.Now.Year + ");", connection);
				SQLiteCommand SQL_Enroll_Benefits = new SQLiteCommand("select count (Benefits) FROM Table_Enrollee where (Benefits=1) AND (Enrolled=1) AND (Year=" + DateTime.Now.Year + ") AND (Specialty=@Specialty);", connection);
				SQLiteCommand SQL_Enroll_Score = new SQLiteCommand("select Average_Score FROM Table_Enrollee where (Specialty=@Specialty) AND (Enrolled=1) order by Average_Score limit 0,1;", connection);
				array_Enrollee_Average_Score.Clear();
				{
					for (int i = 0; i < array_Specialty_Amount.Count; i++)
					{
						SQL_Enroll_Count.Parameters.AddWithValue("@Specialty", i + 1);
						SQL_Enroll_Benefits.Parameters.AddWithValue("@Specialty", i + 1);
						SQL_Enroll_Score.Parameters.AddWithValue("@Specialty", i + 1);
						List_Enrollee.Add(Convert.ToInt32(SQL_Enroll_Count.ExecuteScalar()));
						List_Benefits.Add(Convert.ToInt32(SQL_Enroll_Benefits.ExecuteScalar()));
						array_Enrollee_Average_Score.Add(Convert.ToInt32(SQL_Enroll_Score.ExecuteScalar()));
					}

				}
				connection.Close();
				for (int i = 0; i < array_Specialty_Amount.Count; i++)
					report_text += ("На  специальности «" + array_Specialty_Name[i] + "» на базе "
						+ array_Specialty_Class[i] + " классов было доступно " + array_Specialty_Amount[i] + " мест. Набор на данную специальность составил " + List_Enrollee[i] + " человек, из которых "
						+ List_Benefits[i] + " зачислены вне конкурса. Проходной балл для данной специальности - " + array_Enrollee_Average_Score[i] + ".\n");
				_Document oDoc = GetDoc(Environment.CurrentDirectory + "\\Template_Report.docx", report_text);
				oDoc.SaveAs(FileName: Environment.CurrentDirectory + "\\Отчет за " + DateTime.Now.Year + " год.docx");
				oDoc.Close();
				System.Diagnostics.Process.Start("Отчет за " + DateTime.Now.Year + " год.docx");
			}
			catch
			{ System.Windows.Forms.MessageBox.Show("Что-то пошло не так..."); }
			}

		static private _Document GetDoc(string path,string report_text)
		{
			_Document oDoc = oWord.Documents.Add(path);
			oDoc.Bookmarks["Year"].Range.Text = DateTime.Now.Year.ToString();
			oDoc.Bookmarks["Text"].Range.Text = report_text;
			return oDoc;
		}
		
	}
}
