
namespace SilowniaBartek
{
    partial class DodajUzytkownika
    {
  
        private System.ComponentModel.IContainer components = null;

     
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
            this.NazwaUzytkownikaTxtBox = new System.Windows.Forms.TextBox();
            this.ImieTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NazwiskoTxtBox = new System.Windows.Forms.TextBox();
            this.WiekTxtBox = new System.Windows.Forms.TextBox();
            this.HasloTxtBox = new System.Windows.Forms.TextBox();
            this.GodzinyNaKarnet = new System.Windows.Forms.TrackBar();
            this.CzasKarnetLbl = new System.Windows.Forms.Label();
            this.DodajUzytkownikaBtn = new System.Windows.Forms.Button();
            this.WrocDoPaneluBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GodzinyNaKarnet)).BeginInit();
            this.SuspendLayout();
            // 
            // NazwaUzytkownikaTxtBox
            // 
            this.NazwaUzytkownikaTxtBox.Location = new System.Drawing.Point(541, 116);
            this.NazwaUzytkownikaTxtBox.Name = "NazwaUzytkownikaTxtBox";
            this.NazwaUzytkownikaTxtBox.Size = new System.Drawing.Size(265, 20);
            this.NazwaUzytkownikaTxtBox.TabIndex = 0;
            // 
            // ImieTxtBox
            // 
            this.ImieTxtBox.Location = new System.Drawing.Point(541, 170);
            this.ImieTxtBox.Name = "ImieTxtBox";
            this.ImieTxtBox.Size = new System.Drawing.Size(265, 20);
            this.ImieTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(336, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa użytkownika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(460, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(416, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(452, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wiek:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(446, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Haslo:";
            // 
            // NazwiskoTxtBox
            // 
            this.NazwiskoTxtBox.Location = new System.Drawing.Point(541, 214);
            this.NazwiskoTxtBox.Name = "NazwiskoTxtBox";
            this.NazwiskoTxtBox.Size = new System.Drawing.Size(265, 20);
            this.NazwiskoTxtBox.TabIndex = 7;
            // 
            // WiekTxtBox
            // 
            this.WiekTxtBox.Location = new System.Drawing.Point(541, 262);
            this.WiekTxtBox.Name = "WiekTxtBox";
            this.WiekTxtBox.Size = new System.Drawing.Size(265, 20);
            this.WiekTxtBox.TabIndex = 8;
            // 
            // HasloTxtBox
            // 
            this.HasloTxtBox.Location = new System.Drawing.Point(541, 303);
            this.HasloTxtBox.Name = "HasloTxtBox";
            this.HasloTxtBox.PasswordChar = '*';
            this.HasloTxtBox.Size = new System.Drawing.Size(265, 20);
            this.HasloTxtBox.TabIndex = 9;
            // 
            // GodzinyNaKarnet
            // 
            this.GodzinyNaKarnet.LargeChange = 10;
            this.GodzinyNaKarnet.Location = new System.Drawing.Point(510, 466);
            this.GodzinyNaKarnet.Maximum = 100;
            this.GodzinyNaKarnet.Name = "GodzinyNaKarnet";
            this.GodzinyNaKarnet.Size = new System.Drawing.Size(331, 45);
            this.GodzinyNaKarnet.TabIndex = 10;
            this.GodzinyNaKarnet.Scroll += new System.EventHandler(this.GodzinyNaKarnet_Scroll);
            // 
            // CzasKarnetLbl
            // 
            this.CzasKarnetLbl.AutoSize = true;
            this.CzasKarnetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CzasKarnetLbl.Location = new System.Drawing.Point(599, 417);
            this.CzasKarnetLbl.Name = "CzasKarnetLbl";
            this.CzasKarnetLbl.Size = new System.Drawing.Size(188, 22);
            this.CzasKarnetLbl.TabIndex = 11;
            this.CzasKarnetLbl.Text = "Czas na karnecie: 000";
            // 
            // DodajUzytkownikaBtn
            // 
            this.DodajUzytkownikaBtn.Location = new System.Drawing.Point(569, 543);
            this.DodajUzytkownikaBtn.Name = "DodajUzytkownikaBtn";
            this.DodajUzytkownikaBtn.Size = new System.Drawing.Size(226, 51);
            this.DodajUzytkownikaBtn.TabIndex = 12;
            this.DodajUzytkownikaBtn.Text = "Dodaj użytkownika";
            this.DodajUzytkownikaBtn.UseVisualStyleBackColor = true;
            this.DodajUzytkownikaBtn.Click += new System.EventHandler(this.DodajUzytkownikaBtn_Click);
            // 
            // WrocDoPaneluBtn
            // 
            this.WrocDoPaneluBtn.Location = new System.Drawing.Point(1064, 34);
            this.WrocDoPaneluBtn.Name = "WrocDoPaneluBtn";
            this.WrocDoPaneluBtn.Size = new System.Drawing.Size(226, 51);
            this.WrocDoPaneluBtn.TabIndex = 13;
            this.WrocDoPaneluBtn.Text = "Wróć do panelu głównego";
            this.WrocDoPaneluBtn.UseVisualStyleBackColor = true;
            this.WrocDoPaneluBtn.Click += new System.EventHandler(this.WrocDoPaneluBtn_Click);
            // 
            // DodajUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 647);
            this.Controls.Add(this.WrocDoPaneluBtn);
            this.Controls.Add(this.DodajUzytkownikaBtn);
            this.Controls.Add(this.CzasKarnetLbl);
            this.Controls.Add(this.GodzinyNaKarnet);
            this.Controls.Add(this.HasloTxtBox);
            this.Controls.Add(this.WiekTxtBox);
            this.Controls.Add(this.NazwiskoTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImieTxtBox);
            this.Controls.Add(this.NazwaUzytkownikaTxtBox);
            this.Name = "DodajUzytkownika";
            this.Text = "DodajUzytkownika";
            ((System.ComponentModel.ISupportInitialize)(this.GodzinyNaKarnet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NazwaUzytkownikaTxtBox;
        private System.Windows.Forms.TextBox ImieTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NazwiskoTxtBox;
        private System.Windows.Forms.TextBox WiekTxtBox;
        private System.Windows.Forms.TextBox HasloTxtBox;
        private System.Windows.Forms.TrackBar GodzinyNaKarnet;
        private System.Windows.Forms.Label CzasKarnetLbl;
        private System.Windows.Forms.Button DodajUzytkownikaBtn;
        private System.Windows.Forms.Button WrocDoPaneluBtn;
    }
}