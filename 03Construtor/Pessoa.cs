class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Hello, World!");
    }

    //2 construtor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá, {nome}");
    }

    //3 construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Olá, {nome} voce tem {idade}");
    }
}