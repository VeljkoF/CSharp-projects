namespace Softwer
{
    partial class Dijalog
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
            this.tbIgre = new System.Windows.Forms.TextBox();
            this.tbSoftwer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIgre
            // 
            this.tbIgre.Location = new System.Drawing.Point(-2, 0);
            this.tbIgre.Multiline = true;
            this.tbIgre.Name = "tbIgre";
            this.tbIgre.ReadOnly = true;
            this.tbIgre.Size = new System.Drawing.Size(287, 120);
            this.tbIgre.TabIndex = 0;
            // 
            // tbSoftwer
            // 
            this.tbSoftwer.Location = new System.Drawing.Point(-2, 143);
            this.tbSoftwer.Multiline = true;
            this.tbSoftwer.Name = "tbSoftwer";
            this.tbSoftwer.ReadOnly = true;
            this.tbSoftwer.Size = new System.Drawing.Size(287, 117);
            this.tbSoftwer.TabIndex = 1;
            // 
            // Dijalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbSoftwer);
            this.Controls.Add(this.tbIgre);
            this.Name = "Dijalog";
            this.Text = "Dijalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIgre;
        private System.Windows.Forms.TextBox tbSoftwer;
    }
}