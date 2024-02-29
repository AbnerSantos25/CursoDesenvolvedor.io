
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
            Console.WriteLine("Dados da Pessoa Fisica:");
            //Aqui vamos chamar o metodo Heranca
            HerancaFisica();

            Console.WriteLine("=======================================================================");
            //Aqui vamos chamar o metodo HerancaFuncionario
            Console.WriteLine("Dados do Funcionario:");
            HerancaFuncionario();

            Console.WriteLine("=======================================================================");
            ClasseAbstractAnimal();

            Console.WriteLine("=======================================================================");
            AulaRecordCurso();

            Console.WriteLine("=======================================================================");
            AulaInterfaceProduto();

            Console.WriteLine("=======================================================================");
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

        //Criando um metodo para a aula de Record
        private static void AulaRecordCurso()
        {
            var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            var curso3 = new Cadastro.Curso(); // demostração onde não usamos o Record
            var curso4 = new Cadastro.Curso(); // demostração onde usaremos o Record
            //Console.WriteLine(curso1.Equals(curso2));//jeito certo de comparar
            Console.WriteLine(curso1 == curso2);//jeito errado de comparar

            curso3 = curso1;
            curso3.Id = 2; /*Aqui estamos mudando o valor do id do curso3, mas o curso1 tambem vai mudar,
            porque curso3 é uma referencia(ponteiro) para curso1*/

            curso3 = curso3 with { Id = 3 }; //Aqui estamos mudando apenas o valor do id do curso3, mas o curso1 não vai mudar
        }

        //Criando um metodo para a aula de Interface
        private static void AulaInterfaceProduto()
        {
            var Computador = new Cadastro.Computador();
            Computador.Nome = "Dell";
            Computador.Impirmir();
        }
    }
}
