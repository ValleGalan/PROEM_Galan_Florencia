using System;

namespace Punto3_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar el algoritmo que permita el ingreso de 10 bolsas de alimento para
           mascotas, con los kilos (validar entre 0 y 500) , sabor validar (carne vegetales pollo)
           e informar por consola:
           a. El promedio de los kilos totales.
           b. La bolsa más liviana y su sabor
           c. La cantidad de bolsas sabor carne y el promedio de kilos de sabor carne*/

            double acum=0 , acum_carne=0;
            bool bandera=true;
            int menor=0;
            string menor_sabor=" ";
            int contador=0, contentreda=1;
            int kg;
            string sabor;

            for (int i = 0; i < 10; i++)
            {
                
                   // do {
                        Console.WriteLine("Ingrese kilos (0-500): ");
                        kg = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese sabor del alimento: (carne-vegetales-pollo): ");
                        sabor = Console.ReadLine();

                        if ((kg >= 0 && kg <= 500) && (sabor == "carne" || sabor == "vegetales" || sabor == "pollo"))
                        {
                            Console.WriteLine("Ingreso correctamente ...");
 
                        }
                        else
                        {
                            Console.WriteLine("ERROR : en el ingreso ,vuelva a ingresar... ");
                        }
                   // } while ((kg < 0 && kg > 500) && (sabor != "carne" || sabor != "vegetales" || sabor != "pollo"));

                    if (bandera)
                    {
                        menor = kg;
                        menor_sabor = sabor;
                        bandera = false;
                    }
                    else if (kg < menor)
                    {
                        menor = kg;
                        menor_sabor = sabor;
                    }

                    if (sabor == "carne" || sabor == "Carne")
                    {
                        contador = contador + 1;
                        acum_carne = acum_carne + kg;
                    }
                    acum = acum + kg;

            }
            double promedio = acum / 10;
            Console.WriteLine(" El promedio = "+ promedio);

            double promedio_carne = acum_carne / contador;
            Console.WriteLine(" El promedio = " + promedio_carne);

            Console.WriteLine(" El mas liviano = " + menor +" sabor= " + menor_sabor);


            Console.ReadKey();
        }
    }
}
