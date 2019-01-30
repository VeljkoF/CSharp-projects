namespace Proba
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
            this.btnObrisiOsobe = new System.Windows.Forms.Button();
            this.btnPrikaziStudente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCitajBazu
            // 
            this.btnCitajBazu.Location = new System.Drawing.Point(42, 23);
            this.btnCitajBazu.Name = "btnCitajBazu";
            this.btnCitajBazu.Size = new System.Drawing.Size(121, 23);
            this.btnCitajBazu.TabIndex = 0;
            this.btnCitajBazu.Text = "Citaj bazu...";
            this.btnCitajBazu.UseVisualStyleBackColor = true;
            this.btnCitajBazu.Click += new System.EventHandler(this.btnCitajBazu_Click);
            // 
            // btnObrisiOsobe
            // 
            this.btnObrisiOsobe.AutoSize = true;
            this.btnObrisiOsobe.Location = new System.Drawing.Point(42, 52);
            this.btnObrisiOsobe.Name = "btnObrisiOsobe";
            this.btnObrisiOsobe.Size = new System.Drawing.Size(121, 23);
            this.btnObrisiOsobe.TabIndex = 1;
            this.btnObrisiOsobe.Text = "Obrisi osobe";
            this.btnObrisiOsobe.UseVisualStyleBackColor = true;
            this.btnObrisiOsobe.Click += new System.EventHandler(this.btnObrisiOsobe_Click);
            // 
            // btnPrikaziStudente
            // 
            this.btnPrikaziStudente.AutoSize = true;
            this.btnPrikaziStudente.Location = new System.Drawing.Point(42, 81);
            this.btnPrikaziStudente.Name = "btnPrikaziStudente";
            this.btnPrikaziStudente.Size = new System.Drawing.Size(121, 23);
            this.btnPrikaziStudente.TabIndex = 2;
            this.btnPrikaziStudente.Text = "Prikazi studente";
            this.btnPrikaziStudente.UseVisualStyleBackColor = true;
            this.btnPrikaziStudente.Click += new System.EventHandler(this.btnPrikaziStudente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 125);
            this.Controls.Add(this.btnPrikaziStudente);
            this.Controls.Add(this.btnObrisiOsobe);
            this.Controls.Add(this.btnCitajBazu);
            this.Name = "Form1";
            this.Text = "Osobe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCitajBazu;
        private System.Windows.Forms.Button btnObrisiOsobe;
        private System.Windows.Forms.Button btnPrikaziStudente;
    }
}

