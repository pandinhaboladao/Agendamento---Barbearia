﻿namespace AgendamentoServicos
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            textBoxServico = new TextBox();
            textBoxPreco = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(343, 110);
            button1.Name = "button1";
            button1.Size = new Size(95, 52);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 286);
            button2.Name = "button2";
            button2.Size = new Size(96, 49);
            button2.TabIndex = 1;
            button2.Text = "menu barreiro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxServico
            // 
            textBoxServico.Location = new Point(227, 65);
            textBoxServico.Name = "textBoxServico";
            textBoxServico.Size = new Size(131, 23);
            textBoxServico.TabIndex = 2;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(421, 65);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(137, 23);
            textBoxPreco.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(281, 196);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(225, 139);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(259, 17);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Serviços:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Preços:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxServico);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBoxServico;
        private TextBox textBoxPreco;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
    }
}