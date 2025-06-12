using System.Net.Http.Headers;

class Aluno
{
    public string Nome { get; set; }
    private double _nota1;
    private double _nota2;
    public Aluno(string nome, double nota1, double nota2)
    {
        Nome = nome;
        _nota1 = nota1;
        _nota2 = nota2;
    }

    private double Media()
    {
        double media = (_nota1 + _nota2) / 2;
        return media;
    }

    private string Situacao()
    {
        double mediaAluno = Media();
        return mediaAluno < 7 ? "Reprovado" : "Aprovado";
    }

    public void Mensagem()
    {
        double mediaAluno = Media();
        string situacao = Situacao();
        Console.WriteLine($"O aluno {Nome} tirou {mediaAluno:f2} e está {situacao} ");
    }
    
}