using System;
using FluentAssertions;
using Jabuticaba.OrgaoEmissor;
using Jabuticaba.OrgaoEmissor.SSP.SP;
using Xunit;

namespace JabuticabaTests
{
    public class RgSpTest
    {
        [Fact]
        public void DeveCriarRgComMascara()
        {
            Rg rg = "15.506.536-1";
        }

        [Fact]
        public void DeveCriarRgSemMascara()
        {
            Rg rg = "225427588";
        }

        [Fact]
        public void DeveLancarExcecaoQuandoRgConterValorNaoNumerico()
        {
            Action action = () => { Rg rg = "15.506.536-a"; };

            action.Should().Throw<RgInvalidoException>()
                .WithMessage("Um RG deve conter apenas números. O valor 'a' foi encontrado na posição '12'. Cpf informado: 15.506.536-a");
        }

        [Fact]
        public void DeveLancarExcecaoQuanRgForMenorDoQue9Digitos()
        {
            Action action = () => { Rg rg = "15.506.536"; };

            action.Should().Throw<RgInvalidoException>()
                .WithMessage("O RG deve ter 9 dígitos. 8 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExcecaoQuanRgForMaiorDoQue9Digitos()
        {
            Action action = () => { Rg rg = "15.506.536-12"; };

            action.Should().Throw<RgInvalidoException>()
                .WithMessage("O RG deve ter 9 dígitos. 10 dígitos foram informados");
        }

        [Fact]
        public void DeveLevantarQuandoExcecaoRgNulo()
        {
            Action acao = () => { Rg rg = null; };
            acao.Should().Throw<NullReferenceException>()
                .WithMessage("O RG não pode ser nulo");
        }
    }
}
