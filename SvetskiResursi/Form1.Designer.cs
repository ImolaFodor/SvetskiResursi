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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMape = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resursiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeTipaResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaPrikazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaTipovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaEtiketaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prikazIkonice = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Detalji = new System.Windows.Forms.GroupBox();
            this.fTip = new System.Windows.Forms.Label();
            this.fIme = new System.Windows.Forms.Label();
            this.fOz = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.filtriranjeTip = new System.Windows.Forms.ComboBox();
            this.brisiSimbol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izbrišiSimbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMape)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazIkonice)).BeginInit();
            this.panel1.SuspendLayout();
            this.Detalji.SuspendLayout();
            this.brisiSimbol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMape
            // 
            this.pbMape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMape.BackgroundImage")));
            this.pbMape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMape.ContextMenuStrip = this.contextMenuStrip1;
            this.pbMape.Location = new System.Drawing.Point(0, 11);
            this.pbMape.Name = "pbMape";
            this.pbMape.Size = new System.Drawing.Size(1799, 1064);
            this.pbMape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMape.TabIndex = 1;
            this.pbMape.TabStop = false;
            this.pbMape.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pbMape.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
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
            this.tabelaPrikazaToolStripMenuItem,
            this.tabelaTipovaToolStripMenuItem,
            this.tabelaEtiketaToolStripMenuItem});
            this.pretragaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(89, 36);
            this.pretragaToolStripMenuItem.Text = "Prikaz";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // tabelaPrikazaToolStripMenuItem
            // 
            this.tabelaPrikazaToolStripMenuItem.Name = "tabelaPrikazaToolStripMenuItem";
            this.tabelaPrikazaToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.tabelaPrikazaToolStripMenuItem.Text = "Tabela resursa";
            this.tabelaPrikazaToolStripMenuItem.Click += new System.EventHandler(this.tabelaPrikazaToolStripMenuItem_Click);
            // 
            // tabelaTipovaToolStripMenuItem
            // 
            this.tabelaTipovaToolStripMenuItem.Name = "tabelaTipovaToolStripMenuItem";
            this.tabelaTipovaToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.tabelaTipovaToolStripMenuItem.Text = "Tabela tipova";
            this.tabelaTipovaToolStripMenuItem.Click += new System.EventHandler(this.tabelaTipovaToolStripMenuItem_Click);
            // 
            // tabelaEtiketaToolStripMenuItem
            // 
            this.tabelaEtiketaToolStripMenuItem.Name = "tabelaEtiketaToolStripMenuItem";
            this.tabelaEtiketaToolStripMenuItem.Size = new System.Drawing.Size(242, 36);
            this.tabelaEtiketaToolStripMenuItem.Text = "Tabela etiketa";
            this.tabelaEtiketaToolStripMenuItem.Click += new System.EventHandler(this.tabelaEtiketaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resursiToolStripMenuItem,
            this.pretragaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineHelpToolStripMenuItem,
            this.tutToolStripMenuItem});
            this.pomocToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.pomocToolStripMenuItem.Text = "Pomoć";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            this.onlineHelpToolStripMenuItem.Size = new System.Drawing.Size(241, 36);
            this.onlineHelpToolStripMenuItem.Text = "Onlajn pomoć";
            this.onlineHelpToolStripMenuItem.Click += new System.EventHandler(this.onlineHelpToolStripMenuItem_Click);
            // 
            // tutToolStripMenuItem
            // 
            this.tutToolStripMenuItem.Name = "tutToolStripMenuItem";
            this.tutToolStripMenuItem.Size = new System.Drawing.Size(241, 36);
            this.tutToolStripMenuItem.Text = "Tutorijal";
            this.tutToolStripMenuItem.Click += new System.EventHandler(this.tutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tip:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oznaka:";
            // 
            // prikazIkonice
            // 
            this.prikazIkonice.BackColor = System.Drawing.Color.White;
            this.prikazIkonice.Location = new System.Drawing.Point(50, 122);
            this.prikazIkonice.Name = "prikazIkonice";
            this.prikazIkonice.Size = new System.Drawing.Size(110, 92);
            this.prikazIkonice.TabIndex = 8;
            this.prikazIkonice.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(218, 303);
            this.listView1.TabIndex = 10;
            this.listView1.Tag = "";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 24);
            this.textBox2.TabIndex = 15;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.TextChanged += new System.EventHandler(this.trazenje_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbMape);
            this.panel1.Location = new System.Drawing.Point(270, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 645);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Detalji
            // 
            this.Detalji.Controls.Add(this.fTip);
            this.Detalji.Controls.Add(this.fIme);
            this.Detalji.Controls.Add(this.fOz);
            this.Detalji.Controls.Add(this.label1);
            this.Detalji.Controls.Add(this.label3);
            this.Detalji.Controls.Add(this.label2);
            this.Detalji.Controls.Add(this.prikazIkonice);
            this.Detalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalji.Location = new System.Drawing.Point(19, 452);
            this.Detalji.Name = "Detalji";
            this.Detalji.Size = new System.Drawing.Size(218, 236);
            this.Detalji.TabIndex = 20;
            this.Detalji.TabStop = false;
            this.Detalji.Text = "Detalji";
            // 
            // fTip
            // 
            this.fTip.AutoSize = true;
            this.fTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTip.Location = new System.Drawing.Point(98, 86);
            this.fTip.Name = "fTip";
            this.fTip.Size = new System.Drawing.Size(72, 18);
            this.fTip.TabIndex = 11;
            this.fTip.Text = "                ";
            // 
            // fIme
            // 
            this.fIme.AutoSize = true;
            this.fIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fIme.Location = new System.Drawing.Point(98, 56);
            this.fIme.Name = "fIme";
            this.fIme.Size = new System.Drawing.Size(60, 18);
            this.fIme.TabIndex = 10;
            this.fIme.Text = "             ";
            // 
            // fOz
            // 
            this.fOz.AutoSize = true;
            this.fOz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fOz.Location = new System.Drawing.Point(98, 31);
            this.fOz.Name = "fOz";
            this.fOz.Size = new System.Drawing.Size(64, 18);
            this.fOz.TabIndex = 9;
            this.fOz.Text = "              ";
            this.fOz.Click += new System.EventHandler(this.fOz_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Imola\\Source\\Repos\\SvetskiResursi3\\SvetskiResursi\\Resources\\Help project" +
    "s\\SR.chm";
            // 
            // filtriranjeTip
            // 
            this.filtriranjeTip.FormattingEnabled = true;
            this.filtriranjeTip.Location = new System.Drawing.Point(90, 53);
            this.filtriranjeTip.Name = "filtriranjeTip";
            this.filtriranjeTip.Size = new System.Drawing.Size(109, 26);
            this.filtriranjeTip.TabIndex = 21;
            this.filtriranjeTip.TextChanged += new System.EventHandler(this.filtriranjeTip_TextChanged);
            this.filtriranjeTip.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filtriranjeTip_MouseClick);
            // 
            // brisiSimbol
            // 
            this.brisiSimbol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbrišiSimbolToolStripMenuItem});
            this.brisiSimbol.Name = "brisiSimbol";
            this.brisiSimbol.Size = new System.Drawing.Size(144, 26);
            // 
            // izbrišiSimbolToolStripMenuItem
            // 
            this.izbrišiSimbolToolStripMenuItem.Name = "izbrišiSimbolToolStripMenuItem";
            this.izbrišiSimbolToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.izbrišiSimbolToolStripMenuItem.Text = "Izbriši simbol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filtriranje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.filtriranjeTip);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 83);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretrage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Detalji);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vođenje evidencije o mapi svetskih resursa";
            ((System.ComponentModel.ISupportInitialize)(this.pbMape)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prikazIkonice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Detalji.ResumeLayout(false);
            this.Detalji.PerformLayout();
            this.brisiSimbol.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox prikazIkonice;
        private System.Windows.Forms.ToolStripMenuItem tabelaPrikazaToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem tabelaTipovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaEtiketaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Detalji;
        public System.Windows.Forms.Label fTip;
        public System.Windows.Forms.Label fIme;
        public System.Windows.Forms.Label fOz;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutToolStripMenuItem;
        private System.Windows.Forms.ComboBox filtriranjeTip;
        private System.Windows.Forms.ContextMenuStrip brisiSimbol;
        private System.Windows.Forms.ToolStripMenuItem izbrišiSimbolToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        
    }
}

