using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //AulaClasses();
            AulaHeranca();
        }

        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.PessoaFisica();
            pessoaFisica.id= 1;
            pessoaFisica.Endereco = "Endereco Teste";
            pessoaFisica.Cidade = "Cidade teste";
            pessoaFisica.Cep = "2233131";

            pessoaFisica.ImprimirDados();
            pessoaFisica.ImprimirCPF();
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2,3);
            Console.WriteLine(resultado);

            // var produto = new Cadastro.Produto();
            // produto.Descricao = "teclado";

            // produto.SetId(1);
            // produto.ImprimirDescricao();
        }

    }
}