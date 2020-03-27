namespace BugTracking
{
    partial class ErrorWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserString = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.Label();
            this.Priority = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UserString);
            this.tabPage1.Controls.Add(this.Description);
            this.tabPage1.Controls.Add(this.DescriptionTextBox);
            this.tabPage1.Controls.Add(this.Type);
            this.tabPage1.Controls.Add(this.Level);
            this.tabPage1.Controls.Add(this.Code);
            this.tabPage1.Controls.Add(this.Priority);
            this.tabPage1.Controls.Add(this.Date);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сведения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UserString
            // 
            this.UserString.AutoSize = true;
            this.UserString.Location = new System.Drawing.Point(6, 156);
            this.UserString.Name = "UserString";
            this.UserString.Size = new System.Drawing.Size(83, 13);
            this.UserString.TabIndex = 8;
            this.UserString.Text = "Пользователь:";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(6, 195);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 7;
            this.Description.Text = "Описание:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 211);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(756, 183);
            this.DescriptionTextBox.TabIndex = 6;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(6, 39);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(29, 13);
            this.Type.TabIndex = 5;
            this.Type.Text = "Тип:";
            // 
            // Level
            // 
            this.Level.AutoSize = true;
            this.Level.Location = new System.Drawing.Point(6, 91);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(54, 13);
            this.Level.TabIndex = 4;
            this.Level.Text = "Уровень:";
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(6, 13);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(29, 13);
            this.Code.TabIndex = 3;
            this.Code.Text = "Код:";
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.Location = new System.Drawing.Point(6, 65);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(64, 13);
            this.Priority.TabIndex = 2;
            this.Priority.Text = "Приоритет:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(6, 116);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(99, 13);
            this.Date.TabIndex = 1;
            this.Date.Text = "Дата добавления:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Решения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить решение";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Редактировать решение";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(687, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить решение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // ErrorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ErrorWindow";
            this.Text = "ErrorWindow";
            this.Load += new System.EventHandler(this.ErrorWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label Priority;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label UserString;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox DescriptionTextBox;
    }
}