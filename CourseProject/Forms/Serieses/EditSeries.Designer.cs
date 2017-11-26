namespace CourseProject.Forms.Serieses
{
    partial class EditSeries
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
            this.ButCancel = new System.Windows.Forms.Button();
            this.ButAddSeries = new System.Windows.Forms.Button();
            this.LabelAuthorSeries = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstBook = new System.Windows.Forms.Label();
            this.LableNameSer = new System.Windows.Forms.Label();
            this.TBAuthor = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(26, 209);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 19;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            // 
            // ButAddSeries
            // 
            this.ButAddSeries.Location = new System.Drawing.Point(166, 210);
            this.ButAddSeries.Name = "ButAddSeries";
            this.ButAddSeries.Size = new System.Drawing.Size(75, 23);
            this.ButAddSeries.TabIndex = 18;
            this.ButAddSeries.Text = "Enter";
            this.ButAddSeries.UseVisualStyleBackColor = true;
            // 
            // LabelAuthorSeries
            // 
            this.LabelAuthorSeries.AutoSize = true;
            this.LabelAuthorSeries.Location = new System.Drawing.Point(22, 179);
            this.LabelAuthorSeries.Name = "LabelAuthorSeries";
            this.LabelAuthorSeries.Size = new System.Drawing.Size(38, 13);
            this.LabelAuthorSeries.TabIndex = 17;
            this.LabelAuthorSeries.Text = "Author";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(23, 129);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(96, 13);
            this.LabelLastName.TabIndex = 16;
            this.LabelLastName.Text = "Last book of series";
            // 
            // LabelFirstBook
            // 
            this.LabelFirstBook.AutoSize = true;
            this.LabelFirstBook.Location = new System.Drawing.Point(20, 80);
            this.LabelFirstBook.Name = "LabelFirstBook";
            this.LabelFirstBook.Size = new System.Drawing.Size(95, 13);
            this.LabelFirstBook.TabIndex = 15;
            this.LabelFirstBook.Text = "First book of series";
            // 
            // LableNameSer
            // 
            this.LableNameSer.AutoSize = true;
            this.LableNameSer.Location = new System.Drawing.Point(19, 28);
            this.LableNameSer.Name = "LableNameSer";
            this.LableNameSer.Size = new System.Drawing.Size(121, 13);
            this.LableNameSer.TabIndex = 14;
            this.LableNameSer.Text = "Name of series of books";
            // 
            // TBAuthor
            // 
            this.TBAuthor.Location = new System.Drawing.Point(166, 173);
            this.TBAuthor.Name = "TBAuthor";
            this.TBAuthor.Size = new System.Drawing.Size(100, 20);
            this.TBAuthor.TabIndex = 13;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(166, 123);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(100, 20);
            this.TBLastName.TabIndex = 12;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(166, 74);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(100, 20);
            this.TBFirstName.TabIndex = 11;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(166, 28);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 10;
            // 
            // EditSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButAddSeries);
            this.Controls.Add(this.LabelAuthorSeries);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstBook);
            this.Controls.Add(this.LableNameSer);
            this.Controls.Add(this.TBAuthor);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.TBName);
            this.Name = "EditSeries";
            this.Text = "EditSeries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.Button ButAddSeries;
        private System.Windows.Forms.Label LabelAuthorSeries;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelFirstBook;
        private System.Windows.Forms.Label LableNameSer;
        private System.Windows.Forms.TextBox TBAuthor;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBName;
    }
}