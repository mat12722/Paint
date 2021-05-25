
namespace PaintMateuszMróz54307
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonKolo = new System.Windows.Forms.Button();
            this.button_Prostokat = new System.Windows.Forms.Button();
            this.buttonTlo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_PenKolor = new System.Windows.Forms.Button();
            this.comboBox_WielkoscP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Linia = new System.Windows.Forms.Button();
            this.Gumka = new System.Windows.Forms.Button();
            this.Trujkat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trujkat1 = new System.Windows.Forms.Button();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.widokToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.toolStripMenuItem1,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako";
            this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.zapiszJakoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.Trujkat1);
            this.panel2.Controls.Add(this.Trujkat);
            this.panel2.Controls.Add(this.Gumka);
            this.panel2.Controls.Add(this.Linia);
            this.panel2.Controls.Add(this.buttonEllipse);
            this.panel2.Controls.Add(this.buttonKolo);
            this.panel2.Controls.Add(this.button_Prostokat);
            this.panel2.Controls.Add(this.buttonTlo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_PenKolor);
            this.panel2.Controls.Add(this.comboBox_WielkoscP);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 701);
            this.panel2.TabIndex = 2;
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(0, 283);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(113, 23);
            this.buttonEllipse.TabIndex = 10;
            this.buttonEllipse.Text = "Elipsa";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonKolo
            // 
            this.buttonKolo.Location = new System.Drawing.Point(-1, 253);
            this.buttonKolo.Name = "buttonKolo";
            this.buttonKolo.Size = new System.Drawing.Size(114, 23);
            this.buttonKolo.TabIndex = 8;
            this.buttonKolo.Text = "Koło";
            this.buttonKolo.UseVisualStyleBackColor = true;
            this.buttonKolo.Click += new System.EventHandler(this.buttonKolo_Click);
            // 
            // button_Prostokat
            // 
            this.button_Prostokat.Location = new System.Drawing.Point(-1, 223);
            this.button_Prostokat.Name = "button_Prostokat";
            this.button_Prostokat.Size = new System.Drawing.Size(114, 23);
            this.button_Prostokat.TabIndex = 7;
            this.button_Prostokat.Text = "Prostokąt";
            this.button_Prostokat.UseVisualStyleBackColor = true;
            this.button_Prostokat.Click += new System.EventHandler(this.button_Prostokat_Click);
            // 
            // buttonTlo
            // 
            this.buttonTlo.BackColor = System.Drawing.Color.White;
            this.buttonTlo.Location = new System.Drawing.Point(-1, 131);
            this.buttonTlo.Name = "buttonTlo";
            this.buttonTlo.Size = new System.Drawing.Size(114, 23);
            this.buttonTlo.TabIndex = 5;
            this.buttonTlo.UseVisualStyleBackColor = false;
            this.buttonTlo.Click += new System.EventHandler(this.buttonTlo_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Figury";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(-1, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(113, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tło";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_PenKolor
            // 
            this.button_PenKolor.BackColor = System.Drawing.Color.Black;
            this.button_PenKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_PenKolor.Location = new System.Drawing.Point(-1, 68);
            this.button_PenKolor.Name = "button_PenKolor";
            this.button_PenKolor.Size = new System.Drawing.Size(114, 23);
            this.button_PenKolor.TabIndex = 2;
            this.button_PenKolor.UseVisualStyleBackColor = false;
            this.button_PenKolor.Click += new System.EventHandler(this.button_PenKolor_Click);
            // 
            // comboBox_WielkoscP
            // 
            this.comboBox_WielkoscP.FormattingEnabled = true;
            this.comboBox_WielkoscP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_WielkoscP.Location = new System.Drawing.Point(-1, 41);
            this.comboBox_WielkoscP.Name = "comboBox_WielkoscP";
            this.comboBox_WielkoscP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_WielkoscP.Size = new System.Drawing.Size(113, 21);
            this.comboBox_WielkoscP.TabIndex = 1;
            this.comboBox_WielkoscP.Tag = "";
            this.comboBox_WielkoscP.Text = "1";
            this.comboBox_WielkoscP.SelectedIndexChanged += new System.EventHandler(this.comboBox_WielkoscP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pędzel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Linia
            // 
            this.Linia.Location = new System.Drawing.Point(-1, 194);
            this.Linia.Name = "Linia";
            this.Linia.Size = new System.Drawing.Size(114, 23);
            this.Linia.TabIndex = 11;
            this.Linia.Text = "Linia";
            this.Linia.UseVisualStyleBackColor = true;
            this.Linia.Click += new System.EventHandler(this.Linia_Click);
            // 
            // Gumka
            // 
            this.Gumka.Location = new System.Drawing.Point(-1, 372);
            this.Gumka.Name = "Gumka";
            this.Gumka.Size = new System.Drawing.Size(114, 23);
            this.Gumka.TabIndex = 12;
            this.Gumka.Text = "Gumka";
            this.Gumka.UseVisualStyleBackColor = true;
            this.Gumka.Click += new System.EventHandler(this.Gumka_Click);
            // 
            // Trujkat
            // 
            this.Trujkat.Location = new System.Drawing.Point(-1, 313);
            this.Trujkat.Name = "Trujkat";
            this.Trujkat.Size = new System.Drawing.Size(114, 23);
            this.Trujkat.TabIndex = 13;
            this.Trujkat.Text = "Trójkąt rów.";
            this.Trujkat.UseVisualStyleBackColor = true;
            this.Trujkat.Click += new System.EventHandler(this.Trujkat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(132, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1105, 701);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Trujkat1
            // 
            this.Trujkat1.Location = new System.Drawing.Point(0, 343);
            this.Trujkat1.Name = "Trujkat1";
            this.Trujkat1.Size = new System.Drawing.Size(113, 23);
            this.Trujkat1.TabIndex = 14;
            this.Trujkat1.Text = "Trójkąt prost.";
            this.Trujkat1.UseVisualStyleBackColor = true;
            this.Trujkat1.Click += new System.EventHandler(this.Trujkat1_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "notatnik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonKolo;
        private System.Windows.Forms.Button button_Prostokat;
        private System.Windows.Forms.Button buttonTlo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_PenKolor;
        private System.Windows.Forms.ComboBox comboBox_WielkoscP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button Linia;
        private System.Windows.Forms.Button Gumka;
        private System.Windows.Forms.Button Trujkat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Trujkat1;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
    }
}

