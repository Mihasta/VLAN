namespace BugTracking
{
    partial class AddErrorType
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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dbTypeError = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbTypeError)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(133, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(97, 43);
            this.button8.TabIndex = 16;
            this.button8.Text = "ДобавитьТип Ошибки";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(544, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Обновить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dbTypeError
            // 
            this.dbTypeError.AllowUserToAddRows = false;
            this.dbTypeError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTypeError.Location = new System.Drawing.Point(12, 67);
            this.dbTypeError.Name = "dbTypeError";
            this.dbTypeError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbTypeError.Size = new System.Drawing.Size(600, 377);
            this.dbTypeError.TabIndex = 14;
            this.dbTypeError.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbTypeError_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Delete_ErrorType);
            // 
            // AddErrorType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dbTypeError);
            this.Name = "AddErrorType";
            this.Text = "AddErrorType";
            this.Load += new System.EventHandler(this.AddErrorType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbTypeError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dbTypeError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}