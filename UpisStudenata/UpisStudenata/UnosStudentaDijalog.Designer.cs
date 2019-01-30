namespace UpisStudenata
{
    partial class UnosStudentaDijalog
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
            System.Windows.Forms.Label lIme;
            System.Windows.Forms.Label lPrezime;
            System.Windows.Forms.Label lDatumRodjenja;
            System.Windows.Forms.Label lStudiskiProgram;
            System.Windows.Forms.Label lEspb;
            System.Windows.Forms.Label lBrojIndex;
            System.Windows.Forms.Label lNaslovUnosStudenta;
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.ddlStudiskiProgram = new System.Windows.Forms.ComboBox();
            this.gbStatusFinansiranje = new System.Windows.Forms.GroupBox();
            this.rbSamofinansiranje = new System.Windows.Forms.RadioButton();
            this.rbBudzet = new System.Windows.Forms.RadioButton();
            this.nudEspb = new System.Windows.Forms.NumericUpDown();
            this.mtbIndex = new System.Windows.Forms.MaskedTextBox();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            lIme = new System.Windows.Forms.Label();
            lPrezime = new System.Windows.Forms.Label();
            lDatumRodjenja = new System.Windows.Forms.Label();
            lStudiskiProgram = new System.Windows.Forms.Label();
            lEspb = new System.Windows.Forms.Label();
            lBrojIndex = new System.Windows.Forms.Label();
            lNaslovUnosStudenta = new System.Windows.Forms.Label();
            this.gbStatusFinansiranje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspb)).BeginInit();
            this.SuspendLayout();
            // 
            // lIme
            // 
            lIme.AutoSize = true;
            lIme.Location = new System.Drawing.Point(22, 78);
            lIme.Name = "lIme";
            lIme.Size = new System.Drawing.Size(30, 13);
            lIme.TabIndex = 1;
            lIme.Text = "Ime: ";
            // 
            // lPrezime
            // 
            lPrezime.AutoSize = true;
            lPrezime.Location = new System.Drawing.Point(22, 105);
            lPrezime.Name = "lPrezime";
            lPrezime.Size = new System.Drawing.Size(50, 13);
            lPrezime.TabIndex = 2;
            lPrezime.Text = "Prezime: ";
            // 
            // lDatumRodjenja
            // 
            lDatumRodjenja.AutoSize = true;
            lDatumRodjenja.Location = new System.Drawing.Point(22, 132);
            lDatumRodjenja.Name = "lDatumRodjenja";
            lDatumRodjenja.Size = new System.Drawing.Size(80, 13);
            lDatumRodjenja.TabIndex = 5;
            lDatumRodjenja.Text = "Datum rođenja:";
            // 
            // lStudiskiProgram
            // 
            lStudiskiProgram.AutoSize = true;
            lStudiskiProgram.Location = new System.Drawing.Point(22, 157);
            lStudiskiProgram.Name = "lStudiskiProgram";
            lStudiskiProgram.Size = new System.Drawing.Size(88, 13);
            lStudiskiProgram.TabIndex = 7;
            lStudiskiProgram.Text = "Studiski program:";
            // 
            // lEspb
            // 
            lEspb.AutoSize = true;
            lEspb.Location = new System.Drawing.Point(22, 284);
            lEspb.Name = "lEspb";
            lEspb.Size = new System.Drawing.Size(78, 13);
            lEspb.TabIndex = 10;
            lEspb.Text = "Priznati ESPB: ";
            // 
            // lBrojIndex
            // 
            lBrojIndex.AutoSize = true;
            lBrojIndex.Location = new System.Drawing.Point(22, 53);
            lBrojIndex.Name = "lBrojIndex";
            lBrojIndex.Size = new System.Drawing.Size(62, 13);
            lBrojIndex.TabIndex = 12;
            lBrojIndex.Text = "Broj indexa:";
            // 
            // lNaslovUnosStudenta
            // 
            lNaslovUnosStudenta.AutoSize = true;
            lNaslovUnosStudenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lNaslovUnosStudenta.Location = new System.Drawing.Point(22, 14);
            lNaslovUnosStudenta.Name = "lNaslovUnosStudenta";
            lNaslovUnosStudenta.Size = new System.Drawing.Size(185, 17);
            lNaslovUnosStudenta.TabIndex = 13;
            lNaslovUnosStudenta.Text = "Unesite novog studenta:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(118, 76);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(166, 20);
            this.tbIme.TabIndex = 2;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(118, 102);
            this.tbPrezime.Multiline = true;
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(166, 20);
            this.tbPrezime.TabIndex = 3;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDatumRodjenja.CustomFormat = "d.M.yyyy.";
            this.dtpDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(118, 128);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(166, 20);
            this.dtpDatumRodjenja.TabIndex = 4;
            // 
            // ddlStudiskiProgram
            // 
            this.ddlStudiskiProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStudiskiProgram.FormattingEnabled = true;
            this.ddlStudiskiProgram.Items.AddRange(new object[] {
            "Izaberi...",
            "Internet tehnologije",
            "Telekomunikacije",
            "Poštansko bankarske usluge"});
            this.ddlStudiskiProgram.Location = new System.Drawing.Point(118, 154);
            this.ddlStudiskiProgram.Name = "ddlStudiskiProgram";
            this.ddlStudiskiProgram.Size = new System.Drawing.Size(166, 21);
            this.ddlStudiskiProgram.TabIndex = 5;
            this.ddlStudiskiProgram.Tag = "";
            // 
            // gbStatusFinansiranje
            // 
            this.gbStatusFinansiranje.Controls.Add(this.rbSamofinansiranje);
            this.gbStatusFinansiranje.Controls.Add(this.rbBudzet);
            this.gbStatusFinansiranje.Location = new System.Drawing.Point(75, 192);
            this.gbStatusFinansiranje.Name = "gbStatusFinansiranje";
            this.gbStatusFinansiranje.Size = new System.Drawing.Size(147, 74);
            this.gbStatusFinansiranje.TabIndex = 6;
            this.gbStatusFinansiranje.TabStop = false;
            this.gbStatusFinansiranje.Text = "Status finansiranja: ";
            // 
            // rbSamofinansiranje
            // 
            this.rbSamofinansiranje.AutoSize = true;
            this.rbSamofinansiranje.Location = new System.Drawing.Point(25, 44);
            this.rbSamofinansiranje.Name = "rbSamofinansiranje";
            this.rbSamofinansiranje.Size = new System.Drawing.Size(105, 17);
            this.rbSamofinansiranje.TabIndex = 2;
            this.rbSamofinansiranje.TabStop = true;
            this.rbSamofinansiranje.Text = "Samofinansiranje";
            this.rbSamofinansiranje.UseVisualStyleBackColor = true;
            // 
            // rbBudzet
            // 
            this.rbBudzet.AutoSize = true;
            this.rbBudzet.Location = new System.Drawing.Point(25, 21);
            this.rbBudzet.Name = "rbBudzet";
            this.rbBudzet.Size = new System.Drawing.Size(58, 17);
            this.rbBudzet.TabIndex = 1;
            this.rbBudzet.TabStop = true;
            this.rbBudzet.Text = "Budžet";
            this.rbBudzet.UseVisualStyleBackColor = true;
            // 
            // nudEspb
            // 
            this.nudEspb.Location = new System.Drawing.Point(118, 282);
            this.nudEspb.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudEspb.Name = "nudEspb";
            this.nudEspb.Size = new System.Drawing.Size(104, 20);
            this.nudEspb.TabIndex = 7;
            // 
            // mtbIndex
            // 
            this.mtbIndex.Location = new System.Drawing.Point(118, 50);
            this.mtbIndex.Mask = "###\\/####";
            this.mtbIndex.Name = "mtbIndex";
            this.mtbIndex.Size = new System.Drawing.Size(166, 20);
            this.mtbIndex.TabIndex = 1;
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrihvati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrihvati.Location = new System.Drawing.Point(109, 329);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(80, 30);
            this.btnPrihvati.TabIndex = 8;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(205, 329);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 30);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // UnosStudentaDijalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 380);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(lNaslovUnosStudenta);
            this.Controls.Add(this.mtbIndex);
            this.Controls.Add(lBrojIndex);
            this.Controls.Add(this.nudEspb);
            this.Controls.Add(lEspb);
            this.Controls.Add(this.gbStatusFinansiranje);
            this.Controls.Add(this.ddlStudiskiProgram);
            this.Controls.Add(lStudiskiProgram);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(lDatumRodjenja);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(lPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(lIme);
            this.Name = "UnosStudentaDijalog";
            this.Text = "Unos studenta";
            this.gbStatusFinansiranje.ResumeLayout(false);
            this.gbStatusFinansiranje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEspb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.ComboBox ddlStudiskiProgram;
        private System.Windows.Forms.GroupBox gbStatusFinansiranje;
        private System.Windows.Forms.RadioButton rbSamofinansiranje;
        private System.Windows.Forms.RadioButton rbBudzet;
        private System.Windows.Forms.NumericUpDown nudEspb;
        private System.Windows.Forms.MaskedTextBox mtbIndex;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOdustani;
    }
}