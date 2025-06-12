// Exemplo 01

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Marcelo";
pessoa1.Idade = 22;

//pessoa1.apresentacao();
//pessoa1.tossi();
//string verificado = pessoa1.VerificarIdade();

//Console.WriteLine(verificado);

//exemplo 2

Pessoa pessoa2 = new();
pessoa2.Nome = "Juliana";
//pessoa2.apresentacao();

//Exemplo 3

Pessoa pessoa3 = new()
{
    Nome = "Rafael",
    Idade = 22
};

string retorno = pessoa3.VerificarIdade();
Console.WriteLine(retorno);