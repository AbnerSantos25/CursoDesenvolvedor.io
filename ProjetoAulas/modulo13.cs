namespace Modulo13;

public class TrabalhandoComArquivos
{

    public void AulaCriandoArquivo()
    {
        var escrever = new StreamWriter("Cadastro.txt", true);
        Console.WriteLine("Digite o nome do produto: ");
        var nome = Console.ReadLine();
        escrever.WriteLine("Id...: " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome.: " + nome);
        escrever.WriteLine("----------------------------------");
        escrever.Close();
    }

    public void AulaLendoAequivo()
    {
        /*---------- lendo todo o arquivo------------------
        var conteudo = File.ReadAllText("Cadastro.txt");
        Console.WriteLine(conteudo);
        -------------------------------------------------*/

        //lendo linha por linha
        var ler = new StreamReader("Cadastro.txt");
        while (!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
        }
        ler.Close();
    }

    public void AulaExcluindoArquivo()
    {
        if (File.Exists("Cadastro.txt"))
        {
            File.Delete("Cadastro.txt");
        }
    }
}