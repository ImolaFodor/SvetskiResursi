namespace HCI_projekat
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipResursa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ikonica = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEkpl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbVaznost = new System.Windows.Forms.ComboBox();
            this.cbObnovljivo = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oznaka*:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime*:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tip resursa*:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboTipResursa
            // 
            this.comboTipResursa.FormattingEnabled = true;
            this.comboTipResursa.Location = new System.Drawing.Point(74, 109);
            this.comboTipResursa.Name = "comboTipResursa";
            this.comboTipResursa.Size = new System.Drawing.Size(121, 21);
            this.comboTipResursa.TabIndex = 6;
            this.comboTipResursa.SelectedIndexChanged += new System.EventHandler(this.comboTipResursa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // ikonica
            // 
            this.ikonica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ikonica.Location = new System.Drawing.Point(74, 275);
            this.ikonica.Name = "ikonica";
            this.ikonica.Size = new System.Drawing.Size(100, 50);
            this.ikonica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ikonica.TabIndex = 10;
            this.ikonica.TabStop = false;
            this.ikonica.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ikonica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Obnovljivo?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Moguca eksploatacija?";
            // 
            // cbEkpl
            // 
            this.cbEkpl.FormattingEnabled = true;
            this.cbEkpl.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.cbEkpl.Location = new System.Drawing.Point(372, 11);
            this.cbEkpl.Name = "cbEkpl";
            this.cbEkpl.Size = new System.Drawing.Size(121, 21);
            this.cbEkpl.TabIndex = 14;
            this.cbEkpl.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Od strateske vaznosti?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbVaznost
            // 
            this.cbVaznost.FormattingEnabled = true;
            this.cbVaznost.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.cbVaznost.Location = new System.Drawing.Point(372, 117);
            this.cbVaznost.Name = "cbVaznost";
            this.cbVaznost.Size = new System.Drawing.Size(121, 21);
            this.cbVaznost.TabIndex = 16;
            // 
            // cbObnovljivo
            // 
            this.cbObnovljivo.FormattingEnabled = true;
            this.cbObnovljivo.Items.AddRange(new object[] {
            "DA",
            "NE"});
            this.cbObnovljivo.Location = new System.Drawing.Point(372, 61);
            this.cbObnovljivo.Name = "cbObnovljivo";
            this.cbObnovljivo.Size = new System.Drawing.Size(121, 21);
            this.cbObnovljivo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Jedinica mere:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cena: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(226, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Datum otkrivanja:";
            // 
            // cbMera
            // 
            this.cbMera.FormattingEnabled = true;
            this.cbMera.Items.AddRange(new object[] {
            "Merica",
            "Barel",
            "Tona",
            "Kilogram"});
            this.cbMera.Location = new System.Drawing.Point(372, 188);
            this.cbMera.Name = "cbMera";
            this.cbMera.Size = new System.Drawing.Size(121, 21);
            this.cbMera.TabIndex = 21;
            this.cbMera.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 22;
            this.cena.SetToolTip(this.textBox3, "U dolarima");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 241);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Izaberi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(226, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Frekvencija ponaljvanja:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Redak",
            "Cest",
            "Univerzalan"});
            this.comboBox6.Location = new System.Drawing.Point(372, 275);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(397, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(497, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cena
            // 
            this.cena.AutomaticDelay = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "-* polja su obavezna za unos";
            // 
            // FormV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 404);
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
            this.Controls.Add(this.cbObnovljivo);
            this.Controls.Add(this.cbVaznost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEkpl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ikonica);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipResursa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje resursa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipResursa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox ikonica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEkpl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbVaznost;
        private System.Windows.Forms.ComboBox cbObnovljivo;
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
    }
}

