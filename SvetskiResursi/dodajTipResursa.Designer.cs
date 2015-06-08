namespace SvetskiResursi
{
    partial class dodajTipResursa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajTipResursa));
            this.oznaka_tip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ime_tip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opis_tip = new System.Windows.Forms.RichTextBox();
            this.ikonica = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProviderIm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOz = new System.Windows.Forms.ErrorProvider(this.components);
            this.obavOz = new System.Windows.Forms.Label();
            this.obavIm = new System.Windows.Forms.Label();
            this.obavSl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOz)).BeginInit();
            this.SuspendLayout();
            // 
            // oznaka_tip
            // 
            this.oznaka_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oznaka_tip.Location = new System.Drawing.Point(127, 12);
            this.oznaka_tip.Margin = new System.Windows.Forms.Padding(4);
            this.oznaka_tip.Name = "oznaka_tip";
            this.oznaka_tip.Size = new System.Drawing.Size(164, 23);
            this.oznaka_tip.TabIndex = 1;
            this.oznaka_tip.TextChanged += new System.EventHandler(this.oznaka_tip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oznaka:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:*";
            // 
            // ime_tip
            // 
            this.ime_tip.Location = new System.Drawing.Point(127, 72);
            this.ime_tip.Margin = new System.Windows.Forms.Padding(4);
            this.ime_tip.Name = "ime_tip";
            this.ime_tip.Size = new System.Drawing.Size(164, 24);
            this.ime_tip.TabIndex = 2;
            this.ime_tip.TextChanged += new System.EventHandler(this.ime_tip_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ikonica*:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 307);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opis:";
            // 
            // opis_tip
            // 
            this.opis_tip.Location = new System.Drawing.Point(126, 307);
            this.opis_tip.Margin = new System.Windows.Forms.Padding(4);
            this.opis_tip.Name = "opis_tip";
            this.opis_tip.Size = new System.Drawing.Size(264, 104);
            this.opis_tip.TabIndex = 4;
            this.opis_tip.Text = "";
            // 
            // ikonica
            // 
            this.ikonica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ikonica.Location = new System.Drawing.Point(126, 133);
            this.ikonica.Margin = new System.Windows.Forms.Padding(4);
            this.ikonica.Name = "ikonica";
            this.ikonica.Size = new System.Drawing.Size(164, 92);
            this.ikonica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ikonica.TabIndex = 7;
            this.ikonica.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Učitaj sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.izborSlike_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "-* polja su obavezna za unos";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(208, 419);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "U redu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.potvrdi_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(301, 419);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Otkaži";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProviderIm
            // 
            this.errorProviderIm.ContainerControl = this;
            // 
            // errorProviderOz
            // 
            this.errorProviderOz.ContainerControl = this;
            // 
            // obavOz
            // 
            this.obavOz.AutoSize = true;
            this.obavOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obavOz.Location = new System.Drawing.Point(124, 39);
            this.obavOz.Name = "obavOz";
            this.obavOz.Size = new System.Drawing.Size(48, 16);
            this.obavOz.TabIndex = 12;
            this.obavOz.Text = "          ";
            // 
            // obavIm
            // 
            this.obavIm.AutoSize = true;
            this.obavIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obavIm.Location = new System.Drawing.Point(124, 100);
            this.obavIm.Name = "obavIm";
            this.obavIm.Size = new System.Drawing.Size(48, 16);
            this.obavIm.TabIndex = 13;
            this.obavIm.Text = "          ";
            // 
            // obavSl
            // 
            this.obavSl.AutoSize = true;
            this.obavSl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obavSl.Location = new System.Drawing.Point(124, 229);
            this.obavSl.Name = "obavSl";
            this.obavSl.Size = new System.Drawing.Size(48, 16);
            this.obavSl.TabIndex = 14;
            this.obavSl.Text = "          ";
            // 
            // dodajTipResursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 497);
            this.Controls.Add(this.obavSl);
            this.Controls.Add(this.obavIm);
            this.Controls.Add(this.obavOz);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ikonica);
            this.Controls.Add(this.opis_tip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ime_tip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oznaka_tip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "dodajTipResursa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje tipa resursa";
            ((System.ComponentModel.ISupportInitialize)(this.ikonica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProviderIm;
        private System.Windows.Forms.ErrorProvider errorProviderOz;
        public System.Windows.Forms.TextBox oznaka_tip;
        public System.Windows.Forms.TextBox ime_tip;
        public System.Windows.Forms.RichTextBox opis_tip;
        public System.Windows.Forms.PictureBox ikonica;
        private System.Windows.Forms.Label obavSl;
        private System.Windows.Forms.Label obavIm;
        private System.Windows.Forms.Label obavOz;
    }
}