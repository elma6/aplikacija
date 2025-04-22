namespace projektni_zadatak_g1
{
    partial class KreiranjeNarudžbe
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
            dataGridViewPregledArtikala = new DataGridView();
            dataGridViewKorpa = new DataGridView();
            buttonKreirajNarudžbu = new Button();
            buttonDodaj = new Button();
            buttonObriši = new Button();
            textBoxID = new TextBox();
            textBoxKoličina = new TextBox();
            textBoxTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledArtikala).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKorpa).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPregledArtikala
            // 
            dataGridViewPregledArtikala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPregledArtikala.Location = new Point(14, 89);
            dataGridViewPregledArtikala.Name = "dataGridViewPregledArtikala";
            dataGridViewPregledArtikala.RowHeadersWidth = 51;
            dataGridViewPregledArtikala.Size = new Size(300, 374);
            dataGridViewPregledArtikala.TabIndex = 0;
            // 
            // dataGridViewKorpa
            // 
            dataGridViewKorpa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKorpa.Location = new Point(333, 123);
            dataGridViewKorpa.Name = "dataGridViewKorpa";
            dataGridViewKorpa.RowHeadersWidth = 51;
            dataGridViewKorpa.Size = new Size(300, 241);
            dataGridViewKorpa.TabIndex = 1;
            // 
            // buttonKreirajNarudžbu
            // 
            buttonKreirajNarudžbu.Location = new Point(333, 39);
            buttonKreirajNarudžbu.Name = "buttonKreirajNarudžbu";
            buttonKreirajNarudžbu.Size = new Size(129, 29);
            buttonKreirajNarudžbu.TabIndex = 2;
            buttonKreirajNarudžbu.Text = "Kreiraj narudžbu";
            buttonKreirajNarudžbu.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(333, 388);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(73, 29);
            buttonDodaj.TabIndex = 3;
            buttonDodaj.Text = "Dodaj";
            buttonDodaj.UseVisualStyleBackColor = true;
            // 
            // buttonObriši
            // 
            buttonObriši.Location = new Point(333, 423);
            buttonObriši.Name = "buttonObriši";
            buttonObriši.Size = new Size(73, 29);
            buttonObriši.TabIndex = 4;
            buttonObriši.Text = "Obriši";
            buttonObriši.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(412, 405);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(61, 27);
            textBoxID.TabIndex = 5;
            // 
            // textBoxKoličina
            // 
            textBoxKoličina.Location = new Point(479, 405);
            textBoxKoličina.Name = "textBoxKoličina";
            textBoxKoličina.Size = new Size(61, 27);
            textBoxKoličina.TabIndex = 6;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(513, 473);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(90, 27);
            textBoxTotal.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 66);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 8;
            label1.Text = "Pregled artikala";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 100);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Korpa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 382);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 382);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 11;
            label4.Text = "KOL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 480);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Total: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(610, 480);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 13;
            label6.Text = "KM";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxTotal);
            groupBox1.Controls.Add(textBoxKoličina);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(buttonObriši);
            groupBox1.Controls.Add(buttonDodaj);
            groupBox1.Controls.Add(buttonKreirajNarudžbu);
            groupBox1.Controls.Add(dataGridViewKorpa);
            groupBox1.Controls.Add(dataGridViewPregledArtikala);
            groupBox1.Location = new Point(19, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(647, 513);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kreiranje narudžbe";
            // 
            // KreiranjeNarudžbe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 512);
            Controls.Add(groupBox1);
            Name = "KreiranjeNarudžbe";
            Text = "Kreiranje narudžbe";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPregledArtikala).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKorpa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPregledArtikala;
        private DataGridView dataGridViewKorpa;
        private Button buttonKreirajNarudžbu;
        private Button buttonDodaj;
        private Button buttonObriši;
        private TextBox textBoxID;
        private TextBox textBoxKoličina;
        private TextBox textBoxTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}