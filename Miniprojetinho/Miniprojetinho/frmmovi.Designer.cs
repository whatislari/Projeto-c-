﻿namespace Miniprojetinho
{
    partial class frmmovi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDATA = new System.Windows.Forms.MaskedTextBox();
            this.btopesquisar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cboIDfuncionario = new System.Windows.Forms.ComboBox();
            this.cboqtde = new System.Windows.Forms.ComboBox();
            this.cboIDproduto = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSair = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtDATA);
            this.groupBox1.Controls.Add(this.btopesquisar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtDATA
            // 
            this.txtDATA.Location = new System.Drawing.Point(320, 41);
            this.txtDATA.Mask = "##/##/####";
            this.txtDATA.Name = "txtDATA";
            this.txtDATA.ReadOnly = true;
            this.txtDATA.Size = new System.Drawing.Size(116, 23);
            this.txtDATA.TabIndex = 3;
            this.txtDATA.ValidatingType = typeof(System.DateTime);
            // 
            // btopesquisar
            // 
            this.btopesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btopesquisar.Location = new System.Drawing.Point(252, 38);
            this.btopesquisar.Name = "btopesquisar";
            this.btopesquisar.Size = new System.Drawing.Size(46, 30);
            this.btopesquisar.TabIndex = 2;
            this.btopesquisar.Text = "...";
            this.btopesquisar.UseVisualStyleBackColor = true;
            this.btopesquisar.Click += new System.EventHandler(this.btopesquisar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(13, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(233, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(332, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbotipo);
            this.groupBox2.Controls.Add(this.cboIDfuncionario);
            this.groupBox2.Controls.Add(this.cboqtde);
            this.groupBox2.Controls.Add(this.cboIDproduto);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.lblObs);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 349);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cbotipo
            // 
            this.cbotipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "ENTRADA",
            "SAÍDA"});
            this.cbotipo.Location = new System.Drawing.Point(156, 38);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(142, 28);
            this.cbotipo.TabIndex = 9;
            // 
            // cboIDfuncionario
            // 
            this.cboIDfuncionario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDfuncionario.FormattingEnabled = true;
            this.cboIDfuncionario.Location = new System.Drawing.Point(12, 111);
            this.cboIDfuncionario.Name = "cboIDfuncionario";
            this.cboIDfuncionario.Size = new System.Drawing.Size(90, 28);
            this.cboIDfuncionario.TabIndex = 9;
            // 
            // cboqtde
            // 
            this.cboqtde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboqtde.FormattingEnabled = true;
            this.cboqtde.Location = new System.Drawing.Point(159, 111);
            this.cboqtde.Name = "cboqtde";
            this.cboqtde.Size = new System.Drawing.Size(87, 28);
            this.cboqtde.TabIndex = 9;
            // 
            // cboIDproduto
            // 
            this.cboIDproduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboIDproduto.FormattingEnabled = true;
            this.cboIDproduto.Location = new System.Drawing.Point(13, 38);
            this.cboIDproduto.Name = "cboIDproduto";
            this.cboIDproduto.Size = new System.Drawing.Size(87, 28);
            this.cboIDproduto.TabIndex = 9;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(329, 38);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(144, 32);
            this.cboStatus.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(329, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 169);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(461, 164);
            this.txtObs.TabIndex = 8;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObs.Location = new System.Drawing.Point(12, 151);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(72, 15);
            this.lblObs.TabIndex = 0;
            this.lblObs.Text = "Observação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(156, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de movimentação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade de itens:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Funcionario:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(13, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "ID Produto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSair);
            this.groupBox3.Controls.Add(this.btoExcluir);
            this.groupBox3.Controls.Add(this.btoLimpar);
            this.groupBox3.Controls.Add(this.btoAlterar);
            this.groupBox3.Controls.Add(this.btoCadastrar);
            this.groupBox3.Location = new System.Drawing.Point(12, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 69);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btoSair
            // 
            this.btoSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btoSair.Location = new System.Drawing.Point(371, 22);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(65, 39);
            this.btoSair.TabIndex = 15;
            this.btoSair.Text = "&Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btoExcluir.Location = new System.Drawing.Point(300, 23);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(65, 40);
            this.btoExcluir.TabIndex = 14;
            this.btoExcluir.Text = "&Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            this.btoExcluir.Click += new System.EventHandler(this.btoExcluir_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btoLimpar.Location = new System.Drawing.Point(226, 23);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(65, 39);
            this.btoLimpar.TabIndex = 14;
            this.btoLimpar.Text = "&Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btoAlterar.Location = new System.Drawing.Point(155, 22);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(65, 40);
            this.btoAlterar.TabIndex = 13;
            this.btoAlterar.Text = "&Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            this.btoAlterar.Click += new System.EventHandler(this.btoAlterar_Click);
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btoCadastrar.Location = new System.Drawing.Point(82, 22);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(67, 40);
            this.btoCadastrar.TabIndex = 12;
            this.btoCadastrar.Text = "&Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // frmmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 528);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmovi";
            this.Text = "frmmovi";
            this.Load += new System.EventHandler(this.frmmovi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox txtDATA;
        private Button btopesquisar;
        private TextBox txtCodigo;
        private Label lblData;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cboIDfuncionario;
        private ComboBox cboIDproduto;
        private ComboBox cboStatus;
        private Label lblStatus;
        private TextBox txtObs;
        private Label lblObs;
        private Label label3;
        private Label label2;
        private Label lblNome;
        private GroupBox groupBox3;
        private Button btoExcluir;
        private Button btoAlterar;
        private Button btoCadastrar;
        private Button btoSair;
        private Button btoLimpar;
        private ComboBox cbotipo;
        private Label label4;
        private ComboBox cboqtde;
    }
}