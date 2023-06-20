using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string> { };

            Console.WriteLine("Bem-Vindo ao BK Store");

            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar ou 2 para listar");
                string resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto: ");
                    string produto = Console.ReadLine();
                    produtos.Add(produto);
                    
                    if (produto.Contains(produto ))
                    {
                        Console.WriteLine("Este item já existe na Lista");
                    }

                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado");

                    }

                }

                else
                {
                    string texto = "";
                    int contador = 0;
                    while (contador < produtos.Count )
                    {
                        texto = produtos[contador] + ", ";
                        contador++;
                    }

                    Console.WriteLine(texto);
                    
                }


            }





        }
    }
}
