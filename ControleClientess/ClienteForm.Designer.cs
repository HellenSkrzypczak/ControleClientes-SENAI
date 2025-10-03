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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tpClienteConsulta.Controls.Add(dataGridView1);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colid, colNome, colEmail });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(631, 267);
            dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
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
    }
}