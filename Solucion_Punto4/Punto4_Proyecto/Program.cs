using System;

namespace Punto4_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar el algoritmo que permita iterar el ingreso de dos datos de un vehiculo, un
    color (rojo verde o amarillo) y un valor entre 0 y 10000 hasta que el usuario quiera e
    informar al terminar el ingreso por consola:
    a. La cantidad de rojos
    b. La cantidad de rojos con precio mayor a 5000
    c. La cantidad de vehículos con precio inferior a 5000
    d. El promedio de todos los vehículos ingresados.
    e. El más caro y su color.*/

            int valor , mayor=0;
            string color;
            int contentreda = 0, cont_rojo=0, cont_rojo5000=0, cont_inf=0, contotal=0;
            string resp = " " , mayor_color=" ";
            int acumvalor=0;
            bool bandera = true;

            do
            {
                Console.WriteLine("Ingrese valor (0-10000): ");
                valor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese color : (rojo-verde-amarillo): ");
                color = Console.ReadLine();

                if ((valor >= 0 && valor <= 10000) && (color == "rojo" || color == "verde" || color == "amarillo"))
                {
                    Console.WriteLine("Ingreso correctamente ...");
                    contentreda = contentreda + 1;
                }
                else
                {
                    Console.WriteLine("ERROR : en el  ingreso ... ");
                }

                if (color == "rojo" && valor>5000) {
                    cont_rojo5000 = cont_rojo5000 + 1;
                } else  if (color== "rojo")
                {
                    cont_rojo = cont_rojo + 1;
                } else if (valor<5000)
                {
                    cont_inf = cont_inf + 1;
                }


                if (bandera)
                {
                    mayor = valor;
                    mayor_color= color;
                    bandera = false;
                }
                else if (valor > mayor)
                {
                    mayor = valor;
                    mayor_color = color;
                }

                acumvalor = acumvalor + valor;
                contotal = contotal + 1;

                Console.WriteLine("Desea seguir ingresando datos:(s/S ) "+ resp);
                Console.ReadKey();
            } while (resp== "s" || resp == "S");
            
            double promedio = acumvalor / contotal;

            Console.WriteLine("La cant de rojo= "+ cont_rojo);
            Console.WriteLine("La cant de rojo mayores a 5000= " + cont_rojo5000);
            Console.WriteLine("La cant de vehiculos menores a 5000= " + cont_inf);
            Console.WriteLine("Promedio total " + promedio);
            Console.WriteLine("EL mas caro cuesta = " + mayor +" de color "+color);

            Console.ReadKey();
        }
    }
}
