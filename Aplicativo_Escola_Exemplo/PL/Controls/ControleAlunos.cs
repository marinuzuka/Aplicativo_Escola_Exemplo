using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicativo_Escola_Exemplo.DALs;
using Aplicativo_Escola_Exemplo.PL.Forms;

namespace Aplicativo_Escola_Exemplo.PL.Controls
{
    public partial class ControleAlunos : UserControl
    {
        public ControleAlunos()
        {
            InitializeComponent();

            // Arredondar botões:
            Utils.Rounded.setRoundedController(btn_adicionar, 16);
            Utils.Rounded.setRoundedController(btn_pesquisa, 16);
            Utils.Rounded.setRoundedController(btn_remover, 16);
            Utils.Rounded.setRoundedController(btn_editar, 16);
            Utils.Rounded.setRoundedController(dgv_lista, 16);

            // Preencher Tabela:
            dgv_lista.DataSource = AlunosDAL.ListarAlunos();

            //
            txt_pesquisa.Focus();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            dgv_lista.DataSource = AlunosDAL.PesquisarAluno(txt_pesquisa.Text);
            txt_pesquisa.Focus();

        }

        private void txt_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            //Se apertou o enter
            if (e.KeyCode == Keys.Enter)
            {
                //Ação após apertar enter
                this.btn_pesquisa_Click(this, new EventArgs());

                //Avisa ao sistema que o evento foi tratado e evita o barulho
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            FormAlunos formAlunos = new();
            formAlunos.ShowDialog();
        }
    }
}
