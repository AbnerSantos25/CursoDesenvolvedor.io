using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //AulaClasses();
            //AulaHeranca();
            AulaRecord();
            //aulaClasseAbstrata();
        }

        private static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso{ Id = 1, Descricao = "Curso 1"};
            // var curso2 = new Cadastro.Curso{ Id = 1, Descricao = "Curso 1"};

            var curso1 = new Cadstro.Cursos(1, "Curso 1");
            var curso2 = new Cadstro.Cursos(1, "Curso 1");

            //Console.WriteLine(curso1.Equals(curso2));
            Console.WriteLine(curso1 == curso2);

            var curso3 = curso1 with {Descricao = "Curso 3"};

        }

        private static void aulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Rex";
            cachorro.ImprimirDados();
        }

        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.id= 1;
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Cidade teste";
            pessoaFisica.Cep = "2233131";
            pessoaFisica.CPF = "32412131";

            var funcionario = new Cadastro.funcionario();
            funcionario.id= 10;
            funcionario.Endereco = "Endereco Teste";
            funcionario.Cidade = "Cidade teste";
            funcionario.Cep = "2233131";
            funcionario.CPF = "32412131";

            funcionario.ImprimirDados();
            funcionario.ImprimirCPF();
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2,3);
            Console.WriteLine(resultado);

            var produto = new Cadastro.Produto();
            produto.Descricao = "teclado";

            produto.SetId(1);
            produto.ImprimirDescricao();
        }

    }
}

