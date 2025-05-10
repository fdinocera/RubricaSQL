namespace Rubrica
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 184);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += Ricerca_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(511, 47);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 3;
            label1.Text = "Nominativo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(511, 80);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 4;
            label2.Text = "Numero Telefonico";
            // 
            // button2
            // 
            button2.Location = new Point(258, 40);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 5;
            button2.Text = "Nuovo Contatto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Nuovo_Click;
            // 
            // button3
            // 
            button3.Location = new Point(260, 80);
            button3.Name = "button3";
            button3.Size = new Size(128, 30);
            button3.TabIndex = 6;
            button3.Text = "Modifica Contatto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Modifica_Click;
            // 
            // button4
            // 
            button4.Location = new Point(260, 120);
            button4.Name = "button4";
            button4.Size = new Size(128, 30);
            button4.TabIndex = 7;
            button4.Text = "Elimina Contatto";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Elimina_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Ricerca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Rubrica Telefonica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}
