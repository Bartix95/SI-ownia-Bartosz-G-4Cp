
namespace SilowniaBartek
{
    partial class Logowanie
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
            this.label2 = new System.Windows.Forms.Label();
            this.NuZLbl = new System.Windows.Forms.Label();
            this.HasloTxtBox = new System.Windows.Forms.TextBox();
            this.nUzTxtBox = new System.Windows.Forms.TextBox();
            this.ZalogujBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(645, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Has³o:";
            // 
            // NuZLbl
            // 
            this.NuZLbl.AutoSize = true;
            this.NuZLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NuZLbl.Location = new System.Drawing.Point(569, 236);
            this.NuZLbl.Name = "NuZLbl";
            this.NuZLbl.Size = new System.Drawing.Size(193, 25);
            this.NuZLbl.TabIndex = 8;
            this.NuZLbl.Text = "Nazwa U¿ytkownika:";
            // 
            // HasloTxtBox
            // 
            this.HasloTxtBox.Location = new System.Drawing.Point(768, 309);
            this.HasloTxtBox.Name = "HasloTxtBox";
            this.HasloTxtBox.Size = new System.Drawing.Size(200, 20);
            this.HasloTxtBox.TabIndex = 7;
            // 
            // nUzTxtBox
            // 
            this.nUzTxtBox.Location = new System.Drawing.Point(768, 241);
            this.nUzTxtBox.Name = "nUzTxtBox";
            this.nUzTxtBox.Size = new System.Drawing.Size(200, 20);
            this.nUzTxtBox.TabIndex = 6;
            // 
            // ZalogujBtn
            // 
            this.ZalogujBtn.Location = new System.Drawing.Point(768, 359);
            this.ZalogujBtn.Name = "ZalogujBtn";
            this.ZalogujBtn.Size = new System.Drawing.Size(185, 44);
            this.ZalogujBtn.TabIndex = 5;
            this.ZalogujBtn.Text = "Zaloguj";
            this.ZalogujBtn.UseVisualStyleBackColor = true;
            this.ZalogujBtn.Click += new System.EventHandler(this.ZalogujBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1536, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NuZLbl);
            this.Controls.Add(this.HasloTxtBox);
            this.Controls.Add(this.nUzTxtBox);
            this.Controls.Add(this.ZalogujBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NuZLbl;
        private System.Windows.Forms.TextBox HasloTxtBox;
        private System.Windows.Forms.TextBox nUzTxtBox;
        private System.Windows.Forms.Button ZalogujBtn;
    }
}

