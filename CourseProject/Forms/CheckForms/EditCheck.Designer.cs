namespace CourseProject.Forms.CheckForms
{
    partial class EditCheck
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
            this.CBBook = new System.Windows.Forms.ComboBox();
            this.CBReader = new System.Windows.Forms.ComboBox();
            this.ButChange = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBBook
            // 
            this.CBBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBook.FormattingEnabled = true;
            this.CBBook.Location = new System.Drawing.Point(122, 44);
            this.CBBook.Name = "CBBook";
            this.CBBook.Size = new System.Drawing.Size(121, 21);
            this.CBBook.TabIndex = 0;
            // 
            // CBReader
            // 
            this.CBReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBReader.FormattingEnabled = true;
            this.CBReader.Location = new System.Drawing.Point(122, 118);
            this.CBReader.Name = "CBReader";
            this.CBReader.Size = new System.Drawing.Size(121, 21);
            this.CBReader.TabIndex = 1;
            // 
            // ButChange
            // 
            this.ButChange.Location = new System.Drawing.Point(149, 206);
            this.ButChange.Name = "ButChange";
            this.ButChange.Size = new System.Drawing.Size(75, 23);
            this.ButChange.TabIndex = 2;
            this.ButChange.Text = "Edit";
            this.ButChange.UseVisualStyleBackColor = true;
            this.ButChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(13, 206);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 3;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id of book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reader";
            // 
            // EditCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButChange);
            this.Controls.Add(this.CBReader);
            this.Controls.Add(this.CBBook);
            this.Name = "EditCheck";
            this.Text = "EditCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBBook;
        private System.Windows.Forms.ComboBox CBReader;
        private System.Windows.Forms.Button ButChange;
        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}