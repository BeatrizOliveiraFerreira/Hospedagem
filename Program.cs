using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public double ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidade, double valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }

    public class Reserva
    {
        private Suite _suite;
        private List<Pessoa> _hospedes;
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            _hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            _suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            _hospedes.AddRange(hospedes);
        }

        public int ObterQuantidadeHospedes()
        {
            return _hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            double valorTotal = _suite.ValorDiaria * DiasReservados;
            if (DiasReservados > 10)
            {
                valorTotal *= 0.9; 
            }
            return valorTotal;
        }
    }
}
