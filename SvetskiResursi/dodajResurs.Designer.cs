﻿namespace HCI_projekat
{
    partial class FormV
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
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).BeginInit();
            this.SuspendLayout();
            // 
            // oznaka
            // 
            this.oznaka.Location = new System.Drawing.Point(74, 12);
            this.oznaka.Name = "oznaka";
            this.oznaka.Size = new System.Drawing.Size(100, 20);
            this.oznaka.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oznaka*:";
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(74, 43);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(100, 20);
            this.ime.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip resursa*:";
            // 
            // comboTipResursa
            // 
            this.comboTipResursa.FormattingEnabled = true;
            this.comboTipResursa.Location = new System.Drawing.Point(74, 76);
            this.comboTipResursa.Name = "comboTipResursa";
            this.comboTipResursa.Size = new System.Drawing.Size(100, 21);
            this.comboTipResursa.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis:";
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(293, 219);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(103, 100);
            this.opis.TabIndex = 9;
            this.opis.Text = "";
            // 
            // ikonica
            // 
            this.ikonica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ikonica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ikonica.Location = new System.Drawing.Point(74, 219);
            this.ikonica.Name = "ikonica";
            this.ikonica.Size = new System.Drawing.Size(100, 100);
            this.ikonica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ikonica.TabIndex = 10;
            this.ikonica.TabStop = false;
            this.ikonica.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ikonica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Obnovljivo?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Moguca eksploatacija?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Od strateske vaznosti?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(241, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Jedinica mere:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(241, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cena: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(241, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Datum otkrivanja:";
            // 
            // cbMera
            // 
            this.cbMera.AccessibleName = "";
            this.cbMera.FormattingEnabled = true;
            this.cbMera.Items.AddRange(new object[] {
            "Merica",
            "Barel",
            "Tona",
            "Kilogram"});
            this.cbMera.Location = new System.Drawing.Point(360, 6);
            this.cbMera.Name = "cbMera";
            this.cbMera.Size = new System.Drawing.Size(200, 21);
            this.cbMera.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 22;
            this.cena.SetToolTip(this.textBox3, "U dolarima");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(90, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Izaberi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 26);
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
            this.comboBox6.Location = new System.Drawing.Point(74, 112);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(100, 21);
            this.comboBox6.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(436, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Potvrdi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(529, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
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
            this.label13.Location = new System.Drawing.Point(2, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "-* polja su obavezna za unos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(431, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Etiketa:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(493, 219);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(109, 94);
            this.checkedListBox1.TabIndex = 33;
            // 
            // rbEkp1
            // 
            this.rbEkp1.AutoSize = true;
            this.rbEkp1.Location = new System.Drawing.Point(125, 166);
            this.rbEkp1.Name = "rbEkp1";
            this.rbEkp1.Size = new System.Drawing.Size(40, 17);
            this.rbEkp1.TabIndex = 34;
            this.rbEkp1.TabStop = true;
            this.rbEkp1.Text = "DA";
            this.rbEkp1.UseVisualStyleBackColor = true;
            // 
            // rbEksp2
            // 
            this.rbEksp2.AutoSize = true;
            this.rbEksp2.Location = new System.Drawing.Point(171, 166);
            this.rbEksp2.Name = "rbEksp2";
            this.rbEksp2.Size = new System.Drawing.Size(40, 17);
            this.rbEksp2.TabIndex = 35;
            this.rbEksp2.TabStop = true;
            this.rbEksp2.Text = "NE";
            this.rbEksp2.UseVisualStyleBackColor = true;
            // 
            // rbSV2
            // 
            this.rbSV2.AutoSize = true;
            this.rbSV2.Location = new System.Drawing.Point(598, 164);
            this.rbSV2.Name = "rbSV2";
            this.rbSV2.Size = new System.Drawing.Size(40, 17);
            this.rbSV2.TabIndex = 38;
            this.rbSV2.TabStop = true;
            this.rbSV2.Text = "NE";
            this.rbSV2.UseVisualStyleBackColor = true;
            // 
            // rbSV1
            // 
            this.rbSV1.AutoSize = true;
            this.rbSV1.Location = new System.Drawing.Point(552, 164);
            this.rbSV1.Name = "rbSV1";
            this.rbSV1.Size = new System.Drawing.Size(40, 17);
            this.rbSV1.TabIndex = 39;
            this.rbSV1.TabStop = true;
            this.rbSV1.Text = "DA";
            this.rbSV1.UseVisualStyleBackColor = true;
            // 
            // rbObn2
            // 
            this.rbObn2.AutoSize = true;
            this.rbObn2.Location = new System.Drawing.Point(356, 162);
            this.rbObn2.Name = "rbObn2";
            this.rbObn2.Size = new System.Drawing.Size(40, 17);
            this.rbObn2.TabIndex = 40;
            this.rbObn2.TabStop = true;
            this.rbObn2.Text = "NE";
            this.rbObn2.UseVisualStyleBackColor = true;
            // 
            // rbObn1
            // 
            this.rbObn1.AutoSize = true;
            this.rbObn1.Location = new System.Drawing.Point(310, 162);
            this.rbObn1.Name = "rbObn1";
            this.rbObn1.Size = new System.Drawing.Size(40, 17);
            this.rbObn1.TabIndex = 41;
            this.rbObn1.TabStop = true;
            this.rbObn1.Text = "DA";
            this.rbObn1.UseVisualStyleBackColor = true;
            // 
            // FormV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 418);
            this.Controls.Add(this.rbObn1);
            this.Controls.Add(this.rbObn2);
            this.Controls.Add(this.rbSV1);
            this.Controls.Add(this.rbSV2);
            this.Controls.Add(this.rbEksp2);
            this.Controls.Add(this.rbEkp1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cbMera);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ikonica);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipResursa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oznaka);
            this.Name = "FormV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje resursa";
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).EndInit();
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
    }
}

