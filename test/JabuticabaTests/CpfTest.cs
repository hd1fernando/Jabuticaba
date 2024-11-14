using Bogus;
using Bogus.Extensions.Brazil;
using FluentAssertions;
using Jabuticaba;
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

            do
            {
                inc++;
                faker = new("pt_BR");

                // Act
                Cpf cpf = faker.Person.Cpf();

                // Assert
                cpf.EValido.Should().BeTrue();
                cpf.Erro.Should().BeNull();
            } while (inc < gerar);

        }

        [Fact]
        public void DeveSerInvalidoQuandoPrimeiroDigitoEhInvalido()
        {
            Cpf cpf = "149.764.610-00";

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo("O CPF 149.764.610-00 é inválido.");
        }

        [Fact]
        public void DeveSerInvalidoQuandoSegundoDigitoEhInvalido()
        {
            Cpf cpf = "529.982.247-20";

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo($"O CPF {cpf} é inválido.");
        }

        [Theory]
        [InlineData("000.000.000.00")]
        [InlineData("111.111.111-11")]
        [InlineData("222.222.222-22")]
        [InlineData("999.999.999.99")]

        public void DeveSerInvalidoQuandoCpfContemApenasDigitosRepetidos(string cpfRepetido)
        {
            Cpf cpf = cpfRepetido;

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo("CPF com números repetidos não são válidos");
        }

        [Fact]
        public void DeveSerInvalidoQuandoTamanhoCpfForMaiorDoQue11Digitos()
        {

            Cpf cpf = "149.764.610-331";

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo("O cpf deve ter 11 dígitos. 12 dígitos foram informados");
        }

        [Fact]
        public void DeveSerInvalidoQuandoTamanhoCpfForMenorDoQue11Digitos()
        {
            Cpf cpf = "149.764.610";

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo("O cpf deve ter 11 dígitos. 9 dígitos foram informados");
        }

        [Fact]
        public void DeveSerInvalidoQuandoCpfConterValorNaoNumerico()
        {
            Cpf cpf = "149.764.610a";

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo("Um CPF deve conter apenas números. O valor 'a' foi encontrado na posição '12'. Cpf informado: 149.764.610a");
        }

        [Fact]
        public void DeveSerInvalidoQuandoCpfENull()
        {
            Cpf cpf = null;

            cpf.EValido.Should().BeFalse();
            cpf.Erro.Should()
                .BeEquivalentTo("O CPF não pode ser nulo");
        }
    }
}
