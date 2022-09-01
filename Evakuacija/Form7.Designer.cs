namespace Evakuacija
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label7 = new System.Windows.Forms.Label();
            this.SifSK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Naziv = new System.Windows.Forms.TextBox();
            this.Kapacitet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "SifSK";
            // 
            // SifSK
            // 
            this.SifSK.Location = new System.Drawing.Point(110, 22);
            this.SifSK.Name = "SifSK";
            this.SifSK.Size = new System.Drawing.Size(100, 20);
            this.SifSK.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Dodati nov";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Naziv
            // 
            this.Naziv.Location = new System.Drawing.Point(112, 69);
            this.Naziv.Name = "Naziv";
            this.Naziv.Size = new System.Drawing.Size(100, 20);
            this.Naziv.TabIndex = 35;
            // 
            // Kapacitet
            // 
            this.Kapacitet.Location = new System.Drawing.Point(111, 109);
            this.Kapacitet.Name = "Kapacitet";
            this.Kapacitet.Size = new System.Drawing.Size(100, 20);
            this.Kapacitet.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Kapacitet";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kapacitet);
            this.Controls.Add(this.Naziv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SifSK);
            this.Controls.Add(this.label7);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox SifSK;
        public System.Windows.Forms.TextBox Naziv;
        public System.Windows.Forms.TextBox Kapacitet;
    }
}