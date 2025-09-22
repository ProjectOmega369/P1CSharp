namespace InventoryApp
{
    partial class FormNovoProduto
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 101);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 161);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor do produto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(308, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(308, 274);
            button1.Name = "button1";
            button1.Size = new Size(142, 36);
            button1.TabIndex = 4;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(308, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(164, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 210);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Quantidade";
            // 
            // FormNovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
    }
}