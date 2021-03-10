using System;

namespace Ejerc_Night_2
{
    class Program
    {
        /*Crear un programa que simule un banco que tiene 3 clientes 
        que pueden hacer depósitos y retiros. También el banco requiere 
        que al final del día calcule la cantidad de dinero que hay depositado.*/

        public static void Deposito()
        {
            int monto = 0;
            int decis = 0;
            int totalm = 0;

            Console.WriteLine("\nBienvenido al area de depositar\n");

            do
            {
                Console.WriteLine("¿Cuanto dinero desea depositar hoy en su cuenta?");
                monto = int.Parse(Console.ReadLine());
                Console.Clear(); 

                if (monto > 0)
                {  
                    totalm = totalm + monto;    
                }

                Console.WriteLine("¿Quieres hacer Otro deposito? " + "\n 1-) si" + "\n 2-) no");
                decis = int.Parse(Console.ReadLine()); 
                Console.Clear();
               
            } while (decis != 2);

            Console.WriteLine("El dia de hoy se han depositado {0} pesos", totalm);
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();
        }

        public static void Retirar()
        {
            int retirar = 0;

            Console.WriteLine("\nBienvenido al area de retirar dinero\n");

            Console.WriteLine("Cuanto Desea Retirar");
            retirar = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Usted ha Retirado {0} pesos Con Exito!", retirar);

            Console.WriteLine("");

            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string nombre;
            string [] Client = {"", "Cliente Num 1", "Cliente Num 2", "Cliente Num 3"};
            int NumClient;
            int selector = 0;
            bool loop  = true;

            Console.WriteLine("¿Cual es su nombre?");
            nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Especifique cual cliente es usted" + 
            "\n1-)Cliente Num 1" + 
            "\n2-)Cliente Num 2" + 
            "\n3-)Cliente Num 3");
            NumClient = int.Parse(Console.ReadLine());
            Console.Clear();

            while (loop == true)
            {
                Console.WriteLine("Bienvenido al Banco Las america {0}, usted es el {1}, ¿Que desea hacer hoy?", nombre, Client[NumClient]);
                Console.WriteLine("----------------------");
                Console.WriteLine("1. Depositar Dinero");
                Console.WriteLine("2. Retirar Dinero");
                Console.WriteLine("3. Salir del Banco");
                selector = int.Parse(Console.ReadLine());

                switch (selector)
                {
                    case 1:
                    Console.Clear();
                    Deposito();
                    break;
                    case 2: 
                    Console.Clear();
                    Retirar();
                    break;
                    case 3:
                    loop = false;
                    break;
                    default:
                    Console.WriteLine("Su selecion es invalidad");
                    break;
                }
                Console.Clear();
            }
            Console.WriteLine("Fin del programa");
        }
    }
}