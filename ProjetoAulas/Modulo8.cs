//namespace Cadastro;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }

    public class Produto
    {
        private int Id;

        public string Descricao { get; set;}



        public void ImprimirDescricao()
        {
            System.Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id {get; set;}
        public string Endereco {get; set;}
        public string Cidade {get; set;}
        public string Cep {get; set;}

        public void ImprimirDados()
        {
            Console.write("Codigo: " + Id);
            Console.write("Codigo: " + Endereco);
            Console.write("Codigo: " + Cidade);
            Console.write("Codigo: " + Cep);
            
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;}

    }
}