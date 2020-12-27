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

                cpf.Validar();

                // Assert
                cpf.EValido.Should().BeTrue();
                cpf.Erros.Should().BeNull();
            } while (inc < gerar);

        }

        [Fact]
        public void DeveLancarExcecaoQuandoPrimeiroDigitoEhInvalido()
        {
            Cpf cpf = "149.764.610-00";
            cpf.Validar(ModoCascateamento.PararNoPrimeiroErro);

            cpf.EValido.Should().BeFalse();
            cpf.Erros.Should()
                .ContainEquivalentOf("O CPF 149.764.610-00 é inválido.");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoSegundoDigitoEhInvalido()
        {
            Cpf cpf = "529.982.247-20";
            cpf.Validar();

            cpf.EValido.Should().BeFalse();
            cpf.Erros.Should()
                .ContainEquivalentOf($"O CPF {cpf} é inválido.");
        }

        [Theory]
        [InlineData("000.000.000.00")]
        [InlineData("111.111.111-11")]
        [InlineData("222.222.222-22")]
        [InlineData("999.999.999.99")]

        public void DeveLancarExcecaoQuandoCpfContemApenasDigitosRepetidos(string cpfRepetido)
        {
            Cpf cpf = cpfRepetido;
            cpf.Validar();

            cpf.EValido.Should().BeFalse();
            cpf.Erros.Should()
                .ContainEquivalentOf("CPF com números repetidos não são válidos");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoTamanhoCpfForMaiorDoQue11Digitos()
        {

            Cpf cpf = "149.764.610-331";
            cpf.Validar(ModoCascateamento.PararNoPrimeiroErro);

            cpf.EValido.Should().BeFalse();
            cpf.Erros.Should()
                .ContainEquivalentOf("O cpf deve ter 11 dígitos. 12 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoTamanhoCpfForMenorDoQue11Digitos()
        {
            Cpf cpf = "149.764.610";

            cpf.Validar();

            cpf.EValido.Should().BeFalse();
            cpf.Erros.Should()
                .ContainEquivalentOf("O cpf deve ter 11 dígitos. 9 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuandoCpfConterValorNaoNumerico()
        {
            Cpf cpf = "149.764.610a";
            cpf.Validar();

            cpf.EValido.Should().BeFalse();
            cpf.Erros.Should()
                .ContainEquivalentOf("Um CPF deve conter apenas números. O valor 'a' foi encontrado na posição '12'. Cpf informado: 149.764.610a");
        }
    }
}
