
using System.Security.Cryptography.X509Certificates;

namespace Cadastro
{
    public class Produto
    {
        public string Nome { get; set; }
        private  int Id;
        public string Descricao {get; set;}
        public int Estoque{get;}

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirInformacao()
        {
            Console.WriteLine("Nome do Produto: " + Nome);
            Console.WriteLine(GetID() + " - " + Descricao);
            Console.WriteLine("Quantidade em estoque: " + Estoque);
        }


        //set e get//
        //Nesse SetId vamos receber um id e atribuir a variável id da classe Produto
        public void SetId(int id)
        {
            Id = id;
        }
        //Nesse GetID vamos retornar o valor da variavel id
        public int GetID()
        {
            return Id;
        }
    }


    //Aqui vamos trabalhar com Herança
    public class Pessoa
    {
        public int Id {get; set;}
        public string Nome {get; set;}

        public void ImprimirDados()
        {
            Console.WriteLine("Codigo: " + Id);
            Console.WriteLine("Nome: " + Nome);   
        }
    }
    //Esta classe esta herndando os atributos da classe Pessoa
    public class PessoaFisica : Pessoa
    {
        public string CPF {get; set;}

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + CPF);
        }
    }
    //Esta classe esta herndando os atributos da classe Pessoa
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ {get; set;}

        public void ImprimirCnpj()
        {
            Console.WriteLine("CNPJ: " + CNPJ);
        }
    }
    //Esta classe esta herndando os atributos da classe PessoaFisica e Pessoa fisica herda os atributos da classe Pessoa
    public class Funcionario : PessoaFisica
    {
        public string Matricula {get; set;}

        public void ImprimirMatricula()
        {
            Console.WriteLine("Matricula: " + Matricula);
        }
    }

    //Classes Seladas(Sealed - Essa tipo de classe não deixa outras classes herdar dela)
    public sealed class Configuracao
    {
        public string Host {get; set;}
    }

    //Classes Abstratas (não é possivel instanciar ela)
    public abstract class Animal
    {
        public string Nome {get; set;}

        public abstract string GetInformacoes();

        public void ImprimirDados()
        {
            Console.WriteLine("Nome do Animal: " + Nome);
            Console.WriteLine(GetInformacoes());
        }
    }

    public class Cachorro : Animal
    {
        public override string GetInformacoes()
        {
            return "Cachorro é um bom amigo";
        }
    }
    /*Aqui vamos trabalhar com Record, onde ele nos ajudas a algumas coisas, uma delas é não precisar
    dar um sobrescrever o metodo Equals, GetHashCode, ToString e o construtor. 
    Se não usarmos o record, o resultado falso entre uma comparação de dois objetos iguais.*/
    public record Curso
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
    }

    //interface, usada par aforçar a implementação de metodos nas classes que a implementam/ herdam;
    public interface IProduto
    {
        public String Nome { get; set; }
        public void Impirmir();

    }

    public class Computador : IProduto
    {
        //Como essa classe Herda a interface IProduto, ela é obrigada a implementar as propriedads e metodos da interface
        //Uma forma de organização de codigo e garantindo que ele sera chamado. Assim mantendo um padrão.
        public string Nome { get; set;}

        public void Impirmir()
        {
            Console.WriteLine("Este é um Computador");
        }
    }
    
}