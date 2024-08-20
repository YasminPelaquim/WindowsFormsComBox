using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsComBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Adiciona itens manualmente no ComboBox
            cboLista.Items.Add(txtTexto.Text);
            // Exibe a quantidade de itens do ComboBox
            lblQtde.Text = cboLista.Items.Count.ToString();
            // Limpa a caixa de texto
            txtTexto.Clear();
            // Move o foco para caixa de texto
            txtTexto.Select();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ativa a propriedade para ordenar a lista no combo
            cboLista.Sorted = true;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            // verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex != -1)
            {
                // remove o item selecionado do combo
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                // exibe a quantidade de itens do ComboBox
                lblQtde.Text = cboLista.Items.Count.ToString();
                // limpa o texto da combo
                cboLista.ResetText();
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            // verifica se existe um item selecionado no combo
            if (cboLista.SelectedIndex !=  -1)
            {
                // exibe o conteúdo (texto do combo)
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                // exibe o indice (posição) do item no combo
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }
    }
}
