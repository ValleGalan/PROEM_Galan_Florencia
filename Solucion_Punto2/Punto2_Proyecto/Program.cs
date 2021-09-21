using System;

namespace Punto2_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
  Una empresa de viajes le solicita ingresar que continente le gustaría visitar y la
cantidad de días , la oferta dice que por día se cobra $100 , que se puede pagar de
todas las maneras:
a. Crear un método que valide continentes: recibe un continente y retorna true
si se trata de un continente válido (América, Asia, Europa, Africa, Oceanía).
Crear un método que valide forma de pago: recibe la forma de pago y retorna
true si se trata de una forma de pago válido (Débito, Crédito, Efectivo,
Mercado Pago, Cheque, Leliq)
b. Si es América tiene un 15% de descuento y si además paga por débito se le
agrega un 10% más de descuento
c. Si es África u Oceanía tiene un 30% de descuento y si además paga por
mercadoPago o efectivo se le agrega un 15% más de descuento
d. Si es Europa tiene un 20% de descuento y si además paga por débito se le
agrega un 15% , por mercadoPago un 10% y cualquier otro medio 5%
e. cualquier otro continente tiene un recargo del 20%
f. en cualquier continente , si paga con cheque, se recarga un 15% de
impuesto al cheque*/
            double importe=0;
            double desc = 0,aumento=0;
         
            Console.WriteLine("____________Empresa de Viajes____________");
            continentes();
            Console.WriteLine("___________________________________");
            Console.WriteLine("Ingrese un contienente: ");
            String continente = Console.ReadLine();
            bool V_valor= ValidarNombre(continente);
            Console.WriteLine(V_valor);

            Console.WriteLine("Ingrese forma de pago: ");
            String pago = Console.ReadLine();
            bool V_pago = ValidarPago(pago);
            Console.WriteLine(V_pago);

            Console.WriteLine("Ingrese la cant de dias de hospedaje: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            double cobra_pordia = cant * 100;
            Console.WriteLine("Importe neto= "+ cobra_pordia);

            if (continente=="America" && pago== "Debito"){
                desc = (cobra_pordia * 15) / 100+ (cobra_pordia * 10) / 100;
                importe = cobra_pordia - desc;
            } else if (continente == "America")
            {
                    desc = (cobra_pordia * 15) / 100;
                    importe = cobra_pordia - desc;
            } else if ((continente == "Africa" || continente == "Oceania") && (pago == "Mercado Pago" || pago == "Efectivo"))
            {
                desc = (cobra_pordia * 30) / 100 + (cobra_pordia * 15) / 100;
                importe = cobra_pordia - desc;
            } else  if (continente == "Europa" && pago == "Debito")
            {
                desc = (cobra_pordia * 20) / 100 + (cobra_pordia * 15) / 100;
                importe = cobra_pordia - desc;
            }
            else if (continente == "Europa" && pago == "Mercado Pago")
            {
                desc = (cobra_pordia * 20) / 100 + (cobra_pordia * 10) / 100;
                importe = cobra_pordia - desc;
            }
            else if (continente == "Europa")
            { //cualquier otro pago
                desc = (cobra_pordia * 20) / 100 + (cobra_pordia * 5) / 100;
                importe = cobra_pordia - desc;
            }else if (pago == "Cheque")
            {
                aumento = (cobra_pordia * 15) / 100;
                importe = cobra_pordia + aumento;
            }else if (continente != "Africa" || continente != "Europa" || continente != "Oceania" || continente != "America")
            {
                aumento = (cobra_pordia * 20) / 100;
                importe = cobra_pordia + aumento;
            }

            




            Console.WriteLine("Importe a pagar=  "+ importe +" del continente " +continente + " con forma de pago " + pago);

            Console.ReadKey();
        }
        static void continentes()
        {
            Console.WriteLine("Continentes existentes : America ,Asia,Europa,Africa,Oceania ");
            Console.WriteLine("Formas de pago : Debito, Credito, Efectivo,Mercado Pago, Cheque, Leliq");
        }
        static bool ValidarNombre(string continente)
        {
            bool valor=false;
            if (continente =="America" || continente == "Asia" || continente == "Europa" || continente == "Africa"  || continente == "Oceania")
            {
                valor = true;
 
            }
            return valor;
        }
        static bool ValidarPago(string pago)
        {
            bool valor = false;
            if (pago== "Debito" || pago == "Credito" || pago == "Efectivo" || pago == "Mercado Pago"|| pago == "Cheque" || pago == "Leliq")
            {
                valor = true;

            }
            return valor;
        }
    }
}
