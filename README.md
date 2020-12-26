![main](https://github.com/hd1fernando/Jabuticaba/workflows/.NET/badge.svg?branch=main)
![develop](https://github.com/hd1fernando/Jabuticaba/workflows/.NET/badge.svg?branch=develop)

# Jabuticaba

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/hd1fernando/Jabuticaba/blob/feature/cpf/LICENSE)

# Sobre o projeto

**Jabuticaba** é uma biblioteca de tipos que são utilizados no Brasil. Como CPF, RG, dentre outros.
Seu principal objetivo que que o desenvolvedor não tenha necessidade de ficar recriando tipos quando for preciso lidar com um novo tipo em sua aplicação.

### Download & instalação
**Nuget Package [jabuticaba](https://www.nuget.org/packages/jabuticaba/)**
#### Visual Studio ou Powershell
```powershell
Install-Package jabuticaba
```
#### CLI
```bash
<<<<<<< HEAD
dotnet add package jabuticaba 
=======
dotnet add package jabuticaba --version 0.1.0
>>>>>>> 2405e57ef61dfe8fed49974a4dd6e47104f1aecd
```
Requerimento mínimo: .Net 5.0

# Tipos implementados
 CPF

# Benchmark
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
# Detalhes do projeto
Esse projeto usa [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) para fluxo de trabalho com Git.

[Udacity Style Guide](https://udacity.github.io/git-styleguide/) para descrição de commits.

[Semantic Versioning](https://semver.org/) para versionamento de versões.

## Bibliotecas utlizadas
[XUnit](https://xunit.net/) para criação de testes de automatizado.

[Fluent Assertions](https://fluentassertions.com/) para realizar assert nos testes automatizados.

[Benchmark.NET](https://benchmarkdotnet.org/) para realizar testes de benchmark.

[Bogus](https://github.com/bchavez/Bogus) para geração de dados fake nos testes de unidade.

# Autor
Fernando Gonçalves

[<img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white"/>](https://www.linkedin.com/in/hd1fernando/)


# Referências:

[stevejgordon - Series: Writing High-Performance C# and .NET Code](https://www.stevejgordon.co.uk/writing-high-performance-csharp-and-dotnet-code)

[eximiaco - Limpando Strings](https://www.eximiaco.tech/pt/2019/06/11/limpando-strings/)

[microsoft- unsafe (C# Compiler Options)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/unsafe-compiler-option)

[microsoft- stackalloc expression](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/stackalloc)

[eximiaco - Validação de CPF](https://www.eximiaco.tech/pt/2019/06/11/validacao-de-cpf/)

[elemarjr - Trying to Improve Performance in .NET? Here are the basics you need to know about Intermediate Language, JIT, WinDBG, and Assembly](https://www.elemarjr.com/en/archive/trying-to-improve-performance-in-net-here-are-the-basics-you-need-to-know-about-intermediate-language-jit-windbg-and-assembly/)

[elemarjr - Lições de performances aprendidas com Roslyn](https://www.elemarjr.com/pt/archive/licoes-de-performances-aprendidas-com-roslyn-1-objectpool-e-pooledstringbuilder/)

[dicasdeprogramacao - Algoritmo para Validar CPF](https://dicasdeprogramacao.com.br/algoritmo-para-validar-cpf/)

[You Tube - Entendendo a Heap e o Garbage Collector em .NET](https://www.youtube.com/watch?v=s5-uC-taIi4)

[Medium - Gerando dados aleatórios para seus testes de unidade](https://medium.com/cristiano-cunha/gerando-dados-aleat%C3%B3rios-para-seus-testes-de-unidade-bogus-c-9dd233c9c648)