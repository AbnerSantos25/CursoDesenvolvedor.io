// using System;

// namespace  Application
// {
//     public class Program{
//         public static void Main(string[] args)
//         {
//             AulaInterface();
//         }

//         private static AulaInterface(){
//             var NotificacaoCliente = new Cadastro.NotificacaoCliente();
//             NotificacaoCliente.Notificar();
//         }
//     }
// }


// namespace Cadastro
// {
//     public interface INotificação
//     {
//         string Descricao {get ; set;}
//         void Notificar();
//     }

//     public class NotificacaoCliente : INotificação
//     {
//         public string Descricao { get; set; }

//         public void Notificar()
//         {
//             System.Console.WriteLine("Notificando cliente: " + Descricao);
//         }
//     }

//     public class NotificacaoFuncionario : INotificação
//     {
//         public string Descricao { get; set; }

//         public void Notificar()
//         {
//             System.Console.WriteLine("Notificando Funcionario: " + Descricao);
//         }
//     }
// }
