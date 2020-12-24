using System;
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
            Cpf cpf = "529.982.247-25";
        }

        [Fact]
        public void DeveLancarExececaoQuandoPrimeiroDigitoEhInvalido()
        {
            Action acao = () => { Cpf cpf = "149.764.610-00"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("O CPF 14976461000 é inválido.");
        }

        [Fact]
        public void DeveLancarExececaoQuandoSegundoDigitoEhInvalido()
        {
            Action acao = () => { Cpf cpf = "529.982.247-20"; };

            acao.Should().Throw<CpfInvalidoException>();
        }

                [Fact]
        public void DeveLancarExececaoQuandoCpfContemApenasDigitosRepetidos()
        {
            Action acao = () => { Cpf cpf = "111.111.111-11"; };

            acao.Should().Throw<CpfInvalidoException>();
        }

        [Fact]
        public void DeveLancarExececaoQuandoTamanhoCpfForMaiorDoQue11Digitos()
        {
            Action acao = () => { Cpf cpf = "149.764.610-331"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("O cpf deve ter 11 dígitos. 12 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExececaoQuandoTamanhoCpfForMenorDoQue11Digitos()
        {
            Action acao = () => { Cpf cpf = "149.764.610"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("O cpf deve ter 11 dígitos. 9 dígitos foram informados");
        }

        [Fact]
        public void DeveLancarExececaoQuandoTamanhoCpfConterValorNaoNumerico()
        {
            Action acao = () => { Cpf cpf = "149.764.610a"; };

            acao.Should().Throw<CpfInvalidoException>()
                .WithMessage("Um CPF deve conter apenas números. O valor 'a' foi encontrado na posição '9'. Cpf informado: 149764610a");
        }
    }
}
