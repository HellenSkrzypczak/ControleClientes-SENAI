namespace ControleClientess
{
    partial class ClienteForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tcCliente = new TabControl();
            tpClienteConsulta = new TabPage();
            gridClientes = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlPesquisar = new Panel();
            btnPesquisar = new Button();
            textBox1 = new TextBox();
            pnlBotao = new Panel();
            btnVisualizar = new Button();
            btnNovo = new Button();
            tpClienteCadastro = new TabPage();
            btnBuscarCEP = new Button();
            label7 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtLogradouro = new TextBox();
            label3 = new Label();
            txtCep = new TextBox();
            lblGenero = new Label();
            cmbGenero = new ComboBox();
            panel1 = new Panel();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tcCliente.SuspendLayout();
            tpClienteConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            pnlPesquisar.SuspendLayout();
            pnlBotao.SuspendLayout();
            tpClienteCadastro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tcCliente
            // 
            tcCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcCliente.Controls.Add(tpClienteConsulta);
            tcCliente.Controls.Add(tpClienteCadastro);
            tcCliente.Location = new Point(-2, -27);
            tcCliente.Name = "tcCliente";
            tcCliente.SelectedIndex = 0;
            tcCliente.Size = new Size(645, 368);
            tcCliente.TabIndex = 6;
            tcCliente.TabStop = false;
            // 
            // tpClienteConsulta
            // 
            tpClienteConsulta.Controls.Add(gridClientes);
            tpClienteConsulta.Controls.Add(pnlPesquisar);
            tpClienteConsulta.Controls.Add(pnlBotao);
            tpClienteConsulta.Location = new Point(4, 24);
            tpClienteConsulta.Name = "tpClienteConsulta";
            tpClienteConsulta.Padding = new Padding(3);
            tpClienteConsulta.Size = new Size(637, 340);
            tpClienteConsulta.TabIndex = 0;
            tpClienteConsulta.Text = "Consulta";
            tpClienteConsulta.UseVisualStyleBackColor = true;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { colid, colNome, colEmail });
            gridClientes.Dock = DockStyle.Fill;
            gridClientes.Location = new Point(3, 38);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.Size = new Size(631, 267);
            gridClientes.TabIndex = 0;
            // 
            // colid
            // 
            colid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colid.HeaderText = "ID";
            colid.Name = "colid";
            colid.ReadOnly = true;
            colid.Width = 43;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "E-mail";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // pnlPesquisar
            // 
            pnlPesquisar.Controls.Add(btnPesquisar);
            pnlPesquisar.Controls.Add(textBox1);
            pnlPesquisar.Dock = DockStyle.Top;
            pnlPesquisar.Location = new Point(3, 3);
            pnlPesquisar.Name = "pnlPesquisar";
            pnlPesquisar.Size = new Size(631, 35);
            pnlPesquisar.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Dock = DockStyle.Right;
            btnPesquisar.Image = Properties.Resources.icons8_pesquisar_16;
            btnPesquisar.Location = new Point(544, 0);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(87, 35);
            btnPesquisar.TabIndex = 2;
            btnPesquisar.Text = "&Pesquisar";
            btnPesquisar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar por nome";
            textBox1.Size = new Size(535, 23);
            textBox1.TabIndex = 1;
            // 
            // pnlBotao
            // 
            pnlBotao.Controls.Add(btnVisualizar);
            pnlBotao.Controls.Add(btnNovo);
            pnlBotao.Dock = DockStyle.Bottom;
            pnlBotao.Location = new Point(3, 305);
            pnlBotao.Name = "pnlBotao";
            pnlBotao.Size = new Size(631, 32);
            pnlBotao.TabIndex = 2;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Dock = DockStyle.Right;
            btnVisualizar.Image = Properties.Resources.icons8_olhos_16__1_1;
            btnVisualizar.Location = new Point(469, 0);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(86, 32);
            btnVisualizar.TabIndex = 4;
            btnVisualizar.Text = "&Visualizar";
            btnVisualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Dock = DockStyle.Right;
            btnNovo.Image = Properties.Resources.icons8_soma_161;
            btnNovo.Location = new Point(555, 0);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(76, 32);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "&Novo";
            btnNovo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // tpClienteCadastro
            // 
            tpClienteCadastro.Controls.Add(btnBuscarCEP);
            tpClienteCadastro.Controls.Add(label7);
            tpClienteCadastro.Controls.Add(txtEstado);
            tpClienteCadastro.Controls.Add(label6);
            tpClienteCadastro.Controls.Add(label5);
            tpClienteCadastro.Controls.Add(label4);
            tpClienteCadastro.Controls.Add(txtCidade);
            tpClienteCadastro.Controls.Add(txtBairro);
            tpClienteCadastro.Controls.Add(txtLogradouro);
            tpClienteCadastro.Controls.Add(label3);
            tpClienteCadastro.Controls.Add(txtCep);
            tpClienteCadastro.Controls.Add(lblGenero);
            tpClienteCadastro.Controls.Add(cmbGenero);
            tpClienteCadastro.Controls.Add(panel1);
            tpClienteCadastro.Controls.Add(txtEmail);
            tpClienteCadastro.Controls.Add(txtNome);
            tpClienteCadastro.Controls.Add(label2);
            tpClienteCadastro.Controls.Add(label1);
            tpClienteCadastro.Location = new Point(4, 24);
            tpClienteCadastro.Name = "tpClienteCadastro";
            tpClienteCadastro.Padding = new Padding(3);
            tpClienteCadastro.Size = new Size(637, 340);
            tpClienteCadastro.TabIndex = 1;
            tpClienteCadastro.Text = "Cadastro";
            tpClienteCadastro.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCEP
            // 
            btnBuscarCEP.Location = new Point(146, 141);
            btnBuscarCEP.Name = "btnBuscarCEP";
            btnBuscarCEP.Size = new Size(52, 23);
            btnBuscarCEP.TabIndex = 20;
            btnBuscarCEP.Text = "button1";
            btnBuscarCEP.UseVisualStyleBackColor = true;
            btnBuscarCEP.Click += btnBuscarCEP_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 171);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 19;
            label7.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEstado.Location = new Point(406, 189);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(109, 23);
            txtEstado.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 171);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 17;
            label6.Text = "Cidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 171);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 16;
            label5.Text = "Bairro";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 171);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 15;
            label4.Text = "Logradouro";
            label4.Click += label4_Click;
            // 
            // txtCidade
            // 
            txtCidade.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCidade.Location = new Point(276, 189);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(109, 23);
            txtCidade.TabIndex = 14;
            // 
            // txtBairro
            // 
            txtBairro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBairro.Location = new Point(146, 189);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(109, 23);
            txtBairro.TabIndex = 13;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLogradouro.Location = new Point(20, 189);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(109, 23);
            txtLogradouro.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 123);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 11;
            label3.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCep.Location = new Point(20, 141);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(109, 23);
            txtCep.TabIndex = 10;
            txtCep.TextChanged += txtCep_TextChanged;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(509, 14);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 9;
            lblGenero.Text = "Gênero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(509, 30);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(btnExcluir);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 313);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 24);
            panel1.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Dock = DockStyle.Right;
            btnSalvar.Image = Properties.Resources.icons8_salvar_16;
            btnSalvar.ImageAlign = ContentAlignment.BottomLeft;
            btnSalvar.Location = new Point(489, 0);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(64, 24);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "&Salvar";
            btnSalvar.TextAlign = ContentAlignment.TopRight;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Dock = DockStyle.Left;
            btnExcluir.Image = Properties.Resources.trash;
            btnExcluir.ImageAlign = ContentAlignment.BottomLeft;
            btnExcluir.Location = new Point(0, 0);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(68, 24);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "&Excluir";
            btnExcluir.TextAlign = ContentAlignment.TopRight;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.Image = Properties.Resources.icons8_cancelar_16;
            btnCancelar.ImageAlign = ContentAlignment.BottomLeft;
            btnCancelar.Location = new Point(553, 0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 24);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = ContentAlignment.TopRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(20, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(483, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(16, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(487, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 337);
            Controls.Add(tcCliente);
            Name = "ClienteForm";
            Text = "Cadastro de Clientes";
            tcCliente.ResumeLayout(false);
            tpClienteConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            pnlPesquisar.ResumeLayout(false);
            pnlPesquisar.PerformLayout();
            pnlBotao.ResumeLayout(false);
            tpClienteCadastro.ResumeLayout(false);
            tpClienteCadastro.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tcCliente;
        private TabPage tpClienteConsulta;
        private TabPage tpClienteCadastro;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnCancelar;
        private DataGridView gridClientes;
        private Button btnPesquisar;
        private TextBox textBox1;
        private Button btnVisualizar;
        private Button btnNovo;
        private Panel pnlBotao;
        private Panel pnlPesquisar;
        private Panel panel1;
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colEmail;
        private ComboBox cmbGenero;
        private Label lblGenero;
        private Label label3;
        private TextBox txtCep;
        private Label label4;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtLogradouro;
        private Label label5;
        private Label label7;
        private TextBox txtEstado;
        private Label label6;
        private Button btnBuscarCEP;
    }
}