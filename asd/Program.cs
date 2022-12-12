using System;

namespace ProductRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = new List<Produto>();

            while (true)
            {
                Console.WriteLine("1. Registrar produto");
                Console.WriteLine("2. Listar produto");
                Console.WriteLine("3. Sair");
                Console.Write("Enter your choice: ");

                int opcao = Convert.ToInt16(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Id do produto: ");
                    var id = Convert.ToInt16(Console.ReadLine());

                    Console.Write("Nome: ");
                    var name = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    var quantidade = Convert.ToInt16(Console.ReadLine());

                    var adicionaProduto = new Produto() { Id = id, Nome = name, Quantidade = quantidade };
                    produtos.Add(adicionaProduto);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("List of products:");
                    foreach (var produto in produtos)
                    {
                        Console.WriteLine($"{produto.Id} - {produto.Nome} - {produto.Quantidade}");
                    }
                }
                else if (opcao == 3)
                {
                    break;
                }
            }
        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
}
