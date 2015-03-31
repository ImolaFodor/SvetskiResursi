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
            this.jednica_mere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etiketa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.jednica_mere,
            this.Cena,
            this.datum,
            this.Etiketa});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(937, 241);
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
            // jednica_mere
            // 
            this.jednica_mere.HeaderText = "Jedinica mere";
            this.jednica_mere.Name = "jednica_mere";
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // Etiketa
            // 
            this.Etiketa.HeaderText = "Etiketa";
            this.Etiketa.Name = "Etiketa";
            // 
            // tblD
            // 
            this.tblD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblD.Location = new System.Drawing.Point(423, 381);
            this.tblD.Margin = new System.Windows.Forms.Padding(4);
            this.tblD.Name = "tblD";
            this.tblD.Size = new System.Drawing.Size(112, 32);
            this.tblD.TabIndex = 1;
            this.tblD.Text = "Dodaj";
            this.tblD.UseVisualStyleBackColor = false;
            // 
            // tblI
            // 
            this.tblI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblI.Location = new System.Drawing.Point(592, 381);
            this.tblI.Margin = new System.Windows.Forms.Padding(4);
            this.tblI.Name = "tblI";
            this.tblI.Size = new System.Drawing.Size(112, 32);
            this.tblI.TabIndex = 2;
            this.tblI.Text = "Izmeni";
            this.tblI.UseVisualStyleBackColor = false;
            // 
            // tblB
            // 
            this.tblB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblB.Location = new System.Drawing.Point(773, 381);
            this.tblB.Margin = new System.Windows.Forms.Padding(4);
            this.tblB.Name = "tblB";
            this.tblB.Size = new System.Drawing.Size(112, 32);
            this.tblB.TabIndex = 3;
            this.tblB.Text = "Briši";
            this.tblB.UseVisualStyleBackColor = false;
            // 
            // tabelaPrikaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 465);
            this.Controls.Add(this.tblB);
            this.Controls.Add(this.tblI);
            this.Controls.Add(this.tblD);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabelaPrikaza";
            this.Text = "Tabela prikaza";
            this.Load += new System.EventHandler(this.tabelaPrikaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tblD;
        private System.Windows.Forms.Button tblI;
        private System.Windows.Forms.Button tblB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewImageColumn ikonica;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednica_mere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etiketa;

    }
}