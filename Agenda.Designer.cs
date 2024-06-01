namespace AgendamentoServicos
{
    partial class Agenda
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
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            dataGridViewAgenda = new DataGridView();
            Data = new DataGridViewTextBoxColumn();
            Horário = new DataGridViewTextBoxColumn();
            Serviço = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 2;
            button1.Text = "volar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewAgenda
            // 
            dataGridViewAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAgenda.Columns.AddRange(new DataGridViewColumn[] { Data, Horário, Serviço, Nome, Contato });
            dataGridViewAgenda.Location = new Point(246, 18);
            dataGridViewAgenda.Name = "dataGridViewAgenda";
            dataGridViewAgenda.RowTemplate.Height = 25;
            dataGridViewAgenda.Size = new Size(542, 402);
            dataGridViewAgenda.TabIndex = 3;
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // Horário
            // 
            Horário.HeaderText = "Horário";
            Horário.Name = "Horário";
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
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAgenda);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Name = "Agenda";
            Text = "Agenda";
            Load += Agenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button button1;
        private DataGridView dataGridViewAgenda;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Horário;
        private DataGridViewTextBoxColumn Serviço;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Contato;
    }
}