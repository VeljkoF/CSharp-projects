namespace Proba
{
    partial class Studenti
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
            this.tbPrikaziStudente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPrikaziStudente
            // 
            this.tbPrikaziStudente.Location = new System.Drawing.Point(0, 0);
            this.tbPrikaziStudente.Multiline = true;
            this.tbPrikaziStudente.Name = "tbPrikaziStudente";
            this.tbPrikaziStudente.ReadOnly = true;
            this.tbPrikaziStudente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPrikaziStudente.Size = new System.Drawing.Size(285, 264);
            this.tbPrikaziStudente.TabIndex = 0;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbPrikaziStudente);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrikaziStudente;

    }
}