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
            for (int i = 0; i < telefone.Length; i++)
                telefone[i] = _telefone[i];

            if (EDDValido(telefone) == false)
            {
                DDDValido = false;
                EValido = false;
                return;
            }
        }

        private bool EDDValido(Span<char> telefone)
        {
            int ddd = int.Parse(telefone[0..2]);
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
    }
}