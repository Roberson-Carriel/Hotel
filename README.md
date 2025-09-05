# 🏨 Sistema de Reservas de Hotel

![.NET](https://img.shields.io/badge/.NET-6-blue?logo=dotnet)  
![C#](https://img.shields.io/badge/C%23-7.0-blue?logo=c-sharp)  

## Descrição
Este projeto é um **Construindo um Sistema de Hospedagem de um Hotel no C#**, criado como desafio da **Deal Group - AI Centric .NET**.

O sistema permite:  
- Cadastrar hóspedes (`Pessoa`)  
- Escolher suítes (`Suite`)  
- Realizar reservas (`Reserva`) com cálculo automático da diária  
- Aplicar **desconto de 10%** para reservas com **10 dias ou mais**  
- Validar capacidade da suíte e quantidade de hóspedes  
- Exibir resumo completo da reserva  

---

## Funcionalidades
- Interação com o usuário via console  
- Escolha de suíte entre opções pré-definidas (Simples, Luxo, Master)  
- Cadastro de hóspedes com nome e idade  
- Validação de entrada segura (números válidos)  
- Cálculo de valor total da reserva com desconto automático  
- Resumo detalhado da reserva  

---

## Estrutura do Projeto
- `Pessoa.cs` → representa cada hóspede do hotel  
- `Suite.cs` → representa a suíte com tipo, capacidade e valor da diária  
- `Reserva.cs` → gerencia a reserva, validações e cálculo do valor total  
- `Program.cs` → arquivo principal com interação do usuário  

---

## Como Executar

### Pré-requisitos
- **.NET SDK** instalado ([Baixar .NET](https://dotnet.microsoft.com/download))  
- **Visual Studio** ou **Visual Studio Code**

### 1. Clonar o repositório
- Abra o terminal e digite:  
  `git clone https://github.com/Roberson-Carriel/Hotel.git`  
  `cd Hotel`

### 2. Executar no Visual Studio
1. Abra **Visual Studio**  
2. Clique em **Arquivo → Abrir → Projeto/Solução**  
3. Selecione o arquivo `.csproj` do projeto  
4. Execute o projeto:  
   - **F5** → Executar com depuração  
   - **Ctrl+F5** → Executar sem depuração  

### 3. Executar no Visual Studio Code
1. Abra **Visual Studio Code**  
2. Abra a pasta do projeto: **File → Open Folder**  
3. Abra o terminal integrado: **Ctrl + `** ou **View → Terminal**  
4. Compile o projeto digitando: `dotnet build`  
5. Execute o projeto digitando: `dotnet run`  

---

## Interação com o Usuário
No console, siga as instruções:  
1. Escolha a suíte disponível (Simples, Luxo ou Master) digitando o número correspondente  
2. Digite a **quantidade de dias da reserva** (mínimo 2 dias)  
3. Informe a **quantidade de hóspedes** e os dados de cada hóspede (nome e idade)  
4. Confira o **resumo da reserva** exibido no console  

### Exemplo de interação

=== Sistema de Reservas ===  

Suítes disponíveis:  
1 - Simples (Capacidade: 1, Valor diária: R$ 200)  
2 - Luxo (Capacidade: 2, Valor diária: R$ 500)  
3 - Master (Capacidade: 4, Valor diária: R$ 1000)  

Escolha o tipo da suíte (digite o número): 2  
Digite a quantidade de dias da reserva (mínimo 2 dias): 12  
Digite a quantidade de hóspedes (máx 2): 2  
Nome do hóspede 1: José  
Idade do hóspede 1: 30  
Nome do hóspede 2: João  
Idade do hóspede 2: 28  

=== Resumo da Reserva ===  
Suíte: Luxo  
Dias reservados: 12  
Quantidade de hóspedes: 2  
Valor total: R$ 5400,00  
Hóspedes:  
- José, 30 anos  
- João, 28 anos  
========================  

---

## Regras do Sistema
- A quantidade de hóspedes **não pode ultrapassar a capacidade da suíte**  
- Reservas de **10 dias ou mais** aplicam **desconto de 10%**  
- A quantidade mínima de dias da reserva é **2 dias**  
- Todas as entradas numéricas são validadas  

---

## Comparação: Desafio Original vs Melhorias

| Item                        | Desafio Original                        | Melhorias Implementadas                                        |
|------------------------------|----------------------------------------|----------------------------------------------------------------|
| Interação com usuário        | Não existia                             | Usuário digita nome, idade, suíte e dias                       |
| Validação de entradas        | Apenas capacidade da suíte             | Validação completa de números, capacidade, dias e idade        |
| Resumo da reserva            | Simples ou inexistente                  | Resumo detalhado com hóspedes e valor total                    |
| Cálculo do desconto          | Apenas para ≥10 dias                    | Mantido, integrado ao resumo                                   |
| Segurança contra erros       | Nenhuma (`FormatException` possível)   | Uso de `int.TryParse`, loops de validação                      |
| Modularidade do código       | Básica                                  | Construtores e métodos separados, fácil de manter             |
| Extensibilidade              | Limitada                                | Fácil adicionar novas suítes, propriedades ou regras          |

---

## Tecnologias
- C#  
- .NET 6/7  
- Console Application  
