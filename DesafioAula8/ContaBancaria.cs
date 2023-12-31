﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula8
{
    public class ContaBancaria
    {
        public string Tipo { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(string tipo, int numero, int agencia, double saldo) 
        { 
            Tipo = tipo;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }

        public string ExibirDadosConta()
        {
            return $"A conta de numero pesquisada é do tipo {Tipo} com o numero da conta {Numero} e agência {Agencia} com saldo {Saldo}";
        }
    }
}
