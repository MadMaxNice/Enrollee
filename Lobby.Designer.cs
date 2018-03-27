namespace Coursework___enrollment_entrants__
{
	partial class Form_Lobby
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Entrance = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Average_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Benefits = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_change = new System.Windows.Forms.Button();
			this.button_exit = new System.Windows.Forms.Button();
			this.button_search_switch = new System.Windows.Forms.Button();
			this.SearchBox = new System.Windows.Forms.GroupBox();
			this.textBox_Year = new MetroFramework.Controls.MetroTextBox();
			this.comboBox_Specialty = new MetroFramework.Controls.MetroComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox__Benefits = new MetroFramework.Controls.MetroComboBox();
			this.comboBox_Class = new MetroFramework.Controls.MetroComboBox();
			this.label_Class = new System.Windows.Forms.Label();
			this.label__Benefits = new System.Windows.Forms.Label();
			this.label_Year = new System.Windows.Forms.Label();
			this.button_next = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_SurName = new MetroFramework.Controls.MetroTextBox();
			this.textBox_Name = new MetroFramework.Controls.MetroTextBox();
			this.label_Name = new System.Windows.Forms.Label();
			this.textBox_Patronymic = new MetroFramework.Controls.MetroTextBox();
			this.label_Surname = new System.Windows.Forms.Label();
			this.label_Patronymic = new System.Windows.Forms.Label();
			this.button_drop = new System.Windows.Forms.Button();
			this.button_Enroll = new System.Windows.Forms.Button();
			this.button_report = new System.Windows.Forms.Button();
			this.Button_Box = new System.Windows.Forms.GroupBox();
			this.lobbyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SearchBox.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.Button_Box.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lobbyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Entrance
			// 
			this.Entrance.BackColor = System.Drawing.Color.White;
			this.Entrance.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.Entrance.FlatAppearance.BorderSize = 2;
			this.Entrance.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.Entrance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.Entrance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.Entrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Entrance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Entrance.Location = new System.Drawing.Point(114, 16);
			this.Entrance.Name = "Entrance";
			this.Entrance.Size = new System.Drawing.Size(93, 30);
			this.Entrance.TabIndex = 15;
			this.Entrance.Text = "Добавить";
			this.Entrance.UseVisualStyleBackColor = false;
			this.Entrance.Click += new System.EventHandler(this.Entrance_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(15, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 30);
			this.button1.TabIndex = 16;
			this.button1.Text = "Обновить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SurName,
            this.Name,
            this.Patronymic,
            this.Specialty,
            this.Average_Score,
            this.Class,
            this.Benefits,
            this.Year,
            this.ID});
			this.dataGridView1.Location = new System.Drawing.Point(0, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(813, 330);
			this.dataGridView1.TabIndex = 19;
			// 
			// SurName
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SurName.DefaultCellStyle = dataGridViewCellStyle1;
			this.SurName.HeaderText = "Фамилия";
			this.SurName.Name = "SurName";
			this.SurName.ReadOnly = true;
			// 
			// Name
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name.DefaultCellStyle = dataGridViewCellStyle2;
			this.Name.HeaderText = "Имя";
			this.Name.Name = "Name";
			this.Name.ReadOnly = true;
			// 
			// Patronymic
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Patronymic.DefaultCellStyle = dataGridViewCellStyle3;
			this.Patronymic.HeaderText = "Отчество";
			this.Patronymic.Name = "Patronymic";
			this.Patronymic.ReadOnly = true;
			// 
			// Specialty
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Specialty.DefaultCellStyle = dataGridViewCellStyle4;
			this.Specialty.HeaderText = "Специальность";
			this.Specialty.Name = "Specialty";
			this.Specialty.ReadOnly = true;
			// 
			// Average_Score
			// 
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Average_Score.DefaultCellStyle = dataGridViewCellStyle5;
			this.Average_Score.HeaderText = "Балл";
			this.Average_Score.Name = "Average_Score";
			this.Average_Score.ReadOnly = true;
			// 
			// Class
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Class.DefaultCellStyle = dataGridViewCellStyle6;
			this.Class.HeaderText = "Класс";
			this.Class.Name = "Class";
			this.Class.ReadOnly = true;
			// 
			// Benefits
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.NullValue = false;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkGray;
			this.Benefits.DefaultCellStyle = dataGridViewCellStyle7;
			this.Benefits.HeaderText = "Льготы";
			this.Benefits.Name = "Benefits";
			this.Benefits.ReadOnly = true;
			this.Benefits.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Benefits.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Year
			// 
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Year.DefaultCellStyle = dataGridViewCellStyle8;
			this.Year.HeaderText = "Год";
			this.Year.Name = "Year";
			this.Year.ReadOnly = true;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID_Table";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ID.Visible = false;
			// 
			// button_change
			// 
			this.button_change.BackColor = System.Drawing.Color.White;
			this.button_change.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_change.FlatAppearance.BorderSize = 2;
			this.button_change.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_change.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_change.Location = new System.Drawing.Point(213, 16);
			this.button_change.Name = "button_change";
			this.button_change.Size = new System.Drawing.Size(93, 30);
			this.button_change.TabIndex = 20;
			this.button_change.Text = "Изменить";
			this.button_change.UseVisualStyleBackColor = false;
			this.button_change.Click += new System.EventHandler(this.button_change_Click);
			// 
			// button_exit
			// 
			this.button_exit.BackColor = System.Drawing.Color.White;
			this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_exit.FlatAppearance.BorderSize = 2;
			this.button_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_exit.Location = new System.Drawing.Point(696, 16);
			this.button_exit.Name = "button_exit";
			this.button_exit.Size = new System.Drawing.Size(93, 30);
			this.button_exit.TabIndex = 21;
			this.button_exit.Text = "Выйти";
			this.button_exit.UseVisualStyleBackColor = false;
			this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
			// 
			// button_search_switch
			// 
			this.button_search_switch.BackColor = System.Drawing.Color.White;
			this.button_search_switch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_search_switch.FlatAppearance.BorderSize = 2;
			this.button_search_switch.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_search_switch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_search_switch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_search_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_search_switch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_search_switch.Location = new System.Drawing.Point(589, 16);
			this.button_search_switch.Name = "button_search_switch";
			this.button_search_switch.Size = new System.Drawing.Size(93, 30);
			this.button_search_switch.TabIndex = 22;
			this.button_search_switch.Text = "Поиск";
			this.button_search_switch.UseVisualStyleBackColor = false;
			this.button_search_switch.Click += new System.EventHandler(this.button_search_switch_Click);
			// 
			// SearchBox
			// 
			this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SearchBox.AutoSize = true;
			this.SearchBox.Controls.Add(this.textBox_Year);
			this.SearchBox.Controls.Add(this.comboBox_Specialty);
			this.SearchBox.Controls.Add(this.groupBox2);
			this.SearchBox.Controls.Add(this.button_next);
			this.SearchBox.Controls.Add(this.groupBox1);
			this.SearchBox.Controls.Add(this.button_drop);
			this.SearchBox.Location = new System.Drawing.Point(6, 216);
			this.SearchBox.Name = "SearchBox";
			this.SearchBox.Size = new System.Drawing.Size(790, 176);
			this.SearchBox.TabIndex = 23;
			this.SearchBox.TabStop = false;
			this.SearchBox.Visible = false;
			// 
			// textBox_Year
			// 
			// 
			// 
			// 
			this.textBox_Year.CustomButton.Image = null;
			this.textBox_Year.CustomButton.Location = new System.Drawing.Point(32, 1);
			this.textBox_Year.CustomButton.Name = "";
			this.textBox_Year.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.textBox_Year.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.textBox_Year.CustomButton.TabIndex = 1;
			this.textBox_Year.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.textBox_Year.CustomButton.UseSelectable = true;
			this.textBox_Year.CustomButton.Visible = false;
			this.textBox_Year.Lines = new string[0];
			this.textBox_Year.Location = new System.Drawing.Point(367, 56);
			this.textBox_Year.MaxLength = 32767;
			this.textBox_Year.Name = "textBox_Year";
			this.textBox_Year.PasswordChar = '\0';
			this.textBox_Year.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_Year.SelectedText = "";
			this.textBox_Year.SelectionLength = 0;
			this.textBox_Year.SelectionStart = 0;
			this.textBox_Year.ShortcutsEnabled = true;
			this.textBox_Year.Size = new System.Drawing.Size(60, 29);
			this.textBox_Year.TabIndex = 30;
			this.textBox_Year.UseSelectable = true;
			this.textBox_Year.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBox_Year.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// comboBox_Specialty
			// 
			this.comboBox_Specialty.FormattingEnabled = true;
			this.comboBox_Specialty.ItemHeight = 23;
			this.comboBox_Specialty.Items.AddRange(new object[] {
            "Все специальности"});
			this.comboBox_Specialty.Location = new System.Drawing.Point(6, 128);
			this.comboBox_Specialty.Name = "comboBox_Specialty";
			this.comboBox_Specialty.Size = new System.Drawing.Size(778, 29);
			this.comboBox_Specialty.TabIndex = 42;
			this.comboBox_Specialty.UseSelectable = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox__Benefits);
			this.groupBox2.Controls.Add(this.comboBox_Class);
			this.groupBox2.Controls.Add(this.label_Class);
			this.groupBox2.Controls.Add(this.label__Benefits);
			this.groupBox2.Controls.Add(this.label_Year);
			this.groupBox2.Location = new System.Drawing.Point(293, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 110);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			// 
			// comboBox__Benefits
			// 
			this.comboBox__Benefits.FormattingEnabled = true;
			this.comboBox__Benefits.ItemHeight = 23;
			this.comboBox__Benefits.Items.AddRange(new object[] {
            "Не имеются",
            "Имеются",
            "Все"});
			this.comboBox__Benefits.Location = new System.Drawing.Point(74, 78);
			this.comboBox__Benefits.Name = "comboBox__Benefits";
			this.comboBox__Benefits.Size = new System.Drawing.Size(60, 29);
			this.comboBox__Benefits.TabIndex = 40;
			this.comboBox__Benefits.UseSelectable = true;
			// 
			// comboBox_Class
			// 
			this.comboBox_Class.FormattingEnabled = true;
			this.comboBox_Class.ItemHeight = 23;
			this.comboBox_Class.Items.AddRange(new object[] {
            "Все"});
			this.comboBox_Class.Location = new System.Drawing.Point(74, 9);
			this.comboBox_Class.Name = "comboBox_Class";
			this.comboBox_Class.Size = new System.Drawing.Size(60, 29);
			this.comboBox_Class.TabIndex = 26;
			this.comboBox_Class.UseSelectable = true;
			// 
			// label_Class
			// 
			this.label_Class.AutoSize = true;
			this.label_Class.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Class.Location = new System.Drawing.Point(6, 14);
			this.label_Class.Name = "label_Class";
			this.label_Class.Size = new System.Drawing.Size(54, 18);
			this.label_Class.TabIndex = 36;
			this.label_Class.Text = "Класс:";
			// 
			// label__Benefits
			// 
			this.label__Benefits.AutoSize = true;
			this.label__Benefits.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label__Benefits.Location = new System.Drawing.Point(6, 82);
			this.label__Benefits.Name = "label__Benefits";
			this.label__Benefits.Size = new System.Drawing.Size(62, 18);
			this.label__Benefits.TabIndex = 34;
			this.label__Benefits.Text = "Льготы";
			// 
			// label_Year
			// 
			this.label_Year.AutoSize = true;
			this.label_Year.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Year.Location = new System.Drawing.Point(6, 47);
			this.label_Year.Name = "label_Year";
			this.label_Year.Size = new System.Drawing.Size(38, 18);
			this.label_Year.TabIndex = 37;
			this.label_Year.Text = "Год:";
			// 
			// button_next
			// 
			this.button_next.BackColor = System.Drawing.Color.White;
			this.button_next.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_next.FlatAppearance.BorderSize = 2;
			this.button_next.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_next.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_next.Location = new System.Drawing.Point(449, 19);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(80, 30);
			this.button_next.TabIndex = 40;
			this.button_next.Text = "Искать";
			this.button_next.UseVisualStyleBackColor = false;
			this.button_next.Click += new System.EventHandler(this.button_next_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox_SurName);
			this.groupBox1.Controls.Add(this.textBox_Name);
			this.groupBox1.Controls.Add(this.label_Name);
			this.groupBox1.Controls.Add(this.textBox_Patronymic);
			this.groupBox1.Controls.Add(this.label_Surname);
			this.groupBox1.Controls.Add(this.label_Patronymic);
			this.groupBox1.Location = new System.Drawing.Point(6, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(281, 110);
			this.groupBox1.TabIndex = 35;
			this.groupBox1.TabStop = false;
			// 
			// textBox_SurName
			// 
			// 
			// 
			// 
			this.textBox_SurName.CustomButton.Image = null;
			this.textBox_SurName.CustomButton.Location = new System.Drawing.Point(160, 1);
			this.textBox_SurName.CustomButton.Name = "";
			this.textBox_SurName.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.textBox_SurName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.textBox_SurName.CustomButton.TabIndex = 1;
			this.textBox_SurName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.textBox_SurName.CustomButton.UseSelectable = true;
			this.textBox_SurName.CustomButton.Visible = false;
			this.textBox_SurName.Lines = new string[0];
			this.textBox_SurName.Location = new System.Drawing.Point(88, 15);
			this.textBox_SurName.MaxLength = 32767;
			this.textBox_SurName.Name = "textBox_SurName";
			this.textBox_SurName.PasswordChar = '\0';
			this.textBox_SurName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_SurName.SelectedText = "";
			this.textBox_SurName.SelectionLength = 0;
			this.textBox_SurName.SelectionStart = 0;
			this.textBox_SurName.ShortcutsEnabled = true;
			this.textBox_SurName.Size = new System.Drawing.Size(182, 23);
			this.textBox_SurName.TabIndex = 29;
			this.textBox_SurName.UseSelectable = true;
			this.textBox_SurName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBox_SurName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// textBox_Name
			// 
			// 
			// 
			// 
			this.textBox_Name.CustomButton.Image = null;
			this.textBox_Name.CustomButton.Location = new System.Drawing.Point(160, 1);
			this.textBox_Name.CustomButton.Name = "";
			this.textBox_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.textBox_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.textBox_Name.CustomButton.TabIndex = 1;
			this.textBox_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.textBox_Name.CustomButton.UseSelectable = true;
			this.textBox_Name.CustomButton.Visible = false;
			this.textBox_Name.Lines = new string[0];
			this.textBox_Name.Location = new System.Drawing.Point(88, 42);
			this.textBox_Name.MaxLength = 32767;
			this.textBox_Name.Name = "textBox_Name";
			this.textBox_Name.PasswordChar = '\0';
			this.textBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_Name.SelectedText = "";
			this.textBox_Name.SelectionLength = 0;
			this.textBox_Name.SelectionStart = 0;
			this.textBox_Name.ShortcutsEnabled = true;
			this.textBox_Name.Size = new System.Drawing.Size(182, 23);
			this.textBox_Name.TabIndex = 28;
			this.textBox_Name.UseSelectable = true;
			this.textBox_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBox_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Name.Location = new System.Drawing.Point(6, 16);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(76, 18);
			this.label_Name.TabIndex = 24;
			this.label_Name.Text = "Фамилия:";
			// 
			// textBox_Patronymic
			// 
			// 
			// 
			// 
			this.textBox_Patronymic.CustomButton.Image = null;
			this.textBox_Patronymic.CustomButton.Location = new System.Drawing.Point(160, 1);
			this.textBox_Patronymic.CustomButton.Name = "";
			this.textBox_Patronymic.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.textBox_Patronymic.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.textBox_Patronymic.CustomButton.TabIndex = 1;
			this.textBox_Patronymic.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.textBox_Patronymic.CustomButton.UseSelectable = true;
			this.textBox_Patronymic.CustomButton.Visible = false;
			this.textBox_Patronymic.Lines = new string[0];
			this.textBox_Patronymic.Location = new System.Drawing.Point(88, 71);
			this.textBox_Patronymic.MaxLength = 32767;
			this.textBox_Patronymic.Name = "textBox_Patronymic";
			this.textBox_Patronymic.PasswordChar = '\0';
			this.textBox_Patronymic.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.textBox_Patronymic.SelectedText = "";
			this.textBox_Patronymic.SelectionLength = 0;
			this.textBox_Patronymic.SelectionStart = 0;
			this.textBox_Patronymic.ShortcutsEnabled = true;
			this.textBox_Patronymic.Size = new System.Drawing.Size(182, 23);
			this.textBox_Patronymic.TabIndex = 27;
			this.textBox_Patronymic.UseSelectable = true;
			this.textBox_Patronymic.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBox_Patronymic.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// label_Surname
			// 
			this.label_Surname.AutoSize = true;
			this.label_Surname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Surname.Location = new System.Drawing.Point(6, 42);
			this.label_Surname.Name = "label_Surname";
			this.label_Surname.Size = new System.Drawing.Size(44, 18);
			this.label_Surname.TabIndex = 25;
			this.label_Surname.Text = "Имя:";
			// 
			// label_Patronymic
			// 
			this.label_Patronymic.AutoSize = true;
			this.label_Patronymic.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Patronymic.Location = new System.Drawing.Point(6, 71);
			this.label_Patronymic.Name = "label_Patronymic";
			this.label_Patronymic.Size = new System.Drawing.Size(81, 18);
			this.label_Patronymic.TabIndex = 26;
			this.label_Patronymic.Text = "Отчество:";
			// 
			// button_drop
			// 
			this.button_drop.BackColor = System.Drawing.Color.White;
			this.button_drop.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_drop.FlatAppearance.BorderSize = 2;
			this.button_drop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_drop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_drop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_drop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_drop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_drop.Location = new System.Drawing.Point(449, 59);
			this.button_drop.Name = "button_drop";
			this.button_drop.Size = new System.Drawing.Size(80, 30);
			this.button_drop.TabIndex = 30;
			this.button_drop.Text = "Сброс";
			this.button_drop.UseVisualStyleBackColor = false;
			this.button_drop.Click += new System.EventHandler(this.button_drop_Click);
			// 
			// button_Enroll
			// 
			this.button_Enroll.BackColor = System.Drawing.Color.White;
			this.button_Enroll.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_Enroll.FlatAppearance.BorderSize = 2;
			this.button_Enroll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_Enroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_Enroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_Enroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Enroll.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Enroll.Location = new System.Drawing.Point(312, 16);
			this.button_Enroll.Name = "button_Enroll";
			this.button_Enroll.Size = new System.Drawing.Size(105, 30);
			this.button_Enroll.TabIndex = 24;
			this.button_Enroll.Text = "Зачислить";
			this.button_Enroll.UseVisualStyleBackColor = false;
			this.button_Enroll.Click += new System.EventHandler(this.button_Enroll_Click);
			// 
			// button_report
			// 
			this.button_report.BackColor = System.Drawing.Color.White;
			this.button_report.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.button_report.FlatAppearance.BorderSize = 2;
			this.button_report.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
			this.button_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.button_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.button_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_report.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_report.Location = new System.Drawing.Point(490, 16);
			this.button_report.Name = "button_report";
			this.button_report.Size = new System.Drawing.Size(93, 30);
			this.button_report.TabIndex = 25;
			this.button_report.Text = "Отчет";
			this.button_report.UseVisualStyleBackColor = false;
			this.button_report.Click += new System.EventHandler(this.button_report_Click);
			// 
			// Button_Box
			// 
			this.Button_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Button_Box.Controls.Add(this.button1);
			this.Button_Box.Controls.Add(this.button_exit);
			this.Button_Box.Controls.Add(this.Entrance);
			this.Button_Box.Controls.Add(this.button_change);
			this.Button_Box.Controls.Add(this.button_report);
			this.Button_Box.Controls.Add(this.button_search_switch);
			this.Button_Box.Controls.Add(this.button_Enroll);
			this.Button_Box.Location = new System.Drawing.Point(0, 382);
			this.Button_Box.Name = "Button_Box";
			this.Button_Box.Size = new System.Drawing.Size(813, 55);
			this.Button_Box.TabIndex = 27;
			this.Button_Box.TabStop = false;
			// 
			// lobbyBindingSource
			// 
			this.lobbyBindingSource.DataSource = typeof(Coursework___enrollment_entrants__.Form_Lobby);
			// 
			// Form_Lobby
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(813, 437);
			this.Controls.Add(this.Button_Box);
			this.Controls.Add(this.SearchBox);
			this.Controls.Add(this.dataGridView1);
		//	this.Name = "Form_Lobby";
			this.Text = "Учет абитуриентов";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Lobby_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.SearchBox.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Button_Box.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lobbyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Entrance;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource lobbyBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Average_Score;
		private System.Windows.Forms.DataGridViewTextBoxColumn Class;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Benefits;
		private System.Windows.Forms.DataGridViewTextBoxColumn Year;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button_change;
		private System.Windows.Forms.Button button_exit;
		private System.Windows.Forms.Button button_search_switch;
		private System.Windows.Forms.GroupBox SearchBox;
		private System.Windows.Forms.Label label_Patronymic;
		private System.Windows.Forms.Label label_Surname;
		private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.Button button_drop;
		private System.Windows.Forms.Label label__Benefits;
		private System.Windows.Forms.Label label_Class;
		private System.Windows.Forms.Label label_Year;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button_next;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button_Enroll;
		private System.Windows.Forms.Button button_report;
		private MetroFramework.Controls.MetroTextBox textBox_SurName;
		private MetroFramework.Controls.MetroTextBox textBox_Name;
		private MetroFramework.Controls.MetroTextBox textBox_Patronymic;
		public MetroFramework.Controls.MetroComboBox comboBox__Benefits;
		public MetroFramework.Controls.MetroComboBox comboBox_Class;
		public MetroFramework.Controls.MetroComboBox comboBox_Specialty;
		private MetroFramework.Controls.MetroTextBox textBox_Year;
		private System.Windows.Forms.GroupBox Button_Box;
	}
}