namespace BugTracking
{
    partial class EditTextType
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
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название типа ошбки";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(179, 50);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(56, 50);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(95, 23);
            this.back.TabIndex = 3;
            this.back.Text = "Отмена";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // EditTextType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 88);
            this.Controls.Add(this.back);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTextType";
            this.Text = "TextType";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditTextType_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button back;
    }
}