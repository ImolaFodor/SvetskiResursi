namespace SvetskiResursi
{
    partial class dodajResurs
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
            this.components = new System.ComponentModel.Container();
            this.oznaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipResursa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.RichTextBox();
            this.ikonica = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMera = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cena = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rbEkp1 = new System.Windows.Forms.RadioButton();
            this.rbEksp2 = new System.Windows.Forms.RadioButton();
            this.rbSV2 = new System.Windows.Forms.RadioButton();
            this.rbSV1 = new System.Windows.Forms.RadioButton();
            this.rbObn2 = new System.Windows.Forms.RadioButton();
            this.rbObn1 = new System.Windows.Forms.RadioButton();
            this.errorProviderOz = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTp = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Vizualizacija = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Vizualizacija.SuspendLayout();
            this.SuspendLayout();
            // 
            // oznaka
            // 
            this.oznaka.Location = new System.Drawing.Point(172, 40);
            this.oznaka.Margin = new System.Windows.Forms.Padding(4);
            this.oznaka.Name = "oznaka";
            this.oznaka.Size = new System.Drawing.Size(164, 24);
            this.oznaka.TabIndex = 0;
            this.oznaka.Validating += new System.ComponentModel.CancelEventHandler(this.oznaka_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oznaka*:";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(172, 81);
            this.ime.Margin = new System.Windows.Forms.Padding(4);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(164, 24);
            this.ime.TabIndex = 2;
            this.ime.Validating += new System.ComponentModel.CancelEventHandler(this.ime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip resursa*:";
            // 
            // comboTipResursa
            // 
            this.comboTipResursa.FormattingEnabled = true;
            this.comboTipResursa.Location = new System.Drawing.Point(172, 118);
            this.comboTipResursa.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipResursa.Name = "comboTipResursa";
            this.comboTipResursa.Size = new System.Drawing.Size(164, 26);
            this.comboTipResursa.TabIndex = 6;
            this.comboTipResursa.Validating += new System.ComponentModel.CancelEventHandler(this.comboTipResursa_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis:";
            // 
            // opis
            // 
            this.opis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opis.Location = new System.Drawing.Point(172, 156);
            this.opis.Margin = new System.Windows.Forms.Padding(4);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(221, 78);
            this.opis.TabIndex = 9;
            this.opis.Text = "";
            // 
            // ikonica
            // 
            this.ikonica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ikonica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ikonica.Location = new System.Drawing.Point(117, 44);
            this.ikonica.Margin = new System.Windows.Forms.Padding(4);
            this.ikonica.Name = "ikonica";
            this.ikonica.Size = new System.Drawing.Size(100, 100);
            this.ikonica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ikonica.TabIndex = 10;
            this.ikonica.TabStop = false;
            this.ikonica.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ikonica:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Obnovljivo?";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(589, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Moguca eksploatacija?";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(589, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Od strateske vaznosti?";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Jedinica mere:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cena: ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Datum otkrivanja:";
            // 
            // cbMera
            // 
            this.cbMera.AccessibleName = "";
            this.cbMera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMera.FormattingEnabled = true;
            this.cbMera.Items.AddRange(new object[] {
            "Merica",
            "Barel",
            "Tona",
            "Kilogram"});
            this.cbMera.Location = new System.Drawing.Point(279, 46);
            this.cbMera.Margin = new System.Windows.Forms.Padding(4);
            this.cbMera.Name = "cbMera";
            this.cbMera.Size = new System.Drawing.Size(164, 26);
            this.cbMera.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(279, 82);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 24);
            this.textBox3.TabIndex = 22;
            this.cena.SetToolTip(this.textBox3, "U dolarima");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 151);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(270, 24);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(132, 152);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 24;
            this.button1.Text = "Izaberi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 114);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 36);
            this.label12.TabIndex = 25;
            this.label12.Text = "Frekvencija\r\nponaljvanja:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Redak",
            "Cest",
            "Univerzalan"});
            this.comboBox6.Location = new System.Drawing.Point(279, 114);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(164, 26);
            this.comboBox6.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(721, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 27;
            this.button2.Text = "Potvrdi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(884, 511);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 32);
            this.button3.TabIndex = 28;
            this.button3.Text = "Otkazi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cena
            // 
            this.cena.AutomaticDelay = 100;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 544);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "-* polja su obavezna za unos";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(254, 40);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 18);
            this.label14.TabIndex = 31;
            this.label14.Text = "Etiketa:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(327, 45);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(156, 156);
            this.checkedListBox1.TabIndex = 33;
            // 
            // rbEkp1
            // 
            this.rbEkp1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbEkp1.AutoSize = true;
            this.rbEkp1.Location = new System.Drawing.Point(801, 42);
            this.rbEkp1.Margin = new System.Windows.Forms.Padding(4);
            this.rbEkp1.Name = "rbEkp1";
            this.rbEkp1.Size = new System.Drawing.Size(48, 22);
            this.rbEkp1.TabIndex = 34;
            this.rbEkp1.Text = "DA";
            this.rbEkp1.UseVisualStyleBackColor = true;
            // 
            // rbEksp2
            // 
            this.rbEksp2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbEksp2.AutoSize = true;
            this.rbEksp2.Location = new System.Drawing.Point(857, 44);
            this.rbEksp2.Margin = new System.Windows.Forms.Padding(4);
            this.rbEksp2.Name = "rbEksp2";
            this.rbEksp2.Size = new System.Drawing.Size(49, 22);
            this.rbEksp2.TabIndex = 35;
            this.rbEksp2.Text = "NE";
            this.rbEksp2.UseVisualStyleBackColor = true;
            // 
            // rbSV2
            // 
            this.rbSV2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbSV2.AutoSize = true;
            this.rbSV2.Location = new System.Drawing.Point(857, 120);
            this.rbSV2.Margin = new System.Windows.Forms.Padding(4);
            this.rbSV2.Name = "rbSV2";
            this.rbSV2.Size = new System.Drawing.Size(49, 22);
            this.rbSV2.TabIndex = 38;
            this.rbSV2.TabStop = true;
            this.rbSV2.Text = "NE";
            this.rbSV2.UseVisualStyleBackColor = true;
            // 
            // rbSV1
            // 
            this.rbSV1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbSV1.AutoSize = true;
            this.rbSV1.Location = new System.Drawing.Point(801, 120);
            this.rbSV1.Margin = new System.Windows.Forms.Padding(4);
            this.rbSV1.Name = "rbSV1";
            this.rbSV1.Size = new System.Drawing.Size(48, 22);
            this.rbSV1.TabIndex = 39;
            this.rbSV1.TabStop = true;
            this.rbSV1.Text = "DA";
            this.rbSV1.UseVisualStyleBackColor = true;
            // 
            // rbObn2
            // 
            this.rbObn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbObn2.AutoSize = true;
            this.rbObn2.Location = new System.Drawing.Point(857, 80);
            this.rbObn2.Margin = new System.Windows.Forms.Padding(4);
            this.rbObn2.Name = "rbObn2";
            this.rbObn2.Size = new System.Drawing.Size(49, 22);
            this.rbObn2.TabIndex = 40;
            this.rbObn2.Text = "NE";
            this.rbObn2.UseVisualStyleBackColor = true;
            // 
            // rbObn1
            // 
            this.rbObn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbObn1.AutoSize = true;
            this.rbObn1.Location = new System.Drawing.Point(801, 80);
            this.rbObn1.Margin = new System.Windows.Forms.Padding(4);
            this.rbObn1.Name = "rbObn1";
            this.rbObn1.Size = new System.Drawing.Size(48, 22);
            this.rbObn1.TabIndex = 41;
            this.rbObn1.TabStop = true;
            this.rbObn1.Text = "DA";
            this.rbObn1.UseVisualStyleBackColor = true;
            // 
            // errorProviderOz
            // 
            this.errorProviderOz.ContainerControl = this;
            // 
            // errorProviderIm
            // 
            this.errorProviderIm.ContainerControl = this;
            // 
            // errorProviderTp
            // 
            this.errorProviderTp.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.oznaka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboTipResursa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.opis);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 241);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbMera);
            this.groupBox2.Controls.Add(this.rbEksp2);
            this.groupBox2.Controls.Add(this.rbSV2);
            this.groupBox2.Controls.Add(this.rbEkp1);
            this.groupBox2.Controls.Add(this.rbSV1);
            this.groupBox2.Controls.Add(this.rbObn2);
            this.groupBox2.Controls.Add(this.rbObn1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 196);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalji";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Vizualizacija
            // 
            this.Vizualizacija.Controls.Add(this.label5);
            this.Vizualizacija.Controls.Add(this.ikonica);
            this.Vizualizacija.Controls.Add(this.button1);
            this.Vizualizacija.Controls.Add(this.label14);
            this.Vizualizacija.Controls.Add(this.checkedListBox1);
            this.Vizualizacija.Location = new System.Drawing.Point(513, 13);
            this.Vizualizacija.Name = "Vizualizacija";
            this.Vizualizacija.Size = new System.Drawing.Size(534, 241);
            this.Vizualizacija.TabIndex = 44;
            this.Vizualizacija.TabStop = false;
            this.Vizualizacija.Text = "Vizualizacija";
            // 
            // dodajResurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 579);
            this.Controls.Add(this.Vizualizacija);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dodajResurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAVANJE RESURSA";
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Vizualizacija.ResumeLayout(false);
            this.Vizualizacija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oznaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipResursa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox opis;
        private System.Windows.Forms.PictureBox ikonica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMera;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip cena;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton rbEkp1;
        private System.Windows.Forms.RadioButton rbEksp2;
        private System.Windows.Forms.RadioButton rbSV2;
        private System.Windows.Forms.RadioButton rbSV1;
        private System.Windows.Forms.RadioButton rbObn2;
        private System.Windows.Forms.RadioButton rbObn1;
        private System.Windows.Forms.ErrorProvider errorProviderOz;
        private System.Windows.Forms.ErrorProvider errorProviderIm;
        private System.Windows.Forms.ErrorProvider errorProviderTp;
        private System.Windows.Forms.GroupBox Vizualizacija;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

