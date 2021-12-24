
namespace WFATasarımOrnegi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblYasadiginizGun = new System.Windows.Forms.Label();
            this.lblBurcunuz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğum Tarihiniz";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(140, 133);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(260, 28);
            this.dtpDogumTarihi.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(140, 184);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(127, 36);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(136, 234);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(82, 24);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yaşınız:";
            // 
            // lblYasadiginizGun
            // 
            this.lblYasadiginizGun.AutoSize = true;
            this.lblYasadiginizGun.Location = new System.Drawing.Point(136, 267);
            this.lblYasadiginizGun.Name = "lblYasadiginizGun";
            this.lblYasadiginizGun.Size = new System.Drawing.Size(167, 24);
            this.lblYasadiginizGun.TabIndex = 3;
            this.lblYasadiginizGun.Text = "Yaşadığınız Gün:";
            // 
            // lblBurcunuz
            // 
            this.lblBurcunuz.AutoSize = true;
            this.lblBurcunuz.Location = new System.Drawing.Point(136, 302);
            this.lblBurcunuz.Name = "lblBurcunuz";
            this.lblBurcunuz.Size = new System.Drawing.Size(105, 24);
            this.lblBurcunuz.TabIndex = 3;
            this.lblBurcunuz.Text = "Burcunuz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(501, 415);
            this.Controls.Add(this.lblBurcunuz);
            this.Controls.Add(this.lblYasadiginizGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Burç Gün Yaş Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblYasadiginizGun;
        private System.Windows.Forms.Label lblBurcunuz;
    }
}

