﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospital
{
    internal class FilaPreferencial
    {
        public Paciente Head { get; set; }
        public Paciente Tail { get; set; }
        public int GerarSenha { get; set; }
        public FilaPreferencial()
        {
            Head = null;
            Tail = null;
        }

        public Paciente Saida()
        {
            Paciente aux = Head;
            if (Head.Proximo == null)
            {
                Tail = null;
            }
            Head = Head.Proximo;
            return aux;

        }
        public void Entrada(Paciente novoPaciente)
        {

            if (Vazio())
            {
                Head = novoPaciente;
                Tail = novoPaciente;

            }
            else
            {
                Tail.Proximo = novoPaciente;
                Tail = novoPaciente;

            }
            novoPaciente.Senha = GerarSenha;
            GerarSenha++;
        }
        public bool Vazio()
        {
            if ((Head == null) && (Tail == null))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
