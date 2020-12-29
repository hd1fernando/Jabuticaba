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

            do
            {
                inc++;
                faker = new("pt_BR");
                // Act
                Cnpj cnpj = faker.Company.Cnpj();

                // Assert
                cnpj.EValido.Should().BeTrue();
                cnpj.Erro.Should().BeNull();

            } while (inc < gerar);
        }

        [Fact]
        public void DeveCriarCnpjSemMascara()
        {
            // Arrange
            Faker faker;
            int gerar = 100;
            int inc = 0;

            do
            {
                inc++;
                faker = new("pt_BR");

                // Act
                Cnpj cnpj = faker.Company.Cnpj(includeFormatSymbols: false);

                // Assert
                cnpj.EValido.Should().BeTrue();
                cnpj.Erro.Should().BeNull();

            } while (inc < gerar);
        }

        [Fact]
        public void DeveSerInvalidoQuandoCnpjContarValorNaoNumerico()
        {
            Cnpj cnpj = "2.055.097/0001-6a";

            cnpj.EValido.Should().BeFalse();
            cnpj.Erro.Should()
                .BeEquivalentTo("Um CNPJ deve conter apenas números. O valor 'a' foi encontrado na posição '17'. Cpf informado: 2.055.097/0001-6a");
        }

        [Fact]
        public void DeveSerInvalidoQuanCnpjForMenorDoQue14Digitos()
        {
            Cnpj cnpj = "02.055.097/0001-6";

            cnpj.EValido.Should().BeFalse();
            cnpj.Erro.Should()
                .BeEquivalentTo("O CNPJ deve ter 14 dígitos. 13 dígitos foram informados");
        }

        [Fact]
        public void DeveSerInvalidoQuanCnpjForMaiorDoQue14Digitos()
        {
            Cnpj cnpj = "02.055.097/0001-656";

            cnpj.EValido.Should().BeFalse();
            cnpj.Erro.Should()
                .BeEquivalentTo("O CNPJ deve ter 14 dígitos. 15 dígitos foram informados");
        }

        [Fact]
        public void DeveSerInvalidoQuandoPrimeiroDigitoEhInvalido()
        {

            Cnpj cnpj = "02.055.097/0001-05";

            cnpj.EValido.Should().BeFalse();
             cnpj.Erro.Should()
                .BeEquivalentTo("O CNPJ 02.055.097/0001-05 é inválido.");
        }

        [Fact]
        public void DeveSerInvalidoQuandoSegundoDigitoEhInvalido()
        {
            Cnpj cnpj = "02.055.097/0001-60";

            cnpj.EValido.Should().BeFalse();
            cnpj.Erro.Should()
                .BeEquivalentTo("O CNPJ 02.055.097/0001-60 é inválido.");
        }

    }
}
