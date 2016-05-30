namespace ApiWheather
{
    partial class Dzisiaj
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TempRano = new System.Windows.Forms.TextBox();
            this.DeszczRano = new System.Windows.Forms.TextBox();
            this.ZachmRano = new System.Windows.Forms.TextBox();
            this.WilgotRano = new System.Windows.Forms.TextBox();
            this.ZachmPol = new System.Windows.Forms.TextBox();
            this.TempWiecz = new System.Windows.Forms.TextBox();
            this.TempPol = new System.Windows.Forms.TextBox();
            this.DeszczPol = new System.Windows.Forms.TextBox();
            this.WilgotPol = new System.Windows.Forms.TextBox();
            this.pictureRano = new System.Windows.Forms.PictureBox();
            this.picturePoludnie = new System.Windows.Forms.PictureBox();
            this.pictureWiecz = new System.Windows.Forms.PictureBox();
            this.ZachmWiecz = new System.Windows.Forms.TextBox();
            this.WilgotWiecz = new System.Windows.Forms.TextBox();
            this.DeszczWiecz = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Aktywność = new System.Windows.Forms.Label();
            this.MenuDzis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoludnie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWiecz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deszcz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zachmurzenie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wilgotność";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rano";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Popołudnie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Wieczór";
            // 
            // TempRano
            // 
            this.TempRano.Cursor = System.Windows.Forms.Cursors.No;
            this.TempRano.Location = new System.Drawing.Point(106, 91);
            this.TempRano.Name = "TempRano";
            this.TempRano.ReadOnly = true;
            this.TempRano.Size = new System.Drawing.Size(100, 20);
            this.TempRano.TabIndex = 8;
            this.TempRano.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DeszczRano
            // 
            this.DeszczRano.Location = new System.Drawing.Point(106, 123);
            this.DeszczRano.Name = "DeszczRano";
            this.DeszczRano.Size = new System.Drawing.Size(100, 20);
            this.DeszczRano.TabIndex = 9;
            this.DeszczRano.TextChanged += new System.EventHandler(this.DeszczRano_TextChanged);
            // 
            // ZachmRano
            // 
            this.ZachmRano.Location = new System.Drawing.Point(106, 155);
            this.ZachmRano.Name = "ZachmRano";
            this.ZachmRano.Size = new System.Drawing.Size(100, 20);
            this.ZachmRano.TabIndex = 10;
            this.ZachmRano.TextChanged += new System.EventHandler(this.ZachmRano_TextChanged);
            // 
            // WilgotRano
            // 
            this.WilgotRano.Location = new System.Drawing.Point(106, 186);
            this.WilgotRano.Name = "WilgotRano";
            this.WilgotRano.Size = new System.Drawing.Size(100, 20);
            this.WilgotRano.TabIndex = 11;
            this.WilgotRano.TextChanged += new System.EventHandler(this.WilgotRano_TextChanged);
            // 
            // ZachmPol
            // 
            this.ZachmPol.Location = new System.Drawing.Point(260, 155);
            this.ZachmPol.Name = "ZachmPol";
            this.ZachmPol.ReadOnly = true;
            this.ZachmPol.Size = new System.Drawing.Size(100, 20);
            this.ZachmPol.TabIndex = 12;
            // 
            // TempWiecz
            // 
            this.TempWiecz.Location = new System.Drawing.Point(415, 92);
            this.TempWiecz.Name = "TempWiecz";
            this.TempWiecz.ReadOnly = true;
            this.TempWiecz.Size = new System.Drawing.Size(100, 20);
            this.TempWiecz.TabIndex = 13;
            // 
            // TempPol
            // 
            this.TempPol.Location = new System.Drawing.Point(260, 91);
            this.TempPol.Name = "TempPol";
            this.TempPol.ReadOnly = true;
            this.TempPol.Size = new System.Drawing.Size(100, 20);
            this.TempPol.TabIndex = 14;
            // 
            // DeszczPol
            // 
            this.DeszczPol.Location = new System.Drawing.Point(260, 123);
            this.DeszczPol.Name = "DeszczPol";
            this.DeszczPol.ReadOnly = true;
            this.DeszczPol.Size = new System.Drawing.Size(100, 20);
            this.DeszczPol.TabIndex = 15;
            // 
            // WilgotPol
            // 
            this.WilgotPol.Location = new System.Drawing.Point(260, 186);
            this.WilgotPol.Name = "WilgotPol";
            this.WilgotPol.ReadOnly = true;
            this.WilgotPol.Size = new System.Drawing.Size(100, 20);
            this.WilgotPol.TabIndex = 16;
            // 
            // pictureRano
            // 
            this.pictureRano.Location = new System.Drawing.Point(106, 36);
            this.pictureRano.Name = "pictureRano";
            this.pictureRano.Size = new System.Drawing.Size(100, 50);
            this.pictureRano.TabIndex = 17;
            this.pictureRano.TabStop = false;
            // 
            // picturePoludnie
            // 
            this.picturePoludnie.Location = new System.Drawing.Point(260, 36);
            this.picturePoludnie.Name = "picturePoludnie";
            this.picturePoludnie.Size = new System.Drawing.Size(100, 50);
            this.picturePoludnie.TabIndex = 18;
            this.picturePoludnie.TabStop = false;
            // 
            // pictureWiecz
            // 
            this.pictureWiecz.Location = new System.Drawing.Point(415, 36);
            this.pictureWiecz.Name = "pictureWiecz";
            this.pictureWiecz.Size = new System.Drawing.Size(100, 50);
            this.pictureWiecz.TabIndex = 19;
            this.pictureWiecz.TabStop = false;
            // 
            // ZachmWiecz
            // 
            this.ZachmWiecz.Location = new System.Drawing.Point(415, 155);
            this.ZachmWiecz.Name = "ZachmWiecz";
            this.ZachmWiecz.ReadOnly = true;
            this.ZachmWiecz.Size = new System.Drawing.Size(100, 20);
            this.ZachmWiecz.TabIndex = 20;
            // 
            // WilgotWiecz
            // 
            this.WilgotWiecz.Location = new System.Drawing.Point(415, 186);
            this.WilgotWiecz.Name = "WilgotWiecz";
            this.WilgotWiecz.ReadOnly = true;
            this.WilgotWiecz.Size = new System.Drawing.Size(100, 20);
            this.WilgotWiecz.TabIndex = 21;
            // 
            // DeszczWiecz
            // 
            this.DeszczWiecz.Location = new System.Drawing.Point(415, 123);
            this.DeszczWiecz.Name = "DeszczWiecz";
            this.DeszczWiecz.ReadOnly = true;
            this.DeszczWiecz.Size = new System.Drawing.Size(100, 20);
            this.DeszczWiecz.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(106, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(100, 95);
            this.listBox1.TabIndex = 23;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(260, 241);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(100, 95);
            this.listBox2.TabIndex = 24;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(415, 241);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(100, 95);
            this.listBox3.TabIndex = 25;
            // 
            // Aktywność
            // 
            this.Aktywność.AutoSize = true;
            this.Aktywność.Location = new System.Drawing.Point(20, 290);
            this.Aktywność.Name = "Aktywność";
            this.Aktywność.Size = new System.Drawing.Size(67, 26);
            this.Aktywność.TabIndex = 26;
            this.Aktywność.Text = "Sugerowana\r\naktywność";
            // 
            // MenuDzis
            // 
            this.MenuDzis.Location = new System.Drawing.Point(247, 397);
            this.MenuDzis.Name = "MenuDzis";
            this.MenuDzis.Size = new System.Drawing.Size(125, 23);
            this.MenuDzis.TabIndex = 27;
            this.MenuDzis.Text = "Menu Główne";
            this.MenuDzis.UseVisualStyleBackColor = true;
            this.MenuDzis.Click += new System.EventHandler(this.MenuDzis_Click);
            // 
            // Dzisiaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 443);
            this.Controls.Add(this.MenuDzis);
            this.Controls.Add(this.Aktywność);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeszczWiecz);
            this.Controls.Add(this.WilgotWiecz);
            this.Controls.Add(this.ZachmWiecz);
            this.Controls.Add(this.pictureWiecz);
            this.Controls.Add(this.picturePoludnie);
            this.Controls.Add(this.pictureRano);
            this.Controls.Add(this.WilgotPol);
            this.Controls.Add(this.DeszczPol);
            this.Controls.Add(this.TempPol);
            this.Controls.Add(this.TempWiecz);
            this.Controls.Add(this.ZachmPol);
            this.Controls.Add(this.WilgotRano);
            this.Controls.Add(this.ZachmRano);
            this.Controls.Add(this.DeszczRano);
            this.Controls.Add(this.TempRano);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Name = "Dzisiaj";
            this.Text = "Dzisiaj";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoludnie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWiecz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TempRano;
        private System.Windows.Forms.TextBox DeszczRano;
        private System.Windows.Forms.TextBox ZachmRano;
        private System.Windows.Forms.TextBox WilgotRano;
        private System.Windows.Forms.TextBox ZachmPol;
        private System.Windows.Forms.TextBox TempWiecz;
        private System.Windows.Forms.TextBox TempPol;
        private System.Windows.Forms.TextBox DeszczPol;
        private System.Windows.Forms.TextBox WilgotPol;
        private System.Windows.Forms.PictureBox pictureRano;
        private System.Windows.Forms.PictureBox picturePoludnie;
        private System.Windows.Forms.PictureBox pictureWiecz;
        private System.Windows.Forms.TextBox ZachmWiecz;
        private System.Windows.Forms.TextBox WilgotWiecz;
        private System.Windows.Forms.TextBox DeszczWiecz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label Aktywność;
        private System.Windows.Forms.Button MenuDzis;
    }
}