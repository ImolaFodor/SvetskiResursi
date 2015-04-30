namespace SvetskiResursi
{
    partial class tabelaTipova
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
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalji = new System.Windows.Forms.GroupBox();
            this.Brisi = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.otkazi = new System.Windows.Forms.Button();
            this.Izmeni = new System.Windows.Forms.Button();
            this.imDT = new System.Windows.Forms.PictureBox();
            this.opDT = new System.Windows.Forms.RichTextBox();
            this.ozDT = new System.Windows.Forms.TextBox();
            this.imeDT = new System.Windows.Forms.TextBox();
            this.ozD = new System.Windows.Forms.Label();
            this.imeD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imDT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oznaka,
            this.Ime,
            this.Slika,
            this.Opis});
            this.dataGridView1.Location = new System.Drawing.Point(33, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Oznaka
            // 
            this.Oznaka.Frozen = true;
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            // 
            // Ime
            // 
            this.Ime.Frozen = true;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Slika
            // 
            this.Slika.Frozen = true;
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            // 
            // Opis
            // 
            this.Opis.Frozen = true;
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Opis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // detalji
            // 
            this.detalji.Controls.Add(this.label3);
            this.detalji.Controls.Add(this.imeD);
            this.detalji.Controls.Add(this.ozD);
            this.detalji.Controls.Add(this.imeDT);
            this.detalji.Controls.Add(this.ozDT);
            this.detalji.Controls.Add(this.opDT);
            this.detalji.Controls.Add(this.imDT);
            this.detalji.Location = new System.Drawing.Point(13, 249);
            this.detalji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detalji.Name = "detalji";
            this.detalji.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detalji.Size = new System.Drawing.Size(478, 136);
            this.detalji.TabIndex = 1;
            this.detalji.TabStop = false;
            this.detalji.Text = "Detalji";
            this.detalji.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Brisi
            // 
            this.Brisi.Location = new System.Drawing.Point(358, 197);
            this.Brisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(112, 32);
            this.Brisi.TabIndex = 2;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseVisualStyleBackColor = true;
            this.Brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(239, 197);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(112, 32);
            this.Dodaj.TabIndex = 3;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // otkazi
            // 
            this.otkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.otkazi.Location = new System.Drawing.Point(359, 409);
            this.otkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(112, 32);
            this.otkazi.TabIndex = 4;
            this.otkazi.Text = "Otkazi";
            this.otkazi.UseVisualStyleBackColor = true;
            this.otkazi.Click += new System.EventHandler(this.button3_Click);
            // 
            // Izmeni
            // 
            this.Izmeni.Location = new System.Drawing.Point(239, 409);
            this.Izmeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.Size = new System.Drawing.Size(112, 32);
            this.Izmeni.TabIndex = 5;
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.UseVisualStyleBackColor = true;
            this.Izmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // imDT
            // 
            this.imDT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imDT.Location = new System.Drawing.Point(8, 26);
            this.imDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imDT.Name = "imDT";
            this.imDT.Size = new System.Drawing.Size(105, 104);
            this.imDT.TabIndex = 0;
            this.imDT.TabStop = false;
            this.imDT.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // opDT
            // 
            this.opDT.Location = new System.Drawing.Point(172, 26);
            this.opDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opDT.Name = "opDT";
            this.opDT.Size = new System.Drawing.Size(121, 104);
            this.opDT.TabIndex = 1;
            this.opDT.Text = "";
            // 
            // ozDT
            // 
            this.ozDT.Location = new System.Drawing.Point(373, 26);
            this.ozDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ozDT.Name = "ozDT";
            this.ozDT.Size = new System.Drawing.Size(96, 24);
            this.ozDT.TabIndex = 2;
            // 
            // imeDT
            // 
            this.imeDT.Location = new System.Drawing.Point(373, 77);
            this.imeDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imeDT.Name = "imeDT";
            this.imeDT.Size = new System.Drawing.Size(96, 24);
            this.imeDT.TabIndex = 3;
            // 
            // ozD
            // 
            this.ozD.AutoSize = true;
            this.ozD.Location = new System.Drawing.Point(301, 26);
            this.ozD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ozD.Name = "ozD";
            this.ozD.Size = new System.Drawing.Size(64, 18);
            this.ozD.TabIndex = 4;
            this.ozD.Text = "Oznaka:";
            // 
            // imeD
            // 
            this.imeD.AutoSize = true;
            this.imeD.Location = new System.Drawing.Point(302, 80);
            this.imeD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imeD.Name = "imeD";
            this.imeD.Size = new System.Drawing.Size(36, 18);
            this.imeD.TabIndex = 5;
            this.imeD.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            // 
            // tabelaTipova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.otkazi;
            this.ClientSize = new System.Drawing.Size(500, 451);
            this.Controls.Add(this.Izmeni);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Brisi);
            this.Controls.Add(this.detalji);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "tabelaTipova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tabelaTipova";
            this.Load += new System.EventHandler(this.tabelaTipova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detalji.ResumeLayout(false);
            this.detalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imDT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.GroupBox detalji;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.Button Izmeni;
        private System.Windows.Forms.TextBox imeDT;
        private System.Windows.Forms.TextBox ozDT;
        private System.Windows.Forms.RichTextBox opDT;
        private System.Windows.Forms.PictureBox imDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imeD;
        private System.Windows.Forms.Label ozD;
    }
}