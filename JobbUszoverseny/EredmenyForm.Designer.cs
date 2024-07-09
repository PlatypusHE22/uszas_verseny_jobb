using System.ComponentModel;

namespace JobbUszoverseny {
    partial class EredmenyForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbResztvevok = new System.Windows.Forms.ListBox();
            this.lblResztvevok = new System.Windows.Forms.Label();
            this.lblRajtszam = new System.Windows.Forms.Label();
            this.tbRajtszam = new System.Windows.Forms.TextBox();
            this.tbOrszag = new System.Windows.Forms.TextBox();
            this.lblOrszag = new System.Windows.Forms.Label();
            this.tbEredmeny = new System.Windows.Forms.TextBox();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnEredmeny = new System.Windows.Forms.RadioButton();
            this.rbtnNevsor = new System.Windows.Forms.RadioButton();
            this.btnOrszagok = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResztvevok
            // 
            this.lbResztvevok.FormattingEnabled = true;
            this.lbResztvevok.Location = new System.Drawing.Point(32, 117);
            this.lbResztvevok.Name = "lbResztvevok";
            this.lbResztvevok.Size = new System.Drawing.Size(184, 251);
            this.lbResztvevok.TabIndex = 1;
            this.lbResztvevok.SelectedIndexChanged += new System.EventHandler(this.lbResztvevok_SelectedIndexChanged);
            // 
            // lblResztvevok
            // 
            this.lblResztvevok.Location = new System.Drawing.Point(66, 91);
            this.lblResztvevok.Name = "lblResztvevok";
            this.lblResztvevok.Size = new System.Drawing.Size(100, 23);
            this.lblResztvevok.TabIndex = 2;
            this.lblResztvevok.Text = "Résztvevők";
            this.lblResztvevok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRajtszam
            // 
            this.lblRajtszam.Location = new System.Drawing.Point(252, 137);
            this.lblRajtszam.Name = "lblRajtszam";
            this.lblRajtszam.Size = new System.Drawing.Size(72, 23);
            this.lblRajtszam.TabIndex = 3;
            this.lblRajtszam.Text = "Rajtszám";
            this.lblRajtszam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbRajtszam
            // 
            this.tbRajtszam.Location = new System.Drawing.Point(330, 140);
            this.tbRajtszam.Name = "tbRajtszam";
            this.tbRajtszam.ReadOnly = true;
            this.tbRajtszam.Size = new System.Drawing.Size(79, 20);
            this.tbRajtszam.TabIndex = 4;
            // 
            // tbOrszag
            // 
            this.tbOrszag.Location = new System.Drawing.Point(330, 190);
            this.tbOrszag.Name = "tbOrszag";
            this.tbOrszag.ReadOnly = true;
            this.tbOrszag.Size = new System.Drawing.Size(79, 20);
            this.tbOrszag.TabIndex = 6;
            // 
            // lblOrszag
            // 
            this.lblOrszag.Location = new System.Drawing.Point(252, 187);
            this.lblOrszag.Name = "lblOrszag";
            this.lblOrszag.Size = new System.Drawing.Size(72, 23);
            this.lblOrszag.TabIndex = 5;
            this.lblOrszag.Text = "Ország";
            this.lblOrszag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbEredmeny
            // 
            this.tbEredmeny.Location = new System.Drawing.Point(330, 243);
            this.tbEredmeny.Name = "tbEredmeny";
            this.tbEredmeny.ReadOnly = true;
            this.tbEredmeny.Size = new System.Drawing.Size(79, 20);
            this.tbEredmeny.TabIndex = 8;
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.Location = new System.Drawing.Point(252, 240);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(72, 23);
            this.lblEredmeny.TabIndex = 7;
            this.lblEredmeny.Text = "Eredméy";
            this.lblEredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnEredmeny);
            this.groupBox1.Controls.Add(this.rbtnNevsor);
            this.groupBox1.Location = new System.Drawing.Point(246, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 72);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempont";
            // 
            // rbtnEredmeny
            // 
            this.rbtnEredmeny.Location = new System.Drawing.Point(6, 42);
            this.rbtnEredmeny.Name = "rbtnEredmeny";
            this.rbtnEredmeny.Size = new System.Drawing.Size(104, 24);
            this.rbtnEredmeny.TabIndex = 1;
            this.rbtnEredmeny.TabStop = true;
            this.rbtnEredmeny.Text = "Eredmény szerint";
            this.rbtnEredmeny.UseVisualStyleBackColor = true;
            this.rbtnEredmeny.CheckedChanged += new System.EventHandler(this.rbtnEredmeny_CheckedChanged);
            // 
            // rbtnNevsor
            // 
            this.rbtnNevsor.Location = new System.Drawing.Point(6, 19);
            this.rbtnNevsor.Name = "rbtnNevsor";
            this.rbtnNevsor.Size = new System.Drawing.Size(104, 24);
            this.rbtnNevsor.TabIndex = 0;
            this.rbtnNevsor.TabStop = true;
            this.rbtnNevsor.Text = "Névsor szerint";
            this.rbtnNevsor.UseVisualStyleBackColor = true;
            this.rbtnNevsor.CheckedChanged += new System.EventHandler(this.rbtnNevsor_CheckedChanged);
            // 
            // btnOrszagok
            // 
            this.btnOrszagok.Location = new System.Drawing.Point(66, 398);
            this.btnOrszagok.Name = "btnOrszagok";
            this.btnOrszagok.Size = new System.Drawing.Size(113, 23);
            this.btnOrszagok.TabIndex = 10;
            this.btnOrszagok.Text = "Résztvevő országok";
            this.btnOrszagok.UseVisualStyleBackColor = true;
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(292, 398);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 11;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnOrszagok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEredmeny);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.tbOrszag);
            this.Controls.Add(this.lblOrszag);
            this.Controls.Add(this.tbRajtszam);
            this.Controls.Add(this.lblRajtszam);
            this.Controls.Add(this.lblResztvevok);
            this.Controls.Add(this.lbResztvevok);
            this.Controls.Add(this.lblTitle);
            this.Name = "EredmenyForm";
            this.Text = "EredmenyForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbOrszag;
        private System.Windows.Forms.Label lblOrszag;
        private System.Windows.Forms.TextBox tbEredmeny;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNevsor;
        private System.Windows.Forms.RadioButton rbtnEredmeny;
        private System.Windows.Forms.Button btnOrszagok;
        private System.Windows.Forms.Button btnBezar;

        private System.Windows.Forms.Label lblRajtszam;
        private System.Windows.Forms.TextBox tbRajtszam;

        private System.Windows.Forms.ListBox lbResztvevok;
        private System.Windows.Forms.Label lblResztvevok;

        private System.Windows.Forms.Label lblTitle;

        #endregion
    }
}