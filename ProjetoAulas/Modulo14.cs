using System;

namespace Modulo14
{
    internal class TrabalhandoComLinq
    {
        //aprendendo os conceitos do where para filtrar dados.
        public void AulaWhere()
        {
            string NomeCompleto = "Abner da silva santos";

            Func<char, bool> filtro = c => c == 'A'; // aqui ele vai filtrar as letras que são iguais a 'A'

            //var resultado = NomeCompleto.ToUpper().Where(filtro); // aqui ele vai filtrar as letras que são iguais a 'A' depois de dar um ToUpper(deixar tudo maiusculo)
            //var resultado = NomeCompleto.ToUpper().Where(p => p == 'A');

            //var resultado = from c in NomeCompleto.ToUpper() where c == 'E' select c; // Fazendo a mesma cosia que a de cima, porem usadno outro metodo

            //foreach (var letra in resultado)
            //{
            //    Console.WriteLine(letra);
            //}

            var numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var resultado = numeros.Where(p => p >= 10);
            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }

        }

        public void AulaOrdenacao()
        {
            //var numeros = new int[] { 22, 1, 6, 4, 5, 45, 21, 8, 9, 10 }; //criando um array de numeros
            var nomes = new string[] { "Abner", "João", "Pedro", "Maria", "Ana", "Carlos", "Lucas", "Ricardo", "Fernando", "Rafael" };//criando um array de nomes


            //usando o metodo OrderBy para ordenar os numeros em ordem crescente, e usando o metodo OrderByDescending para ordenar em ordem decrescente
            var resultado = nomes.OrderBy(p => p);
            //var resultado = numeros.OrderBy(p => p); 
            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }
        }

        public void AulaTake()
        {
            var numeros = new int[] { 22, 1, 6, 4, 5, 45, 21, 8, 9, 10 }; //criando um array de numeros

            var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p); //usando o metodo Take para pegar os 5 primeiros numeros
            //em seguida foi colocado o modo where para trazer apenas numeros acima de 10 e tambem o metodo OrderBy para ordenar os numeros em ordem crescente.

            foreach (var numero in resultado)
            {
                Console.WriteLine(numero);
            }
        }
        public void AulaCount()
        {
            var numeros = new int[] { 22, 1, 6, 4, 5, 45, 21, 8, 9, 10 }; //criando um array de numeros

            var resultado = numeros.Count(p => p >10); //usando o metodo Count para contar quantos numeros tem no array
            Console.WriteLine(resultado);
        }
        public void AulaFirstEFirstOrDefault()
        {
            var numeros = new int[] { 22, 1, 6, 4, 5, 45, 21, 8, 9, 10 }; //criando um array de numeros
            //var resultado = numeros.First(p => p > 15); //usando o metodo First para pegar o primeiro numero do array
            var resultado = numeros.FirstOrDefault(p => p > 100); //usando o metodo FirstOrDefault para pegar o primeiro numero do array, caso não tenha ele vai retornar 0

            Console.WriteLine(resultado);
        }
    }
}
