namespace Aplicativo_Escola_Exemplo.PL.Controls
{
    partial class ControleSalas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nomeTela = new Label();
            dgv_lista = new DataGridView();
            btn_adicionar = new Button();
            btn_remover = new Button();
            btn_editar = new Button();
            btn_pesquisa = new Button();
            cbx_pesquisa = new ComboBox();
            lbl_nSala = new Label();
            btn_reiniciarLista = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_lista).BeginInit();
            SuspendLayout();
            // 
            // lbl_nomeTela
            // 
            lbl_nomeTela.AutoSize = true;
            lbl_nomeTela.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nomeTela.ForeColor = Color.FromArgb(20, 20, 20);
            lbl_nomeTela.Location = new Point(16, 16);
            lbl_nomeTela.Margin = new Padding(8, 8, 8, 0);
            lbl_nomeTela.Name = "lbl_nomeTela";
            lbl_nomeTela.Size = new Size(107, 25);
            lbl_nomeTela.TabIndex = 0;
            lbl_nomeTela.Text = "Tela turmas";
            // 
            // dgv_lista
            // 
            dgv_lista.AllowUserToAddRows = false;
            dgv_lista.AllowUserToDeleteRows = false;
            dgv_lista.AllowUserToOrderColumns = true;
            dgv_lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lista.BackgroundColor = Color.AntiqueWhite;
            dgv_lista.BorderStyle = BorderStyle.None;
            dgv_lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_lista.Location = new Point(16, 113);
            dgv_lista.Margin = new Padding(16);
            dgv_lista.MultiSelect = false;
            dgv_lista.Name = "dgv_lista";
            dgv_lista.ReadOnly = true;
            dgv_lista.RowHeadersWidth = 42;
            dgv_lista.Size = new Size(568, 231);
            dgv_lista.TabIndex = 6;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_adicionar.BackColor = Color.Wheat;
            btn_adicionar.Cursor = Cursors.Hand;
            btn_adicionar.FlatAppearance.BorderSize = 0;
            btn_adicionar.FlatStyle = FlatStyle.Flat;
            btn_adicionar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_adicionar.Location = new Point(68, 57);
            btn_adicionar.Margin = new Padding(8, 16, 16, 8);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(156, 32);
            btn_adicionar.TabIndex = 3;
            btn_adicionar.Text = "Adicionar Turma";
            btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_remover
            // 
            btn_remover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_remover.BackColor = Color.Wheat;
            btn_remover.Cursor = Cursors.Hand;
            btn_remover.FlatAppearance.BorderSize = 0;
            btn_remover.FlatStyle = FlatStyle.Flat;
            btn_remover.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_remover.Location = new Point(248, 57);
            btn_remover.Margin = new Padding(8, 16, 16, 8);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(156, 32);
            btn_remover.TabIndex = 4;
            btn_remover.Text = "Remover Turma";
            btn_remover.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_editar.BackColor = Color.Wheat;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_editar.Location = new Point(428, 57);
            btn_editar.Margin = new Padding(8, 16, 16, 8);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(156, 32);
            btn_editar.TabIndex = 5;
            btn_editar.Text = "Editar Turma";
            btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_pesquisa
            // 
            btn_pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_pesquisa.BackColor = Color.Wheat;
            btn_pesquisa.Cursor = Cursors.Hand;
            btn_pesquisa.FlatAppearance.BorderSize = 0;
            btn_pesquisa.FlatStyle = FlatStyle.Flat;
            btn_pesquisa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_pesquisa.Image = Properties.Resources.search;
            btn_pesquisa.Location = new Point(552, 16);
            btn_pesquisa.Margin = new Padding(4, 16, 16, 8);
            btn_pesquisa.Name = "btn_pesquisa";
            btn_pesquisa.Size = new Size(32, 32);
            btn_pesquisa.TabIndex = 2;
            btn_pesquisa.UseVisualStyleBackColor = false;
            btn_pesquisa.Click += btn_pesquisa_Click;
            // 
            // cbx_pesquisa
            // 
            cbx_pesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbx_pesquisa.Cursor = Cursors.Hand;
            cbx_pesquisa.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_pesquisa.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cbx_pesquisa.ForeColor = Color.FromArgb(20, 20, 20);
            cbx_pesquisa.FormattingEnabled = true;
            cbx_pesquisa.ItemHeight = 21;
            cbx_pesquisa.Items.AddRange(new object[] { "" });
            cbx_pesquisa.Location = new Point(448, 16);
            cbx_pesquisa.Margin = new Padding(4, 16, 4, 8);
            cbx_pesquisa.MaxDropDownItems = 100;
            cbx_pesquisa.MaximumSize = new Size(96, 0);
            cbx_pesquisa.MaxLength = 10;
            cbx_pesquisa.Name = "cbx_pesquisa";
            cbx_pesquisa.Size = new Size(96, 29);
            cbx_pesquisa.TabIndex = 1;
            // 
            // lbl_nSala
            // 
            lbl_nSala.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_nSala.AutoSize = true;
            lbl_nSala.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_nSala.ForeColor = Color.FromArgb(20, 20, 20);
            lbl_nSala.Location = new Point(341, 19);
            lbl_nSala.Margin = new Padding(8, 8, 4, 8);
            lbl_nSala.Name = "lbl_nSala";
            lbl_nSala.Size = new Size(99, 21);
            lbl_nSala.TabIndex = 0;
            lbl_nSala.Text = "Nº da turma:";
            // 
            // btn_reiniciarLista
            // 
            btn_reiniciarLista.BackColor = Color.Wheat;
            btn_reiniciarLista.Cursor = Cursors.Hand;
            btn_reiniciarLista.FlatAppearance.BorderSize = 0;
            btn_reiniciarLista.FlatStyle = FlatStyle.Flat;
            btn_reiniciarLista.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_reiniciarLista.Image = Properties.Resources.list_restart;
            btn_reiniciarLista.Location = new Point(16, 57);
            btn_reiniciarLista.Margin = new Padding(16, 16, 16, 8);
            btn_reiniciarLista.Name = "btn_reiniciarLista";
            btn_reiniciarLista.Size = new Size(32, 32);
            btn_reiniciarLista.TabIndex = 7;
            btn_reiniciarLista.UseVisualStyleBackColor = false;
            btn_reiniciarLista.Click += btn_reiniciarLista_Click;
            // 
            // ControleSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btn_reiniciarLista);
            Controls.Add(lbl_nSala);
            Controls.Add(cbx_pesquisa);
            Controls.Add(btn_pesquisa);
            Controls.Add(btn_editar);
            Controls.Add(btn_remover);
            Controls.Add(btn_adicionar);
            Controls.Add(dgv_lista);
            Controls.Add(lbl_nomeTela);
            Name = "ControleSalas";
            Size = new Size(600, 360);
            ((System.ComponentModel.ISupportInitialize)dgv_lista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nomeTela;
        private DataGridView dgv_lista;
        private Button btn_adicionar;
        private Button btn_remover;
        private Button btn_editar;
        private Button btn_pesquisa;
        private ComboBox cbx_pesquisa;
        private Label lbl_nSala;
        private Button btn_reiniciarLista;
    }
}
