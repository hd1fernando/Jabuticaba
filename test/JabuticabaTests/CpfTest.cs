using System;
using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using Jabuticaba;
using Jabuticaba.Excecoes;
using Xunit;

namespace JabuticabaTests
{
    public class CpfTest
    {

        [Fact]
        public void DeveCriarCpf()
        {
            // Arrange
            Faker faker;
            int gerar = 100;
            int inc = 0;

            // Act
            do
            {
                inc++;
                faker = new("pt_BR");
                Cpf cpf = faker.Person.Cpf();
            } while (inc < gerar);
        }

        [Fact]
        public void DeveLevantarExcecaoCpfVazio()
        {
            Action acao = () => { Cpf cpf = null; };
            acao.Should().Throw<NullReferenceException>()
                .WithMessage("O CPF não pode ser nulo");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoPrimeiroDigitoEhInvalido()
        {
            Action acao = () => { Cpf cpf = "149.764.610-00"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("O CPF 149.764.610-00 é inválido.");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoSegundoDigitoEhInvalido()
        {
            Action acao = () => { Cpf cpf = "529.982.247-20"; };

            acao.Should().Throw<CpfInvalidoException>();
        }

        [Theory]
        [InlineData("000.000.000.00")]
        [InlineData("111.111.111-11")]
        [InlineData("222.222.222-22")]
        [InlineData("999.999.999.99")]

        public void DeveLancarExcecaoQuandoCpfContemApenasDigitosRepetidos(string cpfRepetido)
        {
            Action acao = () => { Cpf cpf = cpfRepetido; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("CPF com números repetidos não são válidos");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoTamanhoCpfForMaiorDoQue11Digitos()
        {
            Action acao = () => { Cpf cpf = "149.764.610-331"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("O cpf deve ter 11 dígitos. 12 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoTamanhoCpfForMenorDoQue11Digitos()
        {
            Action acao = () => { Cpf cpf = "149.764.610"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("O cpf deve ter 11 dígitos. 9 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoCpfConterValorNaoNumerico()
        {
            Action acao = () => { Cpf cpf = "149.764.610a"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("Um CPF deve conter apenas números. O valor 'a' foi encontrado na posição '12'. Cpf informado: 149.764.610a");
        }
    }
}
