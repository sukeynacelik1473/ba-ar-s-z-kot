namespace başarısız_kot
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lbAdlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(46, 85);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(114, 20);
            this.txtAd.TabIndex = 1;
            // 
            // lbAdlar
            // 
            this.lbAdlar.FormattingEnabled = true;
            this.lbAdlar.Items.AddRange(new object[] {
            "rabia",
            "kubra",
            "sukeyna",
            "hayrunisa",
            "sukeyna",
            "ayşe",
            "elif",
            "ayşe",
            "kubra",
            "hayrunisa",
            "kubra",
            "nisa",
            "deniz",
            "deniz",
            "ayşe"});
            this.lbAdlar.Location = new System.Drawing.Point(46, 164);
            this.lbAdlar.Name = "lbAdlar";
            this.lbAdlar.Size = new System.Drawing.Size(257, 316);
            this.lbAdlar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 525);
            this.Controls.Add(this.lbAdlar);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ListBox lbAdlar;
    }
}

