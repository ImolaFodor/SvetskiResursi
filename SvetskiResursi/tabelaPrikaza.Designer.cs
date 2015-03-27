namespace SvetskiResursi
{
    partial class tabelaPrikaza
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ikonica = new System.Windows.Forms.DataGridViewImageColumn();
            this.eksploatacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obnovljivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strateska_vaznost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jednica_mere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frekvencija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblD = new System.Windows.Forms.Button();
            this.tblI = new System.Windows.Forms.Button();
            this.tblB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oznaka,
            this.ime,
            this.tip,
            this.opis,
            this.ikonica,
            this.eksploatacija,
            this.obnovljivo,
            this.strateska_vaznost,
            this.jednica_mere,
            this.datum,
            this.frekvencija});
            this.dataGridView1.Location = new System.Drawing.Point(5, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1150, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // Oznaka
            // 
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            // 
            // tip
            // 
            this.tip.HeaderText = "Tip";
            this.tip.Name = "tip";
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            // 
            // ikonica
            // 
            this.ikonica.HeaderText = "Slika";
            this.ikonica.Name = "ikonica";
            // 
            // eksploatacija
            // 
            this.eksploatacija.HeaderText = "Eksploatacija";
            this.eksploatacija.Name = "eksploatacija";
            // 
            // obnovljivo
            // 
            this.obnovljivo.HeaderText = "Obnovljivost";
            this.obnovljivo.Name = "obnovljivo";
            // 
            // strateska_vaznost
            // 
            this.strateska_vaznost.HeaderText = "Strateska važnost";
            this.strateska_vaznost.Name = "strateska_vaznost";
            // 
            // jednica_mere
            // 
            this.jednica_mere.HeaderText = "Jedinica mere";
            this.jednica_mere.Name = "jednica_mere";
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // frekvencija
            // 
            this.frekvencija.HeaderText = "Frekvencija ponavljanja";
            this.frekvencija.Name = "frekvencija";
            // 
            // tblD
            // 
            this.tblD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblD.Location = new System.Drawing.Point(557, 283);
            this.tblD.Name = "tblD";
            this.tblD.Size = new System.Drawing.Size(75, 23);
            this.tblD.TabIndex = 1;
            this.tblD.Text = "Dodaj";
            this.tblD.UseVisualStyleBackColor = false;
            this.tblD.Click += new System.EventHandler(this.tblD_Click);
            // 
            // tblI
            // 
            this.tblI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblI.Location = new System.Drawing.Point(687, 283);
            this.tblI.Name = "tblI";
            this.tblI.Size = new System.Drawing.Size(75, 23);
            this.tblI.TabIndex = 2;
            this.tblI.Text = "Izmeni";
            this.tblI.UseVisualStyleBackColor = false;
            // 
            // tblB
            // 
            this.tblB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblB.Location = new System.Drawing.Point(809, 283);
            this.tblB.Name = "tblB";
            this.tblB.Size = new System.Drawing.Size(75, 23);
            this.tblB.TabIndex = 3;
            this.tblB.Text = "Briši";
            this.tblB.UseVisualStyleBackColor = false;
            // 
            // tabelaPrikaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 357);
            this.Controls.Add(this.tblB);
            this.Controls.Add(this.tblI);
            this.Controls.Add(this.tblD);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tabelaPrikaza";
            this.Text = "Tabela prikaza";
            this.Load += new System.EventHandler(this.tabelaPrikaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewImageColumn ikonica;
        private System.Windows.Forms.DataGridViewTextBoxColumn eksploatacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn obnovljivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn strateska_vaznost;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednica_mere;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn frekvencija;
        private System.Windows.Forms.Button tblD;
        private System.Windows.Forms.Button tblI;
        private System.Windows.Forms.Button tblB;

    }
}