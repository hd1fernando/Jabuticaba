using FluentAssertions;
using Jabuticaba.Telefones;
using Xunit;

namespace JabuticabaTests
{
    public class TelefoneTeste
    {
        [Theory]
        [InlineData("0533931020")] // ddd < 11
        [InlineData("5033331020")] // multiplo de 10
        [InlineData("5633331020")]
        [InlineData("5933331020")]
        [InlineData("2333331020")]
        [InlineData("2533331020")]
        [InlineData("2633331020")]
        [InlineData("2933331020")]
        [InlineData("3633331020")]
        [InlineData("3933331020")]
        [InlineData("5233331020")]
        [InlineData("7233331020")]
        [InlineData("7633331020")]
        [InlineData("7833331020")]
        [InlineData("5578994940001")]
        public void DeveRetornarDDDInvalido(string sTelefone)
        {
            Telefone telefone = sTelefone;
            telefone.DDDValido.Should().BeFalse();
        }

        [Theory]
        [InlineData("+55 (31) 9 7500-0001")]
        [InlineData("55 (31) 9 7500-0001")]
        [InlineData("55 31 9 7500-0001")]
        [InlineData("55 31 9 7500 0001")]
        public void DeveRetornarValidoQuandoComDDDECodigoBrasil(string tel)
        {
            Telefone telefone = tel;
            telefone.EValido.Should().BeTrue();
        }

        [Theory]
        [InlineData("7500-0001")]
        [InlineData("7500 0001")]
        public void DeveRetornarInvalidoQuandoSemDDD(string tel)
        {
            Telefone telefone = tel;
            telefone.EValido.Should().BeFalse();
        }

        [Theory]
        [InlineData("(31) 3393-0001")]
        [InlineData("(31)3393-0001")]
        [InlineData("31 3393 0001")]
        [InlineData("3133930001")]
        public void DeveRetornarValidoQuandoComDDD(string tel)
        {
            Telefone telefone = tel;
            telefone.EValido.Should().BeTrue();
        }

        [Theory]
        [InlineData("55 (31) 6 3393-0001")]
        [InlineData("(31) 6 3393-0001")]
        public void DeveSerInvalidoQuandoNaoConterNonoDigitoValido(string tel)
        {
            Telefone telefone = tel;
            telefone.EValido.Should().BeFalse();
        }
    }
}
