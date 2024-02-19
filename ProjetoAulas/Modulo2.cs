
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
}