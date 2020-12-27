![main](https://github.com/hd1fernando/Jabuticaba/workflows/.NET/badge.svg?branch=main)

# Jabuticaba
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/hd1fernando/Jabuticaba/blob/feature/cpf/LICENSE)

# Sobre o projeto

**Jabuticaba** é uma biblioteca que busca fornecer como tipo valores utilizados em aplicações que lidam com dados de usuários (ex: **CPF**, **CNPJ**, **RG**, ...).

Seu principal objeto é evitar que o desenvolvedor necessite recriar novos tipos para novos projetos além de ter foco em desempenho e baixa alocação de memória.

## Download e instalação
Use o gerenciador de pacotes **Nuget [jabuticaba](https://www.nuget.org/packages/jabuticaba/)** para realizar a instalação.

```powershell
Install-Package jabuticaba
```
```bash
dotnet add package jabuticaba 
```
Requerimento mínimo: **.Net 5.0**.

## Uso

```C#
Cnpj cnpj = "02.055.097/0001-65";
```

## Tipos já implementados
 * CPF
 * CNPJ
 
## Como contribuir

## Benchmark
``` bash
// * Legends *
BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
AMD Ryzen 5 3400G with Radeon Vega Graphics, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT

|   Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
| ObterCpf | 56.57 ns | 0.372 ns | 0.311 ns |  1.00 |     - |     - |     - |         - |

|    Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
| ObterCnpj | 76.67 ns | 0.633 ns | 0.561 ns |  1.00 |     - |     - |     - |         - |

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Ratio     : Mean of the ratio distribution ([Current]/[Baseline])
  Gen 0     : GC Generation 0 collects per 1000 operations
  Gen 1     : GC Generation 1 collects per 1000 operations
  Gen 2     : GC Generation 2 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)
```
## Detalhes do projeto
Esse projeto usa [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) para fluxo de trabalho com Git.

[Udacity Style Guide](https://udacity.github.io/git-styleguide/) para descrição de commits.

[Semantic Versioning](https://semver.org/) para versionamento de versões.

## Bibliotecas utlizadas
- [XUnit](https://xunit.net/) para criação de testes de automatizado.

- [Fluent Assertions](https://fluentassertions.com/) para realizar assert nos testes automatizados.

- [Benchmark.NET](https://benchmarkdotnet.org/) para realizar testes de benchmark.

- [Bogus](https://github.com/bchavez/Bogus) para geração de dados fake nos testes de unidade.

## Autor
Fernando Gonçalves

[<img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white"/>](https://www.linkedin.com/in/hd1fernando/)


# Referências:

Todas as fontes utilizadas até o momento estão disponíveis [aqui]()