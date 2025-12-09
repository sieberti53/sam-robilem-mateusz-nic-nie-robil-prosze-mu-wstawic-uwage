namespace INF._04_01_23._01_SG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stanowisko = new System.Windows.Forms.ComboBox();
            this.stanowiskolabel = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.nazwiskolabel = new System.Windows.Forms.Label();
            this.imielabel = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.generuj = new System.Windows.Forms.Button();
            this.specjalne = new System.Windows.Forms.CheckBox();
            this.cyfry = new System.Windows.Forms.CheckBox();
            this.litery = new System.Windows.Forms.CheckBox();
            this.znakilabel = new System.Windows.Forms.Label();
            this.znaki = new System.Windows.Forms.TextBox();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stanowisko);
            this.groupBox1.Controls.Add(this.stanowiskolabel);
            this.groupBox1.Controls.Add(this.nazwisko);
            this.groupBox1.Controls.Add(this.nazwiskolabel);
            this.groupBox1.Controls.Add(this.imielabel);
            this.groupBox1.Controls.Add(this.imie);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane pracownika";
            // 
            // stanowisko
            // 
            this.stanowisko.FormattingEnabled = true;
            this.stanowisko.Items.AddRange(new object[] {
            "Kierownik",
            "Starszy programista",
            "Młodszy programista",
            "Tester"});
            this.stanowisko.Location = new System.Drawing.Point(126, 130);
            this.stanowisko.Name = "stanowisko";
            this.stanowisko.Size = new System.Drawing.Size(197, 24);
            this.stanowisko.TabIndex = 6;
            // 
            // stanowiskolabel
            // 
            this.stanowiskolabel.AutoSize = true;
            this.stanowiskolabel.Location = new System.Drawing.Point(25, 133);
            this.stanowiskolabel.Name = "stanowiskolabel";
            this.stanowiskolabel.Size = new System.Drawing.Size(76, 16);
            this.stanowiskolabel.TabIndex = 4;
            this.stanowiskolabel.Text = "Stanowisko";
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(126, 88);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(195, 22);
            this.nazwisko.TabIndex = 3;
            // 
            // nazwiskolabel
            // 
            this.nazwiskolabel.AutoSize = true;
            this.nazwiskolabel.Location = new System.Drawing.Point(24, 92);
            this.nazwiskolabel.Name = "nazwiskolabel";
            this.nazwiskolabel.Size = new System.Drawing.Size(65, 16);
            this.nazwiskolabel.TabIndex = 2;
            this.nazwiskolabel.Text = "Nazwisko";
            // 
            // imielabel
            // 
            this.imielabel.AutoSize = true;
            this.imielabel.Location = new System.Drawing.Point(25, 51);
            this.imielabel.Name = "imielabel";
            this.imielabel.Size = new System.Drawing.Size(32, 16);
            this.imielabel.TabIndex = 1;
            this.imielabel.Text = "Imię";
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(126, 45);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(197, 22);
            this.imie.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generuj);
            this.groupBox2.Controls.Add(this.specjalne);
            this.groupBox2.Controls.Add(this.cyfry);
            this.groupBox2.Controls.Add(this.litery);
            this.groupBox2.Controls.Add(this.znakilabel);
            this.groupBox2.Controls.Add(this.znaki);
            this.groupBox2.Location = new System.Drawing.Point(447, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generowanie hasła";
            // 
            // generuj
            // 
            this.generuj.BackColor = System.Drawing.Color.SteelBlue;
            this.generuj.ForeColor = System.Drawing.Color.White;
            this.generuj.Location = new System.Drawing.Point(117, 225);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(114, 29);
            this.generuj.TabIndex = 7;
            this.generuj.Text = "Generuj hasło";
            this.generuj.UseVisualStyleBackColor = false;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // specjalne
            // 
            this.specjalne.AutoSize = true;
            this.specjalne.Location = new System.Drawing.Point(30, 167);
            this.specjalne.Name = "specjalne";
            this.specjalne.Size = new System.Drawing.Size(124, 20);
            this.specjalne.TabIndex = 6;
            this.specjalne.Text = "Znaki specjalne";
            this.specjalne.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            this.cyfry.AutoSize = true;
            this.cyfry.Location = new System.Drawing.Point(30, 126);
            this.cyfry.Name = "cyfry";
            this.cyfry.Size = new System.Drawing.Size(59, 20);
            this.cyfry.TabIndex = 5;
            this.cyfry.Text = "Cyfry";
            this.cyfry.UseVisualStyleBackColor = true;
            // 
            // litery
            // 
            this.litery.AutoSize = true;
            this.litery.Checked = true;
            this.litery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.litery.Location = new System.Drawing.Point(30, 85);
            this.litery.Name = "litery";
            this.litery.Size = new System.Drawing.Size(143, 20);
            this.litery.TabIndex = 4;
            this.litery.Text = "Małe i wielkie litery";
            this.litery.UseVisualStyleBackColor = true;
            // 
            // znakilabel
            // 
            this.znakilabel.AutoSize = true;
            this.znakilabel.Location = new System.Drawing.Point(27, 45);
            this.znakilabel.Name = "znakilabel";
            this.znakilabel.Size = new System.Drawing.Size(76, 16);
            this.znakilabel.TabIndex = 3;
            this.znakilabel.Text = "Ile znaków?";
            // 
            // znaki
            // 
            this.znaki.Location = new System.Drawing.Point(127, 42);
            this.znaki.Name = "znaki";
            this.znaki.Size = new System.Drawing.Size(197, 22);
            this.znaki.TabIndex = 2;
            // 
            // zatwierdz
            // 
            this.zatwierdz.BackColor = System.Drawing.Color.SteelBlue;
            this.zatwierdz.ForeColor = System.Drawing.Color.White;
            this.zatwierdz.Location = new System.Drawing.Point(282, 377);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(242, 39);
            this.zatwierdz.TabIndex = 2;
            this.zatwierdz.Text = "Zatwierdź";
            this.zatwierdz.UseVisualStyleBackColor = false;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Generowanie hasła";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox stanowisko;
        private System.Windows.Forms.Label stanowiskolabel;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label nazwiskolabel;
        private System.Windows.Forms.Label imielabel;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generuj;
        private System.Windows.Forms.CheckBox specjalne;
        private System.Windows.Forms.CheckBox cyfry;
        private System.Windows.Forms.CheckBox litery;
        private System.Windows.Forms.Label znakilabel;
        private System.Windows.Forms.TextBox znaki;
        private System.Windows.Forms.Button zatwierdz;
    }
}
