using Aplicativo_Escola_Exemplo.PL.Controls;

namespace Aplicativo_Escola_Exemplo
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();

            // Arredondar botões:
            Utils.Rounded.setRoundedController(btn_inicio, 16);
            Utils.Rounded.setRoundedController(btn_alunos, 16);
            Utils.Rounded.setRoundedController(btn_cursos, 16);
            Utils.Rounded.setRoundedController(btn_professores, 16);
            Utils.Rounded.setRoundedController(btn_turmas, 16);
            Utils.Rounded.setRoundedController(btn_certificados, 16);
            Utils.Rounded.setRoundedController(btn_sair, 16);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // Caixa de dialogo perguntando ao usuario se gostaria de sair da aplicação?
            // O resultado desse dialogo será armazenado na variavel escolha
            DialogResult escolha = MessageBox.Show(
                "Deseja realmente sair?",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            // SE escolha igual a SIM então saia da aplicação
            if (escolha == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btn_alunos_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Controls.Clear();

            // Chamando a tela - Alunos
            ControleAlunos instanciaControleAlunos = new();
            pnl_conteudo.Controls.Add(instanciaControleAlunos);
            instanciaControleAlunos.Dock = DockStyle.Fill;
        }

        private void btn_turmas_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Controls.Clear();

            // Chamando a tela - Salas/Turmas
            ControleSalas instanciaControleTurmas = new();
            pnl_conteudo.Controls.Add(instanciaControleTurmas);
            instanciaControleTurmas.Dock = DockStyle.Fill;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Controls.Clear();

            // Chamando a tela - Inicio
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Controls.Clear();

            // Chamando a tela - Cursos
        }

        private void btn_professores_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Controls.Clear();

            // Chamando a tela - Professores
        }

        private void btn_certificados_Click(object sender, EventArgs e)
        {
            pnl_conteudo.Controls.Clear();

            // Chamando a tela - Certificados
        }
    }
}
