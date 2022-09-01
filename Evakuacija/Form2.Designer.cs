namespace Evakuacija
{
    partial class Form2
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
            this.SifEM = new System.Windows.Forms.TextBox();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.DatumEvakuacije = new System.Windows.Forms.TextBox();
            this.BrojStanovnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SifEM
            // 
            this.SifEM.Location = new System.Drawing.Point(111, 32);
            this.SifEM.Name = "SifEM";
            this.SifEM.Size = new System.Drawing.Size(100, 20);
            this.SifEM.TabIndex = 0;
            // 
            // Naziv
            // 
            this.Naziv.Location = new System.Drawing.Point(110, 71);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(100, 20);
            this.Naziv.TabIndex = 1;
            // 
            // DatumEvakuacije
            // 
            this.DatumEvakuacije.Location = new System.Drawing.Point(112, 114);
            this.DatumEvakuacije.Name = "DatumEvakuacije";
            this.DatumEvakuacije.Size = new System.Drawing.Size(100, 20);
            this.DatumEvakuacije.TabIndex = 2;
            // 
            // BrojStanovnika
            // 
            this.BrojStanovnika.Location = new System.Drawing.Point(112, 153);
            this.BrojStanovnika.Name = "BrojStanovnika";
            this.BrojStanovnika.Size = new System.Drawing.Size(98, 20);
            this.BrojStanovnika.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SifEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DatumEvakuacije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj Stanovnika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Upis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrojStanovnika);
            this.Controls.Add(this.DatumEvakuacije);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.SifEM);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox SifEM;
        public System.Windows.Forms.TextBox Naziv;
        public System.Windows.Forms.TextBox DatumEvakuacije;
        public System.Windows.Forms.TextBox BrojStanovnika;
    }
}