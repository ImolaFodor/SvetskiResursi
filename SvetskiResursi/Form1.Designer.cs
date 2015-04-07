using System.Drawing;
namespace SvetskiResursi
{
    partial class Form1
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
        //sad da vidimo 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        Image mp2 = new Bitmap(@".\..\..\Resources\Howls.jpg");
        Image mp1 = new Bitmap(@".\..\..\Resources\WorldMap.jpg");

         private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMape = new System.Windows.Forms.PictureBox();
            this.resursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeTipaResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaPrikazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prikazIkonice = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMape)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazIkonice)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMape
            // 
            this.pbMape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMape.BackgroundImage")));
            this.pbMape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMape.Location = new System.Drawing.Point(258, 54);
            this.pbMape.Name = "pbMape";
            this.pbMape.Size = new System.Drawing.Size(610, 396);
            this.pbMape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMape.TabIndex = 1;
            this.pbMape.TabStop = false;
            // 
            // resursiToolStripMenuItem
            // 
            this.resursiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeResursaToolStripMenuItem,
            this.dodavanjeTipaResursaToolStripMenuItem,
            this.dodavanjeToolStripMenuItem});
            this.resursiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resursiToolStripMenuItem.Name = "resursiToolStripMenuItem";
            this.resursiToolStripMenuItem.Size = new System.Drawing.Size(102, 36);
            this.resursiToolStripMenuItem.Text = "Resursi";
            // 
            // dodavanjeResursaToolStripMenuItem
            // 
            this.dodavanjeResursaToolStripMenuItem.Name = "dodavanjeResursaToolStripMenuItem";
            this.dodavanjeResursaToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.dodavanjeResursaToolStripMenuItem.Text = "Dodavanje resursa";
            this.dodavanjeResursaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeResursaToolStripMenuItem_Click);
            // 
            // dodavanjeTipaResursaToolStripMenuItem
            // 
            this.dodavanjeTipaResursaToolStripMenuItem.Name = "dodavanjeTipaResursaToolStripMenuItem";
            this.dodavanjeTipaResursaToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.dodavanjeTipaResursaToolStripMenuItem.Text = "Dodavanje tipa resursa";
            this.dodavanjeTipaResursaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeTipaResursaToolStripMenuItem_Click);
            // 
            // dodavanjeToolStripMenuItem
            // 
            this.dodavanjeToolStripMenuItem.Name = "dodavanjeToolStripMenuItem";
            this.dodavanjeToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.dodavanjeToolStripMenuItem.Text = "Dodavanje etikete";
            this.dodavanjeToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaPrikazaToolStripMenuItem});
            this.pretragaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            // 
            // tabelaPrikazaToolStripMenuItem
            // 
            this.tabelaPrikazaToolStripMenuItem.Name = "tabelaPrikazaToolStripMenuItem";
            this.tabelaPrikazaToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.tabelaPrikazaToolStripMenuItem.Text = "Tabela prikaza";
            this.tabelaPrikazaToolStripMenuItem.Click += new System.EventHandler(this.tabelaPrikazaToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursiToolStripMenuItem,
            this.pretragaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tip";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oznaka";
            // 
            // prikazIkonice
            // 
            this.prikazIkonice.BackColor = System.Drawing.Color.White;
            this.prikazIkonice.Location = new System.Drawing.Point(139, 280);
            this.prikazIkonice.Name = "prikazIkonice";
            this.prikazIkonice.Size = new System.Drawing.Size(100, 64);
            this.prikazIkonice.TabIndex = 8;
            this.prikazIkonice.TabStop = false;
            this.prikazIkonice.Click += new System.EventHandler(this.prikazIkonice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ikonica";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(174, 156);
            this.listView1.TabIndex = 10;
            this.listView1.Tag = "";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prikazIkonice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMape);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vođenje evidencije o mapi svetskih resursa";
            ((System.ComponentModel.ISupportInitialize)(this.pbMape)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazIkonice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

         private System.Windows.Forms.PictureBox pbMape;
        private System.Windows.Forms.ToolStripMenuItem resursiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeTipaResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox prikazIkonice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tabelaPrikazaToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        
    }
}

