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
            this.Add1TypeError = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.dbTypeError = new System.Windows.Forms.DataGridView();
            this.EditTypeError = new System.Windows.Forms.Button();
            this.DelTypeError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbTypeError)).BeginInit();
            this.SuspendLayout();
            // 
            // Add1TypeError
            // 
            this.Add1TypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add1TypeError.Location = new System.Drawing.Point(156, 18);
            this.Add1TypeError.Name = "Add1TypeError";
            this.Add1TypeError.Size = new System.Drawing.Size(138, 43);
            this.Add1TypeError.TabIndex = 16;
            this.Add1TypeError.Text = "➕";
            this.Add1TypeError.UseVisualStyleBackColor = true;
            this.Add1TypeError.Click += new System.EventHandler(this.button8_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(444, 18);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(138, 43);
            this.refresh.TabIndex = 15;
            this.refresh.Text = "🔄";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.button7_Click);
            // 
            // dbTypeError
            // 
            this.dbTypeError.AllowUserToAddRows = false;
            this.dbTypeError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTypeError.Location = new System.Drawing.Point(12, 67);
            this.dbTypeError.Name = "dbTypeError";
            this.dbTypeError.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbTypeError.Size = new System.Drawing.Size(570, 377);
            this.dbTypeError.TabIndex = 14;
            this.dbTypeError.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbTypeError_CellContentClick);
            // 
            // EditTypeError
            // 
            this.EditTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTypeError.Location = new System.Drawing.Point(12, 18);
            this.EditTypeError.Name = "EditTypeError";
            this.EditTypeError.Size = new System.Drawing.Size(138, 43);
            this.EditTypeError.TabIndex = 17;
            this.EditTypeError.Text = "🔧";
            this.EditTypeError.UseVisualStyleBackColor = true;
            this.EditTypeError.Click += new System.EventHandler(this.button1_Click);
            // 
            // DelTypeError
            // 
            this.DelTypeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelTypeError.Location = new System.Drawing.Point(300, 18);
            this.DelTypeError.Name = "DelTypeError";
            this.DelTypeError.Size = new System.Drawing.Size(138, 43);
            this.DelTypeError.TabIndex = 18;
            this.DelTypeError.Text = "🗑️";
            this.DelTypeError.UseVisualStyleBackColor = true;
            this.DelTypeError.Click += new System.EventHandler(this.Delete_ErrorType);
            // 
            // AddErrorType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 453);
            this.Controls.Add(this.DelTypeError);
            this.Controls.Add(this.EditTypeError);
            this.Controls.Add(this.Add1TypeError);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dbTypeError);
            this.KeyPreview = true;
            this.Name = "AddErrorType";
            this.Text = "AddErrorType";
            this.Load += new System.EventHandler(this.AddErrorType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddErrorType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dbTypeError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Add1TypeError;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView dbTypeError;
        private System.Windows.Forms.Button EditTypeError;
        private System.Windows.Forms.Button DelTypeError;
    }
}