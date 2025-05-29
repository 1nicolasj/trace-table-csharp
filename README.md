# Testes de Mesa e Calculadora de Investimentos em C# 

## Sobre os Projetos

O primeiro programa testa operações em vetores e o segundo calcula valor futuro e rendimentos de investimentos. A lógica dos cálculos foi pensada e validada inicialmente com **testes de mesa em planilhas, por iteração**, e depois implementada aqui.


O código da calculadora de investimentos (TraceTable2) é organizado em:
* `Program.cs`: Função principal.
* `CalculadoraFutureValue.cs`: Tem todas as funções de cálculo (valor futuro, taxas, tabelas diárias e etc).
* `Problem.cs`: Cada arquivo `Problem` resolve um exercício específico das tabelas, usando a `CalculadoraFutureValue`.

## Exercícios Principais

* **Exercícios 1-5:** Abordam diferentes cálculos básicos de investimento e tabelas de rendimento.
* **Exercício 6:** Permite calcular o valor futuro para um período informado em "X meses e Y dias" (a partir de hoje) e mostra uma tabela diária detalhada do rendimento.
* **Exercício 7:** Similar ao 6, mas simula um resgate no 5º mês (ou dia correspondente) e mostra na tabela diária.
* **Exercício 8:** Permite ao usuário definir o valor e o dia exato de um resgate, exibindo a tabela diária com essa alteração.

### Links para as tabelas de base:

* https://docs.google.com/spreadsheets/d/1-LmdewpXF8wEMDAUxoNM6msACa3KX5JdTX3UZoGtCXY/edit?usp=sharing
* https://docs.google.com/spreadsheets/d/1q9dRm4QjwmqQ9S-pWXrurnoP9xAfpJ9oWtUVBvaop98/edit?usp=sharing
* https://docs.google.com/spreadsheets/d/1I9GTsoy70SWFxChdA4LXiJ0AMM9qo69S0XGK9afAReI/edit?usp=sharing
