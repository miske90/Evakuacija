﻿namespace Evakuacija
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lista1 = new System.Windows.Forms.ListBox();
            this.pretraga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ucitaj listu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nov";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Izmeni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(286, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 29);
            this.button4.TabIndex = 3;
            this.button4.Text = "Pretrazi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SifSK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kapacitet";
            // 
            // Lista1
            // 
            this.Lista1.FormattingEnabled = true;
            this.Lista1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Lista1.Location = new System.Drawing.Point(10, 106);
            this.Lista1.MultiColumn = true;
            this.Lista1.Name = "Lista1";
            this.Lista1.Size = new System.Drawing.Size(306, 95);
            this.Lista1.Sorted = true;
            this.Lista1.TabIndex = 7;
            // 
            // pretraga
            // 
            this.pretraga.Location = new System.Drawing.Point(104, 241);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(100, 20);
            this.pretraga.TabIndex = 8;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 308);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.Lista1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Lista1;
        private System.Windows.Forms.TextBox pretraga;

    }
}