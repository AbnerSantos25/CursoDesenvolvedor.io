namespace Conversores
{
    public class Conversor
    {
        //Conversão com Parse, sem tratamentos.
        public void ConversorAndParse()
        {
            int numero = int.Parse("1");
            int numero2 = Convert.ToInt32("2"); // outra forma de fazer a converção, porem nao é mt usado pois não é seguro
            Console.WriteLine(numero);
        }


        //Aula de como utilizar o TryParse e tratar o erro.
        public void AulaTryParse()
        {
            var numero = "aaa";
            if (int.TryParse(numero, out int NumeroConvertido))
            {
                Console.WriteLine("Conversão realizada com sucesso");
            }
            else
            {
                Console.WriteLine("Conversão falhou"); //mensagem de erro
            }

            Console.WriteLine(NumeroConvertido);
        }
    }


}
