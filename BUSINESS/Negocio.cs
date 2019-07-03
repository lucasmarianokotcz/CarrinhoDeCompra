using MODEL;
using System;
using System.Windows.Forms;

namespace BUSINESS
{
    public class Negocio
    {
        public decimal ValorMinimoCarrinho { get; private set; } = 50m;
        public int QuantidadeMaximaItensPorProduto { get; private set; } = 10;

        // Calcula o total do carrinho varrendo a coluna do SubTotal.
        public string CalculaTotal(DataGridView dgvCarrinho, Carrinho carrinho)
        {
            for (int i = 0; i < dgvCarrinho.Rows.Count; i++)
            {
                carrinho.Total += Convert.ToDecimal(dgvCarrinho.Rows[i].Cells[3].Value);
            }
            return carrinho.Total.ToString();            
        }
    }
}
