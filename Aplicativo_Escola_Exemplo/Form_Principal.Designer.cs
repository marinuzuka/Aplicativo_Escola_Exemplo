namespace Aplicativo_Escola_Exemplo
{
    partial class Form_Principal
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
            pnl_menuLateral = new Panel();
            btn_sair = new Button();
            btn_certificados = new Button();
            btn_cursos = new Button();
            btn_turmas = new Button();
            btn_professores = new Button();
            btn_alunos = new Button();
            btn_inicio = new Button();
            lbl_logo = new Label();
            pnl_conteudo = new Panel();
            panel3 = new Panel();
            pnl_menuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_menuLateral
            // 
            pnl_menuLateral.BackColor = Color.FromArgb(0, 84, 149);
            pnl_menuLateral.Controls.Add(btn_sair);
            pnl_menuLateral.Controls.Add(btn_certificados);
            pnl_menuLateral.Controls.Add(btn_cursos);
            pnl_menuLateral.Controls.Add(btn_turmas);
            pnl_menuLateral.Controls.Add(btn_professores);
            pnl_menuLateral.Controls.Add(btn_alunos);
            pnl_menuLateral.Controls.Add(btn_inicio);
            pnl_menuLateral.Controls.Add(lbl_logo);
            pnl_menuLateral.Dock = DockStyle.Left;
            pnl_menuLateral.Location = new Point(0, 0);
            pnl_menuLateral.Margin = new Padding(0);
            pnl_menuLateral.Name = "pnl_menuLateral";
            pnl_menuLateral.Size = new Size(256, 541);
            pnl_menuLateral.TabIndex = 0;
            // 
            // btn_sair
            // 
            btn_sair.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_sair.BackColor = Color.White;
            btn_sair.Cursor = Cursors.Hand;
            btn_sair.FlatAppearance.BorderSize = 0;
            btn_sair.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_sair.FlatStyle = FlatStyle.Flat;
            btn_sair.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_sair.Location = new Point(16, 492);
            btn_sair.Margin = new Padding(16, 16, 16, 8);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(224, 32);
            btn_sair.TabIndex = 7;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // btn_certificados
            // 
            btn_certificados.BackColor = Color.White;
            btn_certificados.Cursor = Cursors.Hand;
            btn_certificados.FlatAppearance.BorderSize = 0;
            btn_certificados.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_certificados.FlatStyle = FlatStyle.Flat;
            btn_certificados.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_certificados.Location = new Point(16, 355);
            btn_certificados.Margin = new Padding(16, 16, 16, 8);
            btn_certificados.Name = "btn_certificados";
            btn_certificados.Size = new Size(224, 32);
            btn_certificados.TabIndex = 6;
            btn_certificados.Text = "Certificados";
            btn_certificados.UseVisualStyleBackColor = false;
            btn_certificados.Click += btn_certificados_Click;
            // 
            // btn_cursos
            // 
            btn_cursos.BackColor = Color.White;
            btn_cursos.Cursor = Cursors.Hand;
            btn_cursos.FlatAppearance.BorderSize = 0;
            btn_cursos.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_cursos.FlatStyle = FlatStyle.Flat;
            btn_cursos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_cursos.Location = new Point(16, 187);
            btn_cursos.Margin = new Padding(16, 16, 16, 8);
            btn_cursos.Name = "btn_cursos";
            btn_cursos.Size = new Size(224, 32);
            btn_cursos.TabIndex = 3;
            btn_cursos.Text = "Cursos";
            btn_cursos.UseVisualStyleBackColor = false;
            btn_cursos.Click += btn_cursos_Click;
            // 
            // btn_turmas
            // 
            btn_turmas.BackColor = Color.White;
            btn_turmas.Cursor = Cursors.Hand;
            btn_turmas.FlatAppearance.BorderSize = 0;
            btn_turmas.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_turmas.FlatStyle = FlatStyle.Flat;
            btn_turmas.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_turmas.Location = new Point(16, 299);
            btn_turmas.Margin = new Padding(16, 16, 16, 8);
            btn_turmas.Name = "btn_turmas";
            btn_turmas.Size = new Size(224, 32);
            btn_turmas.TabIndex = 5;
            btn_turmas.Text = "Turmas";
            btn_turmas.UseVisualStyleBackColor = false;
            btn_turmas.Click += btn_turmas_Click;
            // 
            // btn_professores
            // 
            btn_professores.BackColor = Color.White;
            btn_professores.Cursor = Cursors.Hand;
            btn_professores.FlatAppearance.BorderSize = 0;
            btn_professores.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_professores.FlatStyle = FlatStyle.Flat;
            btn_professores.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_professores.Location = new Point(16, 243);
            btn_professores.Margin = new Padding(16, 16, 16, 8);
            btn_professores.Name = "btn_professores";
            btn_professores.Size = new Size(224, 32);
            btn_professores.TabIndex = 4;
            btn_professores.Text = "Professores";
            btn_professores.UseVisualStyleBackColor = false;
            btn_professores.Click += btn_professores_Click;
            // 
            // btn_alunos
            // 
            btn_alunos.BackColor = Color.White;
            btn_alunos.Cursor = Cursors.Hand;
            btn_alunos.FlatAppearance.BorderSize = 0;
            btn_alunos.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_alunos.FlatStyle = FlatStyle.Flat;
            btn_alunos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_alunos.Location = new Point(16, 131);
            btn_alunos.Margin = new Padding(16, 16, 16, 8);
            btn_alunos.Name = "btn_alunos";
            btn_alunos.Size = new Size(224, 32);
            btn_alunos.TabIndex = 2;
            btn_alunos.Text = "Alunos";
            btn_alunos.UseVisualStyleBackColor = false;
            btn_alunos.Click += btn_alunos_Click;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.White;
            btn_inicio.Cursor = Cursors.Hand;
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(228, 142, 0);
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btn_inicio.Location = new Point(16, 75);
            btn_inicio.Margin = new Padding(16, 16, 16, 8);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(224, 32);
            btn_inicio.TabIndex = 1;
            btn_inicio.Text = "Início";
            btn_inicio.UseVisualStyleBackColor = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // lbl_logo
            // 
            lbl_logo.AutoSize = true;
            lbl_logo.BackColor = Color.Transparent;
            lbl_logo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbl_logo.ForeColor = Color.FromArgb(241, 241, 241);
            lbl_logo.Location = new Point(12, 19);
            lbl_logo.Name = "lbl_logo";
            lbl_logo.Size = new Size(129, 25);
            lbl_logo.TabIndex = 3;
            lbl_logo.Text = "Projeto Escola";
            // 
            // pnl_conteudo
            // 
            pnl_conteudo.BackgroundImage = Properties.Resources.bg_escola;
            pnl_conteudo.Dock = DockStyle.Fill;
            pnl_conteudo.Location = new Point(256, 36);
            pnl_conteudo.Margin = new Padding(0);
            pnl_conteudo.Name = "pnl_conteudo";
            pnl_conteudo.Size = new Size(688, 505);
            pnl_conteudo.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Wheat;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(256, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(688, 36);
            panel3.TabIndex = 3;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(944, 541);
            Controls.Add(pnl_conteudo);
            Controls.Add(panel3);
            Controls.Add(pnl_menuLateral);
            Font = new Font("Segoe UI Semibold", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ForeColor = Color.FromArgb(20, 20, 20);
            Margin = new Padding(4);
            MinimumSize = new Size(920, 560);
            Name = "Form_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicativo Escola - Exemplo";
            pnl_menuLateral.ResumeLayout(false);
            pnl_menuLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_menuLateral;
        private Panel pnl_conteudo;
        private Button btn_inicio;
        private Label lbl_logo;
        private Button btn_alunos;
        private Button btn_certificados;
        private Button btn_cursos;
        private Button btn_turmas;
        private Button btn_professores;
        private Button btn_sair;
        private Panel panel3;
    }
}
