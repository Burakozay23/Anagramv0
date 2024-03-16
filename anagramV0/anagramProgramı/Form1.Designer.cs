namespace anagramProgramı
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
            this.firstArrayButton = new System.Windows.Forms.Button();
            this.secondArrayButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.anagramButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // firstArrayButton
            // 
            this.firstArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstArrayButton.Location = new System.Drawing.Point(12, 91);
            this.firstArrayButton.Name = "firstArrayButton";
            this.firstArrayButton.Size = new System.Drawing.Size(103, 48);
            this.firstArrayButton.TabIndex = 0;
            this.firstArrayButton.Text = "1. Kelime Grubu";
            this.firstArrayButton.UseVisualStyleBackColor = true;
            this.firstArrayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondArrayButton
            // 
            this.secondArrayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondArrayButton.Location = new System.Drawing.Point(137, 91);
            this.secondArrayButton.Name = "secondArrayButton";
            this.secondArrayButton.Size = new System.Drawing.Size(103, 48);
            this.secondArrayButton.TabIndex = 1;
            this.secondArrayButton.Text = "2. Kelime Grubu";
            this.secondArrayButton.UseVisualStyleBackColor = true;
            this.secondArrayButton.Click += new System.EventHandler(this.secondArrayButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(71, 145);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 38);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Ekle/Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletButton.Location = new System.Drawing.Point(71, 189);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(112, 38);
            this.deletButton.TabIndex = 3;
            this.deletButton.Text = "Sil/Delete";
            this.deletButton.UseVisualStyleBackColor = true;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // anagramButton
            // 
            this.anagramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anagramButton.Location = new System.Drawing.Point(12, 321);
            this.anagramButton.Name = "anagramButton";
            this.anagramButton.Size = new System.Drawing.Size(228, 63);
            this.anagramButton.TabIndex = 5;
            this.anagramButton.Text = "Anagram";
            this.anagramButton.UseVisualStyleBackColor = true;
            this.anagramButton.Click += new System.EventHandler(this.anagramButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(312, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 372);
            this.listBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 38);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(581, 398);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.anagramButton);
            this.Controls.Add(this.deletButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondArrayButton);
            this.Controls.Add(this.firstArrayButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button firstArrayButton;
        private System.Windows.Forms.Button secondArrayButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deletButton;
        private System.Windows.Forms.Button anagramButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

