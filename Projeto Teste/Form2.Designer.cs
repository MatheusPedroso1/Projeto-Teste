
namespace Projeto_Teste
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.lblRetirada = new System.Windows.Forms.Label();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbRA = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.lblEditrora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(14, 154);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(107, 61);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "Mostrar Dados";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(353, 154);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(107, 61);
            this.btnRemover.TabIndex = 24;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(240, 154);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 61);
            this.btnEditar.TabIndex = 23;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(127, 154);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(107, 61);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(14, 27);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(103, 20);
            this.tbCodigo.TabIndex = 21;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código";
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(14, 222);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.Size = new System.Drawing.Size(776, 218);
            this.dgvLivros.TabIndex = 19;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Location = new System.Drawing.Point(16, 107);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(240, 20);
            this.dtpRetirada.TabIndex = 36;
            // 
            // lblRetirada
            // 
            this.lblRetirada.AutoSize = true;
            this.lblRetirada.Location = new System.Drawing.Point(13, 91);
            this.lblRetirada.Name = "lblRetirada";
            this.lblRetirada.Size = new System.Drawing.Size(88, 13);
            this.lblRetirada.TabIndex = 35;
            this.lblRetirada.Text = "Data de Retirada";
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(509, 27);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(240, 20);
            this.tbAutor.TabIndex = 34;
            this.tbAutor.TextChanged += new System.EventHandler(this.tbAutor_TextChanged);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(506, 11);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 33;
            this.lblAutor.Text = "Autor";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(232, 27);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(271, 20);
            this.tbTitulo.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(229, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Título";
            // 
            // tbRA
            // 
            this.tbRA.Location = new System.Drawing.Point(123, 27);
            this.tbRA.Name = "tbRA";
            this.tbRA.Size = new System.Drawing.Size(103, 20);
            this.tbRA.TabIndex = 38;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(120, 11);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(22, 13);
            this.lblRA.TabIndex = 37;
            this.lblRA.Text = "RA";
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(16, 66);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(240, 20);
            this.tbCategoria.TabIndex = 40;
            this.tbCategoria.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 50);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 39;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblEditora_Click);
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(262, 107);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(240, 20);
            this.dtpEntrega.TabIndex = 42;
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Location = new System.Drawing.Point(259, 91);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(85, 13);
            this.lblEntrega.TabIndex = 41;
            this.lblEntrega.Text = "Data de Entrega";
            // 
            // tbEditora
            // 
            this.tbEditora.Location = new System.Drawing.Point(262, 66);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(240, 20);
            this.tbEditora.TabIndex = 44;
            // 
            // lblEditrora
            // 
            this.lblEditrora.AutoSize = true;
            this.lblEditrora.Location = new System.Drawing.Point(259, 50);
            this.lblEditrora.Name = "lblEditrora";
            this.lblEditrora.Size = new System.Drawing.Size(40, 13);
            this.lblEditrora.TabIndex = 43;
            this.lblEditrora.Text = "Editora";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEditora);
            this.Controls.Add(this.lblEditrora);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tbRA);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.dtpRetirada);
            this.Controls.Add(this.lblRetirada);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvLivros);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.Label lblRetirada;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbRA;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.Label lblEditrora;
    }
}