
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(115, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğum Tarihiniz";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpDogumTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtpDogumTarihi.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dtpDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDogumTarihi.Location = new System.Drawing.Point(120, 127);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(280, 30);
            this.dtpDogumTarihi.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.Red;
            this.btnHesapla.Location = new System.Drawing.Point(207, 340);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(150, 41);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.BackColor = System.Drawing.Color.Transparent;
            this.lblYas.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblYas.Location = new System.Drawing.Point(115, 194);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(89, 25);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Yaşınız:";
            // 
            // lblYasadiginizGun
            // 
            this.lblYasadiginizGun.AutoSize = true;
            this.lblYasadiginizGun.BackColor = System.Drawing.Color.Transparent;
            this.lblYasadiginizGun.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblYasadiginizGun.Location = new System.Drawing.Point(115, 233);
            this.lblYasadiginizGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYasadiginizGun.Name = "lblYasadiginizGun";
            this.lblYasadiginizGun.Size = new System.Drawing.Size(176, 25);
            this.lblYasadiginizGun.TabIndex = 3;
            this.lblYasadiginizGun.Text = "Yaşadığınız Gün:";
            // 
            // lblBurcunuz
            // 
            this.lblBurcunuz.AutoSize = true;
            this.lblBurcunuz.BackColor = System.Drawing.Color.Transparent;
            this.lblBurcunuz.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblBurcunuz.Location = new System.Drawing.Point(115, 271);
            this.lblBurcunuz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBurcunuz.Name = "lblBurcunuz";
            this.lblBurcunuz.Size = new System.Drawing.Size(110, 25);
            this.lblBurcunuz.TabIndex = 3;
            this.lblBurcunuz.Text = "Burcunuz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(533, 479);
            this.Controls.Add(this.lblBurcunuz);
            this.Controls.Add(this.lblYasadiginizGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Yaş Gün ve Burç Hesaplama";
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

