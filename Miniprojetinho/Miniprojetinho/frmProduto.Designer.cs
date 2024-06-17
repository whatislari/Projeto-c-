namespace Miniprojetinho
{
    partial class frmProduto
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btoSairpro = new System.Windows.Forms.Button();
            this.btoLimparpro = new System.Windows.Forms.Button();
            this.btoExcluirpro = new System.Windows.Forms.Button();
            this.btoAlterarpro = new System.Windows.Forms.Button();
            this.btoCadastrarpro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboStatuspro = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDATApro = new System.Windows.Forms.MaskedTextBox();
            this.btopesquisa = new System.Windows.Forms.Button();
            this.txtCodigopro = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVvenda = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.txtVcusto = new System.Windows.Forms.TextBox();
            this.txtNomepro = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoSairpro);
            this.groupBox3.Controls.Add(this.btoLimparpro);
            this.groupBox3.Controls.Add(this.btoExcluirpro);
            this.groupBox3.Controls.Add(this.btoAlterarpro);
            this.groupBox3.Controls.Add(this.btoCadastrarpro);
            this.groupBox3.Location = new System.Drawing.Point(16, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(645, 69);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btoSairpro
            // 
            this.btoSairpro.Location = new System.Drawing.Point(465, 22);
            this.btoSairpro.Name = "btoSairpro";
            this.btoSairpro.Size = new System.Drawing.Size(87, 40);
            this.btoSairpro.TabIndex = 5;
            this.btoSairpro.Text = "&Sair";
            this.btoSairpro.UseVisualStyleBackColor = true;
            this.btoSairpro.Click += new System.EventHandler(this.btoSairpro_Click);
            // 
            // btoLimparpro
            // 
            this.btoLimparpro.Location = new System.Drawing.Point(372, 22);
            this.btoLimparpro.Name = "btoLimparpro";
            this.btoLimparpro.Size = new System.Drawing.Size(87, 40);
            this.btoLimparpro.TabIndex = 4;
            this.btoLimparpro.Text = "&Limpar";
            this.btoLimparpro.UseVisualStyleBackColor = true;
            this.btoLimparpro.Click += new System.EventHandler(this.btoLimparpro_Click);
            // 
            // btoExcluirpro
            // 
            this.btoExcluirpro.Location = new System.Drawing.Point(279, 22);
            this.btoExcluirpro.Name = "btoExcluirpro";
            this.btoExcluirpro.Size = new System.Drawing.Size(87, 40);
            this.btoExcluirpro.TabIndex = 3;
            this.btoExcluirpro.Text = "&Excluir";
            this.btoExcluirpro.UseVisualStyleBackColor = true;
            this.btoExcluirpro.Click += new System.EventHandler(this.btoExcluirpro_Click);
            // 
            // btoAlterarpro
            // 
            this.btoAlterarpro.Location = new System.Drawing.Point(186, 22);
            this.btoAlterarpro.Name = "btoAlterarpro";
            this.btoAlterarpro.Size = new System.Drawing.Size(87, 40);
            this.btoAlterarpro.TabIndex = 2;
            this.btoAlterarpro.Text = "&Alterar";
            this.btoAlterarpro.UseVisualStyleBackColor = true;
            this.btoAlterarpro.Click += new System.EventHandler(this.btoAlterarpro_Click);
            // 
            // btoCadastrarpro
            // 
            this.btoCadastrarpro.Location = new System.Drawing.Point(93, 22);
            this.btoCadastrarpro.Name = "btoCadastrarpro";
            this.btoCadastrarpro.Size = new System.Drawing.Size(87, 40);
            this.btoCadastrarpro.TabIndex = 1;
            this.btoCadastrarpro.Text = "&Cadastrar";
            this.btoCadastrarpro.UseVisualStyleBackColor = true;
            this.btoCadastrarpro.Click += new System.EventHandler(this.btoCadastrarpro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboStatuspro);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.txtDATApro);
            this.groupBox1.Controls.Add(this.btopesquisa);
            this.groupBox1.Controls.Add(this.txtCodigopro);
            this.groupBox1.Controls.Add(this.lblData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboStatuspro
            // 
            this.cboStatuspro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatuspro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboStatuspro.FormattingEnabled = true;
            this.cboStatuspro.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatuspro.Location = new System.Drawing.Point(491, 41);
            this.cboStatuspro.Name = "cboStatuspro";
            this.cboStatuspro.Size = new System.Drawing.Size(144, 32);
            this.cboStatuspro.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(491, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // txtDATApro
            // 
            this.txtDATApro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDATApro.Location = new System.Drawing.Point(351, 41);
            this.txtDATApro.Mask = "##/##/####";
            this.txtDATApro.Name = "txtDATApro";
            this.txtDATApro.ReadOnly = true;
            this.txtDATApro.Size = new System.Drawing.Size(116, 33);
            this.txtDATApro.TabIndex = 3;
            this.txtDATApro.ValidatingType = typeof(System.DateTime);
            // 
            // btopesquisa
            // 
            this.btopesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btopesquisa.Location = new System.Drawing.Point(251, 45);
            this.btopesquisa.Name = "btopesquisa";
            this.btopesquisa.Size = new System.Drawing.Size(46, 30);
            this.btopesquisa.TabIndex = 2;
            this.btopesquisa.Text = "...";
            this.btopesquisa.UseVisualStyleBackColor = true;
            this.btopesquisa.Click += new System.EventHandler(this.btopesquisa_Click);
            // 
            // txtCodigopro
            // 
            this.txtCodigopro.Location = new System.Drawing.Point(12, 48);
            this.txtCodigopro.Name = "txtCodigopro";
            this.txtCodigopro.Size = new System.Drawing.Size(233, 23);
            this.txtCodigopro.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(351, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtVvenda);
            this.groupBox2.Controls.Add(this.txtqtde);
            this.groupBox2.Controls.Add(this.txtVcusto);
            this.groupBox2.Controls.Add(this.txtNomepro);
            this.groupBox2.Location = new System.Drawing.Point(14, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 105);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor de venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor de custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome do produto";
            // 
            // txtVvenda
            // 
            this.txtVvenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVvenda.Location = new System.Drawing.Point(503, 47);
            this.txtVvenda.Name = "txtVvenda";
            this.txtVvenda.Size = new System.Drawing.Size(91, 29);
            this.txtVvenda.TabIndex = 4;
            this.txtVvenda.Enter += new System.EventHandler(this.txtVvenda_Enter);
            // 
            // txtqtde
            // 
            this.txtqtde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtqtde.Location = new System.Drawing.Point(230, 47);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.Size = new System.Drawing.Size(91, 29);
            this.txtqtde.TabIndex = 3;
            // 
            // txtVcusto
            // 
            this.txtVcusto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVcusto.Location = new System.Drawing.Point(377, 47);
            this.txtVcusto.Name = "txtVcusto";
            this.txtVcusto.Size = new System.Drawing.Size(91, 29);
            this.txtVcusto.TabIndex = 3;
            this.txtVcusto.Leave += new System.EventHandler(this.txtVcusto_Leave);
            // 
            // txtNomepro
            // 
            this.txtNomepro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomepro.Location = new System.Drawing.Point(10, 47);
            this.txtNomepro.Name = "txtNomepro";
            this.txtNomepro.Size = new System.Drawing.Size(192, 29);
            this.txtNomepro.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtObs);
            this.groupBox4.Location = new System.Drawing.Point(16, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(645, 150);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observação";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObs.Location = new System.Drawing.Point(8, 46);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(631, 89);
            this.txtObs.TabIndex = 2;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmProduto";
            this.Text = "frmProduto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox3;
        private Button btoSairpro;
        private Button btoLimparpro;
        private Button btoExcluirpro;
        private Button btoAlterarpro;
        private Button btoCadastrarpro;
        private GroupBox groupBox1;
        private ComboBox cboStatuspro;
        private Label lblStatus;
        private MaskedTextBox txtDATApro;
        private Button btopesquisa;
        private TextBox txtCodigopro;
        private Label lblData;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox txtNomepro;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private TextBox txtVvenda;
        private TextBox txtVcusto;
        private Label label6;
        private TextBox txtObs;
        private TextBox txtqtde;
    }
}