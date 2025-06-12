class Smartphone : Produto
{
    public string OS { get; set; }

    public Smartphone(string nome, string marca, double valor, string os) : base(nome, marca, valor)
    {
        this.OS = os;

        FichaTecnica();
    }

    public void FichaTecnica()
    {
        Informacoes();
        Console.WriteLine($"Sistema Operacional: {this.OS}");
    }
}