namespace JobbUszoverseny {
    partial class Form1 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuMegnyit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileMenuKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerseny = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEredmeny = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNevjegy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.menuFile, this.menuVerseny, this.menuEredmeny, this.menuNevjegy });
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(519, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileMenuMegnyit, this.toolStripSeparator1, this.fileMenuMentes, this.toolStripSeparator2, this.fileMenuKilepes });
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "Fájl";
            // 
            // fileMenuMegnyit
            // 
            this.fileMenuMegnyit.Name = "fileMenuMegnyit";
            this.fileMenuMegnyit.Size = new System.Drawing.Size(152, 22);
            this.fileMenuMegnyit.Text = "Megnyitás";
            this.fileMenuMegnyit.Click += new System.EventHandler(this.fileMenuMegnyit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // fileMenuMentes
            // 
            this.fileMenuMentes.Name = "fileMenuMentes";
            this.fileMenuMentes.Size = new System.Drawing.Size(152, 22);
            this.fileMenuMentes.Text = "Mentés";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // fileMenuKilepes
            // 
            this.fileMenuKilepes.Name = "fileMenuKilepes";
            this.fileMenuKilepes.Size = new System.Drawing.Size(152, 22);
            this.fileMenuKilepes.Text = "Kilépés";
            this.fileMenuKilepes.Click += new System.EventHandler(this.fileMenuKilepes_Click);
            // 
            // menuVerseny
            // 
            this.menuVerseny.Enabled = false;
            this.menuVerseny.Name = "menuVerseny";
            this.menuVerseny.Size = new System.Drawing.Size(59, 20);
            this.menuVerseny.Text = "Verseny";
            // 
            // menuEredmeny
            // 
            this.menuEredmeny.Enabled = false;
            this.menuEredmeny.Name = "menuEredmeny";
            this.menuEredmeny.Size = new System.Drawing.Size(72, 20);
            this.menuEredmeny.Text = "Eredmény";
            // 
            // menuNevjegy
            // 
            this.menuNevjegy.Name = "menuNevjegy";
            this.menuNevjegy.Size = new System.Drawing.Size(62, 20);
            this.menuNevjegy.Text = "Névjegy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem fileMenuMegnyit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fileMenuMentes;
        private System.Windows.Forms.ToolStripMenuItem fileMenuKilepes;

        private System.Windows.Forms.ToolStripMenuItem menuEredmeny;
        private System.Windows.Forms.ToolStripMenuItem menuVerseny;

        private System.Windows.Forms.ToolStripMenuItem menuNevjegy;

        private System.Windows.Forms.ToolStripMenuItem menuFile;

        private System.Windows.Forms.MenuStrip menu;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}