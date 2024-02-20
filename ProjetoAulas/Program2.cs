
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseSelada();
            Console.WriteLine("=======================================================================");
            // Console.WriteLine("Cadastro de Produtos, Digite o nome do Produto: ");
            // var NomeProduto = Console.ReadLine();
            // var produto = new Cadastro.Produto();
            // produto.Nome = NomeProduto;
 
            //Lendo o id do produto fornecido pelo usuario.
            // Console.Write("Digite o id do produto: ");
            // int id = int.Parse(Console.ReadLine());
            /*Aqui estamos setando o id do produto1 atraves do metodo SetId, 
            porque a variavel id é privada*/
            // produto.SetId(id);

            //Gravando a descrição do produto fornecida pelo usuario.
            // Console.Write("Digite a Descrição do produto: ");
            // produto.Descricao = Console.ReadLine();

            // Console.Clear();
            // produto.ImprimirInformacao();
            // QuantidadeEmEstoque();
            Console.WriteLine("=======================================================================");
            //Aqui vamos chamar o metodo Heranca
            Console.WriteLine("=======================================================================");
            Console.WriteLine("Dados da Pessoa Fisica:");  
            HerancaFisica();
            Console.WriteLine("=======================================================================");
            //Aqui vamos chamar o metodo HerancaFuncionario
            Console.WriteLine("Dados do Funcionario:");
            HerancaFuncionario();
            Console.WriteLine("=======================================================================");
            ClasseAbstractAnimal();
        }

        //Vamos criar o mentodo Privado sobre a aula Herança
        private static void HerancaFisica()
        {
            var PessoaFisica = new Cadastro.PessoaFisica();
            PessoaFisica.Id = 1;
            PessoaFisica.Nome = "João";
            PessoaFisica.CPF = "12345612";
            PessoaFisica.ImprimirDados();
            PessoaFisica.ImprimirCpf();
        }

        private static void HerancaFuncionario()
        {
            //Criando objeto da classe Funcionario e atribuindo valores
            var Funcionario = new Cadastro.Funcionario();
            Funcionario.Id = 2;
            Funcionario.Nome = "Pedro";
            Funcionario.CPF = "42224612";
            Funcionario.Matricula = "1020";
            //funções de impressão
            Funcionario.ImprimirDados();
            Funcionario.ImprimirCpf();
            Funcionario.ImprimirMatricula();
            
        }   

        //Criando um metodo para a classe selada Configuracao 
        private static void ClasseSelada()
        {
            //Ha dois metodos para atribuir valores a variavel Host
            //Primeira forma
                // --> var configuracao = new Cadastro.Configuracao();
                // --> configuracao.Host = "localhost";
            //Segunda forma
                var configuracao2 = new Cadastro.Configuracao()
                {
                    Host = "localhost"
                };

            Console.WriteLine("Host: " + configuracao2.Host);
        }

        //Criando um metodo para a classe abstract Animal.
        private static void ClasseAbstractAnimal()
        {   
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Rex";
            cachorro.ImprimirDados();
        }
    }
}
