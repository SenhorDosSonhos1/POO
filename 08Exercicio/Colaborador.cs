class Colaborador : IBonus, IDesconto
{
    public double ValeTransporte(double salarioBruto)
    {
        double desconto = salarioBruto * 0.06;
        return (int)desconto;
    }
    
    public void PremioFaltas(double faltas)
    {
        Console.WriteLine(faltas < 1 ? "Recebeu o bonus" : "Você não tem direito ao bonus");
    }
}