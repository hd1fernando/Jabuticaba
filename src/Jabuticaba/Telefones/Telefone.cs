using System;

namespace Jabuticaba.Telefones
{
    public struct Telefone
    {
        private readonly string _telefone;
        public bool EValido;
        public bool DDDValido;
        private Telefone(string telefone)
        {
            _telefone = telefone;
            EValido = true;
            DDDValido = true;
            Validar();
        }

        public static implicit operator Telefone(string telefone)
            => new Telefone(telefone);

        public override string ToString()
            => _telefone;
        private void Validar()
        {

            Span<char> telefone = stackalloc char[_telefone.Length];
            Span<char> telefoneSemMascara = stackalloc char[13];

            for (int i = 0; i < telefone.Length; i++)
                telefone[i] = _telefone[i];

            if (FormatoValido(telefone, telefoneSemMascara) == false
                || EhDDDValido(telefoneSemMascara) == false
                || ValidarNonoDigito(telefoneSemMascara) == false)
            {
                DDDValido = false;
                EValido = false;
                return;
            }
        }



        private bool FormatoValido(Span<char> telefone, Span<char> semMascara)
        {
            if (telefone[0] == '+' && int.Parse(telefone[1..3]) != 55)
                return false;

            int tamanho = telefone.Length;
            int contadorSemMascara = 0;
            for (int i = 0; i < telefone.Length; i++)
            {
                if (char.IsDigit(telefone[i]) == false)
                {
                    tamanho--;
                    continue;
                }
                if (contadorSemMascara < semMascara.Length)
                    semMascara[contadorSemMascara++] = telefone[i];
            }

            if (tamanho > 17 || tamanho < 10)
                return false;

            if (tamanho < semMascara.Length)
                semMascara[tamanho + 1] = '\0';

            return true;
        }

        private bool SomenteDigito(Span<char> span)
        {
            foreach (char c in span)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private bool ValidarNonoDigito(Span<char> telefone)
        {
            int tamanhoTelefone = telefone.IndexOf('\0');

            if (tamanhoTelefone == -1)
                return telefone[4] == '9';
            if (tamanhoTelefone == 11)
                return telefone[2] == '9';
            return true;
        }

        private bool EhDDDValido(Span<char> telefone)
        {
            int tamanhoTelefone = telefone.IndexOf('\0');
            int ddd = tamanhoTelefone <= 11 && tamanhoTelefone > 0
                ? int.Parse(telefone[0..2])
                : NaoCapturarDDI(telefone);

            if (ddd % 10 == 0)
                return false;

            return ddd switch
            {
                < 11 => false,
                23 or 25 or 26 or 29 or 36 or 39 or 52 or 72 or 76 or 78 => false,
                >= 56 and < 60 => false,
                > 99 => false,
                _ => true
            };
        }

        private int NaoCapturarDDI(Span<char> telefone)
            => int.Parse(telefone[2..4]);
    }
}