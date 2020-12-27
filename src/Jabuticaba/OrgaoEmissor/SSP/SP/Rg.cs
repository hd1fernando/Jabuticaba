using System;

namespace Jabuticaba.OrgaoEmissor.SSP.SP
{
    public struct Rg
    {
        private readonly string _rg;
        private const int TAMANHO_RG = 9;

        private Rg(string rg)
        {
            _rg = rg;
            Validar();
        }

        public static implicit operator Rg(string rg)
             => new Rg(rg);

        public override string ToString()
            => _rg;
        void Validar()
        {
            Span<char> spanRg = stackalloc char[TAMANHO_RG];
            ValidarSeNulo();
            ValidarSeSomentDigito(_rg);
            ValidarTamanho();
            RemoverMascara(spanRg);
        }

        private void ValidarSeNulo()
        {
            if (_rg is null)
                throw new NullReferenceException("O RG não pode ser nulo");
        }

        private void ValidarTamanho()
        {
            int contador = 0;
            foreach (var c in _rg)
            {
                if (c >= 0x30 && c <= 0x39)
                    contador++;
            }
            if (contador is not TAMANHO_RG)
                throw new RgInvalidoException($"O RG deve ter {TAMANHO_RG} dígitos. {contador} dígitos foram informados");
        }

        private void RemoverMascara(Span<char> cnpjSpan)
        {
            int contador = 0;
            foreach (var c in _rg)
            {
                if (c >= 0x30 && c <= 0x39 && c != 0x58 && c != 0x78)
                    cnpjSpan[contador++] = c;
            }
        }

        void ValidarSeSomentDigito(string _rg)
        {
            for (int i = 0; i < _rg.Length; i++)
            {
                if (_rg[i] == 0x2d || _rg[i] == 0x2e || _rg[i] == 0x58 || _rg[i] == 0x78)
                    continue;
                if (_rg[i] < 0x30 || _rg[i] > 0x39)
                    throw new RgInvalidoException($"Um RG deve conter apenas números. O valor '{_rg[i]}' foi encontrado na posição '{i + 1}'. Cpf informado: {_rg}");
            }
        }

        private void ValidarDigitoVerificador(Span<char> rg)
        {
            int resultado =
                rg[0] * 9 +
                rg[1] * 8 +
                rg[2] * 7 +
                rg[3] * 6 +
                rg[4] * 5 +
                rg[5] * 4 +
                rg[6] * 3 +
                rg[7] * 2;

            int digitoVerificador = resultado % 11;

            if(digitoVerificador == 10)

            if (rg[8] != digitoVerificador)
                throw new RgInvalidoException($"O RG {_rg} é inválido.");
        }

    }
}