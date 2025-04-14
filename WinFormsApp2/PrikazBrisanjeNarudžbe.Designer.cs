namespace projektni_zadatak_g1
{
    partial class PrikazBrisanjeNarudžbe
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
            dataGridView1 = new DataGridView();
            textBoxIDNarudžbe = new TextBox();
            label1 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(560, 203);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxIDNarudžbe
            // 
            textBoxIDNarudžbe.Location = new Point(121, 259);
            textBoxIDNarudžbe.Name = "textBoxIDNarudžbe";
            textBoxIDNarudžbe.Size = new Size(76, 27);
            textBoxIDNarudžbe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 262);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 2;
            label1.Text = "ID narudžbe: ";
            // 
            // button1
            // 
            button1.Location = new Point(203, 258);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 3;
            button1.Text = "Brisanje narudžbe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIDNarudžbe);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(25, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 317);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prikaz / Brisanje narudžbe";
            // 
            // PrikazBrisanjeNarudžbe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 356);
            Controls.Add(groupBox1);
            Name = "PrikazBrisanjeNarudžbe";
            Text = "Prikaz / Brisanje narudžbe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxIDNarudžbe;
        private Label label1;
        private Button button1;
        private GroupBox groupBox1;
    }
}