//Classe: classe é um molde para criar objetos.
// De uma classe podemos criar várias abstração particularidades dele.
// Ex: classe carro e pessoa. Cada pessoa tem suas individualidades.


//Atributos: São caracteristicas contidas nas classes.

//Métodos: São funções/Ações que um objeto pode executar.

//Objeto: São criados a partir das classes(moldes).

//Encapsulamento: É um dos pilares da Poo, atravês dele é possivel trabalhar com a visibilidade de atributos e métodos.
//Caracteristicas: Ocultar informações; Segurança; Facilidade de manutenção;
    //Modificadores de acesso: 
        // public: atributos e métodos visiveis para qualquer classe
        // private: atributos e metodos visiveis apenas na classe onde são criados.
        // protected: atributos e métodos disponiveis na classe onde são criados ou herdados.

//classe
class Pessoa
{
    //Atributos
    public string? Nome; //{ get; set; }
    public int Idade;

    //mÉTODOS

    public void apresentacao()
    {
        Console.WriteLine($"Olá meu nome é {Nome} e  tenho {Idade} anos");
    }
    public void tossi()
    {
        Console.WriteLine("ATCHIMMMM!!!");
    }

    public string VerificarIdade()
    {
        return Idade > 18 ? "Maior de idade" : "Menor de idade";
    }
}

// Objetos