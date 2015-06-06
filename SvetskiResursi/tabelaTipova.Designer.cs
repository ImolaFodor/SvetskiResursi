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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabelaTipova));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalji = new System.Windows.Forms.GroupBox();
            this.imeDT = new System.Windows.Forms.Label();
            this.ozDT = new System.Windows.Forms.Label();
            this.opDT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imeD = new System.Windows.Forms.Label();
            this.ozD = new System.Windows.Forms.Label();
            this.imDT = new System.Windows.Forms.PictureBox();
            this.Brisi = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.otkazi = new System.Windows.Forms.Button();
            this.Izmeni = new System.Windows.Forms.Button();
            this.trazi = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pretr = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imDT)).BeginInit();
            this.pretr.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oznaka,
            this.Ime,
            this.Opis});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(378, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Oznaka
            // 
            this.Oznaka.Frozen = true;
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.Width = 110;
            // 
            // Ime
            // 
            this.Ime.Frozen = true;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.Width = 115;
            // 
            // Opis
            // 
            this.Opis.Frozen = true;
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Opis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Opis.Width = 120;
            // 
            // detalji
            // 
            this.detalji.Controls.Add(this.imeDT);
            this.detalji.Controls.Add(this.ozDT);
            this.detalji.Controls.Add(this.opDT);
            this.detalji.Controls.Add(this.label3);
            this.detalji.Controls.Add(this.imeD);
            this.detalji.Controls.Add(this.ozD);
            this.detalji.Controls.Add(this.imDT);
            this.detalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalji.Location = new System.Drawing.Point(128, 204);
            this.detalji.Margin = new System.Windows.Forms.Padding(4);
            this.detalji.Name = "detalji";
            this.detalji.Padding = new System.Windows.Forms.Padding(4);
            this.detalji.Size = new System.Drawing.Size(408, 136);
            this.detalji.TabIndex = 1;
            this.detalji.TabStop = false;
            this.detalji.Text = "Detalji";
            // 
            // imeDT
            // 
            this.imeDT.AutoSize = true;
            this.imeDT.Location = new System.Drawing.Point(197, 66);
            this.imeDT.MaximumSize = new System.Drawing.Size(70, 100);
            this.imeDT.Name = "imeDT";
            this.imeDT.Size = new System.Drawing.Size(48, 18);
            this.imeDT.TabIndex = 9;
            this.imeDT.Text = "        ";
            // 
            // ozDT
            // 
            this.ozDT.AutoSize = true;
            this.ozDT.Location = new System.Drawing.Point(197, 21);
            this.ozDT.MaximumSize = new System.Drawing.Size(50, 100);
            this.ozDT.Name = "ozDT";
            this.ozDT.Size = new System.Drawing.Size(38, 18);
            this.ozDT.TabIndex = 8;
            this.ozDT.Text = "      ";
            // 
            // opDT
            // 
            this.opDT.AutoSize = true;
            this.opDT.Location = new System.Drawing.Point(319, 21);
            this.opDT.MaximumSize = new System.Drawing.Size(100, 100);
            this.opDT.Name = "opDT";
            this.opDT.Size = new System.Drawing.Size(58, 18);
            this.opDT.TabIndex = 7;
            this.opDT.Text = "          ";
            this.opDT.MouseHover += new System.EventHandler(this.opDT_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            // 
            // imeD
            // 
            this.imeD.AutoSize = true;
            this.imeD.Location = new System.Drawing.Point(121, 66);
            this.imeD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imeD.Name = "imeD";
            this.imeD.Size = new System.Drawing.Size(40, 18);
            this.imeD.TabIndex = 5;
            this.imeD.Text = "Ime:";
            // 
            // ozD
            // 
            this.ozD.AutoSize = true;
            this.ozD.Location = new System.Drawing.Point(119, 21);
            this.ozD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ozD.Name = "ozD";
            this.ozD.Size = new System.Drawing.Size(71, 18);
            this.ozD.TabIndex = 4;
            this.ozD.Text = "Oznaka:";
            // 
            // imDT
            // 
            this.imDT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.imDT.Location = new System.Drawing.Point(8, 21);
            this.imDT.Margin = new System.Windows.Forms.Padding(4);
            this.imDT.Name = "imDT";
            this.imDT.Size = new System.Drawing.Size(105, 104);
            this.imDT.TabIndex = 0;
            this.imDT.TabStop = false;
            this.imDT.Click += new System.EventHandler(this.imDT_Click);
            // 
            // Brisi
            // 
            this.Brisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Brisi.Location = new System.Drawing.Point(412, 130);
            this.Brisi.Margin = new System.Windows.Forms.Padding(4);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(112, 32);
            this.Brisi.TabIndex = 2;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseVisualStyleBackColor = false;
            this.Brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dodaj.Location = new System.Drawing.Point(412, 76);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(112, 32);
            this.Dodaj.TabIndex = 3;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // otkazi
            // 
            this.otkazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.otkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.otkazi.Location = new System.Drawing.Point(412, 361);
            this.otkazi.Margin = new System.Windows.Forms.Padding(4);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(112, 32);
            this.otkazi.TabIndex = 4;
            this.otkazi.Text = "Izadji";
            this.otkazi.UseVisualStyleBackColor = false;
            // 
            // Izmeni
            // 
            this.Izmeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Izmeni.Location = new System.Drawing.Point(412, 23);
            this.Izmeni.Margin = new System.Windows.Forms.Padding(4);
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.Size = new System.Drawing.Size(112, 32);
            this.Izmeni.TabIndex = 5;
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.UseVisualStyleBackColor = false;
            this.Izmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // trazi
            // 
            this.trazi.Location = new System.Drawing.Point(7, 34);
            this.trazi.Margin = new System.Windows.Forms.Padding(4);
            this.trazi.Name = "trazi";
            this.trazi.Size = new System.Drawing.Size(82, 24);
            this.trazi.TabIndex = 6;
            this.trazi.Click += new System.EventHandler(this.trazi_Click);
            this.trazi.TextChanged += new System.EventHandler(this.trazi_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(7, 87);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(82, 26);
            this.cbFilter.TabIndex = 34;
            this.cbFilter.TextChanged += new System.EventHandler(this.cbFilter_TextChanged);
            // 
            // pretr
            // 
            this.pretr.Controls.Add(this.trazi);
            this.pretr.Controls.Add(this.cbFilter);
            this.pretr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretr.Location = new System.Drawing.Point(13, 204);
            this.pretr.Name = "pretr";
            this.pretr.Size = new System.Drawing.Size(106, 136);
            this.pretr.TabIndex = 35;
            this.pretr.TabStop = false;
            this.pretr.Text = "Pretrage";
            // 
            // tabelaTipova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.otkazi;
            this.ClientSize = new System.Drawing.Size(546, 405);
            this.Controls.Add(this.pretr);
            this.Controls.Add(this.Izmeni);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Brisi);
            this.Controls.Add(this.detalji);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "tabelaTipova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela prikaza tipova";
            this.Load += new System.EventHandler(this.tabelaTipova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detalji.ResumeLayout(false);
            this.detalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imDT)).EndInit();
            this.pretr.ResumeLayout(false);
            this.pretr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detalji;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.Button Izmeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label imeD;
        private System.Windows.Forms.Label ozD;
        private System.Windows.Forms.TextBox trazi;
        private System.Windows.Forms.ComboBox cbFilter;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox imDT;
        public System.Windows.Forms.Label opDT;
        public System.Windows.Forms.Label ozDT;
        public System.Windows.Forms.Label imeDT;
        private System.Windows.Forms.GroupBox pretr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}