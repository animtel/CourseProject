namespace CourseProject.Forms.CheckForms
{
    partial class AddCheck
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
            this.CBBookID = new System.Windows.Forms.ComboBox();
            this.CBReader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBBookID
            // 
            this.CBBookID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBookID.FormattingEnabled = true;
            this.CBBookID.Location = new System.Drawing.Point(124, 46);
            this.CBBookID.Name = "CBBookID";
            this.CBBookID.Size = new System.Drawing.Size(121, 21);
            this.CBBookID.TabIndex = 0;
            // 
            // CBReader
            // 
            this.CBReader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBReader.FormattingEnabled = true;
            this.CBReader.Location = new System.Drawing.Point(124, 111);
            this.CBReader.Name = "CBReader";
            this.CBReader.Size = new System.Drawing.Size(121, 21);
            this.CBReader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id of book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reader";
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(124, 205);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(75, 23);
            this.ButAdd.TabIndex = 4;
            this.ButAdd.Text = "Add";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(19, 204);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 5;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBReader);
            this.Controls.Add(this.CBBookID);
            this.Name = "AddCheck";
            this.Text = "AddCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBBookID;
        private System.Windows.Forms.ComboBox CBReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButCancel;
    }
}