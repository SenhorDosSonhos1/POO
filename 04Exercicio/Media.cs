class Media
{
    public Media(double nota1, double nota2)
    {
        Console.WriteLine($"A media é {(nota1 + nota2) / 2:f1}");
    }

    public Media(double nota1, double nota2, double nota3)
    {
        Console.WriteLine($"A media é {(nota1 + nota2 + nota3) / 3:f1}");
    }
}
