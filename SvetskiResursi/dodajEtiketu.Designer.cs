namespace SvetskiResursi
{
    partial class dodajEtiketu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodajEtiketu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.RichTextBox();
            this.oznaka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lBoja = new System.Windows.Forms.Label();
            this.errorProviderEt = new System.Windows.Forms.ErrorProvider(this.components);
            this.obavE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oznaka:*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boja:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "-* polja su obavezna za unos";
            // 
            // opis
            // 
            this.opis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.opis.Location = new System.Drawing.Point(117, 118);
            this.opis.Margin = new System.Windows.Forms.Padding(4);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(297, 131);
            this.opis.TabIndex = 3;
            this.opis.Text = "";
            // 
            // oznaka
            // 
            this.oznaka.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.oznaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oznaka.Location = new System.Drawing.Point(115, 10);
            this.oznaka.Margin = new System.Windows.Forms.Padding(4);
            this.oznaka.Name = "oznaka";
            this.oznaka.Size = new System.Drawing.Size(164, 23);
            this.oznaka.TabIndex = 1;
            this.oznaka.Tag = "";
            this.oznaka.TextChanged += new System.EventHandler(this.oznaka_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(117, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Biraj boju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.izborBoje);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(204, 270);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "U redu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.potvrdi_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(302, 270);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "Otkaži";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lBoja
            // 
            this.lBoja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lBoja.AutoSize = true;
            this.lBoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoja.ForeColor = System.Drawing.SystemColors.Control;
            this.lBoja.Location = new System.Drawing.Point(320, 66);
            this.lBoja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBoja.Name = "lBoja";
            this.lBoja.Size = new System.Drawing.Size(55, 15);
            this.lBoja.TabIndex = 4;
            this.lBoja.Text = "                ";
            // 
            // errorProviderEt
            // 
            this.errorProviderEt.ContainerControl = this;
            // 
            // obavE
            // 
            this.obavE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.obavE.AutoSize = true;
            this.obavE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obavE.ForeColor = System.Drawing.SystemColors.Control;
            this.obavE.Location = new System.Drawing.Point(114, 37);
            this.obavE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.obavE.Name = "obavE";
            this.obavE.Size = new System.Drawing.Size(56, 16);
            this.obavE.TabIndex = 10;
            this.obavE.Text = "                ";
            // 
            // dodajEtiketu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 384);
            this.Controls.Add(this.obavE);
            this.Controls.Add(this.lBoja);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oznaka);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "dodajEtiketu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje etikete";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ErrorProvider errorProviderEt;
        public System.Windows.Forms.RichTextBox opis;
        public System.Windows.Forms.TextBox oznaka;
        public System.Windows.Forms.Label lBoja;
        public System.Windows.Forms.Label obavE;
    }
}