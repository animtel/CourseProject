namespace CourseProject.Forms.FreeSQLRequestForm
{
    partial class FreeSQLRequests
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
            this.TestInput = new System.Windows.Forms.RichTextBox();
            this.do_sql = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TestInput
            // 
            this.TestInput.Location = new System.Drawing.Point(19, 25);
            this.TestInput.Name = "TestInput";
            this.TestInput.Size = new System.Drawing.Size(473, 160);
            this.TestInput.TabIndex = 0;
            this.TestInput.Text = "SELECT";
            // 
            // do_sql
            // 
            this.do_sql.Location = new System.Drawing.Point(524, 25);
            this.do_sql.Name = "do_sql";
            this.do_sql.Size = new System.Drawing.Size(106, 24);
            this.do_sql.TabIndex = 1;
            this.do_sql.Text = "Do SQL";
            this.do_sql.UseVisualStyleBackColor = true;
            this.do_sql.Click += new System.EventHandler(this.do_sql_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(19, 191);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.Size = new System.Drawing.Size(650, 222);
            this.resultsDataGridView.TabIndex = 2;
            // 
            // FreeSQLRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 438);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.do_sql);
            this.Controls.Add(this.TestInput);
            this.Name = "FreeSQLRequests";
            this.Text = "FreeSQLRequests";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TestInput;
        private System.Windows.Forms.Button do_sql;
        private System.Windows.Forms.DataGridView resultsDataGridView;
    }
}