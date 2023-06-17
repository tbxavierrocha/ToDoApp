namespace ToDoApp
{
    partial class frmMain
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
            this.lblTarefa = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtAnotacoes = new System.Windows.Forms.TextBox();
            this.lblAnotacoes = new System.Windows.Forms.Label();
            this.gpbPrioridade = new System.Windows.Forms.GroupBox();
            this.rbPrioridadeBaixa = new System.Windows.Forms.RadioButton();
            this.rbPrioridadeNormal = new System.Windows.Forms.RadioButton();
            this.rbPrioridadeAlta = new System.Windows.Forms.RadioButton();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbStatusConcluida = new System.Windows.Forms.RadioButton();
            this.rbStatusAdiada = new System.Windows.Forms.RadioButton();
            this.rbStatusEmAndamento = new System.Windows.Forms.RadioButton();
            this.rbStatusNaoIniciada = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbPrioridade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTarefa
            // 
            this.lblTarefa.AutoSize = true;
            this.lblTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarefa.Location = new System.Drawing.Point(12, 18);
            this.lblTarefa.Name = "lblTarefa";
            this.lblTarefa.Size = new System.Drawing.Size(61, 20);
            this.lblTarefa.TabIndex = 0;
            this.lblTarefa.Text = "Tarefa";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarefa.Location = new System.Drawing.Point(113, 15);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(983, 26);
            this.txtTarefa.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(113, 56);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(983, 26);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(12, 59);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(89, 20);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtAnotacoes
            // 
            this.txtAnotacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnotacoes.Location = new System.Drawing.Point(113, 100);
            this.txtAnotacoes.Multiline = true;
            this.txtAnotacoes.Name = "txtAnotacoes";
            this.txtAnotacoes.Size = new System.Drawing.Size(983, 72);
            this.txtAnotacoes.TabIndex = 5;
            // 
            // lblAnotacoes
            // 
            this.lblAnotacoes.AutoSize = true;
            this.lblAnotacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotacoes.Location = new System.Drawing.Point(12, 103);
            this.lblAnotacoes.Name = "lblAnotacoes";
            this.lblAnotacoes.Size = new System.Drawing.Size(95, 20);
            this.lblAnotacoes.TabIndex = 4;
            this.lblAnotacoes.Text = "Anotações";
            // 
            // gpbPrioridade
            // 
            this.gpbPrioridade.Controls.Add(this.rbPrioridadeBaixa);
            this.gpbPrioridade.Controls.Add(this.rbPrioridadeNormal);
            this.gpbPrioridade.Controls.Add(this.rbPrioridadeAlta);
            this.gpbPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPrioridade.Location = new System.Drawing.Point(113, 218);
            this.gpbPrioridade.Name = "gpbPrioridade";
            this.gpbPrioridade.Size = new System.Drawing.Size(276, 75);
            this.gpbPrioridade.TabIndex = 6;
            this.gpbPrioridade.TabStop = false;
            this.gpbPrioridade.Text = "Prioridade";
            // 
            // rbPrioridadeBaixa
            // 
            this.rbPrioridadeBaixa.AutoSize = true;
            this.rbPrioridadeBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrioridadeBaixa.Location = new System.Drawing.Point(176, 37);
            this.rbPrioridadeBaixa.Name = "rbPrioridadeBaixa";
            this.rbPrioridadeBaixa.Size = new System.Drawing.Size(67, 22);
            this.rbPrioridadeBaixa.TabIndex = 2;
            this.rbPrioridadeBaixa.TabStop = true;
            this.rbPrioridadeBaixa.Text = "Baixa";
            this.rbPrioridadeBaixa.UseVisualStyleBackColor = true;
            // 
            // rbPrioridadeNormal
            // 
            this.rbPrioridadeNormal.AutoSize = true;
            this.rbPrioridadeNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrioridadeNormal.Location = new System.Drawing.Point(89, 37);
            this.rbPrioridadeNormal.Name = "rbPrioridadeNormal";
            this.rbPrioridadeNormal.Size = new System.Drawing.Size(81, 22);
            this.rbPrioridadeNormal.TabIndex = 1;
            this.rbPrioridadeNormal.TabStop = true;
            this.rbPrioridadeNormal.Text = "Normal";
            this.rbPrioridadeNormal.UseVisualStyleBackColor = true;
            // 
            // rbPrioridadeAlta
            // 
            this.rbPrioridadeAlta.AutoSize = true;
            this.rbPrioridadeAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrioridadeAlta.Location = new System.Drawing.Point(31, 37);
            this.rbPrioridadeAlta.Name = "rbPrioridadeAlta";
            this.rbPrioridadeAlta.Size = new System.Drawing.Size(54, 22);
            this.rbPrioridadeAlta.TabIndex = 0;
            this.rbPrioridadeAlta.TabStop = true;
            this.rbPrioridadeAlta.Text = "Alta";
            this.rbPrioridadeAlta.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbStatusConcluida);
            this.gbStatus.Controls.Add(this.rbStatusAdiada);
            this.gbStatus.Controls.Add(this.rbStatusEmAndamento);
            this.gbStatus.Controls.Add(this.rbStatusNaoIniciada);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.Location = new System.Drawing.Point(580, 218);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(516, 75);
            this.gbStatus.TabIndex = 7;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbStatusConcluida
            // 
            this.rbStatusConcluida.AutoSize = true;
            this.rbStatusConcluida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusConcluida.Location = new System.Drawing.Point(383, 37);
            this.rbStatusConcluida.Name = "rbStatusConcluida";
            this.rbStatusConcluida.Size = new System.Drawing.Size(101, 22);
            this.rbStatusConcluida.TabIndex = 3;
            this.rbStatusConcluida.TabStop = true;
            this.rbStatusConcluida.Text = "Concluida";
            this.rbStatusConcluida.UseVisualStyleBackColor = true;
            // 
            // rbStatusAdiada
            // 
            this.rbStatusAdiada.AutoSize = true;
            this.rbStatusAdiada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusAdiada.Location = new System.Drawing.Point(301, 37);
            this.rbStatusAdiada.Name = "rbStatusAdiada";
            this.rbStatusAdiada.Size = new System.Drawing.Size(76, 22);
            this.rbStatusAdiada.TabIndex = 2;
            this.rbStatusAdiada.TabStop = true;
            this.rbStatusAdiada.Text = "Adiada";
            this.rbStatusAdiada.UseVisualStyleBackColor = true;
            // 
            // rbStatusEmAndamento
            // 
            this.rbStatusEmAndamento.AutoSize = true;
            this.rbStatusEmAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusEmAndamento.Location = new System.Drawing.Point(156, 37);
            this.rbStatusEmAndamento.Name = "rbStatusEmAndamento";
            this.rbStatusEmAndamento.Size = new System.Drawing.Size(139, 22);
            this.rbStatusEmAndamento.TabIndex = 1;
            this.rbStatusEmAndamento.TabStop = true;
            this.rbStatusEmAndamento.Text = "Em andamento";
            this.rbStatusEmAndamento.UseVisualStyleBackColor = true;
            // 
            // rbStatusNaoIniciada
            // 
            this.rbStatusNaoIniciada.AutoSize = true;
            this.rbStatusNaoIniciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStatusNaoIniciada.Location = new System.Drawing.Point(31, 37);
            this.rbStatusNaoIniciada.Name = "rbStatusNaoIniciada";
            this.rbStatusNaoIniciada.Size = new System.Drawing.Size(119, 22);
            this.rbStatusNaoIniciada.TabIndex = 0;
            this.rbStatusNaoIniciada.TabStop = true;
            this.rbStatusNaoIniciada.Text = "Não iniciada";
            this.rbStatusNaoIniciada.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 500);
            this.linkLabel1.Location = new System.Drawing.Point(71, 188);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(983, 24);
            this.textBox1.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 324);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1089, 369);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarefa";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Anotações";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Link";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prioridade";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 100;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 705);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gpbPrioridade);
            this.Controls.Add(this.txtAnotacoes);
            this.Controls.Add(this.lblAnotacoes);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.lblTarefa);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.gpbPrioridade.ResumeLayout(false);
            this.gpbPrioridade.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarefa;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtAnotacoes;
        private System.Windows.Forms.Label lblAnotacoes;
        private System.Windows.Forms.GroupBox gpbPrioridade;
        private System.Windows.Forms.RadioButton rbPrioridadeBaixa;
        private System.Windows.Forms.RadioButton rbPrioridadeNormal;
        private System.Windows.Forms.RadioButton rbPrioridadeAlta;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbStatusAdiada;
        private System.Windows.Forms.RadioButton rbStatusEmAndamento;
        private System.Windows.Forms.RadioButton rbStatusNaoIniciada;
        private System.Windows.Forms.RadioButton rbStatusConcluida;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

