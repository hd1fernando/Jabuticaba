using System;

namespace Jabuticaba
{
    public struct Cnpj
    {
        private string _cnpj;

        private Cnpj(string cnpj)
        {
            _cnpj = cnpj;
            Validar();
        }

        public static implicit operator Cnpj(string cnpj)
            => new Cnpj(cnpj);

        public void Validar()
        {
            Span<int> stackCnpj = stackalloc int[14];
            ValidarSeNulo();
            ValidarSeSomentDigito();
            ValidarTamanho();
            RemoverMascara(stackCnpj);
            ValidarPrimeroDigito(stackCnpj);
            ValidarSegundoDigito(stackCnpj);
        }

        private void ValidarSeNulo()
        {
            if (_cnpj is null)
                throw new NullReferenceException("O CNPJ não pode ser nulo");
        }

        private void ValidarSeSomentDigito()
        {
            for (int i = 0; i < _cnpj.Length; i++)
            {
                if (_cnpj[i] == 0x2d || _cnpj[i] == 0x2e || _cnpj[i] == 0x2f)
                    continue;
                if (_cnpj[i] < 0x30 || _cnpj[i] > 0x39)
                    throw new CnpjInvalidoException($"Um CNPJ deve conter apenas números. O valor '{_cnpj[i]}' foi encontrado na posição '{i + 1}'. Cpf informado: {_cnpj}");
            }
        }

        private void ValidarTamanho()
        {
            int contador = 0;
            foreach (var c in _cnpj)
            {
                if (c >= 0x30 && c <= 0x39)
                    contador++;
            }
            if (contador is not 14)
                throw new CnpjInvalidoException($"O CNPJ deve ter 14 dígitos. {contador} dígitos foram informados");
        }

        private void RemoverMascara(Span<int> cnpjSpan)
        {
            int contador = 0;
            foreach (var c in _cnpj)
            {
                if (c >= 0x30 && c <= 0x39)
                    cnpjSpan[contador++] = c - 0x30;
            }
        }

        private void ValidarPrimeroDigito(Span<int> cnpj)
        {
            int resultado =
                cnpj[0] * 5 +
                cnpj[1] * 4 +
                cnpj[2] * 3 +
                cnpj[3] * 2 +
                cnpj[4] * 9 +
                cnpj[5] * 8 +
                cnpj[6] * 7 +
                cnpj[7] * 6 +
                cnpj[8] * 5 +
                cnpj[9] * 4 +
                cnpj[10] * 3 +
                cnpj[11] * 2;

            int mod = resultado % 11;
            int digitoVerificador;

            if (mod < 2)
                digitoVerificador = 0;
            else
                digitoVerificador = 11 - mod;

            if (cnpj[12] != digitoVerificador)
                throw new CnpjInvalidoException($"O CNPJ {_cnpj} é inválido.");
        }

        private void ValidarSegundoDigito(Span<int> cnpj)
        {
            int resultado =
                cnpj[0] * 6 +
                cnpj[1] * 5 +
                cnpj[2] * 4 +
                cnpj[3] * 3 +
                cnpj[4] * 2 +
                cnpj[5] * 9 +
                cnpj[6] * 8 +
                cnpj[7] * 7 +
                cnpj[8] * 6 +
                cnpj[9] * 5 +
                cnpj[10] * 4 +
                cnpj[11] * 3 +
                cnpj[12] * 2;

            int mod = resultado % 11;
            int digitoVerificador;

            if (mod < 2)
                digitoVerificador = 0;
            else
                digitoVerificador = 11 - mod;

            if (cnpj[13] != digitoVerificador)
                throw new CnpjInvalidoException($"O CNPJ {_cnpj} é inválido.");
        }

    }
}
