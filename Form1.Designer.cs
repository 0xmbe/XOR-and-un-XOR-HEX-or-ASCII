
namespace XOR_test1
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_Xored_TextType = new System.Windows.Forms.ComboBox();
            this.comboBox_UnXored_TextType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Un-XOR the string";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonUnXor_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(554, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "29 15 14 0E 5D 14 0E 5D 25 32 2F 50 18 19 5D 09 \n18 05 09 53\n";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 331);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(554, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "7D";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "XOR-ED text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "XOR HEX byte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NON-XOR-ED text:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "XOR the string";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonXor_Click);
            // 
            // comboBox_Xored_TextType
            // 
            this.comboBox_Xored_TextType.FormattingEnabled = true;
            this.comboBox_Xored_TextType.Location = new System.Drawing.Point(12, 38);
            this.comboBox_Xored_TextType.Name = "comboBox_Xored_TextType";
            this.comboBox_Xored_TextType.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Xored_TextType.TabIndex = 11;
            // 
            // comboBox_UnXored_TextType
            // 
            this.comboBox_UnXored_TextType.FormattingEnabled = true;
            this.comboBox_UnXored_TextType.Location = new System.Drawing.Point(12, 301);
            this.comboBox_UnXored_TextType.Name = "comboBox_UnXored_TextType";
            this.comboBox_UnXored_TextType.Size = new System.Drawing.Size(121, 24);
            this.comboBox_UnXored_TextType.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XOR_test1.Properties.Resources.XOR;
            this.pictureBox1.Location = new System.Drawing.Point(13, 433);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_UnXored_TextType);
            this.Controls.Add(this.comboBox_Xored_TextType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_Xored_TextType;
        private System.Windows.Forms.ComboBox comboBox_UnXored_TextType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

