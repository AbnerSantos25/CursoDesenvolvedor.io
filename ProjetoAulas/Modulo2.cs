
namespace Cadastro
{
    public class Produto
    {
        private  int Id;
        public string Descricao {get; set;}

        public void ImprimirInformacao()
        {
            Console.WriteLine(GetID() + " - " + Descricao);
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
}