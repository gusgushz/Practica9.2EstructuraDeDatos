namespace Practica9._2
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
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(145, 233);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 164);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(364, 233);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(204, 164);
            listBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(145, 154);
            button1.Name = "button1";
            button1.Size = new Size(201, 61);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(405, 161);
            button2.Name = "button2";
            button2.Size = new Size(161, 61);
            button2.TabIndex = 3;
            button2.Text = "Reemplazar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(145, 71);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 4;
            label1.Text = "Agrega una cantidaad ";
            label1.UseMnemonic = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(405, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(72, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(405, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 27);
            textBox3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 40);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 8;
            label2.Text = "Numero a reemplazar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 96);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 9;
            label3.Text = "Nuevo numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 91);
            label4.Name = "label4";
            label4.Size = new Size(214, 20);
            label4.TabIndex = 10;
            label4.Text = "de numeros aleatorios a la pila";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}