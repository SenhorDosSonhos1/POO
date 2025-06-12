class Conversor : Padrao
{
    public override void DolarReal(double valor)
    {
        Console.WriteLine($"R$: {valor * 5.60}");
    }

    public override void RealDolar(double valor)
    {
        Console.WriteLine($"US$: {valor / 5.60}");
    }
}