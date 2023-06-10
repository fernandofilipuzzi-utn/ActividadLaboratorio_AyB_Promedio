using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadParcial
{
    class Promedio
    {
        double acum;
        int cnt;

        public Promedio()
        {
            acum = 0;
            cnt = 0;
        }

        public void AgregarValor(double valor)
        {
            acum += valor;
            cnt++; 
        }
        public double CalcularPromedio()
        {
            double promedio = 0;
            if(cnt>0)
                promedio=acum/cnt;
            return promedio;
        }
    }
}
