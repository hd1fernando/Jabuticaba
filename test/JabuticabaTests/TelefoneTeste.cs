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
        public void DeveRetornarDDDInvalido(string sTelefone)
        {
            Telefone telefone = sTelefone;
            telefone.DDDValido.Should().BeFalse();
        }

    }
}
