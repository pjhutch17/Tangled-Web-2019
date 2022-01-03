namespace Tangled_Web_2019
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.ComboBox();
            this.Load_WebPage = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // txt_Address
            // 
            this.txt_Address.FormattingEnabled = true;
            this.txt_Address.Location = new System.Drawing.Point(109, 9);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(478, 21);
            this.txt_Address.TabIndex = 1;
            this.txt_Address.TextUpdate += new System.EventHandler(this.txt_Address_TextUpdate);
            this.txt_Address.Enter += new System.EventHandler(this.txt_Address_Enter);
            // 
            // Load_WebPage
            // 
            this.Load_WebPage.Location = new System.Drawing.Point(603, 7);
            this.Load_WebPage.Name = "Load_WebPage";
            this.Load_WebPage.Size = new System.Drawing.Size(50, 23);
            this.Load_WebPage.TabIndex = 2;
            this.Load_WebPage.Text = "Go";
            this.Load_WebPage.UseVisualStyleBackColor = true;
            this.Load_WebPage.Click += new System.EventHandler(this.Load_WebPage_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 46);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1064, 625);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("http://www.bing.com", System.UriKind.Absolute);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(276, 208);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(250, 250);
            this.webBrowser2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 687);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Load_WebPage);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tangled Web";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_Address;
        private System.Windows.Forms.Button Load_WebPage;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}

