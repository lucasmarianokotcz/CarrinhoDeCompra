*Passos para a criação do projeto CarrinhoDeCompra*

1. Abrir Visual Studio, novo projeto, Windows Forms.
2. Alterar nome do projeto para VIEW.
3. "Desenhar" a tela de carrinho de compras arrastando controles ao form.
4. Criar novo projeto chamado MODEL.
5. Adicionar classe Carrinho, para servir de base para manipular a quantidade de items de um produto, e somar o total. 
6. Adicionar classe ColunasCarrinho, para gerenciar as colunas que irão existir relacionadas às informações do carrinho (nome do produto, valor unitário, quantidade e subtotal).
7. Criar novo projeto chamado BUSINESS.
8. Adicionar classe Negocio, onde serão gerenciadas as regras de negócio do projeto (propriedades ValorMinimoCarrinho e QuantidadeMaximaItensPorProduto), inicializando-os.
9. Fazer a parte da View para poder testar a aplicação, adicionando produtos ao carrinho e modificando a quantidade de itens.
10. Método CalculaTotal() que calcula o total do carrinho passou para a classe Negocio, antes estava na VIEW.
11. Testar a aplicação, verificando se atende os requisitos do projeto.

--Observações--
Não foi criado todas as validações possíveis, como texto ao invés de números, por exemplo.
Para testar a quantidade de itens de um produto, é necessário CLICAR na célula desejada e alterar o valor ali. Exemplo: produto "Lápis", valor unitário "1,50", >quantidade< "1" => Click + digitar "2" e dar ENTER.