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

        public int VerCantidadValores()
        {
            return cnt;
        }
        public double VerValor(int idx)
        {
            double valor = 0;
            if (idx >= 0 && idx < cnt)
                valor = valores[idx];
            return valor;
        }
        public void OrdenarValores()
        {
            QuickSort(valores,0,cnt-1);            
        }

        private void QuickSort(double[] a, int inicio, int fin)
        {
            #region partición
            double p = a[inicio];
            int m = inicio + 1;
            int n = fin;
            double aux = 0;

            while (m <= n)
            {
                while (m <= fin && a[m] < p) m++;
                while (n > inicio && p < a[n]) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[inicio] = a[n];
            a[n] = p;
            #endregion

            if (inicio < n - 1)
                QuickSort(a, inicio, n - 1);
            if (n + 1 < fin)
                QuickSort(a, n + 1, fin);
        }

    }
}
