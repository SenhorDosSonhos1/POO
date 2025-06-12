class Produto
{
    public string? Nome { get; set; }
    public double Valor { get; set; }
    public string? FormaPagamento { get; set; }

    public void Comprar()
    {
        double valorProduto = Valor >= 500 && FormaPagamento == "Á vista" ? Valor * 0.9 : Valor;

        Console.WriteLine($"O produto:  {Nome} será pago de maneira: {FormaPagamento} no valor de {valorProduto}");
    }
}