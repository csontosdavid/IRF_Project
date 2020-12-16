namespace beadando_yh3dt9
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
            this.adatbetoltes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sorsolas = new System.Windows.Forms.Button();
            this.exportalas = new System.Windows.Forms.Button();
            this.kithuzott = new System.Windows.Forms.Button();
            this.ajandekotlet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adatbetoltes
            // 
            this.adatbetoltes.Location = new System.Drawing.Point(762, 12);
            this.adatbetoltes.Name = "adatbetoltes";
            this.adatbetoltes.Size = new System.Drawing.Size(369, 94);
            this.adatbetoltes.TabIndex = 0;
            this.adatbetoltes.Text = "Adatok betöltése";
            this.adatbetoltes.UseVisualStyleBackColor = true;
            this.adatbetoltes.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 686);
            this.listBox1.TabIndex = 1;
            // 
            // sorsolas
            // 
            this.sorsolas.Location = new System.Drawing.Point(762, 113);
            this.sorsolas.Name = "sorsolas";
            this.sorsolas.Size = new System.Drawing.Size(369, 94);
            this.sorsolas.TabIndex = 2;
            this.sorsolas.Text = "Sorsolás";
            this.sorsolas.UseVisualStyleBackColor = true;
            this.sorsolas.Click += new System.EventHandler(this.button2_Click);
            // 
            // exportalas
            // 
            this.exportalas.Location = new System.Drawing.Point(762, 213);
            this.exportalas.Name = "exportalas";
            this.exportalas.Size = new System.Drawing.Size(369, 94);
            this.exportalas.TabIndex = 4;
            this.exportalas.Text = "Adatok exportálása";
            this.exportalas.UseVisualStyleBackColor = true;
            this.exportalas.Click += new System.EventHandler(this.button3_Click);
            // 
            // kithuzott
            // 
            this.kithuzott.Location = new System.Drawing.Point(12, 12);
            this.kithuzott.Name = "kithuzott";
            this.kithuzott.Size = new System.Drawing.Size(369, 94);
            this.kithuzott.TabIndex = 5;
            this.kithuzott.Text = "Kit húzott?";
            this.kithuzott.UseVisualStyleBackColor = true;
            this.kithuzott.Click += new System.EventHandler(this.button4_Click);
            // 
            // ajandekotlet
            // 
            this.ajandekotlet.Location = new System.Drawing.Point(387, 12);
            this.ajandekotlet.Name = "ajandekotlet";
            this.ajandekotlet.Size = new System.Drawing.Size(369, 94);
            this.ajandekotlet.TabIndex = 6;
            this.ajandekotlet.Text = "Ajándékötlet keresés";
            this.ajandekotlet.UseVisualStyleBackColor = true;
            this.ajandekotlet.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 972);
            this.Controls.Add(this.ajandekotlet);
            this.Controls.Add(this.kithuzott);
            this.Controls.Add(this.exportalas);
            this.Controls.Add(this.sorsolas);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.adatbetoltes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adatbetoltes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sorsolas;
        private System.Windows.Forms.Button exportalas;
        private System.Windows.Forms.Button kithuzott;
        private System.Windows.Forms.Button ajandekotlet;
    }
}

