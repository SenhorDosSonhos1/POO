class Geladeira : Produto
{
    public double Capacidade { get; set; }

    public Geladeira(string nome, string marca, double valor, double capacidade) : base(nome, marca, valor)
    {
        this.Capacidade = capacidade;

        FichaTecnica();
    }

    private void FichaTecnica()
    {
        Informacoes();
        Console.WriteLine($"Capacidade: {this.Capacidade}");
    }
}