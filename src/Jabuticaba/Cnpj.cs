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
            ValidarSeSomentDigito();
            ValidarTamanho();
        }

        private void ValidarSeSomentDigito()
        {
            for (int i = 0; i < _cnpj.Length; i++)
            {
                if (_cnpj[i] == 0x2d || _cnpj[i] == 0x2e || _cnpj[i] == 0x2f)
                    continue;
                if (char.IsDigit(_cnpj[i]) == false)
                    throw new CnpjInvalidoException($"Um CNPJ deve conter apenas números. O valor '{_cnpj[i]}' foi encontrado na posição '{i + 1}'. Cpf informado: {_cnpj}");
            }
        }

        private void ValidarTamanho()
        {
            int contador = 0;
            foreach (var c in _cnpj)
            {
                if (char.IsDigit(c))
                    contador++;
            }
            if(contador is not 14)
                throw new CnpjInvalidoException($"O CNPJ deve ter 14 dígitos. {contador} dígitos foram informados");
        }
    }
}
