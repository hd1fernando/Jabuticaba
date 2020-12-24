
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
            long[] cpfsInvalidos = {
                11111111111,
                22222222222,
                33333333333,
                44444444444,
                55555555555,
                66666666666,
                77777777777,
                88888888888,
                99999999999,
                00000000000
            };

            foreach(var cpfInvalido in cpfsInvalidos)
            {
                if(long.Parse(cpf) == cpfInvalido)
                    throw new CpfInvalidoException("CPF com números repetidos não são válidos");
            }
        }

        private static void ValidarSegundoDigito(string cpf)
        {
            int multiplicador = 11;
            int resultado = 0;
            for (int i = 0; i < 10; i++)
            {
                resultado += ((int)char.GetNumericValue(cpf[i]) * multiplicador);
                multiplicador--;
            }
            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if ((int)char.GetNumericValue(cpf[10]) != restoDaDivisao)
                throw new CpfInvalidoException($"O CPF {cpf} é inválido.");
        }

        private static void ValidarPrimeroDigito(string cpf)
        {
            int multiplicador = 10;
            int resultado = 0;
            for (int i = 0; i < 9; i++)
            {
                resultado += ((int)char.GetNumericValue(cpf[i]) * multiplicador);
                multiplicador--;
            }
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
