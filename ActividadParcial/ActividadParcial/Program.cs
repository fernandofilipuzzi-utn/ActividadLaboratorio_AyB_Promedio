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
            //instanciación clase de gestión del promedio
            Promedio p = new Promedio();

            int op;
            do 
            {
                #region pantalla de menú
                Console.WriteLine("\t\tCálculo del promedio");
                Console.WriteLine("1- Ingresar valor");
                Console.WriteLine("2- Calcular y Mostrar promedio");
                Console.WriteLine("3- Listar valores que superan al promedio");
                Console.WriteLine("Otro- Salir");
                op = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region procesando las demás pantallas
                switch (op)
                {
                    case 1:
                        {
                            #region pantalla de ingreso de datos

                            Console.WriteLine("Ingrese el valor");
                            int valor = Convert.ToInt32( Console.ReadLine() );
                            p.AgregarValor(valor);

                            Console.WriteLine("Presione cualquier tecla para volver al menú.");
                            Console.ReadKey();

                            #endregion
                        }
                        break;
                    case 2:
                        {
                            #region pantalla para mostrar datos
                            
                            double promedio = p.CalcularPromedio();
                            Console.WriteLine("El promedio es {0:f2}", promedio);

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
