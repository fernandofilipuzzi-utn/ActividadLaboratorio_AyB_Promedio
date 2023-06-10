using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciación clase de gestión de promedio
            Promedio p = new Promedio();

            int op;
            do 
            {
                #region pantalla de menú
                Console.Clear();
                Console.WriteLine("\t\tCálculo del promedio");
                Console.WriteLine("1- Ingresar valor");
                Console.WriteLine("2- Calcular y Mostrar promedio");
                Console.WriteLine("3- Listar valores que superan al promedio");
                Console.WriteLine("4- Mostrar valores ordenados");
                Console.WriteLine("Otro- Salir");
                op = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region procesando las demás pantallas
                switch (op)
                {
                    case 1:
                        {
                            #region pantalla de ingreso de datos
                            Console.Clear();

                            Console.WriteLine("Ingrese el valor");
                            double valor = Convert.ToDouble( Console.ReadLine() );
                            p.AgregarValor(valor);

                            Console.WriteLine("Presione cualquier tecla para volver al menú.");
                            Console.ReadKey();

                            #endregion
                        }
                        break;
                    case 2:
                        {
                            #region pantalla para mostrar datos
                            Console.Clear();

                            double promedio = p.CalcularPromedio();
                            Console.WriteLine("El promedio es {0:f2}", promedio);

                            Console.WriteLine("Presione cualquier tecla para volver al menú.");
                            Console.ReadKey();

                            #endregion
                        }
                        break;
                    case 3:
                        {
                            #region pantalla para mostrar datos
                            Console.Clear();
                            Console.WriteLine("Valores que superaron el promedio: {0:f2}", p.CalcularPromedio());

                            double[] valores= new double[100];
                            int cnt = p.ValoresQueSuperaElPromedio(valores);
                            for (int n = 0; n < cnt; n++)
                            {
                                Console.Write("{0:f2} ", valores[n]);
                            }
                            Console.Write("\n");

                            Console.WriteLine("Presione cualquier tecla para volver al menú.");
                            Console.ReadKey();

                            #endregion
                        }
                        break;
                    case 4:
                        {
                            #region pantalla para mostrar valores ordenados
                            Console.Clear();
                            Console.WriteLine("Valores ordenados");

                            p.OrdenarValores();

                            for (int n = 0; n < p.VerCantidadValores(); n++)
                            {
                                Console.Write("{0:f2} ", p.VerValor(n));
                            }
                            Console.Write("\n");

                            Console.WriteLine("Presione cualquier tecla para volver al menú.");
                            Console.ReadKey();

                            #endregion
                        }
                        break;
                    default: 
                        {
                            op = 0;
                        }break;
                }
                #endregion
            } while (op>0);

            Console.ReadKey();
        }
    }
}
