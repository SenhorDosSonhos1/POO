public class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    public double Valor { get; set; }

    public Produto(string nome, string marca, double valor)
    {
        this.Nome = nome;
        this.Marca = marca;
        this.Valor = valor;
    }
    protected void Informacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Valor: {Valor}");
    }
}