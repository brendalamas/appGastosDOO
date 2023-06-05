namespace ControladorDeGastos
{
    partial class Ingreso
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
            textBox2 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 385);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 27);
            textBox2.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 334);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 35;
            label4.Text = "Comentario";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 267);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 223);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 33;
            label3.Text = "Fecha";
            // 
            // button2
            // 
            button2.Location = new Point(514, 158);
            button2.Name = "button2";
            button2.Size = new Size(90, 35);
            button2.TabIndex = 32;
            button2.Text = "Más";
            button2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(204, 158);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 24);
            radioButton4.TabIndex = 31;
            radioButton4.TabStop = true;
            radioButton4.Text = "Interés";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(371, 158);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 24);
            radioButton3.TabIndex = 30;
            radioButton3.TabStop = true;
            radioButton3.Text = "Otro";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(63, 158);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "Salario";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 102);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 28;
            label2.Text = "Categoria";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 27;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 42);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 26;
            label1.Text = "Ingreso";
            // 
            // button1
            // 
            button1.Location = new Point(616, 367);
            button1.Name = "button1";
            button1.Size = new Size(142, 45);
            button1.TabIndex = 25;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 12);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 37;
            button3.Text = "Atrás";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Ingreso";
            Text = "Ingreso";
            Load += Ingreso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button3;
    }
}