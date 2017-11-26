namespace CourseProject.Forms.ReaderForms
{
    partial class AddReader
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
            this.TBFio = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.TBTelephone = new System.Windows.Forms.TextBox();
            this.LabelFioReader = new System.Windows.Forms.Label();
            this.LabelAddressReader = new System.Windows.Forms.Label();
            this.LabelTelephonereader = new System.Windows.Forms.Label();
            this.ButAddReader = new System.Windows.Forms.Button();
            this.ButCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBFio
            // 
            this.TBFio.Location = new System.Drawing.Point(111, 40);
            this.TBFio.Name = "TBFio";
            this.TBFio.Size = new System.Drawing.Size(100, 20);
            this.TBFio.TabIndex = 0;
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(111, 95);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(100, 20);
            this.TBAddress.TabIndex = 1;
            // 
            // TBTelephone
            // 
            this.TBTelephone.Location = new System.Drawing.Point(111, 147);
            this.TBTelephone.Name = "TBTelephone";
            this.TBTelephone.Size = new System.Drawing.Size(100, 20);
            this.TBTelephone.TabIndex = 2;
            // 
            // LabelFioReader
            // 
            this.LabelFioReader.AutoSize = true;
            this.LabelFioReader.Location = new System.Drawing.Point(27, 46);
            this.LabelFioReader.Name = "LabelFioReader";
            this.LabelFioReader.Size = new System.Drawing.Size(24, 13);
            this.LabelFioReader.TabIndex = 3;
            this.LabelFioReader.Text = "FIO";
            // 
            // LabelAddressReader
            // 
            this.LabelAddressReader.AutoSize = true;
            this.LabelAddressReader.Location = new System.Drawing.Point(27, 102);
            this.LabelAddressReader.Name = "LabelAddressReader";
            this.LabelAddressReader.Size = new System.Drawing.Size(45, 13);
            this.LabelAddressReader.TabIndex = 4;
            this.LabelAddressReader.Text = "Address";
            // 
            // LabelTelephonereader
            // 
            this.LabelTelephonereader.AutoSize = true;
            this.LabelTelephonereader.Location = new System.Drawing.Point(27, 154);
            this.LabelTelephonereader.Name = "LabelTelephonereader";
            this.LabelTelephonereader.Size = new System.Drawing.Size(58, 13);
            this.LabelTelephonereader.TabIndex = 5;
            this.LabelTelephonereader.Text = "Telephone";
            // 
            // ButAddReader
            // 
            this.ButAddReader.Location = new System.Drawing.Point(136, 197);
            this.ButAddReader.Name = "ButAddReader";
            this.ButAddReader.Size = new System.Drawing.Size(75, 23);
            this.ButAddReader.TabIndex = 6;
            this.ButAddReader.Text = "Add";
            this.ButAddReader.UseVisualStyleBackColor = true;
            // 
            // ButCancel
            // 
            this.ButCancel.Location = new System.Drawing.Point(30, 197);
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(75, 23);
            this.ButCancel.TabIndex = 7;
            this.ButCancel.Text = "Cancel";
            this.ButCancel.UseVisualStyleBackColor = true;
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 234);
            this.Controls.Add(this.ButCancel);
            this.Controls.Add(this.ButAddReader);
            this.Controls.Add(this.LabelTelephonereader);
            this.Controls.Add(this.LabelAddressReader);
            this.Controls.Add(this.LabelFioReader);
            this.Controls.Add(this.TBTelephone);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBFio);
            this.Name = "AddReader";
            this.Text = "AddReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBFio;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.TextBox TBTelephone;
        private System.Windows.Forms.Label LabelFioReader;
        private System.Windows.Forms.Label LabelAddressReader;
        private System.Windows.Forms.Label LabelTelephonereader;
        private System.Windows.Forms.Button ButAddReader;
        private System.Windows.Forms.Button ButCancel;
    }
}