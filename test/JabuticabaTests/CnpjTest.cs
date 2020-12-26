using System;
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
            Cnpj cnpj = "02.055.097/0001-65";
        }

        [Fact]
        public void DeveCriarCnpjSemMascara()
        {
            Cnpj cnpj = "02055097000165";
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

    }
}
