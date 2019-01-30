namespace Softwer
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
            this.btnCitajBazu = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.gbNoviSoftwer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbGodinaIzdanja = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gbNoviSoftwer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCitajBazu
            // 
            this.btnCitajBazu.Location = new System.Drawing.Point(38, 30);
            this.btnCitajBazu.Name = "btnCitajBazu";
            this.btnCitajBazu.Size = new System.Drawing.Size(75, 23);
            this.btnCitajBazu.TabIndex = 0;
            this.btnCitajBazu.Text = "Citaj Bazu";
            this.btnCitajBazu.UseVisualStyleBackColor = true;
            this.btnCitajBazu.Click += new System.EventHandler(this.btnCitajBazu_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(142, 30);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // gbNoviSoftwer
            // 
            this.gbNoviSoftwer.Controls.Add(this.btnDodaj);
            this.gbNoviSoftwer.Controls.Add(this.tbGodinaIzdanja);
            this.gbNoviSoftwer.Controls.Add(this.tbNaziv);
            this.gbNoviSoftwer.Controls.Add(this.label2);
            this.gbNoviSoftwer.Controls.Add(this.label1);
            this.gbNoviSoftwer.Location = new System.Drawing.Point(29, 70);
            this.gbNoviSoftwer.Name = "gbNoviSoftwer";
            this.gbNoviSoftwer.Size = new System.Drawing.Size(200, 152);
            this.gbNoviSoftwer.TabIndex = 2;
            this.gbNoviSoftwer.TabStop = false;
            this.gbNoviSoftwer.Text = "Nov softwer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Godina izdranja: ";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(88, 25);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 2;
            // 
            // tbGodinaIzdanja
            // 
            this.tbGodinaIzdanja.Location = new System.Drawing.Point(113, 61);
            this.tbGodinaIzdanja.Name = "tbGodinaIzdanja";
            this.tbGodinaIzdanja.Size = new System.Drawing.Size(75, 20);
            this.tbGodinaIzdanja.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(113, 104);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbNoviSoftwer);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.btnCitajBazu);
            this.Name = "Form1";
            this.Text = "Softver";
            this.gbNoviSoftwer.ResumeLayout(false);
            this.gbNoviSoftwer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCitajBazu;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox gbNoviSoftwer;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbGodinaIzdanja;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

