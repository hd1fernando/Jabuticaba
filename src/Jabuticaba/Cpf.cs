
using System;
using System.Runtime.CompilerServices;
using System.Text;
using Jabuticaba.Excecoes;

namespace Jabuticaba
{
    public struct Cpf
    {
        private string _cpf;
        private Cpf(string cpf)
        {
            _cpf = cpf;
            Validar(cpf);
        }

        public static implicit operator Cpf(string cpf)
            => new Cpf(cpf);

        private void Validar(string cpf)
        {
            ValidarSeNulo();
            RemoverMascara();
            ValidarSeSomenteDigito();
            ValidarTamanho();
            ValidarDigitosRepetidos();
            ValidarPrimeroDigito();
            ValidarSegundoDigito();
        }

        private void ValidarSeNulo()
        {
            if (_cpf is null)
                throw new NullReferenceException("O CPF não pode ser nulo");
        }

        private void ValidarDigitosRepetidos()
        {
            long cpfLong = long.Parse(_cpf);

            if (cpfLong == 11111111111 ||
                cpfLong == 22222222222 ||
                cpfLong == 33333333333 ||
                cpfLong == 44444444444 ||
                cpfLong == 55555555555 ||
                cpfLong == 66666666666 ||
                cpfLong == 77777777777 ||
                cpfLong == 88888888888 ||
                cpfLong == 99999999999 ||
                cpfLong == 00000000000)
                throw new CpfInvalidoException("CPF com números repetidos não são válidos");
        }

        private void ValidarSegundoDigito()
        {
            int resultado =
                ObterDigito(0) * 11 +
                ObterDigito(1) * 10 +
                ObterDigito(2) * 9 +
                ObterDigito(3) * 8 +
                ObterDigito(4) * 7 +
                ObterDigito(5) * 6 +
                ObterDigito(6) * 5 +
                ObterDigito(7) * 4 +
                ObterDigito(8) * 3 +
                ObterDigito(9) * 2;


            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if (ObterDigito(10) != restoDaDivisao)
                throw new CpfInvalidoException($"O CPF {_cpf} é inválido.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int ObterDigito(int posicao)
            => _cpf[posicao] - 0x30;

        private void ValidarPrimeroDigito()
        {
            int resultado =
                ObterDigito(0) * 10 +
                ObterDigito(1) * 9 +
                ObterDigito(2) * 8 +
                ObterDigito(3) * 7 +
                ObterDigito(4) * 6 +
                ObterDigito(5) * 5 +
                ObterDigito(6) * 4 +
                ObterDigito(7) * 3 +
                ObterDigito(8) * 2;

            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if (ObterDigito(9) != restoDaDivisao)
                throw new CpfInvalidoException($"O CPF {_cpf} é inválido.");
        }

        private void ValidarSeSomenteDigito()
        {
            for (int i = 0; i < _cpf.Length; i++)
            {
                if (_cpf[i] < 0x30 || _cpf[i] > 0x39)
                    throw new CpfInvalidoException($"Um CPF deve conter apenas números. O valor '{_cpf[i]}' foi encontrado na posição '{i}'. Cpf informado: {_cpf}");
            }
        }

        private void ValidarTamanho()
        {
            if (_cpf.Length is not 11)
                throw new CpfInvalidoException($"O cpf deve ter 11 dígitos. {_cpf.Length} dígitos foram informados");
        }

        private string RemoverMascara()
           => _cpf = _cpf.Replace("-", "").Replace(".", "");
    }
}
