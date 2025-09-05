using System;
using System.Collections.Generic;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>(); // Lista de hóspedes
    public Suite Suite { get; set; }   // Suíte escolhida
    public int DiasReservados { get; set; } // Número de dias da reserva

    // Construtor que já recebe suíte e dias
    public Reserva(Suite suite, int diasReservados)
    {
        Suite = suite;
        DiasReservados = diasReservados;
    }

    // Valida e cadastra os hóspedes
    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (hospedes.Count > Suite.Capacidade)
            throw new ArgumentException("A suíte não comporta essa quantidade de hóspedes.");

        Hospedes = hospedes;
    }

    // Retorna a quantidade de hóspedes
    public int ObterQuantidadeHospedes() => Hospedes.Count;

    // Calcula valor total da reserva com desconto se ≥ 10 dias
    public decimal CalcularValorDiaria()
    {
        decimal valorTotal = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
            valorTotal *= 0.9m; // desconto de 10%

        return valorTotal;
    }

    // Exibe resumo da reserva
    public void ExibirResumoReserva()
    {
        Console.WriteLine("\n=== Resumo da Reserva ===");
        Console.WriteLine($"Suíte: {Suite.TipoSuite}");
        Console.WriteLine($"Dias reservados: {DiasReservados}");
        Console.WriteLine($"Quantidade de hóspedes: {ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total: R$ {CalcularValorDiaria():0.00}");
        Console.WriteLine("Hóspedes:");
        foreach (var hospede in Hospedes)
            Console.WriteLine($"- {hospede.Nome}, {hospede.Idade} anos");
        Console.WriteLine("========================\n");
    }
}