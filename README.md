![.NET](https://github.com/hd1fernando/Jabuticaba/workflows/.NET/badge.svg?branch=main)
[![NuGet](http://img.shields.io/nuget/v/:jabuticaba)](https://www.nuget.org/packages/jabuticaba/)

# Jabuticaba
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/hd1fernando/Jabuticaba/blob/feature/cpf/LICENSE)

# Sobre o projeto

**Jabuticaba** é uma biblioteca que busca fornecer como tipo valores utilizados no Brasil. (ex: **CPF**, **CNPJ**, **RG**, ...).

Seu principal objeto é evitar que o desenvolvedor necessite recriar novos tipos para novos projetos além de ter foco em desempenho e baixa alocação de memória.

## Download e instalação
Use o gerenciador de pacotes **[Nuget](https://www.nuget.org/packages/jabuticaba/)** para realizar a instalação.

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
 
## Benchmark
Clique [aqui](https://github.com/hd1fernando/Jabuticaba/blob/main/benchmark/DiagnoseResult.md) para ver o último resultado do teste de benchmark

## Detalhes do projeto
* [GitFlow](https://www.atlassian.com/br/git/tutorials/comparing-workflows/gitflow-workflow) para fluxo de trabalho com Git.

* [Udacity Style Guide](https://udacity.github.io/git-styleguide/) para descrição de commits.

* [Semantic Versioning](https://semver.org/) para versionamento de versões.

## Bibliotecas utilizadas
- [XUnit](https://xunit.net/) para criação de testes de automatizado.

- [Fluent Assertions](https://fluentassertions.com/) para realizar assert nos testes automatizados.

- [Benchmark.NET](https://benchmarkdotnet.org/) para realizar testes de benchmark.

- [Bogus](https://github.com/bchavez/Bogus) para geração de dados fake nos testes de unidade.

## Contribuidores

Criado por Fernando Gonçalves 

[<img src="https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white"/>](https://www.linkedin.com/in/hd1fernando/)


# Referências:

Todas as fontes utilizadas até o momento estão disponíveis [aqui](https://github.com/hd1fernando/Jabuticaba/blob/main/doc/Referencias.md).
