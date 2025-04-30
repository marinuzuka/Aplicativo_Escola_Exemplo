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

namespace Aplicativo_Escola_Exemplo.PL.Controls
{
    public partial class ControleSalas : UserControl
    {
        public ControleSalas()
        {
            InitializeComponent();

            // Arredondar botões:
            Utils.Rounded.setRoundedController(btn_reiniciarLista, 16);
            Utils.Rounded.setRoundedController(btn_adicionar, 16);
            Utils.Rounded.setRoundedController(btn_pesquisa, 16);
            Utils.Rounded.setRoundedController(btn_remover, 16);
            Utils.Rounded.setRoundedController(btn_editar, 16);
            Utils.Rounded.setRoundedController(dgv_lista, 16);

            // Preencher Tabela:
            dgv_lista.DataSource = SalasDAL.ListarSalas();

            // Preencher ComboBoxes:
            cbx_pesquisa.DataSource = SalasDAL.ListarIDsDeSalas();
            cbx_pesquisa.DisplayMember = "ID";  // Valor mostrado
            cbx_pesquisa.ValueMember = "ID";    // Valor computado

            // Retornar foco ao controle de pesquisa
            cbx_pesquisa.Focus();
        }

        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            dgv_lista.DataSource = SalasDAL.PesquisarSala(Convert.ToInt32(cbx_pesquisa.Text));
            cbx_pesquisa.Focus();
        }

        private void btn_reiniciarLista_Click(object sender, EventArgs e)
        {
            // Preencher Tabela:
            dgv_lista.DataSource = SalasDAL.ListarSalas();
        }
    }
}
