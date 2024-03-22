
namespace Projeto_Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.lblRA = new System.Windows.Forms.Label();
            this.tbRA = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.rbDesativado = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbRA = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.lblBusca = new System.Windows.Forms.Label();
            this.btCriarDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(12, 220);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.ReadOnly = true;
            this.dgvAluno.Size = new System.Drawing.Size(776, 218);
            this.dgvAluno.TabIndex = 0;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(9, 9);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(22, 13);
            this.lblRA.TabIndex = 1;
            this.lblRA.Text = "RA";
            // 
            // tbRA
            // 
            this.tbRA.Location = new System.Drawing.Point(12, 25);
            this.tbRA.Name = "tbRA";
            this.tbRA.Size = new System.Drawing.Size(100, 20);
            this.tbRA.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(12, 66);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(238, 20);
            this.tbNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 109);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(238, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "E-Mail";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(259, 66);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(100, 20);
            this.tbTelefone.TabIndex = 8;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(256, 50);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 7;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(116, 9);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(104, 13);
            this.lblNascimento.TabIndex = 9;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(125, 152);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 61);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(238, 152);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 61);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(351, 152);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(107, 61);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(610, 152);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(178, 61);
            this.btnProximo.TabIndex = 15;
            this.btnProximo.Text = "Abrir a Página Livros";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(119, 25);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(240, 20);
            this.dtpDataNascimento.TabIndex = 17;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 152);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(107, 61);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // rbDesativado
            // 
            this.rbDesativado.AutoSize = true;
            this.rbDesativado.Checked = true;
            this.rbDesativado.Location = new System.Drawing.Point(379, 27);
            this.rbDesativado.Name = "rbDesativado";
            this.rbDesativado.Size = new System.Drawing.Size(79, 17);
            this.rbDesativado.TabIndex = 19;
            this.rbDesativado.TabStop = true;
            this.rbDesativado.Text = "Desativado";
            this.rbDesativado.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(379, 73);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(72, 17);
            this.rbNome.TabIndex = 20;
            this.rbNome.Text = "Por Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbRA
            // 
            this.rbRA.AutoSize = true;
            this.rbRA.Location = new System.Drawing.Point(379, 50);
            this.rbRA.Name = "rbRA";
            this.rbRA.Size = new System.Drawing.Size(59, 17);
            this.rbRA.TabIndex = 21;
            this.rbRA.Text = "Por RA";
            this.rbRA.UseVisualStyleBackColor = true;
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Location = new System.Drawing.Point(379, 96);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(73, 17);
            this.rbEmail.TabIndex = 22;
            this.rbEmail.Text = "Por E-Mail";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Location = new System.Drawing.Point(376, 9);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(73, 13);
            this.lblBusca.TabIndex = 23;
            this.lblBusca.Text = "Modo Busca?";
            // 
            // btCriarDatabase
            // 
            this.btCriarDatabase.Location = new System.Drawing.Point(653, 12);
            this.btCriarDatabase.Name = "btCriarDatabase";
            this.btCriarDatabase.Size = new System.Drawing.Size(135, 65);
            this.btCriarDatabase.TabIndex = 24;
            this.btCriarDatabase.Text = "Criar Database e Tabelas";
            this.btCriarDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btCriarDatabase.UseVisualStyleBackColor = true;
            this.btCriarDatabase.Visible = false;
            this.btCriarDatabase.Click += new System.EventHandler(this.btCriarDatabase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCriarDatabase);
            this.Controls.Add(this.lblBusca);
            this.Controls.Add(this.rbEmail);
            this.Controls.Add(this.rbRA);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.rbDesativado);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbRA);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.dgvAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox tbRA;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.RadioButton rbDesativado;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbRA;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.Button btCriarDatabase;
    }
}

