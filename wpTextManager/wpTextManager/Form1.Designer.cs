namespace wpTextManager
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountWords = new System.Windows.Forms.TextBox();
            this.txtCountLetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWordFind = new System.Windows.Forms.TextBox();
            this.txtcountWordFind = new System.Windows.Forms.TextBox();
            this.txtcoundFindWordRegx = new System.Windows.Forms.TextBox();
            this.txtWordFindReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcountWordExact = new System.Windows.Forms.TextBox();
            this.txtFindExactWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTextToNumberConverter = new System.Windows.Forms.TextBox();
            this.txtNumberConverter = new System.Windows.Forms.TextBox();
            this.txtCulture = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtText.Location = new System.Drawing.Point(0, 0);
            this.txtText.Margin = new System.Windows.Forms.Padding(5);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(615, 151);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "hola a todos este es un texto de prueba ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 151);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de palabras";
            // 
            // txtCountWords
            // 
            this.txtCountWords.Location = new System.Drawing.Point(120, 227);
            this.txtCountWords.Name = "txtCountWords";
            this.txtCountWords.Size = new System.Drawing.Size(72, 20);
            this.txtCountWords.TabIndex = 4;
            // 
            // txtCountLetter
            // 
            this.txtCountLetter.Location = new System.Drawing.Point(120, 256);
            this.txtCountLetter.Name = "txtCountLetter";
            this.txtCountLetter.Size = new System.Drawing.Size(72, 20);
            this.txtCountLetter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero de letras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Palabra a buscar";
            // 
            // txtWordFind
            // 
            this.txtWordFind.Location = new System.Drawing.Point(432, 223);
            this.txtWordFind.Name = "txtWordFind";
            this.txtWordFind.Size = new System.Drawing.Size(85, 20);
            this.txtWordFind.TabIndex = 8;
            this.txtWordFind.Text = "es";
            // 
            // txtcountWordFind
            // 
            this.txtcountWordFind.Location = new System.Drawing.Point(523, 223);
            this.txtcountWordFind.Name = "txtcountWordFind";
            this.txtcountWordFind.Size = new System.Drawing.Size(35, 20);
            this.txtcountWordFind.TabIndex = 9;
            // 
            // txtcoundFindWordRegx
            // 
            this.txtcoundFindWordRegx.Location = new System.Drawing.Point(523, 275);
            this.txtcoundFindWordRegx.Name = "txtcoundFindWordRegx";
            this.txtcoundFindWordRegx.Size = new System.Drawing.Size(35, 20);
            this.txtcoundFindWordRegx.TabIndex = 12;
            // 
            // txtWordFindReg
            // 
            this.txtWordFindReg.Location = new System.Drawing.Point(432, 275);
            this.txtWordFindReg.Name = "txtWordFindReg";
            this.txtWordFindReg.Size = new System.Drawing.Size(85, 20);
            this.txtWordFindReg.TabIndex = 11;
            this.txtWordFindReg.Text = "es";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Palabra repetida continua";
            // 
            // txtcountWordExact
            // 
            this.txtcountWordExact.Location = new System.Drawing.Point(523, 249);
            this.txtcountWordExact.Name = "txtcountWordExact";
            this.txtcountWordExact.Size = new System.Drawing.Size(35, 20);
            this.txtcountWordExact.TabIndex = 15;
            // 
            // txtFindExactWord
            // 
            this.txtFindExactWord.Location = new System.Drawing.Point(432, 249);
            this.txtFindExactWord.Name = "txtFindExactWord";
            this.txtFindExactWord.Size = new System.Drawing.Size(85, 20);
            this.txtFindExactWord.TabIndex = 14;
            this.txtFindExactWord.Text = "es";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Palabra exacta a buscar";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(491, 440);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(52, 13);
            this.lblVersion.TabIndex = 16;
            this.lblVersion.Text = "lblVersion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Convertir texto en numero";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Convertir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTextToNumberConverter
            // 
            this.txtTextToNumberConverter.Location = new System.Drawing.Point(158, 351);
            this.txtTextToNumberConverter.Name = "txtTextToNumberConverter";
            this.txtTextToNumberConverter.Size = new System.Drawing.Size(263, 20);
            this.txtTextToNumberConverter.TabIndex = 19;
            this.txtTextToNumberConverter.Text = "dos mil quinientos cinco";
            // 
            // txtNumberConverter
            // 
            this.txtNumberConverter.Location = new System.Drawing.Point(432, 351);
            this.txtNumberConverter.Name = "txtNumberConverter";
            this.txtNumberConverter.Size = new System.Drawing.Size(126, 20);
            this.txtNumberConverter.TabIndex = 20;
            this.txtNumberConverter.Text = "0";
            this.txtNumberConverter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCulture
            // 
            this.txtCulture.Location = new System.Drawing.Point(564, 351);
            this.txtCulture.Name = "txtCulture";
            this.txtCulture.Size = new System.Drawing.Size(39, 20);
            this.txtCulture.TabIndex = 21;
            this.txtCulture.Text = "es";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 459);
            this.Controls.Add(this.txtCulture);
            this.Controls.Add(this.txtNumberConverter);
            this.Controls.Add(this.txtTextToNumberConverter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtcountWordExact);
            this.Controls.Add(this.txtFindExactWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcoundFindWordRegx);
            this.Controls.Add(this.txtWordFindReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcountWordFind);
            this.Controls.Add(this.txtWordFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCountLetter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountWords;
        private System.Windows.Forms.TextBox txtCountLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWordFind;
        private System.Windows.Forms.TextBox txtcountWordFind;
        private System.Windows.Forms.TextBox txtcoundFindWordRegx;
        private System.Windows.Forms.TextBox txtWordFindReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcountWordExact;
        private System.Windows.Forms.TextBox txtFindExactWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTextToNumberConverter;
        private System.Windows.Forms.TextBox txtNumberConverter;
        private System.Windows.Forms.TextBox txtCulture;
    }
}

