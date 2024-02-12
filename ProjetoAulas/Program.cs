using System;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //AulaClasses();

        }

        private static void AulaHeranca()
        {
            var pessoaFisica = new Cadastro.pessoaFisica();
            pessoaFisica.id = 1;
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