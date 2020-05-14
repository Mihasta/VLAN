namespace BugTracking
{
    partial class MainMenu
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
            this.User = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ошибкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типОшибкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инфОКомпеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.PersonalErrorsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SortBox1 = new System.Windows.Forms.ComboBox();
            this.SortBox2 = new System.Windows.Forms.ComboBox();
            this.ErrorStatusBox = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.LevelBox = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.PriorityBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.filterBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.ErrorStatusBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.LevelBox.SuspendLayout();
            this.PriorityBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User.Location = new System.Drawing.Point(12, 27);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(36, 35);
            this.User.TabIndex = 0;
            this.User.Text = "👤";
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 417);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.ошибкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.инфОКомпеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_MainMenu);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходИзАккаунтаToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Меню";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // выходИзАккаунтаToolStripMenuItem
            // 
            this.выходИзАккаунтаToolStripMenuItem.Name = "выходИзАккаунтаToolStripMenuItem";
            this.выходИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.выходИзАккаунтаToolStripMenuItem.Text = "Выход из аккаунта";
            this.выходИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.выходИзАккаунтаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // ошибкиToolStripMenuItem
            // 
            this.ошибкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типОшибкиToolStripMenuItem});
            this.ошибкиToolStripMenuItem.Name = "ошибкиToolStripMenuItem";
            this.ошибкиToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ошибкиToolStripMenuItem.Text = "Ошибки";
            // 
            // типОшибкиToolStripMenuItem
            // 
            this.типОшибкиToolStripMenuItem.Name = "типОшибкиToolStripMenuItem";
            this.типОшибкиToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.типОшибкиToolStripMenuItem.Text = "Типы ошибок";
            this.типОшибкиToolStripMenuItem.Click += new System.EventHandler(this.типОшибкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОтчетToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // создатьОтчетToolStripMenuItem
            // 
            this.создатьОтчетToolStripMenuItem.Name = "создатьОтчетToolStripMenuItem";
            this.создатьОтчетToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.создатьОтчетToolStripMenuItem.Text = "Создать отчет";
            this.создатьОтчетToolStripMenuItem.Click += new System.EventHandler(this.создатьОтчетToolStripMenuItem_Click);
            // 
            // инфОКомпеToolStripMenuItem
            // 
            this.инфОКомпеToolStripMenuItem.Name = "инфОКомпеToolStripMenuItem";
            this.инфОКомпеToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.инфОКомпеToolStripMenuItem.Text = "инф о компе";
            this.инфОКомпеToolStripMenuItem.Click += new System.EventHandler(this.инфОКомпеToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(710, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "TestError";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(621, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "OneTypeError";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(54, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "➕";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddError);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(180, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "🔄";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RefreshButton);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(96, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 35);
            this.button5.TabIndex = 7;
            this.button5.Text = "🔧";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Edit_Error);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(138, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 35);
            this.button6.TabIndex = 8;
            this.button6.Text = "🗑️";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Delete_Error);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 491);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Фильтры";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.groupBox4);
            this.filterBox.Controls.Add(this.groupBox3);
            this.filterBox.Controls.Add(this.ErrorStatusBox);
            this.filterBox.Controls.Add(this.groupBox2);
            this.filterBox.Controls.Add(this.groupBox1);
            this.filterBox.Controls.Add(this.LevelBox);
            this.filterBox.Controls.Add(this.PriorityBox);
            this.filterBox.Location = new System.Drawing.Point(12, 356);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(826, 129);
            this.filterBox.TabIndex = 10;
            this.filterBox.TabStop = false;
            this.filterBox.Visible = false;
            // 
            // PersonalErrorsCheckBox
            // 
            this.PersonalErrorsCheckBox.AutoSize = true;
            this.PersonalErrorsCheckBox.Location = new System.Drawing.Point(12, 19);
            this.PersonalErrorsCheckBox.Name = "PersonalErrorsCheckBox";
            this.PersonalErrorsCheckBox.Size = new System.Drawing.Size(156, 17);
            this.PersonalErrorsCheckBox.TabIndex = 20;
            this.PersonalErrorsCheckBox.Text = "Отобразить ваши ошибки";
            this.PersonalErrorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SortBox1);
            this.groupBox3.Controls.Add(this.SortBox2);
            this.groupBox3.Location = new System.Drawing.Point(495, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 110);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сортировка по ст.";
            // 
            // SortBox1
            // 
            this.SortBox1.FormattingEnabled = true;
            this.SortBox1.Items.AddRange(new object[] {
            "Нет",
            "Id",
            "Date",
            "ErrorStatus",
            "Priority",
            "Level",
            "Code",
            "Description",
            "UserId",
            "TypeId"});
            this.SortBox1.Location = new System.Drawing.Point(6, 19);
            this.SortBox1.Name = "SortBox1";
            this.SortBox1.Size = new System.Drawing.Size(126, 21);
            this.SortBox1.TabIndex = 15;
            // 
            // SortBox2
            // 
            this.SortBox2.FormattingEnabled = true;
            this.SortBox2.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.SortBox2.Location = new System.Drawing.Point(6, 46);
            this.SortBox2.Name = "SortBox2";
            this.SortBox2.Size = new System.Drawing.Size(126, 21);
            this.SortBox2.TabIndex = 16;
            // 
            // ErrorStatusBox
            // 
            this.ErrorStatusBox.Controls.Add(this.radioButton13);
            this.ErrorStatusBox.Controls.Add(this.radioButton12);
            this.ErrorStatusBox.Controls.Add(this.radioButton11);
            this.ErrorStatusBox.Location = new System.Drawing.Point(276, 13);
            this.ErrorStatusBox.Name = "ErrorStatusBox";
            this.ErrorStatusBox.Size = new System.Drawing.Size(74, 110);
            this.ErrorStatusBox.TabIndex = 18;
            this.ErrorStatusBox.TabStop = false;
            this.ErrorStatusBox.Text = "Статус";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(6, 65);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(57, 17);
            this.radioButton13.TabIndex = 2;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "Closed";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 42);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(51, 17);
            this.radioButton12.TabIndex = 1;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Open";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Checked = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 19);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(36, 17);
            this.radioButton11.TabIndex = 0;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "All";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(356, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 58);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск по коду";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(6, 20);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(121, 20);
            this.CodeTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TypeComboBox);
            this.groupBox1.Location = new System.Drawing.Point(356, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(6, 19);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 0;
            // 
            // LevelBox
            // 
            this.LevelBox.Controls.Add(this.radioButton10);
            this.LevelBox.Controls.Add(this.radioButton9);
            this.LevelBox.Controls.Add(this.radioButton8);
            this.LevelBox.Controls.Add(this.radioButton7);
            this.LevelBox.Controls.Add(this.radioButton6);
            this.LevelBox.Controls.Add(this.radioButton5);
            this.LevelBox.Location = new System.Drawing.Point(103, 13);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(167, 110);
            this.LevelBox.TabIndex = 12;
            this.LevelBox.TabStop = false;
            this.LevelBox.Text = "Уровень";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(36, 17);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "All";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(95, 42);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(66, 17);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.Text = "Blocking";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(95, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(56, 17);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.Text = "Critical";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 87);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(74, 17);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.Text = "Significant";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 64);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(81, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.Text = "Insignificant";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 41);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.Text = "Trivial";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // PriorityBox
            // 
            this.PriorityBox.Controls.Add(this.radioButton4);
            this.PriorityBox.Controls.Add(this.radioButton3);
            this.PriorityBox.Controls.Add(this.radioButton2);
            this.PriorityBox.Controls.Add(this.radioButton1);
            this.PriorityBox.Location = new System.Drawing.Point(6, 13);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(91, 110);
            this.PriorityBox.TabIndex = 11;
            this.PriorityBox.TabStop = false;
            this.PriorityBox.Text = "Приоритет";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 87);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Low";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Medium";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "High";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(294, 36);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(229, 26);
            this.button9.TabIndex = 13;
            this.button9.Text = "Отобразить добавленные вами решения";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PersonalErrorsCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(641, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 104);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Дополнительно";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 526);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.User);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "BugTracking";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_MainMenu);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filterBox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ErrorStatusBox.ResumeLayout(false);
            this.ErrorStatusBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.LevelBox.ResumeLayout(false);
            this.LevelBox.PerformLayout();
            this.PriorityBox.ResumeLayout(false);
            this.PriorityBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button User;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem ошибкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типОшибкиToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.GroupBox PriorityBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox LevelBox;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.ComboBox SortBox1;
        private System.Windows.Forms.ComboBox SortBox2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инфОКомпеToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox ErrorStatusBox;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox PersonalErrorsCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

