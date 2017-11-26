namespace CourseProject.Forms.AuthorForms
{
    partial class EditAuthor
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
            this.ButCancelAuhtor = new System.Windows.Forms.Button();
            this.ButAddAuthor = new System.Windows.Forms.Button();
            this.LabelYearAuthor = new System.Windows.Forms.Label();
            this.LaberFIOAuthor = new System.Windows.Forms.Label();
            this.TBYearAuthor = new System.Windows.Forms.TextBox();
            this.TBFIOAuthor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButCancelAuhtor
            // 
            this.ButCancelAuhtor.Location = new System.Drawing.Point(19, 106);
            this.ButCancelAuhtor.Name = "ButCancelAuhtor";
            this.ButCancelAuhtor.Size = new System.Drawing.Size(75, 23);
            this.ButCancelAuhtor.TabIndex = 11;
            this.ButCancelAuhtor.Text = "Cancel";
            this.ButCancelAuhtor.UseVisualStyleBackColor = true;
            // 
            // ButAddAuthor
            // 
            this.ButAddAuthor.Location = new System.Drawing.Point(136, 106);
            this.ButAddAuthor.Name = "ButAddAuthor";
            this.ButAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.ButAddAuthor.TabIndex = 10;
            this.ButAddAuthor.Text = "Add";
            this.ButAddAuthor.UseVisualStyleBackColor = true;
            // 
            // LabelYearAuthor
            // 
            this.LabelYearAuthor.AutoSize = true;
            this.LabelYearAuthor.Location = new System.Drawing.Point(19, 66);
            this.LabelYearAuthor.Name = "LabelYearAuthor";
            this.LabelYearAuthor.Size = new System.Drawing.Size(60, 13);
            this.LabelYearAuthor.TabIndex = 9;
            this.LabelYearAuthor.Text = "When born";
            // 
            // LaberFIOAuthor
            // 
            this.LaberFIOAuthor.AutoSize = true;
            this.LaberFIOAuthor.Location = new System.Drawing.Point(19, 22);
            this.LaberFIOAuthor.Name = "LaberFIOAuthor";
            this.LaberFIOAuthor.Size = new System.Drawing.Size(24, 13);
            this.LaberFIOAuthor.TabIndex = 8;
            this.LaberFIOAuthor.Text = "FIO";
            // 
            // TBYearAuthor
            // 
            this.TBYearAuthor.Location = new System.Drawing.Point(111, 66);
            this.TBYearAuthor.Name = "TBYearAuthor";
            this.TBYearAuthor.Size = new System.Drawing.Size(100, 20);
            this.TBYearAuthor.TabIndex = 7;
            // 
            // TBFIOAuthor
            // 
            this.TBFIOAuthor.Location = new System.Drawing.Point(111, 22);
            this.TBFIOAuthor.Name = "TBFIOAuthor";
            this.TBFIOAuthor.Size = new System.Drawing.Size(100, 20);
            this.TBFIOAuthor.TabIndex = 6;
            // 
            // EditAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 155);
            this.Controls.Add(this.ButCancelAuhtor);
            this.Controls.Add(this.ButAddAuthor);
            this.Controls.Add(this.LabelYearAuthor);
            this.Controls.Add(this.LaberFIOAuthor);
            this.Controls.Add(this.TBYearAuthor);
            this.Controls.Add(this.TBFIOAuthor);
            this.Name = "EditAuthor";
            this.Text = "EditAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButCancelAuhtor;
        private System.Windows.Forms.Button ButAddAuthor;
        private System.Windows.Forms.Label LabelYearAuthor;
        private System.Windows.Forms.Label LaberFIOAuthor;
        private System.Windows.Forms.TextBox TBYearAuthor;
        private System.Windows.Forms.TextBox TBFIOAuthor;
    }
}