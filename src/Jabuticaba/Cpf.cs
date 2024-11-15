﻿using System;
using System.Runtime.CompilerServices;

namespace Jabuticaba
{

    public struct Cpf
    {
        private string _cpf;
        public bool EValido { get; private set; }
        public string Erro { get; private set; }

        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
        private Cpf(string cpf)
        {
            Erro = null;
            _cpf = cpf;
            EValido = true;
            Validar();
        }

        public static implicit operator Cpf(string cpf)
            => new Cpf(cpf);

        public override string ToString()
            => _cpf;

        private void Validar()
        {
            Span<int> stackCpf = stackalloc int[11];

            ValidarSeNulo();
            if(EValido == false) return;

            ValidarSeSomenteDigito();
            if (EValido == false) return;

            ValidarTamanho();
            if (EValido == false) return;

            RemoverMascara(stackCpf);
            if (EValido == false) return;

            ValidarDigitosRepetidos(stackCpf);
            if (EValido == false) return;

            ValidarPrimeroDigito(stackCpf);
            if (EValido == false) return;

            ValidarSegundoDigito(stackCpf);
            if (EValido == false) return;
        }

        private void ValidarSeNulo()
        {
            if (_cpf is null)
            {
                EValido = false;
                Erro = "O CPF não pode ser nulo";
            }
        }

        private void ValidarDigitosRepetidos(Span<int> cpf)
        {
            for (int i = 1; i < 11; i++)
            {
                if (cpf[i] != cpf[0])
                    return;
            }
            EValido = false;
            Erro = "CPF com números repetidos não são válidos";
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
        private void ValidarSegundoDigito(Span<int> cpf)
        {
            int resultado =
                cpf[0] * 11 +
                cpf[1] * 10 +
                cpf[2] * 9 +
                cpf[3] * 8 +
                cpf[4] * 7 +
                cpf[5] * 6 +
                cpf[6] * 5 +
                cpf[7] * 4 +
                cpf[8] * 3 +
                cpf[9] * 2;


            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if (cpf[10] != restoDaDivisao)
            {
                EValido = false;
                Erro = $"O CPF {_cpf} é inválido.";
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization | MethodImplOptions.AggressiveInlining)]
        private void ValidarPrimeroDigito(Span<int> cpf)
        {
            int resultado =
                cpf[0] * 10 +
                cpf[1] * 9 +
                cpf[2] * 8 +
                cpf[3] * 7 +
                cpf[4] * 6 +
                cpf[5] * 5 +
                cpf[6] * 4 +
                cpf[7] * 3 +
                cpf[8] * 2;

            int restoDaDivisao = (resultado * 10) % 11;

            if (restoDaDivisao == 10)
                restoDaDivisao = 0;

            if (cpf[9] != restoDaDivisao)
            {
                EValido = false;
                Erro = $"O CPF {_cpf} é inválido.";
            }
        }

        private void ValidarSeSomenteDigito()
        {
            for (int i = 0; i < _cpf.Length; i++)
            {
                if (_cpf[i] == 0x2d || _cpf[i] == 0x2e)
                    continue;
                if (_cpf[i] < 0x30 || _cpf[i] > 0x39)
                {
                    EValido = false;
                    Erro = $"Um CPF deve conter apenas números. O valor '{_cpf[i]}' foi encontrado na posição '{i + 1}'. Cpf informado: {_cpf}";
                    break;
                }
            }
        }

        private void ValidarTamanho()
        {
            int contador = 0;
            foreach (var c in _cpf)
            {
                if (char.IsDigit(c))
                    contador++;
            }
            if (contador is not 11)
            {

                EValido = false;
                Erro = $"O cpf deve ter 11 dígitos. {contador} dígitos foram informados";
            }
        }

        private void RemoverMascara(Span<int> nCpf)
        {
            int contador = 0;
            foreach (var cpf in _cpf)
            {
                if (char.IsDigit(cpf))
                    nCpf[contador++] = cpf - 0x30;
            }
        }
    }

}
