//namespace Cadastro;

// namespace Cadastro
// {
//     public static class Calculos
//     {
//         public static int SomarNumeros(int a, int b)
//         {
//             return a + b;
//         }
//     }

//     public class Produto
//     {
//         private int Id;

//         public string Descricao { get; set;}

//         public void ImprimirDescricao()
//         {
//             System.Console.WriteLine(GetId() + " - " + Descricao);
//         }

//         public void SetId(int id)
//         {
//             Id = id;
//         }

//         public int GetId()
//         {
//             return Id;
//         }
//     }


//     public class Pessoa
//     {
//         public int id {get; set;}
//         public string Endereco {get; set;}
//         public string Cidade {get; set;}
//         public string Cep {get; set;}

//         public void ImprimirDados()
//         {
//             Console.WriteLine("Codigo: " + id);
//             Console.WriteLine("Codigo: " + Endereco);
//             Console.WriteLine("Codigo: " + Cidade);
//             Console.WriteLine("Codigo: " + Cep);
//         }
//     }

//     public class PessoaFisica : Pessoa
//     {
//         public string CPF {get; set;}
//         public void ImprimirCPF()
//         {
//             Console.WriteLine("CPF: " + CPF);
//         }
//     }

//     public class funcionario : PessoaFisica
//     {
//         public string Matricula {get; set;}
//     }

//     public abstract class Animal
//     {
//         public string Nome {get; set;}
        
//         public abstract string GetInformacoes();

//         public void ImprimirDados()
//         {
//             Console.WriteLine("Nome animal:" + Nome);
//             Console.WriteLine("Informacoes:" + GetInformacoes());
//         }
//     }

//     public class Cachorro : Animal
//     {
//         public override string GetInformacoes()
//         {
//             return "Cachorro é um bom amigo do homem";
//         }
//     }

//     public record Curso(int Id, string Descricao);
//     public class cursoTeste{
        
//         public int Id { get; set; }
//         public string Descricao { get; set; }
//     }
        


        // public int Id { get; set; }
        // public string Descricao { get; set; }

        // public override bool Equals(object obj)
        // {
        //     if (obj is null) return false;

        //     if (obj is Curso curso)
        //     {
        //         return Id == curso.Id && Descricao == curso.Descricao;
        //     }
        //     return base.Equals(obj);
        // }
    

//}