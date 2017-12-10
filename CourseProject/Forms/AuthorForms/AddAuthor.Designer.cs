namespace CourseProject.Forms.AuthorForms
{
    partial class AddAuthor
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
            this.TBFIOAuthor = new System.Windows.Forms.TextBox();
            this.TBYearAuthor = new System.Windows.Forms.TextBox();
            this.LaberFIOAuthor = new System.Windows.Forms.Label();
            this.LabelYearAuthor = new System.Windows.Forms.Label();
            this.ButAddAuthor = new System.Windows.Forms.Button();
            this.ButCancelAuhtor = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TBFIOAuthor
            // 
            this.TBFIOAuthor.Location = new System.Drawing.Point(104, 40);
            this.TBFIOAuthor.Name = "TBFIOAuthor";
            this.TBFIOAuthor.Size = new System.Drawing.Size(100, 20);
            this.TBFIOAuthor.TabIndex = 0;
            // 
            // TBYearAuthor
            // 
            this.TBYearAuthor.Location = new System.Drawing.Point(104, 84);
            this.TBYearAuthor.Name = "TBYearAuthor";
            this.TBYearAuthor.Size = new System.Drawing.Size(100, 20);
            this.TBYearAuthor.TabIndex = 1;
            // 
            // LaberFIOAuthor
            // 
            this.LaberFIOAuthor.AutoSize = true;
            this.LaberFIOAuthor.Location = new System.Drawing.Point(12, 40);
            this.LaberFIOAuthor.Name = "LaberFIOAuthor";
            this.LaberFIOAuthor.Size = new System.Drawing.Size(24, 13);
            this.LaberFIOAuthor.TabIndex = 2;
            this.LaberFIOAuthor.Text = "FIO";
            // 
            // LabelYearAuthor
            // 
            this.LabelYearAuthor.AutoSize = true;
            this.LabelYearAuthor.Location = new System.Drawing.Point(12, 84);
            this.LabelYearAuthor.Name = "LabelYearAuthor";
            this.LabelYearAuthor.Size = new System.Drawing.Size(60, 13);
            this.LabelYearAuthor.TabIndex = 3;
            this.LabelYearAuthor.Text = "When born";
            // 
            // ButAddAuthor
            // 
            this.ButAddAuthor.Location = new System.Drawing.Point(129, 124);
            this.ButAddAuthor.Name = "ButAddAuthor";
            this.ButAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButAddAuthor.TabIndex = 4;
            this.ButAddAuthor.Text = "Add";
            this.ButAddAuthor.UseVisualStyleBackColor = true;
            this.ButAddAuthor.Click += new System.EventHandler(this.ButAddAuthor_Click);
            // 
            // ButCancelAuhtor
            // 
            this.ButCancelAuhtor.Location = new System.Drawing.Point(12, 124);
            this.ButCancelAuhtor.Name = "ButCancelAuhtor";
            this.ButCancelAuhtor.Size = new System.Drawing.Size(75, 23);
            this.ButCancelAuhtor.TabIndex = 5;
            this.ButCancelAuhtor.Text = "Cancel";
            this.ButCancelAuhtor.UseVisualStyleBackColor = true;
            this.ButCancelAuhtor.Click += new System.EventHandler(this.ButCancelAuhtor_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 178);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ButCancelAuhtor);
            this.Controls.Add(this.ButAddAuthor);
            this.Controls.Add(this.LabelYearAuthor);
            this.Controls.Add(this.LaberFIOAuthor);
            this.Controls.Add(this.TBYearAuthor);
            this.Controls.Add(this.TBFIOAuthor);
            this.Name = "AddAuthor";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBFIOAuthor;
        private System.Windows.Forms.TextBox TBYearAuthor;
        private System.Windows.Forms.Label LaberFIOAuthor;
        private System.Windows.Forms.Label LabelYearAuthor;
        private System.Windows.Forms.Button ButAddAuthor;
        private System.Windows.Forms.Button ButCancelAuhtor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}