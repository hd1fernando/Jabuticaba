using System;
using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using Jabuticaba;
using Xunit;

namespace JabuticabaTests
{
    public class CnpjTest
    {
        [Fact]
        public void DeveCriarCnpjComMascara()
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
                Cnpj cnpj = faker.Company.Cnpj();
            } while (inc < gerar);
        }

        [Fact]
        public void DeveCriarCnpjSemMascara()
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
                Cnpj cnpj = faker.Company.Cnpj(includeFormatSymbols: false);
            } while (inc < gerar);
        }

        [Fact]
        public void DeveLancarExcecaoQuandoCnpjContarValorNaoNumerico()
        {
            Action action = () => { Cnpj cnpj = "2.055.097/0001-6a"; };

            action.Should().Throw<CnpjInvalidoException>()
                .WithMessage("Um CNPJ deve conter apenas números. O valor 'a' foi encontrado na posição '17'. Cpf informado: 2.055.097/0001-6a");
        }

        [Fact]
        public void DeveLancarExcecaoQuanCnpjForMenorDoQue14Digitos()
        {
            Action action = () => { Cnpj cnpj = "02.055.097/0001-6"; };

            action.Should().Throw<CnpjInvalidoException>()
                .WithMessage("O CNPJ deve ter 14 dígitos. 13 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuanCnpjForMaiorDoQue14Digitos()
        {
            Action action = () => { Cnpj cnpj = "02.055.097/0001-656"; };

            action.Should().Throw<CnpjInvalidoException>()
                .WithMessage("O CNPJ deve ter 14 dígitos. 15 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoPrimeiroDigitoEhInvalido()
        {
            Action action = () => { Cnpj cnpj = "02.055.097/0001-05"; };

            action.Should().Throw<CnpjInvalidoException>()
                .WithMessage("O CNPJ 02.055.097/0001-05 é inválido.");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoSegundoDigitoEhInvalido()
        {
            Action action = () => { Cnpj cnpj = "02.055.097/0001-60"; };

            action.Should().Throw<CnpjInvalidoException>()
                .WithMessage("O CNPJ 02.055.097/0001-60 é inválido.");
        }

        public void DeveLevantarExcecaoCpfVazio()
        {
            Action acao = () => { Cpf cpf = null; };
            acao.Should().Throw<NullReferenceException>()
                .WithMessage("O CNPJ não pode ser nulo");
        }
    }
}