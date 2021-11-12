using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    internal class ContaCorrente
    {
        private decimal saldo;
        private string nome ;
        private DateTime date = DateTime.Now;
        private int cont = 0;
        public ContaCorrente(decimal val, string nome)
        {
            saldo = val;
            this.nome = nome;
        }

        public string name
        {
            get { return nome; }
        }
        public DateTime data
        {
            get { return date; }
        }

        public void Depositar(decimal val)
        {
            saldo = saldo + val;
            cont++;
        }
        public void Sacar(decimal val)
        {
            saldo = saldo - val;
            cont++;
        }
        public decimal Saldo
        {
            get { return saldo; }
        }
        public decimal saldomedio
        {
            get { return saldo/cont; }
        }
    }
}