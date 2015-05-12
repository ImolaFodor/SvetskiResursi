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
            this.oznaka_tip.TabIndex = 0;
            this.oznaka_tip.Validating += new System.ComponentModel.CancelEventHandler(this.oznaka_tip_Validating);
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
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:*";
            // 
            // ime_tip
            // 
            this.ime_tip.Location = new System.Drawing.Point(127, 61);
            this.ime_tip.Margin = new System.Windows.Forms.Padding(4);
            this.ime_tip.Name = "ime_tip";
            this.ime_tip.Size = new System.Drawing.Size(164, 24);
            this.ime_tip.TabIndex = 3;
            this.ime_tip.Validating += new System.ComponentModel.CancelEventHandler(this.ime_tip_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ikonica*:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opis:";
            // 
            // opis_tip
            // 
            this.opis_tip.Location = new System.Drawing.Point(126, 262);
            this.opis_tip.Margin = new System.Windows.Forms.Padding(4);
            this.opis_tip.Name = "opis_tip";
            this.opis_tip.Size = new System.Drawing.Size(264, 104);
            this.opis_tip.TabIndex = 6;
            this.opis_tip.Text = "";
            // 
            // ikonica
            // 
            this.ikonica.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ikonica.Location = new System.Drawing.Point(127, 104);
            this.ikonica.Margin = new System.Windows.Forms.Padding(4);
            this.ikonica.Name = "ikonica";
            this.ikonica.Size = new System.Drawing.Size(164, 92);
            this.ikonica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ikonica.TabIndex = 7;
            this.ikonica.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Učitaj sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 466);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "-* polja su obavezna za unos";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(208, 394);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "U redu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.potvrdi_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(301, 394);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 32);
            this.button3.TabIndex = 11;
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
            // dodajTipResursa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 497);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "dodajTipResursa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj tip resursa";
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
    }
}