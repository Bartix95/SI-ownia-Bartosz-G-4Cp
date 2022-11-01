
namespace SilowniaBartek
{
    partial class EdytujKarnet
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
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ObecnyCzasLbl = new System.Windows.Forms.Label();
            this.NowyCzasLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZatwierdzBtn = new System.Windows.Forms.Button();
            this.WrocBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(363, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obecny czas w karnecie:";


            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(363, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nowy czas w karnecie:";

            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(367, 294);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(326, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Tag = "";
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ObecnyCzasLbl
            // 
            this.ObecnyCzasLbl.AutoSize = true;
            this.ObecnyCzasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObecnyCzasLbl.Location = new System.Drawing.Point(578, 134);
            this.ObecnyCzasLbl.Name = "ObecnyCzasLbl";
            this.ObecnyCzasLbl.Size = new System.Drawing.Size(44, 18);
            this.ObecnyCzasLbl.TabIndex = 4;
            this.ObecnyCzasLbl.Text = "00:00";

            // 
            // NowyCzasLbl
            // 
            this.NowyCzasLbl.AutoSize = true;
            this.NowyCzasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NowyCzasLbl.Location = new System.Drawing.Point(578, 184);
            this.NowyCzasLbl.Name = "NowyCzasLbl";
            this.NowyCzasLbl.Size = new System.Drawing.Size(44, 18);
            this.NowyCzasLbl.TabIndex = 5;
            this.NowyCzasLbl.Text = "00:00";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(423, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(565, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edytujesz iloœæ czasu w karnecie dla NAZWA_UZYTKOWNIKA";

            // 
            // ZatwierdzBtn
            // 
            this.ZatwierdzBtn.Location = new System.Drawing.Point(743, 442);
            this.ZatwierdzBtn.Name = "ZatwierdzBtn";
            this.ZatwierdzBtn.Size = new System.Drawing.Size(185, 43);
            this.ZatwierdzBtn.TabIndex = 7;
            this.ZatwierdzBtn.Text = "ZatwierdŸ operacjê";
            this.ZatwierdzBtn.UseVisualStyleBackColor = true;
            this.ZatwierdzBtn.Click += new System.EventHandler(this.ZatwierdzBtn_Click);
            // 
            // WrocBtn
            // 
            this.WrocBtn.Location = new System.Drawing.Point(416, 442);
            this.WrocBtn.Name = "WrocBtn";
            this.WrocBtn.Size = new System.Drawing.Size(185, 43);
            this.WrocBtn.TabIndex = 8;
            this.WrocBtn.Text = "Wróæ do panelu g³ównego";
            this.WrocBtn.UseVisualStyleBackColor = true;
            this.WrocBtn.Click += new System.EventHandler(this.WrocBtn_Click);
            // 
            // EdytujKarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 640);
            this.Controls.Add(this.WrocBtn);
            this.Controls.Add(this.ZatwierdzBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NowyCzasLbl);
            this.Controls.Add(this.ObecnyCzasLbl);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EdytujKarnet";
            this.Text = "EdytujKarnet";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label ObecnyCzasLbl;
        private System.Windows.Forms.Label NowyCzasLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ZatwierdzBtn;
        private System.Windows.Forms.Button WrocBtn;
    }
}