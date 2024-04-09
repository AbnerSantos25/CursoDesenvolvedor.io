using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.WriteLine("Favor digitar alguma informação");
        var linha  = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }
    public void ConverterParaLetrasMaiusculas()
    {
        Console.WriteLine("Favor digitar alguma informação");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.WriteLine("Favor digitar alguma informação");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(0, 10)); // Capturando os 10 primeiros caracteres, caso querira iniciar a partir de algum campo, mudar o primeiro parametro.
    }
    public void AulaRange() 
    {
        string nomeArquivo = "imagem.png";
        string extensao = nomeArquivo[^3..]; //captura os 3 ultimos caracteres
        string nome = nomeArquivo[..^4]; //captura todos os caracteres menos os 4 ultimos
        Console.WriteLine(nome);
        Console.WriteLine(extensao);
    }
    public void AulaContains()
    {
        var linha = "teste de contain com strings";
        if (linha.Contains("string"))//o contains verifica se a palavra existe na string
        {
            Console.WriteLine($"A palavra foi encontrada");
        }
        else 
        { 
            Console.WriteLine($"A palavra não foi encontrada");      
        }
    }
    public void AulaThim()
    {
        string teste = "**ABNER SANTOS**";
        Console.WriteLine("THIM: " + teste.Trim('*'));//Limpa todos caracteres indicado
        Console.WriteLine("TrimEnd: " + teste.TrimEnd('*'));//Limpa os caracteres no final
        Console.WriteLine("TrimStart: " + teste.TrimStart('*'));//Limpa os caracteres no inicio
        Console.WriteLine("THIM ESPAÇO EM BRANCO: " + teste.Trim());//Limpa os espaços em branco
    }
    public void AulaStartWitheEndswith()
    {
        string curso = "Curso de C#";
        Console.WriteLine(curso.StartsWith("Curso"));//Verifica se a string começa com a palavra Curso
        Console.WriteLine(curso.EndsWith("C#"));//Verifica se a string termina com a palavra C#
    }
    public void AulaReplace() // substitui uma palavra por outra dentro da string
    {
        string teste =  "Curso de C#";
        Console.WriteLine(teste);
        Console.WriteLine(teste.Replace("C#", "CSharp"));
    }
    public void AulaLength()
    {
        string teste = Console.ReadLine();
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);
    }
}
