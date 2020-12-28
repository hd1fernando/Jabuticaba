using System;
using System.Text.RegularExpressions;

namespace Jabuticaba
{
    public struct Cep
    {
        private string _cep;
        public bool EValido { get; private set; }

        private Cep(string cep) : this()
        {
            _cep = cep;
            EValido = true;
            Validar();
        }
    
        public static implicit operator Cep(string cep)
            => new Cep(cep);

        private void Validar()
        {
            if (_cep.Length > 9 || _cep.Length < 8)
            {
                EValido = false;
                return;
            }

            if (_cep.Length == 9)
            {
                if (_cep[5] != 0x2d)
                {
                    EValido = false;
                    return;
                }

                if (char.IsDigit(_cep[0]) == false ||
                char.IsDigit(_cep[1]) == false ||
                char.IsDigit(_cep[2]) == false ||
                char.IsDigit(_cep[3]) == false ||
                char.IsDigit(_cep[4]) == false ||
                char.IsDigit(_cep[6]) == false ||
                char.IsDigit(_cep[7]) == false ||
                char.IsDigit(_cep[8]) == false)
                {
                    EValido = false;
                    return;
                }

                return;
            }

            if (char.IsDigit(_cep[0]) == false ||
            char.IsDigit(_cep[1]) == false ||
            char.IsDigit(_cep[2]) == false ||
            char.IsDigit(_cep[3]) == false ||
            char.IsDigit(_cep[4]) == false ||
            char.IsDigit(_cep[5]) == false ||
            char.IsDigit(_cep[6]) == false ||
            char.IsDigit(_cep[7]) == false)
            {
                EValido = false;
                return;
            }

        }

    }
}
