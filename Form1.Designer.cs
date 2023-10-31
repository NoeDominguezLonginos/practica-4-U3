namespace practica_4_U3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 55);
            label1.Name = "label1";
            label1.Size = new Size(239, 45);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador,\r\nel programa aplica un argumento del 15%\r\nsi el sueldo es inferior a 400000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 158);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresar sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 286);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Nuevo sueldo ";
            // 
            // button1
            // 
            button1.Location = new Point(82, 215);
            button1.Name = "button1";
            button1.Size = new Size(91, 34);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(256, 216);
            button2.Name = "button2";
            button2.Size = new Size(85, 33);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 278);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 356);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}