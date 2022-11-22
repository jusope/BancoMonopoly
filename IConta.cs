using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13Poo
{
    public interface IConta
    {
        void Sacar(double valor); // usa o void pois não retorna valor, só faz a ação
        double Calcular();

    }
}
