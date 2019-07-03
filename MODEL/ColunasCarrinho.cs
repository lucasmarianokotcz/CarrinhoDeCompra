using System.Collections.Generic;

namespace MODEL
{
    public class ColunasCarrinho
    {
        public List<string> ColunasDoCarrinho { get; set; }

        public ColunasCarrinho()
        {
            ColunasDoCarrinho = new List<string>()
            {
                "Produto",
                "Valor unitário",
                "Quantidade",
                "Subtotal",
            };
        }
    }
}
