using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sistema de Reservas ===\n");

        // Definindo suítes disponíveis
        List<Suite> suitesDisponiveis = new List<Suite>
        {
            new Suite("Simples", 1, 200m),
            new Suite("Luxo", 2, 500m),
            new Suite("Master", 4, 1000m)
        };

        // Mostra suítes disponíveis
        Console.WriteLine("Suítes disponíveis:");
        for (int i = 0; i < suitesDisponiveis.Count; i++)
        {
            var s = suitesDisponiveis[i];
            Console.WriteLine($"{i + 1} - {s.TipoSuite} (Capacidade: {s.Capacidade}, Valor diária: R$ {s.ValorDiaria})");
        }

        // Escolha da suíte com validação
        int opcao;
        Console.Write("\nEscolha o tipo da suíte (digite o número): ");
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > suitesDisponiveis.Count)
        {
            Console.Write("Digite um número válido para a suíte: ");
        }
        Suite suiteEscolhida = suitesDisponiveis[opcao - 1];

        // Dias de reserva com validação
       int dias;
        Console.Write("Digite a quantidade de dias da reserva (mínimo 2 dias): ");
        while (!int.TryParse(Console.ReadLine(), out dias) || dias < 2)
        {
            Console.Write("Digite um número válido de dias (mínimo 2 dias): ");
        }


        Reserva reserva = new Reserva(suiteEscolhida, dias);

        // Quantidade de hóspedes com validação
        int qtdHospedes;
        Console.Write($"Digite a quantidade de hóspedes (máx {suiteEscolhida.Capacidade}): ");
        while (!int.TryParse(Console.ReadLine(), out qtdHospedes) || qtdHospedes < 1 || qtdHospedes > suiteEscolhida.Capacidade)
        {
            Console.Write($"Digite um número válido de hóspedes (máx {suiteEscolhida.Capacidade}): ");
        }

        List<Pessoa> hospedes = new List<Pessoa>();

        // Cadastro dos hóspedes com validação de idade
        for (int i = 1; i <= qtdHospedes; i++)
        {
            Console.Write($"Nome do hóspede {i}: ");
            string nome = Console.ReadLine();

            int idade;
            Console.Write($"Idade do hóspede {i}: ");
            while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
            {
                Console.Write("Digite uma idade válida: ");
            }

            hospedes.Add(new Pessoa(nome, idade));
        }

        // Tentativa de cadastrar hóspedes e exibir resumo
        try
        {
            reserva.CadastrarHospedes(hospedes);
            reserva.ExibirResumoReserva();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}