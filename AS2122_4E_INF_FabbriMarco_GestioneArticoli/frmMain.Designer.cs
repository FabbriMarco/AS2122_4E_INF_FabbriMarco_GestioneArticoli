namespace AS2122_4E_INF_FabbriMarco_GestioneArticoli
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitadiMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.cmbUnitadiMisura = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.cmbVisualizzaarticoli = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.cmbUnitadiMisura);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.lblPrezzo);
            this.groupBox1.Controls.Add(this.lblUnitadiMisura);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Controls.Add(this.lblCodice);
            this.groupBox1.Location = new System.Drawing.Point(47, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dettagli articolo";
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(11, 31);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(44, 15);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(11, 72);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitadiMisura
            // 
            this.lblUnitadiMisura.AutoSize = true;
            this.lblUnitadiMisura.Location = new System.Drawing.Point(11, 109);
            this.lblUnitadiMisura.Name = "lblUnitadiMisura";
            this.lblUnitadiMisura.Size = new System.Drawing.Size(81, 15);
            this.lblUnitadiMisura.TabIndex = 2;
            this.lblUnitadiMisura.Text = "UnitadiMisura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(15, 148);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(41, 15);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(95, 31);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 4;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(95, 70);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 5;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(94, 145);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 6;
            // 
            // cmbUnitadiMisura
            // 
            this.cmbUnitadiMisura.FormattingEnabled = true;
            this.cmbUnitadiMisura.Location = new System.Drawing.Point(99, 109);
            this.cmbUnitadiMisura.Name = "cmbUnitadiMisura";
            this.cmbUnitadiMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitadiMisura.TabIndex = 7;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(65, 219);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(226, 52);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi/modifica articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(44, 397);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(59, 15);
            this.lblArticoli.TabIndex = 1;
            this.lblArticoli.Text = "Articoli(0)";
            // 
            // cmbVisualizzaarticoli
            // 
            this.cmbVisualizzaarticoli.FormattingEnabled = true;
            this.cmbVisualizzaarticoli.Location = new System.Drawing.Point(489, 48);
            this.cmbVisualizzaarticoli.Name = "cmbVisualizzaarticoli";
            this.cmbVisualizzaarticoli.Size = new System.Drawing.Size(204, 23);
            this.cmbVisualizzaarticoli.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(489, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 304);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmbVisualizzaarticoli);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "AS2122_4E_INF_FabbriMarco_LAB2.2_18/05/2022GestioneArticoli";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblCodice;
        private Label lblPrezzo;
        private Label lblUnitadiMisura;
        private Label lblDescrizione;
        private Button btnAggiungi;
        private ComboBox cmbUnitadiMisura;
        private TextBox txtPrezzo;
        private TextBox txtDescrizione;
        private TextBox txtCodice;
        private Label lblArticoli;
        private ComboBox cmbVisualizzaarticoli;
        private ListBox listBox1;
        private Button button1;
    }
}