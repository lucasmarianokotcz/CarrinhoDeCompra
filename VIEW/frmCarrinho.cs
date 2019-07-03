using MODEL;
using BUSINESS;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarrinhoDeCompra
{
    public partial class frmCarrinho : Form
    {
        private Carrinho carrinho = new Carrinho();
        private ColunasCarrinho colunasCarrinho = new ColunasCarrinho();
        private Negocio negocio = new Negocio();
        private DataTable dtCarrinho = new DataTable();
        private int celulaAtual = 0;

        public frmCarrinho()
        {
            InitializeComponent();
        }

        private void frmCarrinho_Load(object sender, EventArgs e)
        {
            // Na inicialização do form, criar colunas para o DataTable.
            foreach (var item in colunasCarrinho.ColunasDoCarrinho)
            {
                dtCarrinho.Columns.Add(item);
            }
            dgvCarrinho.DataSource = dtCarrinho;
        }

        #region Métodos
        // Limpa o carrinho retornando ao estado inicial (tudo zerado).
        private void LimpaCarrinho()
        {
            foreach (Control item in panelDadosProduto.Controls)
            {
                item.ResetText();
            }
            dtCarrinho.Clear();
            lblTotalCarrinho.Text = "0,00";
        }
        #endregion

        private void btnAdicionarAoCarrinho_Click(object sender, EventArgs e)
        {
            // Insere uma nova linha com os dados digitados.
            DataRow dr = dtCarrinho.NewRow();
            dr[colunasCarrinho.ColunasDoCarrinho[0]] = txtProduto.Text;
            dr[colunasCarrinho.ColunasDoCarrinho[1]] = txtValorUnitario.Text;
            dr[colunasCarrinho.ColunasDoCarrinho[2]] = 1;
            dr[colunasCarrinho.ColunasDoCarrinho[3]] = dr[colunasCarrinho.ColunasDoCarrinho[1]];
            dtCarrinho.Rows.Add(dr);            
            lblTotalCarrinho.Text = negocio.CalculaTotal(dgvCarrinho, carrinho);
            carrinho.Total = 0;
        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            // Verifica se o total do carrinho está no valor correto estipulado.
            if (!(Convert.ToDecimal(lblTotalCarrinho.Text) < negocio.ValorMinimoCarrinho))
            {                
                MessageBox.Show("Pedido efetuado com sucesso!", "Pedido concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpaCarrinho();
            }
            else
            {
                MessageBox.Show("O valor mínimo do pedido é de R$ " + negocio.ValorMinimoCarrinho + ",00.", "Erro ao fechar pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparCarrinho_Click(object sender, EventArgs e)
        {
            LimpaCarrinho();
        }

        private void dgvCarrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pega o conteúdo da célula clicada.
            if (dgvCarrinho.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dgvCarrinho.CurrentCell != null && dgvCarrinho.CurrentCell.Value != null)
                {
                    celulaAtual = dgvCarrinho.CurrentCell.RowIndex;
                    carrinho.Quantidade = Convert.ToInt32(dgvCarrinho.CurrentCell.Value);
                }
            }
        }

        private void dgvCarrinho_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o total de itens de um produto é menor ou igual ao estipulado.
            if (Convert.ToInt32(dgvCarrinho[colunasCarrinho.ColunasDoCarrinho[2], celulaAtual].Value) <= negocio.QuantidadeMaximaItensPorProduto)
            {
                dgvCarrinho[colunasCarrinho.ColunasDoCarrinho[3], celulaAtual].Value = Convert.ToDecimal(dgvCarrinho[colunasCarrinho.ColunasDoCarrinho[1], celulaAtual].Value) * Convert.ToInt32(dgvCarrinho[colunasCarrinho.ColunasDoCarrinho[2], celulaAtual].Value);
                lblTotalCarrinho.Text = negocio.CalculaTotal(dgvCarrinho, carrinho);
                carrinho.Total = 0;
                carrinho.Quantidade = Convert.ToInt32(dgvCarrinho[colunasCarrinho.ColunasDoCarrinho[2], celulaAtual].Value);
            }
            else
            {
                dgvCarrinho[colunasCarrinho.ColunasDoCarrinho[2], celulaAtual].Value = carrinho.Quantidade;
                MessageBox.Show("A quantidade máxima de itens por produto é " + negocio.QuantidadeMaximaItensPorProduto + ".", "Erro ao alterar a quantidade do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
