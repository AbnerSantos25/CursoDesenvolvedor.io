using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo12
{
    public class TrabalhandoComExcecoes
    {
        public void AulaTratandoException()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Informe um numero: ");
                    var numero = Console.ReadLine();
                    var resultado = 500 / int.Parse(numero);
                    Console.WriteLine("Resultado: " + resultado);
                }
                catch(DivideByZeroException exception)
                {
                    Console.WriteLine("Ocorreu um erro de divisão" + exception.Message);
                    Console.WriteLine("Stack: " + exception.StackTrace);
                }
                catch(Exception exception)
                {
                    Console.WriteLine("Ocorreu um erro, tente novamente" + exception.Message);
                    Console.WriteLine("Stack: " + exception.StackTrace);//Aqui estamos imprimindo a pilha de erro.
                }
            }
        }
    }
}
