
namespace SilowniaBartek
{
    partial class EdytujCzasNaSilowni
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
            this.WrocBtn = new System.Windows.Forms.Button();
            this.ZatwierdzBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NowyCzasLbl = new System.Windows.Forms.Label();
            this.ObecnyCzasLbl = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // WrocBtn
            // 
            this.WrocBtn.Location = new System.Drawing.Point(419, 511);
            this.WrocBtn.Name = "WrocBtn";
            this.WrocBtn.Size = new System.Drawing.Size(185, 43);
            this.WrocBtn.TabIndex = 16;
            this.WrocBtn.Text = "Wróæ do panelu g³ównego";
            this.WrocBtn.UseVisualStyleBackColor = true;
            this.WrocBtn.Click += new System.EventHandler(this.WrocBtn_Click);
            // 
            // ZatwierdzBtn
            // 
            this.ZatwierdzBtn.Location = new System.Drawing.Point(746, 511);
            this.ZatwierdzBtn.Name = "ZatwierdzBtn";
            this.ZatwierdzBtn.Size = new System.Drawing.Size(185, 43);
            this.ZatwierdzBtn.TabIndex = 15;
            this.ZatwierdzBtn.Text = "ZatwierdŸ operacjê";
            this.ZatwierdzBtn.UseVisualStyleBackColor = true;
            this.ZatwierdzBtn.Click += new System.EventHandler(this.ZatwierdzBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(426, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Obliczas iloœæ czasu na si³owni";
            // 
            // NowyCzasLbl
            // 
            this.NowyCzasLbl.AutoSize = true;
            this.NowyCzasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NowyCzasLbl.Location = new System.Drawing.Point(581, 253);
            this.NowyCzasLbl.Name = "NowyCzasLbl";
            this.NowyCzasLbl.Size = new System.Drawing.Size(44, 18);
            this.NowyCzasLbl.TabIndex = 13;
            this.NowyCzasLbl.Text = "00:00";
            // 
            // ObecnyCzasLbl
            // 
            this.ObecnyCzasLbl.AutoSize = true;
            this.ObecnyCzasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObecnyCzasLbl.Location = new System.Drawing.Point(581, 203);
            this.ObecnyCzasLbl.Name = "ObecnyCzasLbl";
            this.ObecnyCzasLbl.Size = new System.Drawing.Size(44, 18);
            this.ObecnyCzasLbl.TabIndex = 12;
            this.ObecnyCzasLbl.Text = "00:00";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(370, 363);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(326, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Tag = "";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(366, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nowy czas w karnecie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(366, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Obecny czas w karnecie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(414, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Iloœæ godzin na si³owni:";
            // 
            // EdytujCzasNaSilowni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WrocBtn);
            this.Controls.Add(this.ZatwierdzBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NowyCzasLbl);
            this.Controls.Add(this.ObecnyCzasLbl);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdytujCzasNaSilowni";
            this.Text = "EdytujCzasNaSilowni";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WrocBtn;
        private System.Windows.Forms.Button ZatwierdzBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NowyCzasLbl;
        private System.Windows.Forms.Label ObecnyCzasLbl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}