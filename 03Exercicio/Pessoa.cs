class Pessoa
{
    private string _nome;
    private int _idade;
    private string _cidade;


    public Pessoa(string nome, int idade, string cidade)
    {
        _nome = nome;
        _idade = idade;
        _cidade = cidade;

        Mensagem();
    }


    private void Mensagem()
    {
        Console.WriteLine($"Olá {this._nome} você tem {this._idade} e mora em {this._cidade}");
    }
}