using System;

namespace Punto1_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir dos números por consola y mostrar el resultado:
            a. Si son iguales muestro el cuadrado del número.
            b. Si el primero es divisible por el segundo, los resto, de lo contrario muestro
            solo el resto.
            c. si el resto es mayor a 3(tres ) informar por consola.
            */
            System.Console.WriteLine("Ingrese un 1er numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingrese un 2do numero:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                int cuadrado = num1 * num1;
                System.Console.WriteLine("Cuadrado de "+num1 +" es "+ cuadrado);
            }
            else
            {
                if ( num1 % num2 ==0)
                {
                    int resta = num1 - num2;
                    System.Console.WriteLine("La resta de " + num1 +" - " +num2+ "= " + resta);
                }
                else
                {
                    int resto = num1 % num2;
                    System.Console.WriteLine("Resto= " + resto );
                    if (resto > 3)
                    {
                        System.Console.WriteLine("El resto es mayor a 3");
                    }
                }
            }
            System.Console.ReadKey();
        }
    }
}
