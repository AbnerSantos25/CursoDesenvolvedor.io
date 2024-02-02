
// Console.WriteLine("teste");
// const string constante = "Constante 1";
// Console.WriteLine(constante);

// int numero1 = 1;
// Console.WriteLine(numero1);

// double numero2 = 2;
// Console.WriteLine(numero2);

// float numero3 = 3;
// Console.WriteLine(numero3);

// decimal numero4 = 4;
// Console.WriteLine(numero4);

// bool VF = true;
// Console.WriteLine(VF);

var nome = NomeCompleto();
EscreverNome();

void EscreverNome()
{
    var nome = NomeCompleto();

    Console.WriteLine(nome);
}

string NomeCompleto()
{
    string primeiroNome = "Rafael";
    string segundoNome = "Almeida";
    return primeiroNome + " " + segundoNome;
}




