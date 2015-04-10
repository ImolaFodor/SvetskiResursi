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
            this.tabIm = new System.Windows.Forms.PictureBox();
            this.ttOz = new System.Windows.Forms.TextBox();
            this.ttTip = new System.Windows.Forms.TextBox();
            this.ttIm = new System.Windows.Forms.TextBox();
            this.ttOp = new System.Windows.Forms.RichTextBox();
            this.ttF = new System.Windows.Forms.TextBox();
            this.ttJm = new System.Windows.Forms.TextBox();
            this.ttCen = new System.Windows.Forms.TextBox();
            this.ttDatum = new System.Windows.Forms.TextBox();
            this.tabOz = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ttEkspl = new System.Windows.Forms.TextBox();
            this.ttObn = new System.Windows.Forms.TextBox();
            this.ttStv = new System.Windows.Forms.TextBox();
            this.ttEtik = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabIm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(946, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.tblD.Location = new System.Drawing.Point(607, 236);
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
            this.tblI.Location = new System.Drawing.Point(727, 236);
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
            this.tblB.Location = new System.Drawing.Point(847, 236);
            this.tblB.Margin = new System.Windows.Forms.Padding(4);
            this.tblB.Name = "tblB";
            this.tblB.Size = new System.Drawing.Size(112, 32);
            this.tblB.TabIndex = 3;
            this.tblB.Text = "Briši";
            this.tblB.UseVisualStyleBackColor = false;
            // 
            // tabIm
            // 
            this.tabIm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tabIm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabIm.Location = new System.Drawing.Point(13, 319);
            this.tabIm.Name = "tabIm";
            this.tabIm.Size = new System.Drawing.Size(113, 96);
            this.tabIm.TabIndex = 4;
            this.tabIm.TabStop = false;
            // 
            // ttOz
            // 
            this.ttOz.Enabled = false;
            this.ttOz.Location = new System.Drawing.Point(202, 319);
            this.ttOz.Name = "ttOz";
            this.ttOz.Size = new System.Drawing.Size(100, 24);
            this.ttOz.TabIndex = 5;
            // 
            // ttTip
            // 
            this.ttTip.Location = new System.Drawing.Point(202, 394);
            this.ttTip.Name = "ttTip";
            this.ttTip.Size = new System.Drawing.Size(100, 24);
            this.ttTip.TabIndex = 6;
            // 
            // ttIm
            // 
            this.ttIm.Location = new System.Drawing.Point(202, 355);
            this.ttIm.Name = "ttIm";
            this.ttIm.Size = new System.Drawing.Size(100, 24);
            this.ttIm.TabIndex = 7;
            // 
            // ttOp
            // 
            this.ttOp.Location = new System.Drawing.Point(357, 317);
            this.ttOp.Name = "ttOp";
            this.ttOp.Size = new System.Drawing.Size(116, 98);
            this.ttOp.TabIndex = 8;
            this.ttOp.Text = "";
            // 
            // ttF
            // 
            this.ttF.Location = new System.Drawing.Point(555, 315);
            this.ttF.Name = "ttF";
            this.ttF.Size = new System.Drawing.Size(100, 24);
            this.ttF.TabIndex = 9;
            // 
            // ttJm
            // 
            this.ttJm.Location = new System.Drawing.Point(555, 345);
            this.ttJm.Name = "ttJm";
            this.ttJm.Size = new System.Drawing.Size(100, 24);
            this.ttJm.TabIndex = 10;
            // 
            // ttCen
            // 
            this.ttCen.Location = new System.Drawing.Point(555, 375);
            this.ttCen.Name = "ttCen";
            this.ttCen.Size = new System.Drawing.Size(100, 24);
            this.ttCen.TabIndex = 11;
            // 
            // ttDatum
            // 
            this.ttDatum.Location = new System.Drawing.Point(555, 405);
            this.ttDatum.Name = "ttDatum";
            this.ttDatum.Size = new System.Drawing.Size(100, 24);
            this.ttDatum.TabIndex = 12;
            // 
            // tabOz
            // 
            this.tabOz.AutoSize = true;
            this.tabOz.Location = new System.Drawing.Point(132, 319);
            this.tabOz.Name = "tabOz";
            this.tabOz.Size = new System.Drawing.Size(64, 18);
            this.tabOz.TabIndex = 13;
            this.tabOz.Text = "Oznaka:";
            // 
            // tbIme
            // 
            this.tbIme.AutoSize = true;
            this.tbIme.Location = new System.Drawing.Point(132, 355);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(36, 18);
            this.tbIme.TabIndex = 14;
            this.tbIme.Text = "Ime:";
            // 
            // tbTip
            // 
            this.tbTip.AutoSize = true;
            this.tbTip.Location = new System.Drawing.Point(132, 394);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(32, 18);
            this.tbTip.TabIndex = 15;
            this.tbTip.Text = "Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Frekv.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "J. mere:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cena:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Datum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(661, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ekspl.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(661, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Obnov.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(661, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "St. vaz.";
            // 
            // ttEkspl
            // 
            this.ttEkspl.Location = new System.Drawing.Point(727, 314);
            this.ttEkspl.Name = "ttEkspl";
            this.ttEkspl.Size = new System.Drawing.Size(100, 24);
            this.ttEkspl.TabIndex = 24;
            // 
            // ttObn
            // 
            this.ttObn.Location = new System.Drawing.Point(727, 355);
            this.ttObn.Name = "ttObn";
            this.ttObn.Size = new System.Drawing.Size(100, 24);
            this.ttObn.TabIndex = 25;
            // 
            // ttStv
            // 
            this.ttStv.Location = new System.Drawing.Point(727, 397);
            this.ttStv.Name = "ttStv";
            this.ttStv.Size = new System.Drawing.Size(100, 24);
            this.ttStv.TabIndex = 26;
            // 
            // ttEtik
            // 
            this.ttEtik.Location = new System.Drawing.Point(847, 316);
            this.ttEtik.Name = "ttEtik";
            this.ttEtik.Size = new System.Drawing.Size(113, 99);
            this.ttEtik.TabIndex = 27;
            this.ttEtik.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(847, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Otkazi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabelaPrikaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ttEtik);
            this.Controls.Add(this.ttStv);
            this.Controls.Add(this.ttObn);
            this.Controls.Add(this.ttEkspl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tabOz);
            this.Controls.Add(this.ttDatum);
            this.Controls.Add(this.ttCen);
            this.Controls.Add(this.ttJm);
            this.Controls.Add(this.ttF);
            this.Controls.Add(this.ttOp);
            this.Controls.Add(this.ttIm);
            this.Controls.Add(this.ttTip);
            this.Controls.Add(this.ttOz);
            this.Controls.Add(this.tabIm);
            this.Controls.Add(this.tblB);
            this.Controls.Add(this.tblI);
            this.Controls.Add(this.tblD);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "tabelaPrikaza";
            this.Text = "Tabela prikaza";
            this.Load += new System.EventHandler(this.tabelaPrikaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox tabIm;
        private System.Windows.Forms.TextBox ttOz;
        private System.Windows.Forms.TextBox ttTip;
        private System.Windows.Forms.TextBox ttIm;
        private System.Windows.Forms.RichTextBox ttOp;
        private System.Windows.Forms.TextBox ttF;
        private System.Windows.Forms.TextBox ttJm;
        private System.Windows.Forms.TextBox ttCen;
        private System.Windows.Forms.TextBox ttDatum;
        private System.Windows.Forms.Label tabOz;
        private System.Windows.Forms.Label tbIme;
        private System.Windows.Forms.Label tbTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ttEkspl;
        private System.Windows.Forms.TextBox ttObn;
        private System.Windows.Forms.TextBox ttStv;
        private System.Windows.Forms.RichTextBox ttEtik;
        private System.Windows.Forms.Button button1;

    }
}