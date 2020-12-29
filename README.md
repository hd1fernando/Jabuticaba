![.NET](https://github.com/hd1fernando/Jabuticaba/workflows/.NET/badge.svg?branch=main)
[![NuGet](http://img.shields.io/nuget/v/:jabuticaba)](https://www.nuget.org/packages/jabuticaba/)

# Jabuticaba
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/hd1fernando/Jabuticaba/blob/feature/cpf/LICENSE)

# Sobre o projeto

**Jabuticaba** é uma biblioteca que busca fornecer como tipo valores utilizados no Brasil. (ex: **CPF**, **CNPJ**, **RG**, ...).

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

## Exemplo

#### `Cnpj`
```C#
Cnpj cnpj = "02.055.097/0001-65";
Console.WriteLine(cnpj.EValido);
// true
```

## Tipos já implementados
 * CPF
 * CNPJ
 * CEP
 * Telefone
 
## Benchmark
``` bash
// * Legends *
BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
AMD Ryzen 5 3400G with Radeon Vega Graphics, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.101
  [Host]     : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT
  DefaultJob : .NET Core 5.0.1 (CoreCLR 5.0.120.57516, CoreFX 5.0.120.57516), X64 RyuJIT


|                        Method |      Mean |    Error |    StdDev |    Median | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------ |----------:|---------:|----------:|----------:|-----:|-------:|------:|------:|----------:|
|                      ObterCpf |  55.70 ns | 1.092 ns |  1.022 ns |  55.60 ns |    1 |      - |     - |     - |         - |
|     CpfApenasDigitosRepetidos |  62.27 ns | 1.254 ns |  1.444 ns |  62.13 ns |    2 |      - |     - |     - |         - |
|     CpfPrimeiroDigitoInvalido |  99.88 ns | 4.280 ns | 12.620 ns |  94.13 ns |    3 | 0.0421 |     - |     - |      88 B |
|      CpfSegundoDigitoInvalido | 107.18 ns | 2.146 ns |  3.146 ns | 106.61 ns |    4 | 0.0421 |     - |     - |      88 B |
| CpfTamanhoMenorDoQue11Digitos | 240.83 ns | 3.868 ns |  4.299 ns | 240.59 ns |    5 | 0.0725 |     - |     - |     152 B |
| CpfTamanhoMaiorDoQue11Digitos | 255.29 ns | 4.031 ns |  3.573 ns | 255.30 ns |    6 | 0.0763 |     - |     - |     160 B |
|   CpfContendoValorNaoNumerico | 427.66 ns | 8.255 ns |  8.108 ns | 428.53 ns |    7 | 0.1488 |     - |     - |     312 B |

|                     Method |      Mean |    Error |   StdDev | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------- |----------:|---------:|---------:|-----:|-------:|------:|------:|----------:|
|             CnpjSemMascara |  67.85 ns | 0.416 ns | 0.389 ns |    1 |      - |     - |     - |         - |
|                  ObterCnpj |  75.87 ns | 0.758 ns | 0.672 ns |    2 |      - |     - |     - |         - |
|  CnpjSegundoDigitoInvalido | 101.82 ns | 2.066 ns | 3.337 ns |    3 | 0.0459 |     - |     - |      96 B |
| CnpjPrimeiroDigitoInvalido | 112.16 ns | 2.267 ns | 2.699 ns |    4 | 0.0459 |     - |     - |      96 B |
|    CnpjMaiorDoQue14Digitos | 259.65 ns | 4.840 ns | 4.753 ns |    5 | 0.0763 |     - |     - |     160 B |
|    CnpjMenorDoQue14Digitos | 265.31 ns | 5.343 ns | 7.132 ns |    5 | 0.0763 |     - |     - |     160 B |
|       CnpjValorNaoNumerico | 436.29 ns | 6.250 ns | 5.846 ns |    6 | 0.1526 |     - |     - |     320 B |

|                   Method |      Mean |     Error |    StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |----------:|----------:|----------:|-----:|------:|------:|------:|----------:|
|                 CepMaior |  2.489 ns | 0.0308 ns | 0.0257 ns |    1 |     - |     - |     - |         - |
| CepSemIfenNaSextaPosicao |  3.030 ns | 0.0297 ns | 0.0278 ns |    2 |     - |     - |     - |         - |
|            CepSemNumeros |  7.735 ns | 0.1570 ns | 0.1542 ns |    3 |     - |     - |     - |         - |
|                 CepMenor |  9.955 ns | 0.1558 ns | 0.1457 ns |    4 |     - |     - |     - |         - |
|                  OberCep | 10.835 ns | 0.1485 ns | 0.1389 ns |    5 |     - |     - |     - |         - |
|      OberCepSemPontuacao | 11.632 ns | 0.1208 ns | 0.1130 ns |    6 |     - |     - |     - |         - |

|                              Method |      Mean |    Error |    StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |----------:|---------:|----------:|-----:|------:|------:|------:|----------:|
|               NaoEhUmTelefoneValido |  20.48 ns | 0.413 ns |  0.386 ns |    1 |     - |     - |     - |         - |
|   ObterTelefoneServicoPublicoValido |  33.18 ns | 0.687 ns |  0.609 ns |    2 |     - |     - |     - |         - |
| ObterTelefoneServicoPublicoInvalido |  48.77 ns | 0.717 ns |  0.636 ns |    3 |     - |     - |     - |         - |
|            ObterTelefoneDDDInvalido |  82.00 ns | 1.186 ns |  1.109 ns |    4 |     - |     - |     - |         - |
|                 ObterTelefoneSemDDI |  96.33 ns | 1.874 ns |  1.661 ns |    5 |     - |     - |     - |         - |
|          ObterTelefoneSemNonoDigito | 121.86 ns | 2.479 ns |  3.710 ns |    6 |     - |     - |     - |         - |
|               ObterTelefoneCompleto | 137.91 ns | 3.916 ns | 11.361 ns |    7 |     - |     - |     - |         - |


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
* [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) para fluxo de trabalho com Git.

* [Udacity Style Guide](https://udacity.github.io/git-styleguide/) para descrição de commits.

* [Semantic Versioning](https://semver.org/) para versionamento de versões.

## Bibliotecas utlizadas
- [XUnit](https://xunit.net/) para criação de testes de automatizado.

- [Fluent Assertions](https://fluentassertions.com/) para realizar assert nos testes automatizados.

- [Benchmark.NET](https://benchmarkdotnet.org/) para realizar testes de benchmark.

- [Bogus](https://github.com/bchavez/Bogus) para geração de dados fake nos testes de unidade.

## Contribuidores

Criado por Fernando Gonçalves 

[<img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white"/>](https://www.linkedin.com/in/hd1fernando/)


# Referências:

Todas as fontes utilizadas até o momento estão disponíveis [aqui](https://github.com/hd1fernando/Jabuticaba/blob/feature/organizacaoProjeto/doc/Referencias.md).
