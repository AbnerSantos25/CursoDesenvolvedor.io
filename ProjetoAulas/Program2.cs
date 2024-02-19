
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Cadastro.Produto();

            //Lendo o id do produto fornecido pelo usuario.
            Console.Write("Digite o id do produto: ");
            int id = int.Parse(Console.ReadLine());
            /*Aqui estamos setando o id do produto1 atraves do metodo SetId, 
            porque a variavel id é privada*/
            produto1.SetId(id);

            //Gravando a descrição do produto fornecida pelo usuario.
            Console.Write("Digite a Descrição do produto: ");
            produto1.Descricao = Console.ReadLine();

            Console.Clear();
            produto1.ImprimirInformacao();
        }
    }
}
