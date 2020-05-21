namespace BugTracking
{
    partial class Users
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Editbd = new System.Windows.Forms.GroupBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Editbd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(926, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить Админа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "👤➕";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(84, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "👤🔧";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Edit_User);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(158, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "👤🗑️";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Delete_User);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 454);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Изменить таблицы";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Editbd
            // 
            this.Editbd.Controls.Add(this.checkBox11);
            this.Editbd.Controls.Add(this.checkBox10);
            this.Editbd.Controls.Add(this.checkBox9);
            this.Editbd.Controls.Add(this.checkBox8);
            this.Editbd.Controls.Add(this.checkBox7);
            this.Editbd.Controls.Add(this.checkBox6);
            this.Editbd.Controls.Add(this.checkBox5);
            this.Editbd.Controls.Add(this.checkBox4);
            this.Editbd.Controls.Add(this.checkBox3);
            this.Editbd.Controls.Add(this.checkBox2);
            this.Editbd.Controls.Add(this.checkBox1);
            this.Editbd.Location = new System.Drawing.Point(12, 404);
            this.Editbd.Name = "Editbd";
            this.Editbd.Size = new System.Drawing.Size(926, 44);
            this.Editbd.TabIndex = 7;
            this.Editbd.TabStop = false;
            this.Editbd.Visible = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(549, 19);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(66, 17);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "Ошибки";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(698, 19);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(58, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Лайки";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(621, 19);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(71, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "Решения";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(443, 19);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(112, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Номер телефона";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(381, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(56, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Почта";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(315, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(60, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Статус";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(245, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(64, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Пароль";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(182, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox4.Size = new System.Drawing.Size(57, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Логин";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(101, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(75, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Фамилия";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(47, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Имя";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Id";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(232, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "🔄";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 509);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Editbd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "Users";
            this.Text = "\'";
            this.Load += new System.EventHandler(this.Users_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Users_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Editbd.ResumeLayout(false);
            this.Editbd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox Editbd;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Button button7;
    }
}