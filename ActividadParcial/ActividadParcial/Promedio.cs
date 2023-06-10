using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadParcial
{
    ///Clase que gestiona el promedio
    class Promedio
    {
        //double acum;
        double[] valores;
        int cnt;

        public Promedio()
        {
            //acum = 0;
            valores = new double[100];
            cnt = 0;
        }

        public void AgregarValor(double valor)
        {
            valores[cnt] = valor;
            cnt++; 
        }
        public double CalcularPromedio()
        {
            double acum = 0;
            for (int n = 0; n < cnt; n++)
                acum += valores[n];

            double promedio = 0;
            if(cnt>0)
                promedio=acum/cnt;
            return promedio;
        }

        public int ValoresQueSuperaElPromedio(double [] valoresMayores)
        {
            double promedio = CalcularPromedio();
            int cntMayores=0;
            for (int n = 0; n < cnt; n++)
            {
                if (valores[n] > promedio)
                {
                    valoresMayores[cntMayores] = valores[n];
                    cntMayores++;
                }
            }
            return cntMayores;
        }
    }
}
