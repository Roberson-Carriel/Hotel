public class Suite
{
    public string TipoSuite { get; set; }   // Tipo da suíte (Simples, Luxo, Master)
    public int Capacidade { get; set; }     // Número máximo de hóspedes
    public decimal ValorDiaria { get; set; } // Valor da diária da suíte

    // Construtor da classe
    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}