namespace AgendamentoServicos
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
            buttonConfirmar = new Button();
            textBoxNome = new TextBox();
            textBoxContato = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePickerData = new DateTimePicker();
            comboBoxServico = new ComboBox();
            button2 = new Button();
            comboBoxHora = new ComboBox();
            dataGridViewAgenda = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Hora = new DataGridViewTextBoxColumn();
            Serviço = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).BeginInit();
            SuspendLayout();
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.Location = new Point(592, 45);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(146, 66);
            buttonConfirmar.TabIndex = 0;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = true;
            buttonConfirmar.Click += buttonConfirmar_Click_1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(309, 190);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(183, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxContato
            // 
            textBoxContato.Location = new Point(309, 241);
            textBoxContato.Name = "textBoxContato";
            textBoxContato.Size = new Size(183, 23);
            textBoxContato.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Informe a data";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 88);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Informe o horario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 143);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Informe o serviço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 190);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 6;
            label4.Text = "Informe o nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 241);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 7;
            label5.Text = "Informe o contato";
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(241, 43);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(251, 23);
            dateTimePickerData.TabIndex = 8;
            dateTimePickerData.ValueChanged += dateTimePickerData_ValueChanged;
            // 
            // comboBoxServico
            // 
            comboBoxServico.FormattingEnabled = true;
            comboBoxServico.Location = new Point(309, 143);
            comboBoxServico.Name = "comboBoxServico";
            comboBoxServico.Size = new Size(183, 23);
            comboBoxServico.TabIndex = 9;
            comboBoxServico.SelectedIndexChanged += comboBoxServico_SelectedIndexChanged_1;
            // 
            // button2
            // 
            button2.Location = new Point(49, 305);
            button2.Name = "button2";
            button2.Size = new Size(146, 60);
            button2.TabIndex = 11;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // comboBoxHora
            // 
            comboBoxHora.FormattingEnabled = true;
            comboBoxHora.Location = new Point(309, 88);
            comboBoxHora.Name = "comboBoxHora";
            comboBoxHora.Size = new Size(183, 23);
            comboBoxHora.TabIndex = 13;
            comboBoxHora.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridViewAgenda
            // 
            dataGridViewAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgenda.Columns.AddRange(new DataGridViewColumn[] { Data, Hora, Serviço, Nome, Contato });
            dataGridViewAgenda.Location = new Point(223, 270);
            dataGridViewAgenda.Name = "dataGridViewAgenda";
            dataGridViewAgenda.RowTemplate.Height = 25;
            dataGridViewAgenda.Size = new Size(543, 150);
            dataGridViewAgenda.TabIndex = 14;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Hora
            // 
            Hora.HeaderText = "Horário";
            Hora.Name = "Hora";
            // 
            // Serviço
            // 
            Serviço.HeaderText = "Serviço";
            Serviço.Name = "Serviço";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Contato
            // 
            Contato.HeaderText = "Contato";
            Contato.Name = "Contato";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAgenda);
            Controls.Add(comboBoxHora);
            Controls.Add(button2);
            Controls.Add(comboBoxServico);
            Controls.Add(dateTimePickerData);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxContato);
            Controls.Add(textBoxNome);
            Controls.Add(buttonConfirmar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirmar;
        private TextBox textBoxNome;
        private TextBox textBoxContato;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerData;
        private ComboBox comboBoxServico;
        private Button button2;
        private ComboBox comboBoxHora;
        private DataGridView dataGridViewAgenda;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Contato;
    }
}