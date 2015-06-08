namespace SvetskiResursi
{
    partial class TabelaPrikaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabelaPrikaza));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Oznaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jednica_mere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etiketa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblD = new System.Windows.Forms.Button();
            this.tblI = new System.Windows.Forms.Button();
            this.tblB = new System.Windows.Forms.Button();
            this.tabIm = new System.Windows.Forms.PictureBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.gbDet = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttEtik = new System.Windows.Forms.Label();
            this.ttStv = new System.Windows.Forms.Label();
            this.ttObn = new System.Windows.Forms.Label();
            this.ttEkspl = new System.Windows.Forms.Label();
            this.ttDatum = new System.Windows.Forms.Label();
            this.ttCen = new System.Windows.Forms.Label();
            this.ttJm = new System.Windows.Forms.Label();
            this.ttFv = new System.Windows.Forms.Label();
            this.ttOp = new System.Windows.Forms.Label();
            this.ttTip = new System.Windows.Forms.Label();
            this.ttIm = new System.Windows.Forms.Label();
            this.ttOz = new System.Windows.Forms.Label();
            this.tbTrazi = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.gbPretrage = new System.Windows.Forms.GroupBox();
            this.rbTip = new System.Windows.Forms.RadioButton();
            this.rbIme = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabIm)).BeginInit();
            this.gbDet.SuspendLayout();
            this.gbPretrage.SuspendLayout();
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
            this.jednica_mere,
            this.Cena,
            this.datum,
            this.Etiketa});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(987, 215);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Oznaka
            // 
            this.Oznaka.HeaderText = "Oznaka";
            this.Oznaka.Name = "Oznaka";
            this.Oznaka.Width = 118;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.Width = 118;
            // 
            // tip
            // 
            this.tip.HeaderText = "Tip";
            this.tip.Name = "tip";
            this.tip.Width = 118;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.Name = "opis";
            this.opis.Width = 125;
            // 
            // jednica_mere
            // 
            this.jednica_mere.HeaderText = "Jedinica mere";
            this.jednica_mere.Name = "jednica_mere";
            this.jednica_mere.Width = 118;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            this.Cena.Width = 118;
            // 
            // datum
            // 
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            this.datum.Width = 118;
            // 
            // Etiketa
            // 
            this.Etiketa.HeaderText = "Etiketa";
            this.Etiketa.Name = "Etiketa";
            this.Etiketa.Width = 118;
            // 
            // tblD
            // 
            this.tblD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblD.Location = new System.Drawing.Point(1024, 78);
            this.tblD.Margin = new System.Windows.Forms.Padding(4);
            this.tblD.Name = "tblD";
            this.tblD.Size = new System.Drawing.Size(112, 32);
            this.tblD.TabIndex = 2;
            this.tblD.Text = "Dodaj";
            this.tblD.UseVisualStyleBackColor = false;
            this.tblD.Click += new System.EventHandler(this.tblD_Click);
            // 
            // tblI
            // 
            this.tblI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblI.Location = new System.Drawing.Point(1024, 24);
            this.tblI.Margin = new System.Windows.Forms.Padding(4);
            this.tblI.Name = "tblI";
            this.tblI.Size = new System.Drawing.Size(112, 32);
            this.tblI.TabIndex = 1;
            this.tblI.Text = "Izmeni";
            this.tblI.UseVisualStyleBackColor = false;
            this.tblI.Click += new System.EventHandler(this.tblI_Click);
            // 
            // tblB
            // 
            this.tblB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblB.Location = new System.Drawing.Point(1024, 135);
            this.tblB.Margin = new System.Windows.Forms.Padding(4);
            this.tblB.Name = "tblB";
            this.tblB.Size = new System.Drawing.Size(112, 32);
            this.tblB.TabIndex = 3;
            this.tblB.Text = "Briši";
            this.tblB.UseVisualStyleBackColor = false;
            this.tblB.Click += new System.EventHandler(this.tblB_Click);
            // 
            // tabIm
            // 
            this.tabIm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tabIm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabIm.Location = new System.Drawing.Point(19, 27);
            this.tabIm.Name = "tabIm";
            this.tabIm.Size = new System.Drawing.Size(125, 118);
            this.tabIm.TabIndex = 4;
            this.tabIm.TabStop = false;
            // 
            // tabOz
            // 
            this.tabOz.AutoSize = true;
            this.tabOz.Location = new System.Drawing.Point(165, 40);
            this.tabOz.Name = "tabOz";
            this.tabOz.Size = new System.Drawing.Size(71, 18);
            this.tabOz.TabIndex = 13;
            this.tabOz.Text = "Oznaka:";
            // 
            // tbIme
            // 
            this.tbIme.AutoSize = true;
            this.tbIme.Location = new System.Drawing.Point(165, 82);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(40, 18);
            this.tbIme.TabIndex = 14;
            this.tbIme.Text = "Ime:";
            // 
            // tbTip
            // 
            this.tbTip.AutoSize = true;
            this.tbTip.Location = new System.Drawing.Point(165, 124);
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(36, 18);
            this.tbTip.TabIndex = 15;
            this.tbTip.Text = "Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Opis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Frekv.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "J. mere:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cena:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Datum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(659, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ekspl.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(659, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Obnov.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(659, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "St. vaz.";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1024, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Izadji";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbDet
            // 
            this.gbDet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbDet.BackColor = System.Drawing.SystemColors.Control;
            this.gbDet.Controls.Add(this.tabIm);
            this.gbDet.Controls.Add(this.label1);
            this.gbDet.Controls.Add(this.ttEtik);
            this.gbDet.Controls.Add(this.ttStv);
            this.gbDet.Controls.Add(this.ttObn);
            this.gbDet.Controls.Add(this.ttEkspl);
            this.gbDet.Controls.Add(this.ttDatum);
            this.gbDet.Controls.Add(this.ttCen);
            this.gbDet.Controls.Add(this.ttJm);
            this.gbDet.Controls.Add(this.ttFv);
            this.gbDet.Controls.Add(this.ttOp);
            this.gbDet.Controls.Add(this.ttTip);
            this.gbDet.Controls.Add(this.ttIm);
            this.gbDet.Controls.Add(this.ttOz);
            this.gbDet.Controls.Add(this.tabOz);
            this.gbDet.Controls.Add(this.tbIme);
            this.gbDet.Controls.Add(this.label11);
            this.gbDet.Controls.Add(this.label10);
            this.gbDet.Controls.Add(this.tbTip);
            this.gbDet.Controls.Add(this.label9);
            this.gbDet.Controls.Add(this.label8);
            this.gbDet.Controls.Add(this.label4);
            this.gbDet.Controls.Add(this.label7);
            this.gbDet.Controls.Add(this.label6);
            this.gbDet.Controls.Add(this.label5);
            this.gbDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDet.Location = new System.Drawing.Point(227, 253);
            this.gbDet.Name = "gbDet";
            this.gbDet.Size = new System.Drawing.Size(926, 165);
            this.gbDet.TabIndex = 7;
            this.gbDet.TabStop = false;
            this.gbDet.Text = "Detalji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Etikete:";
            // 
            // ttEtik
            // 
            this.ttEtik.AutoSize = true;
            this.ttEtik.Location = new System.Drawing.Point(851, 44);
            this.ttEtik.MaximumSize = new System.Drawing.Size(50, 100);
            this.ttEtik.Name = "ttEtik";
            this.ttEtik.Size = new System.Drawing.Size(48, 36);
            this.ttEtik.TabIndex = 45;
            this.ttEtik.Text = "          ";
            // 
            // ttStv
            // 
            this.ttStv.AutoSize = true;
            this.ttStv.Location = new System.Drawing.Point(714, 124);
            this.ttStv.Name = "ttStv";
            this.ttStv.Size = new System.Drawing.Size(58, 18);
            this.ttStv.TabIndex = 44;
            this.ttStv.Text = "          ";
            // 
            // ttObn
            // 
            this.ttObn.AutoSize = true;
            this.ttObn.Location = new System.Drawing.Point(714, 82);
            this.ttObn.Name = "ttObn";
            this.ttObn.Size = new System.Drawing.Size(58, 18);
            this.ttObn.TabIndex = 43;
            this.ttObn.Text = "          ";
            // 
            // ttEkspl
            // 
            this.ttEkspl.AutoSize = true;
            this.ttEkspl.Location = new System.Drawing.Point(714, 43);
            this.ttEkspl.Name = "ttEkspl";
            this.ttEkspl.Size = new System.Drawing.Size(58, 18);
            this.ttEkspl.TabIndex = 42;
            this.ttEkspl.Text = "          ";
            // 
            // ttDatum
            // 
            this.ttDatum.AutoSize = true;
            this.ttDatum.Cursor = System.Windows.Forms.Cursors.Default;
            this.ttDatum.Location = new System.Drawing.Point(537, 135);
            this.ttDatum.Name = "ttDatum";
            this.ttDatum.Size = new System.Drawing.Size(58, 18);
            this.ttDatum.TabIndex = 41;
            this.ttDatum.Text = "          ";
            // 
            // ttCen
            // 
            this.ttCen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ttCen.AutoSize = true;
            this.ttCen.Location = new System.Drawing.Point(537, 103);
            this.ttCen.Name = "ttCen";
            this.ttCen.Size = new System.Drawing.Size(58, 18);
            this.ttCen.TabIndex = 40;
            this.ttCen.Text = "          ";
            // 
            // ttJm
            // 
            this.ttJm.AutoSize = true;
            this.ttJm.Location = new System.Drawing.Point(537, 73);
            this.ttJm.Name = "ttJm";
            this.ttJm.Size = new System.Drawing.Size(58, 18);
            this.ttJm.TabIndex = 39;
            this.ttJm.Text = "          ";
            // 
            // ttFv
            // 
            this.ttFv.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ttFv.AutoSize = true;
            this.ttFv.Location = new System.Drawing.Point(537, 43);
            this.ttFv.MinimumSize = new System.Drawing.Size(50, 50);
            this.ttFv.Name = "ttFv";
            this.ttFv.Size = new System.Drawing.Size(58, 50);
            this.ttFv.TabIndex = 38;
            this.ttFv.Text = "          ";
            // 
            // ttOp
            // 
            this.ttOp.AutoSize = true;
            this.ttOp.Location = new System.Drawing.Point(354, 43);
            this.ttOp.MaximumSize = new System.Drawing.Size(100, 100);
            this.ttOp.Name = "ttOp";
            this.ttOp.Size = new System.Drawing.Size(58, 18);
            this.ttOp.TabIndex = 37;
            this.ttOp.Text = "          ";
            this.ttOp.MouseHover += new System.EventHandler(this.ttOp_MouseHover);
            // 
            // ttTip
            // 
            this.ttTip.AutoSize = true;
            this.ttTip.Location = new System.Drawing.Point(235, 124);
            this.ttTip.Name = "ttTip";
            this.ttTip.Size = new System.Drawing.Size(58, 18);
            this.ttTip.TabIndex = 36;
            this.ttTip.Text = "          ";
            // 
            // ttIm
            // 
            this.ttIm.AutoSize = true;
            this.ttIm.Location = new System.Drawing.Point(235, 82);
            this.ttIm.Name = "ttIm";
            this.ttIm.Size = new System.Drawing.Size(58, 18);
            this.ttIm.TabIndex = 35;
            this.ttIm.Text = "          ";
            // 
            // ttOz
            // 
            this.ttOz.AutoSize = true;
            this.ttOz.Location = new System.Drawing.Point(235, 40);
            this.ttOz.Name = "ttOz";
            this.ttOz.Size = new System.Drawing.Size(58, 18);
            this.ttOz.TabIndex = 34;
            this.ttOz.Text = "          ";
            // 
            // tbTrazi
            // 
            this.tbTrazi.Location = new System.Drawing.Point(28, 34);
            this.tbTrazi.Name = "tbTrazi";
            this.tbTrazi.Size = new System.Drawing.Size(105, 24);
            this.tbTrazi.TabIndex = 4;
            this.tbTrazi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbTrazi_MouseClick);
            this.tbTrazi.TextChanged += new System.EventHandler(this.tbTrazi_TextChanged);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(28, 116);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(105, 26);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            this.cbFilter.TextChanged += new System.EventHandler(this.cbFilter_TextChanged);
            // 
            // gbPretrage
            // 
            this.gbPretrage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbPretrage.BackColor = System.Drawing.SystemColors.Control;
            this.gbPretrage.Controls.Add(this.rbTip);
            this.gbPretrage.Controls.Add(this.rbIme);
            this.gbPretrage.Controls.Add(this.tbTrazi);
            this.gbPretrage.Controls.Add(this.cbFilter);
            this.gbPretrage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPretrage.Location = new System.Drawing.Point(12, 253);
            this.gbPretrage.Name = "gbPretrage";
            this.gbPretrage.Size = new System.Drawing.Size(209, 165);
            this.gbPretrage.TabIndex = 34;
            this.gbPretrage.TabStop = false;
            this.gbPretrage.Text = "Pretrage";
            // 
            // rbTip
            // 
            this.rbTip.AutoSize = true;
            this.rbTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTip.Location = new System.Drawing.Point(6, 81);
            this.rbTip.Name = "rbTip";
            this.rbTip.Size = new System.Drawing.Size(84, 22);
            this.rbTip.TabIndex = 5;
            this.rbTip.TabStop = true;
            this.rbTip.Text = "Po Tipu";
            this.rbTip.UseVisualStyleBackColor = true;
            // 
            // rbIme
            // 
            this.rbIme.AutoSize = true;
            this.rbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIme.Location = new System.Drawing.Point(106, 80);
            this.rbIme.Name = "rbIme";
            this.rbIme.Size = new System.Drawing.Size(97, 22);
            this.rbIme.TabIndex = 6;
            this.rbIme.TabStop = true;
            this.rbIme.Text = "Po Imenu";
            this.rbIme.UseVisualStyleBackColor = true;
            // 
            // TabelaPrikaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 487);
            this.Controls.Add(this.gbPretrage);
            this.Controls.Add(this.gbDet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblB);
            this.Controls.Add(this.tblI);
            this.Controls.Add(this.tblD);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1181, 526);
            this.MinimumSize = new System.Drawing.Size(1181, 526);
            this.Name = "TabelaPrikaza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela prikaza resursa";
            this.Load += new System.EventHandler(this.tabelaPrikaza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabIm)).EndInit();
            this.gbDet.ResumeLayout(false);
            this.gbDet.PerformLayout();
            this.gbPretrage.ResumeLayout(false);
            this.gbPretrage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tblD;
        private System.Windows.Forms.Button tblI;
        private System.Windows.Forms.Button tblB;
        private System.Windows.Forms.PictureBox tabIm;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbDet;
        private System.Windows.Forms.TextBox tbTrazi;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label ttOp;
        private System.Windows.Forms.Label ttTip;
        private System.Windows.Forms.Label ttIm;
        private System.Windows.Forms.Label ttOz;
        private System.Windows.Forms.Label ttEtik;
        private System.Windows.Forms.Label ttStv;
        private System.Windows.Forms.Label ttObn;
        private System.Windows.Forms.Label ttEkspl;
        private System.Windows.Forms.Label ttDatum;
        private System.Windows.Forms.Label ttCen;
        private System.Windows.Forms.Label ttJm;
        private System.Windows.Forms.Label ttFv;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPretrage;
        private System.Windows.Forms.RadioButton rbTip;
        private System.Windows.Forms.RadioButton rbIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oznaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednica_mere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etiketa;

    }
}