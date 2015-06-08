namespace SvetskiResursi
{
    partial class tabelaEtiketa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabelaEtiketa));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detalji = new System.Windows.Forms.GroupBox();
            this.op = new System.Windows.Forms.Label();
            this.boja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oz = new System.Windows.Forms.Label();
            this.opE = new System.Windows.Forms.Label();
            this.bojaE = new System.Windows.Forms.Label();
            this.ozE = new System.Windows.Forms.Label();
            this.Brisi = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.otkazi = new System.Windows.Forms.Button();
            this.Izmeni = new System.Windows.Forms.Button();
            this.trazi = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detalji.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oznaka,
            this.opis});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // detalji
            // 
            this.detalji.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.detalji.Controls.Add(this.op);
            this.detalji.Controls.Add(this.boja);
            this.detalji.Controls.Add(this.label1);
            this.detalji.Controls.Add(this.oz);
            this.detalji.Controls.Add(this.opE);
            this.detalji.Controls.Add(this.bojaE);
            this.detalji.Controls.Add(this.ozE);
            this.detalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalji.Location = new System.Drawing.Point(196, 188);
            this.detalji.Name = "detalji";
            this.detalji.Size = new System.Drawing.Size(318, 100);
            this.detalji.TabIndex = 1;
            this.detalji.TabStop = false;
            this.detalji.Text = "Detalji";
            // 
            // op
            // 
            this.op.AutoSize = true;
            this.op.Location = new System.Drawing.Point(228, 23);
            this.op.MaximumSize = new System.Drawing.Size(100, 100);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(58, 18);
            this.op.TabIndex = 5;
            this.op.Text = "          ";
            this.op.MouseHover += new System.EventHandler(this.op_MouseHover);
            // 
            // boja
            // 
            this.boja.AutoSize = true;
            this.boja.Location = new System.Drawing.Point(85, 63);
            this.boja.Name = "boja";
            this.boja.Size = new System.Drawing.Size(83, 18);
            this.boja.TabIndex = 5;
            this.boja.Text = "               ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, -16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "\"          \"";
            // 
            // oz
            // 
            this.oz.AutoSize = true;
            this.oz.Location = new System.Drawing.Point(90, 23);
            this.oz.Name = "oz";
            this.oz.Size = new System.Drawing.Size(78, 18);
            this.oz.TabIndex = 5;
            this.oz.Text = "              ";
            // 
            // opE
            // 
            this.opE.AutoSize = true;
            this.opE.Location = new System.Drawing.Point(174, 23);
            this.opE.Name = "opE";
            this.opE.Size = new System.Drawing.Size(48, 18);
            this.opE.TabIndex = 5;
            this.opE.Text = "Opis:";
            // 
            // bojaE
            // 
            this.bojaE.AutoSize = true;
            this.bojaE.Location = new System.Drawing.Point(15, 63);
            this.bojaE.Name = "bojaE";
            this.bojaE.Size = new System.Drawing.Size(47, 18);
            this.bojaE.TabIndex = 5;
            this.bojaE.Text = "Boja:";
            // 
            // ozE
            // 
            this.ozE.AutoSize = true;
            this.ozE.Location = new System.Drawing.Point(15, 23);
            this.ozE.Name = "ozE";
            this.ozE.Size = new System.Drawing.Size(71, 18);
            this.ozE.TabIndex = 5;
            this.ozE.Text = "Oznaka:";
            // 
            // Brisi
            // 
            this.Brisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Brisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Brisi.Location = new System.Drawing.Point(392, 131);
            this.Brisi.Margin = new System.Windows.Forms.Padding(4);
            this.Brisi.MaximumSize = new System.Drawing.Size(111, 32);
            this.Brisi.MinimumSize = new System.Drawing.Size(100, 23);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(111, 32);
            this.Brisi.TabIndex = 3;
            this.Brisi.Text = "Briši";
            this.Brisi.UseVisualStyleBackColor = false;
            this.Brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dodaj.Location = new System.Drawing.Point(391, 75);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(112, 32);
            this.Dodaj.TabIndex = 2;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = false;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // otkazi
            // 
            this.otkazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.otkazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.otkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.otkazi.Location = new System.Drawing.Point(392, 314);
            this.otkazi.Margin = new System.Windows.Forms.Padding(4);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(112, 32);
            this.otkazi.TabIndex = 0;
            this.otkazi.Text = "Izadji";
            this.otkazi.UseVisualStyleBackColor = false;
            // 
            // Izmeni
            // 
            this.Izmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Izmeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Izmeni.Location = new System.Drawing.Point(391, 23);
            this.Izmeni.Margin = new System.Windows.Forms.Padding(4);
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.Size = new System.Drawing.Size(112, 32);
            this.Izmeni.TabIndex = 1;
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.UseVisualStyleBackColor = false;
            this.Izmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // trazi
            // 
            this.trazi.Location = new System.Drawing.Point(88, 24);
            this.trazi.Margin = new System.Windows.Forms.Padding(4);
            this.trazi.Name = "trazi";
            this.trazi.Size = new System.Drawing.Size(83, 24);
            this.trazi.TabIndex = 4;
            this.trazi.Click += new System.EventHandler(this.trazi_Click);
            this.trazi.TextChanged += new System.EventHandler(this.trazi_TextChanged);
            this.trazi.MouseHover += new System.EventHandler(this.trazi_MouseHover);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(88, 68);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(84, 26);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.TextChanged += new System.EventHandler(this.cbFilter_TextChanged);
            this.cbFilter.Leave += new System.EventHandler(this.cbFilter_Leave);
            this.cbFilter.MouseHover += new System.EventHandler(this.cbFilter_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.trazi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretrage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Pretraga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Filtriranje:";
            // 
            // oznaka
            // 
            this.oznaka.Frozen = true;
            this.oznaka.HeaderText = "Oznaka";
            this.oznaka.Name = "oznaka";
            this.oznaka.Width = 150;
            // 
            // opis
            // 
            this.opis.Frozen = true;
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.opis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.opis.Width = 160;
            // 
            // tabelaEtiketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 359);
            this.Controls.Add(this.groupBox1);
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
            this.MaximumSize = new System.Drawing.Size(542, 398);
            this.MinimumSize = new System.Drawing.Size(450, 381);
            this.Name = "tabelaEtiketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela prikaza etiketa";
            this.Load += new System.EventHandler(this.tabelaEtiketa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detalji.ResumeLayout(false);
            this.detalji.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detalji;
        private System.Windows.Forms.Label opE;
        private System.Windows.Forms.Label bojaE;
        private System.Windows.Forms.Label ozE;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.Button Izmeni;
        private System.Windows.Forms.TextBox trazi;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label oz;
        public System.Windows.Forms.Label boja;
        public System.Windows.Forms.Label op;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}