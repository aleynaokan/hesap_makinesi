namespace hesap_makinesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_cıkar = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_esittir = new System.Windows.Forms.Button();
            this.sonuc_text = new System.Windows.Forms.TextBox();
            this.btn_nokta = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(80, 139);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(58, 45);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(144, 139);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(58, 45);
            this.b2.TabIndex = 1;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(208, 139);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(58, 45);
            this.b3.TabIndex = 2;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(80, 190);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(58, 45);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(144, 190);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(58, 45);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(208, 190);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(58, 45);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(80, 241);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(58, 45);
            this.b7.TabIndex = 6;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(144, 241);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(58, 45);
            this.b8.TabIndex = 7;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(208, 241);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(58, 45);
            this.b9.TabIndex = 8;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.RakamOlay);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(80, 292);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(122, 45);
            this.b0.TabIndex = 9;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.RakamOlay);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(272, 139);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(58, 45);
            this.btn_bol.TabIndex = 10;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.OptHesaplama);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(272, 190);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(58, 45);
            this.btn_carp.TabIndex = 11;
            this.btn_carp.Text = "*";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.OptHesaplama);
            // 
            // btn_cıkar
            // 
            this.btn_cıkar.Location = new System.Drawing.Point(272, 241);
            this.btn_cıkar.Name = "btn_cıkar";
            this.btn_cıkar.Size = new System.Drawing.Size(58, 45);
            this.btn_cıkar.TabIndex = 12;
            this.btn_cıkar.Text = "-";
            this.btn_cıkar.UseVisualStyleBackColor = true;
            this.btn_cıkar.Click += new System.EventHandler(this.OptHesaplama);
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(272, 292);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(58, 45);
            this.btn_topla.TabIndex = 13;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.OptHesaplama);
            // 
            // btn_esittir
            // 
            this.btn_esittir.Location = new System.Drawing.Point(336, 241);
            this.btn_esittir.Name = "btn_esittir";
            this.btn_esittir.Size = new System.Drawing.Size(58, 96);
            this.btn_esittir.TabIndex = 14;
            this.btn_esittir.Text = "=";
            this.btn_esittir.UseVisualStyleBackColor = true;
            this.btn_esittir.Click += new System.EventHandler(this.btn_esittir_Click);
            // 
            // sonuc_text
            // 
            this.sonuc_text.Location = new System.Drawing.Point(80, 75);
            this.sonuc_text.Multiline = true;
            this.sonuc_text.Name = "sonuc_text";
            this.sonuc_text.Size = new System.Drawing.Size(314, 58);
            this.sonuc_text.TabIndex = 15;
            // 
            // btn_nokta
            // 
            this.btn_nokta.Location = new System.Drawing.Point(208, 292);
            this.btn_nokta.Name = "btn_nokta";
            this.btn_nokta.Size = new System.Drawing.Size(58, 45);
            this.btn_nokta.TabIndex = 16;
            this.btn_nokta.Text = ".";
            this.btn_nokta.UseVisualStyleBackColor = true;
            this.btn_nokta.Click += new System.EventHandler(this.btn_nokta_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(336, 190);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(58, 45);
            this.btn_C.TabIndex = 17;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Location = new System.Drawing.Point(336, 139);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(58, 45);
            this.btn_CE.TabIndex = 18;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(193, 44);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(38, 15);
            this.lbl_sonuc.TabIndex = 19;
            this.lbl_sonuc.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_nokta);
            this.Controls.Add(this.sonuc_text);
            this.Controls.Add(this.btn_esittir);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.btn_cıkar);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.OptHesaplama);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b0;
        private Button btn_bol;
        private Button btn_carp;
        private Button btn_cıkar;
        private Button btn_topla;
        private Button btn_esittir;
        private TextBox sonuc_text;
        private Button btn_nokta;
        private Button btn_C;
        private Button btn_CE;
        private Label lbl_sonuc;
    }
}