namespace BugTracking
{
    partial class SolutionWindow
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.ErrorId = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(546, 369);
            this.textBox1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(9, 18);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(83, 13);
            this.Login.TabIndex = 1;
            this.Login.Text = "Пользователь:";
            // 
            // ErrorId
            // 
            this.ErrorId.AutoSize = true;
            this.ErrorId.Location = new System.Drawing.Point(9, 40);
            this.ErrorId.Name = "ErrorId";
            this.ErrorId.Size = new System.Drawing.Size(60, 13);
            this.ErrorId.TabIndex = 2;
            this.ErrorId.Text = "Id ошибки:";
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Location = new System.Drawing.Point(9, 62);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(93, 13);
            this.UserId.TabIndex = 3;
            this.UserId.Text = "Id пользователя:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(9, 86);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(81, 13);
            this.Date.TabIndex = 4;
            this.Date.Text = "Дата и Время:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Кол-во лайков:";
            // 
            // SolutionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.UserId);
            this.Controls.Add(this.ErrorId);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox1);
            this.Name = "SolutionWindow";
            this.Text = "SolutionWindow";
            this.Load += new System.EventHandler(this.SolutionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label ErrorId;
        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label1;
    }
}