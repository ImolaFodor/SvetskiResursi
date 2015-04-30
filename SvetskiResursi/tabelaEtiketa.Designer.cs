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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalji = new System.Windows.Forms.GroupBox();
            this.opE = new System.Windows.Forms.Label();
            this.bojaE = new System.Windows.Forms.Label();
            this.ozE = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.RichTextBox();
            this.boja = new System.Windows.Forms.TextBox();
            this.oz = new System.Windows.Forms.TextBox();
            this.Brisi = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.otkazi = new System.Windows.Forms.Button();
            this.Izmeni = new System.Windows.Forms.Button();
            this.trazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.detalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oznaka,
            this.opis});
            this.dataGridView1.Location = new System.Drawing.Point(80, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // oznaka
            // 
            this.oznaka.Frozen = true;
            this.oznaka.HeaderText = "Oznaka";
            this.oznaka.Name = "oznaka";
            // 
            // opis
            // 
            this.opis.Frozen = true;
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.opis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // detalji
            // 
            this.detalji.Controls.Add(this.opE);
            this.detalji.Controls.Add(this.bojaE);
            this.detalji.Controls.Add(this.ozE);
            this.detalji.Controls.Add(this.op);
            this.detalji.Controls.Add(this.boja);
            this.detalji.Controls.Add(this.oz);
            this.detalji.Location = new System.Drawing.Point(24, 235);
            this.detalji.Name = "detalji";
            this.detalji.Size = new System.Drawing.Size(347, 105);
            this.detalji.TabIndex = 1;
            this.detalji.TabStop = false;
            this.detalji.Text = "Detalji";
            // 
            // opE
            // 
            this.opE.AutoSize = true;
            this.opE.Location = new System.Drawing.Point(188, 23);
            this.opE.Name = "opE";
            this.opE.Size = new System.Drawing.Size(43, 18);
            this.opE.TabIndex = 7;
            this.opE.Text = "Opis:";
            // 
            // bojaE
            // 
            this.bojaE.AutoSize = true;
            this.bojaE.Location = new System.Drawing.Point(6, 63);
            this.bojaE.Name = "bojaE";
            this.bojaE.Size = new System.Drawing.Size(42, 18);
            this.bojaE.TabIndex = 6;
            this.bojaE.Text = "Boja:";
            // 
            // ozE
            // 
            this.ozE.AutoSize = true;
            this.ozE.Location = new System.Drawing.Point(6, 23);
            this.ozE.Name = "ozE";
            this.ozE.Size = new System.Drawing.Size(64, 18);
            this.ozE.TabIndex = 5;
            this.ozE.Text = "Oznaka:";
            // 
            // op
            // 
            this.op.Location = new System.Drawing.Point(237, 20);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(100, 67);
            this.op.TabIndex = 4;
            this.op.Text = "";
            this.op.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // boja
            // 
            this.boja.Location = new System.Drawing.Point(76, 63);
            this.boja.Name = "boja";
            this.boja.Size = new System.Drawing.Size(100, 24);
            this.boja.TabIndex = 3;
            this.boja.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boja_MouseClick);
            // 
            // oz
            // 
            this.oz.Enabled = false;
            this.oz.Location = new System.Drawing.Point(76, 23);
            this.oz.Name = "oz";
            this.oz.Size = new System.Drawing.Size(100, 24);
            this.oz.TabIndex = 2;
            // 
            // Brisi
            // 
            this.Brisi.Location = new System.Drawing.Point(259, 183);
            this.Brisi.Margin = new System.Windows.Forms.Padding(4);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(112, 32);
            this.Brisi.TabIndex = 3;
            this.Brisi.Text = "Brisi";
            this.Brisi.UseVisualStyleBackColor = true;
            this.Brisi.Click += new System.EventHandler(this.Brisi_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(129, 183);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(112, 32);
            this.Dodaj.TabIndex = 4;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // otkazi
            // 
            this.otkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.otkazi.Location = new System.Drawing.Point(259, 362);
            this.otkazi.Margin = new System.Windows.Forms.Padding(4);
            this.otkazi.Name = "otkazi";
            this.otkazi.Size = new System.Drawing.Size(112, 32);
            this.otkazi.TabIndex = 5;
            this.otkazi.Text = "Otkazi";
            this.otkazi.UseVisualStyleBackColor = true;
            // 
            // Izmeni
            // 
            this.Izmeni.Location = new System.Drawing.Point(129, 362);
            this.Izmeni.Margin = new System.Windows.Forms.Padding(4);
            this.Izmeni.Name = "Izmeni";
            this.Izmeni.Size = new System.Drawing.Size(112, 32);
            this.Izmeni.TabIndex = 6;
            this.Izmeni.Text = "Izmeni";
            this.Izmeni.UseVisualStyleBackColor = true;
            this.Izmeni.Click += new System.EventHandler(this.Izmeni_Click);
            // 
            // trazi
            // 
            this.trazi.Location = new System.Drawing.Point(24, 187);
            this.trazi.Margin = new System.Windows.Forms.Padding(4);
            this.trazi.Name = "trazi";
            this.trazi.Size = new System.Drawing.Size(79, 24);
            this.trazi.TabIndex = 7;
            this.trazi.TextChanged += new System.EventHandler(this.trazi_TextChanged);
            // 
            // tabelaEtiketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 418);
            this.Controls.Add(this.trazi);
            this.Controls.Add(this.Izmeni);
            this.Controls.Add(this.otkazi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.Brisi);
            this.Controls.Add(this.detalji);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tabelaEtiketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tabelaEtiketa";
            this.Load += new System.EventHandler(this.tabelaEtiketa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.detalji.ResumeLayout(false);
            this.detalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.GroupBox detalji;
        private System.Windows.Forms.Label opE;
        private System.Windows.Forms.Label bojaE;
        private System.Windows.Forms.Label ozE;
        private System.Windows.Forms.RichTextBox op;
        private System.Windows.Forms.TextBox boja;
        private System.Windows.Forms.TextBox oz;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button otkazi;
        private System.Windows.Forms.Button Izmeni;
        private System.Windows.Forms.TextBox trazi;
    }
}