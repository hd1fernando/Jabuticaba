
using System;
using Jabuticaba.Excecoes;

namespace Jabuticaba
{
    public struct Cpf
    {
        private readonly string _cpf;
        private Cpf(string cpf)
           => _cpf = cpf;

        public static implicit operator Cpf(string cpf)
            => Validar(cpf);

        private static Cpf Validar(string cpf)
        {
            cpf = RemoverMascara(cpf);
            ValidarSeSomenteDigito(cpf);
            ValidarTamanho(cpf);
            ValidarDigitosRepetidos(cpf);
            ValidarPrimeroDigito(cpf);
            ValidarSegundoDigito(cpf);
            return new Cpf(cpf);
        }

        private static void ValidarDigitosRepetidos(string cpf)
        {
            long cpfLong = long.Parse(cpf);

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

        private static void ValidarSegundoDigito(string cpf)
        {
            int resultado =
                (int)char.GetNumericValue(cpf[0]) * 11 +
                (int)char.GetNumericValue(cpf[1]) * 10 +
                (int)char.GetNumericValue(cpf[2]) * 9 +
                (int)char.GetNumericValue(cpf[3]) * 8 +
                (int)char.GetNumericValue(cpf[4]) * 7 +
                (int)char.GetNumericValue(cpf[5]) * 6 +
                (int)char.GetNumericValue(cpf[6]) * 5 +
                (int)char.GetNumericValue(cpf[7]) * 4 +
                (int)char.GetNumericValue(cpf[8]) * 3 +
                (int)char.GetNumericValue(cpf[9]) * 2;


            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if ((int)char.GetNumericValue(cpf[10]) != restoDaDivisao)
                throw new CpfInvalidoException($"O CPF {cpf} é inválido.");
        }

        private static void ValidarPrimeroDigito(string cpf)
        {
            int resultado =
                (int)char.GetNumericValue(cpf[0]) * 10 +
                (int)char.GetNumericValue(cpf[1]) * 9 +
                (int)char.GetNumericValue(cpf[2]) * 8 +
                (int)char.GetNumericValue(cpf[3]) * 7 +
                (int)char.GetNumericValue(cpf[4]) * 6 +
                (int)char.GetNumericValue(cpf[5]) * 5 +
                (int)char.GetNumericValue(cpf[6]) * 4 +
                (int)char.GetNumericValue(cpf[7]) * 3 +
                (int)char.GetNumericValue(cpf[8]) * 2;

            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if ((int)char.GetNumericValue(cpf[9]) != restoDaDivisao)
                throw new CpfInvalidoException($"O CPF {cpf} é inválido.");
        }

        private static void ValidarSeSomenteDigito(string cpf)
        {
            for (int i = 0; i < cpf.Length; i++)
            {
                if (cpf[i] < 0x30 || cpf[i] > 0x39)
                    throw new CpfInvalidoException($"Um CPF deve conter apenas números. O valor '{cpf[i]}' foi encontrado na posição '{i}'. Cpf informado: {cpf}");
            }
        }

        private static void ValidarTamanho(string cpf)
        {
            if (cpf.Length is not 11)
                throw new CpfInvalidoException($"O cpf deve ter 11 dígitos. {cpf.Length} dígitos foram informados");
        }

        private static string RemoverMascara(string cpf)
            => cpf.Replace("-", "").Replace(".", "");
    }
}
