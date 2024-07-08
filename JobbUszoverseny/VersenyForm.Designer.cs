using System.ComponentModel;

namespace JobbUszoverseny {
    partial class VersenyForm {
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
            this.lblTav = new System.Windows.Forms.Label();
            this.numTav = new System.Windows.Forms.NumericUpDown();
            this.lblVatMeter = new System.Windows.Forms.Label();
            this.lblVersenyzo = new System.Windows.Forms.Label();
            this.tbVersenyzo = new System.Windows.Forms.TextBox();
            this.lblIdoeredmeny = new System.Windows.Forms.Label();
            this.mtbEredmeny = new System.Windows.Forms.MaskedTextBox();
            this.btnVerseny = new System.Windows.Forms.Button();
            this.btnKovetkezo = new System.Windows.Forms.Button();
            this.comboFajta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTav)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTav
            // 
            this.lblTav.Location = new System.Drawing.Point(31, 22);
            this.lblTav.Name = "lblTav";
            this.lblTav.Size = new System.Drawing.Size(39, 23);
            this.lblTav.TabIndex = 0;
            this.lblTav.Text = "Táv:";
            this.lblTav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numTav
            // 
            this.numTav.Location = new System.Drawing.Point(76, 25);
            this.numTav.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numTav.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numTav.Name = "numTav";
            this.numTav.Size = new System.Drawing.Size(58, 20);
            this.numTav.TabIndex = 1;
            this.numTav.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblVatMeter
            // 
            this.lblVatMeter.Location = new System.Drawing.Point(140, 22);
            this.lblVatMeter.Name = "lblVatMeter";
            this.lblVatMeter.Size = new System.Drawing.Size(17, 23);
            this.lblVatMeter.TabIndex = 2;
            this.lblVatMeter.Text = "m";
            this.lblVatMeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersenyzo
            // 
            this.lblVersenyzo.Location = new System.Drawing.Point(31, 69);
            this.lblVersenyzo.Name = "lblVersenyzo";
            this.lblVersenyzo.Size = new System.Drawing.Size(67, 23);
            this.lblVersenyzo.TabIndex = 3;
            this.lblVersenyzo.Text = "Versenyző:";
            this.lblVersenyzo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbVersenyzo
            // 
            this.tbVersenyzo.Location = new System.Drawing.Point(104, 69);
            this.tbVersenyzo.Name = "tbVersenyzo";
            this.tbVersenyzo.Size = new System.Drawing.Size(204, 20);
            this.tbVersenyzo.TabIndex = 4;
            // 
            // lblIdoeredmeny
            // 
            this.lblIdoeredmeny.Location = new System.Drawing.Point(31, 121);
            this.lblIdoeredmeny.Name = "lblIdoeredmeny";
            this.lblIdoeredmeny.Size = new System.Drawing.Size(76, 23);
            this.lblIdoeredmeny.TabIndex = 5;
            this.lblIdoeredmeny.Text = "Időeredmény";
            this.lblIdoeredmeny.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbEredmeny
            // 
            this.mtbEredmeny.Location = new System.Drawing.Point(113, 123);
            this.mtbEredmeny.Mask = "00:00:00";
            this.mtbEredmeny.Name = "mtbEredmeny";
            this.mtbEredmeny.Size = new System.Drawing.Size(195, 20);
            this.mtbEredmeny.TabIndex = 6;
            // 
            // btnVerseny
            // 
            this.btnVerseny.Location = new System.Drawing.Point(387, 25);
            this.btnVerseny.Name = "btnVerseny";
            this.btnVerseny.Size = new System.Drawing.Size(75, 23);
            this.btnVerseny.TabIndex = 7;
            this.btnVerseny.Text = "Verseny";
            this.btnVerseny.UseVisualStyleBackColor = true;
            this.btnVerseny.Click += new System.EventHandler(this.btnVerseny_Click);
            // 
            // btnKovetkezo
            // 
            this.btnKovetkezo.Location = new System.Drawing.Point(387, 120);
            this.btnKovetkezo.Name = "btnKovetkezo";
            this.btnKovetkezo.Size = new System.Drawing.Size(75, 23);
            this.btnKovetkezo.TabIndex = 8;
            this.btnKovetkezo.Text = "Következő";
            this.btnKovetkezo.UseVisualStyleBackColor = true;
            this.btnKovetkezo.Click += new System.EventHandler(this.btnKovetkezo_Click);
            // 
            // comboFajta
            // 
            this.comboFajta.FormattingEnabled = true;
            this.comboFajta.Items.AddRange(new object[] { "mellúszás", "pillangóúszás", "gyorsúszás", "hátúszás", "vegyes" });
            this.comboFajta.Location = new System.Drawing.Point(163, 24);
            this.comboFajta.Name = "comboFajta";
            this.comboFajta.Size = new System.Drawing.Size(121, 21);
            this.comboFajta.TabIndex = 9;
            // 
            // VersenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 176);
            this.Controls.Add(this.comboFajta);
            this.Controls.Add(this.btnKovetkezo);
            this.Controls.Add(this.btnVerseny);
            this.Controls.Add(this.mtbEredmeny);
            this.Controls.Add(this.lblIdoeredmeny);
            this.Controls.Add(this.tbVersenyzo);
            this.Controls.Add(this.lblVersenyzo);
            this.Controls.Add(this.lblVatMeter);
            this.Controls.Add(this.numTav);
            this.Controls.Add(this.lblTav);
            this.Name = "VersenyForm";
            this.Text = "VersenyForm";
            ((System.ComponentModel.ISupportInitialize)(this.numTav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboFajta;

        private System.Windows.Forms.Button btnVerseny;
        private System.Windows.Forms.Button btnKovetkezo;

        private System.Windows.Forms.MaskedTextBox mtbEredmeny;

        private System.Windows.Forms.Label lblIdoeredmeny;

        private System.Windows.Forms.TextBox tbVersenyzo;

        private System.Windows.Forms.Label lblVersenyzo;

        private System.Windows.Forms.Label lblVatMeter;

        private System.Windows.Forms.NumericUpDown numTav;

        private System.Windows.Forms.Label lblTav;

        #endregion
    }
}