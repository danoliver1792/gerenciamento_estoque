using System;
using System.Collections.Generic;

namespace GerenciamentoEstoque
{
    class Program
    {
        // criando uma lista para armazenar os produtos em estoque
        static List<Produto> estoque = new List<Produto>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Sistema de Gerenciamento de Estoque");
                Console.WriteLine("1. Adicionar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;
                    case 3:
                        Console.WriteLine("Saindo do Programa...");
                        return;
                    default:
                        Console.WriteLine("Opcao invalida. Tente novamente");
                        break;
                }
            }
        }

        static void AdicionarProduto()
        {
            Console.WriteLine("Nome do Produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // criando um objeto Produto e adicionando à lista de estoque
            Produto produto = new Produto(nome, quantidade);
            estoque.Add(produto);

            Console.WriteLine("Produto Adicionado com Sucesso");
        }

        static void ListarProdutos()
        {
            Console.WriteLine("Lista de Produtos no Estoque:");
            // iterando pela lista de produtos e imprimindo as informações
            foreach (var produto in estoque)
            {
                Console.WriteLine($"{produto.Nome} - Quantidade: {produto.Quantidade}");
            }
        }
    }

    class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }
    }
}
