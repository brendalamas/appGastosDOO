namespace ControladorDeGastos
{
    partial class ControladorGastos
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(517, 207);
            button2.Name = "button2";
            button2.Size = new Size(152, 41);
            button2.TabIndex = 1;
            button2.Text = "Ingreso";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(230, 21);
            label1.Name = "label1";
            label1.Size = new Size(401, 39);
            label1.TabIndex = 3;
            label1.Text = "Controlador de Gastos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(372, 92);
            label2.Name = "label2";
            label2.Size = new Size(68, 27);
            label2.TabIndex = 4;
            label2.Text = "Total";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(157, 207);
            button4.Name = "button4";
            button4.Size = new Size(152, 41);
            button4.TabIndex = 6;
            button4.Text = "Gasto";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(318, 304);
            button1.Name = "button1";
            button1.Size = new Size(188, 41);
            button1.TabIndex = 7;
            button1.Text = "Movimiento";
            button1.UseVisualStyleBackColor = false;
            // 
            // ControladorGastos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "ControladorGastos";
            Text = "Controlador de Gastos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private Button button1;
    }
}