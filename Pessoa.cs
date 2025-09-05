public class Pessoa
{
    public string Nome { get; set; }  // Nome do hóspede
    public int Idade { get; set; }    // Idade do hóspede

    // Construtor da classe
    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}