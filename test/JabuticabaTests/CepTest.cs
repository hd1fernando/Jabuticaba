using FluentAssertions;
using Jabuticaba;
using Xunit;

namespace JabuticabaTests
{
    public class CepTest
    {
        [Fact]
        public void DeveSerValidoComIfen()
        {
            Cep cep = "70686-820";
            cep.EValido.Should().BeTrue();
        }

        [Fact]
        public void DeveSerValidoSemIfen()
        {
            Cep cep = "70686820";
            cep.EValido.Should().BeTrue();
        }

        [Fact]
        public void QuandoTamanhoForMenorDoQue8DeveSerInvalido()
        {
            Cep cep = "70686-82";
            cep.EValido.Should().BeFalse();
        }

        [Fact]
        public void QuandoTamanhoForMaiorDoQue9DeveSerInvalido()
        {
            Cep cep = "70686-8200";
            cep.EValido.Should().BeFalse();
        }

        [Theory]
        [InlineData("70686 820")]
        [InlineData("706860820")]
        [InlineData("70686a820")]
        [InlineData("70686.820")]
        public void QuandoNaoConterIfenNaSextaPosicaoDeveSerInvalido(string sCep)
        {
            Cep cep = sCep;
            cep.EValido.Should().BeFalse();
        }

        [Theory]
        [InlineData("70686-82a")]
        [InlineData("7068a-820")]
        [InlineData("7$680820")]
        public void TiverCararterNaoNumericoDeveSerInvalido(string sCep)
        {
            Cep cep = sCep;
            cep.EValido.Should().BeFalse();
        }
    }
}
