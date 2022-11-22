using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13Poo
{
    public class ContaCorrente : Conta, IConta // com : pode fazer ou herança ou implementação de classe
    {
        public double Limite { get; set; }
        public double Calcular()
        {
            return Saldo * 0.015;
        }

        public void Sacar(double valor)
        {
            if((Saldo+Limite)=>valor)
            {
                Saldo -= valor;
            }
        }
    }
}
