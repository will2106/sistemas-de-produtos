using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema_de_produtos;

namespace Projeto___Sistema_de_Produtos
{
    class GerenciadorProdutos
    {
        private List<Produto> produtos = new List<Produto>();

        public void cadastrarProduto()
        {
            Console.Write("\nDigite o nome do produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine());

            Console.Write("O produto está em promoção? (S/N) ");
            bool promocao = (Console.ReadLine().ToUpper() == "S");

            Produto produto = new Produto(nome, preco, promocao);
            produtos.Add(produto);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nProduto cadastrado com sucesso!");
            Console.ResetColor();
        }

        public void ListarProdutos()
        {
            Console.WriteLine("\nProdutos cadastrados:");

            foreach (Produto produto in produtos)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n{0} - R${1} - {2}", produto.Nome, produto.Preco.ToString("F2"), produto.Promocao ? "Em promoção" : "Não está em promoção\n");
                Console.ResetColor();
            }
        }

        public void mostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("0 - Sair");
            Console.ResetColor();
        }
    }
}