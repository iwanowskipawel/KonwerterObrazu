namespace KonwerterObrazu
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
            this.otworzObrazButton = new System.Windows.Forms.Button();
            this.konwertujButton = new System.Windows.Forms.Button();
            this.zapiszNowyButton = new System.Windows.Forms.Button();
            this.obrazWczytanyPicBox = new System.Windows.Forms.PictureBox();
            this.obrazPoKonwersjiPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progIITextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.limitGornyTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazWczytanyPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazPoKonwersjiPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // otworzObrazButton
            // 
            this.otworzObrazButton.Location = new System.Drawing.Point(13, 13);
            this.otworzObrazButton.Name = "otworzObrazButton";
            this.otworzObrazButton.Size = new System.Drawing.Size(109, 23);
            this.otworzObrazButton.TabIndex = 0;
            this.otworzObrazButton.Text = "Otwórz obraz";
            this.otworzObrazButton.UseVisualStyleBackColor = true;
            this.otworzObrazButton.Click += new System.EventHandler(this.otworzObrazButton_Click_1);
            // 
            // konwertujButton
            // 
            this.konwertujButton.Enabled = false;
            this.konwertujButton.Location = new System.Drawing.Point(12, 179);
            this.konwertujButton.Name = "konwertujButton";
            this.konwertujButton.Size = new System.Drawing.Size(181, 23);
            this.konwertujButton.TabIndex = 1;
            this.konwertujButton.Text = "Konwertuj";
            this.konwertujButton.UseVisualStyleBackColor = true;
            this.konwertujButton.Click += new System.EventHandler(this.konwertujButton_Click);
            // 
            // zapiszNowyButton
            // 
            this.zapiszNowyButton.Enabled = false;
            this.zapiszNowyButton.Location = new System.Drawing.Point(12, 208);
            this.zapiszNowyButton.Name = "zapiszNowyButton";
            this.zapiszNowyButton.Size = new System.Drawing.Size(181, 23);
            this.zapiszNowyButton.TabIndex = 2;
            this.zapiszNowyButton.Text = "Zapisz nowy";
            this.zapiszNowyButton.UseVisualStyleBackColor = true;
            this.zapiszNowyButton.Click += new System.EventHandler(this.zapiszNowyButton_Click);
            // 
            // obrazWczytanyPicBox
            // 
            this.obrazWczytanyPicBox.BackColor = System.Drawing.Color.White;
            this.obrazWczytanyPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obrazWczytanyPicBox.Location = new System.Drawing.Point(199, 13);
            this.obrazWczytanyPicBox.Name = "obrazWczytanyPicBox";
            this.obrazWczytanyPicBox.Size = new System.Drawing.Size(530, 190);
            this.obrazWczytanyPicBox.TabIndex = 3;
            this.obrazWczytanyPicBox.TabStop = false;
            this.obrazWczytanyPicBox.Click += new System.EventHandler(this.obrazWczytanyPicBox_Click);
            // 
            // obrazPoKonwersjiPicBox
            // 
            this.obrazPoKonwersjiPicBox.BackColor = System.Drawing.Color.White;
            this.obrazPoKonwersjiPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obrazPoKonwersjiPicBox.Location = new System.Drawing.Point(199, 208);
            this.obrazPoKonwersjiPicBox.Name = "obrazPoKonwersjiPicBox";
            this.obrazPoKonwersjiPicBox.Size = new System.Drawing.Size(530, 190);
            this.obrazPoKonwersjiPicBox.TabIndex = 4;
            this.obrazPoKonwersjiPicBox.TabStop = false;
            this.obrazPoKonwersjiPicBox.Click += new System.EventHandler(this.obrazPoKonwersjiPicBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "obraz oryginalny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "obraz po konwersji";
            // 
            // progTextBox
            // 
            this.progTextBox.Location = new System.Drawing.Point(13, 55);
            this.progTextBox.Name = "progTextBox";
            this.progTextBox.Size = new System.Drawing.Size(180, 20);
            this.progTextBox.TabIndex = 7;
            this.progTextBox.TextChanged += new System.EventHandler(this.progTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Próg (1 do 255)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Limit Dolny (1 do 255)";
            // 
            // progIITextBox
            // 
            this.progIITextBox.Location = new System.Drawing.Point(12, 94);
            this.progIITextBox.Name = "progIITextBox";
            this.progIITextBox.Size = new System.Drawing.Size(180, 20);
            this.progIITextBox.TabIndex = 9;
            this.progIITextBox.TextChanged += new System.EventHandler(this.progIITextBox_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(181, 156);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Limit Górny (1 do 255)";
            // 
            // limitGornyTextBox
            // 
            this.limitGornyTextBox.Location = new System.Drawing.Point(12, 139);
            this.limitGornyTextBox.Name = "limitGornyTextBox";
            this.limitGornyTextBox.Size = new System.Drawing.Size(180, 20);
            this.limitGornyTextBox.TabIndex = 12;
            this.limitGornyTextBox.TextChanged += new System.EventHandler(this.limitGornyTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.limitGornyTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progIITextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obrazPoKonwersjiPicBox);
            this.Controls.Add(this.obrazWczytanyPicBox);
            this.Controls.Add(this.zapiszNowyButton);
            this.Controls.Add(this.konwertujButton);
            this.Controls.Add(this.otworzObrazButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.obrazWczytanyPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrazPoKonwersjiPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otworzObrazButton;
        private System.Windows.Forms.Button konwertujButton;
        private System.Windows.Forms.Button zapiszNowyButton;
        private System.Windows.Forms.PictureBox obrazWczytanyPicBox;
        private System.Windows.Forms.PictureBox obrazPoKonwersjiPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox progTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox progIITextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox limitGornyTextBox;
    }
}

