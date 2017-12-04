namespace CourseProject.Forms.ReaderForms
{
    partial class EditReader
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
            this.ButEditReader = new System.Windows.Forms.Button();
            this.LabelTelephonereader = new System.Windows.Forms.Label();
            this.LabelAddressReader = new System.Windows.Forms.Label();
            this.LabelFioReader = new System.Windows.Forms.Label();
            this.TBTelephone = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.TBFio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(23, 172);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 15;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            this.ButCancel.Click += new System.EventHandler(this.ButCancel_Click);
            // 
            // ButEditReader
            // 
            this.ButEditReader.Location = new System.Drawing.Point(129, 172);
            this.ButEditReader.Name = "ButEditReader";
            this.ButEditReader.Size = new System.Drawing.Size(75, 23);
            this.ButEditReader.TabIndex = 14;
            this.ButEditReader.Text = "Edit";
            this.ButEditReader.UseVisualStyleBackColor = true;
            this.ButEditReader.Click += new System.EventHandler(this.ButEditReader_Click);
            // 
            // LabelTelephonereader
            // 
            this.LabelTelephonereader.AutoSize = true;
            this.LabelTelephonereader.Location = new System.Drawing.Point(20, 129);
            this.LabelTelephonereader.Name = "LabelTelephonereader";
            this.LabelTelephonereader.Size = new System.Drawing.Size(58, 13);
            this.LabelTelephonereader.TabIndex = 13;
            this.LabelTelephonereader.Text = "Telephone";
            // 
            // LabelAddressReader
            // 
            this.LabelAddressReader.AutoSize = true;
            this.LabelAddressReader.Location = new System.Drawing.Point(20, 77);
            this.LabelAddressReader.Name = "LabelAddressReader";
            this.LabelAddressReader.Size = new System.Drawing.Size(45, 13);
            this.LabelAddressReader.TabIndex = 12;
            this.LabelAddressReader.Text = "Address";
            // 
            // LabelFioReader
            // 
            this.LabelFioReader.AutoSize = true;
            this.LabelFioReader.Location = new System.Drawing.Point(20, 21);
            this.LabelFioReader.Name = "LabelFioReader";
            this.LabelFioReader.Size = new System.Drawing.Size(24, 13);
            this.LabelFioReader.TabIndex = 11;
            this.LabelFioReader.Text = "FIO";
            // 
            // TBTelephone
            // 
            this.TBTelephone.Location = new System.Drawing.Point(104, 122);
            this.TBTelephone.Name = "TBTelephone";
            this.TBTelephone.Size = new System.Drawing.Size(100, 20);
            this.TBTelephone.TabIndex = 10;
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(104, 70);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(100, 20);
            this.TBAddress.TabIndex = 9;
            // 
            // TBFio
            // 
            this.TBFio.Location = new System.Drawing.Point(104, 15);
            this.TBFio.Name = "TBFio";
            this.TBFio.Size = new System.Drawing.Size(100, 20);
            this.TBFio.TabIndex = 8;
            // 
            // EditReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 209);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButEditReader);
            this.Controls.Add(this.LabelTelephonereader);
            this.Controls.Add(this.LabelAddressReader);
            this.Controls.Add(this.LabelFioReader);
            this.Controls.Add(this.TBTelephone);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBFio);
            this.Name = "EditReader";
            this.Text = "EditReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButCancel;
        private System.Windows.Forms.Button ButEditReader;
        private System.Windows.Forms.Label LabelTelephonereader;
        private System.Windows.Forms.Label LabelAddressReader;
        private System.Windows.Forms.Label LabelFioReader;
        private System.Windows.Forms.TextBox TBTelephone;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.TextBox TBFio;
    }
}