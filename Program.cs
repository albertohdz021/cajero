using System;

namespace cajero_automatico
{
    public class cajero
    {
        int saldo;
        public static void Main()
        {
            Console.WriteLine("Cajero automático");
            Console.WriteLine("");
            Console.WriteLine("Seleccione su banco:");
            Console.WriteLine("");
            Console.WriteLine("1 = FDP INVERSMENTS");
            Console.WriteLine("2 =  Otros");

            int x = Convert.ToInt32(Console.ReadLine());
            int y;

            do
            {
                switch (x)
                {
                    case 1:
                        int saldo = 20000;
                        Console.WriteLine("");
                        Console.WriteLine("Bienvenido a FDP INVERSMENTS");
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el monto a retirar:");
                        int monto = Convert.ToInt32(Console.ReadLine());

                        y = 0;
                        break;

                    case 2:
                        int saldo2 = 10000;
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el monto a retirar:");
                        int monto2 = Convert.ToInt32(Console.ReadLine());

                        y = 2;
                        break;

                    default:
                        Console.WriteLine("Esta opción no existe");
                        y = 0;
                        break;



                }

            } while (y > 2);

            Console.ReadKey();
        }
        public int retiro(int cantidad)
        {
            if (saldo <= cantidad)
            {
                Console.WriteLine("Transacción invalida. Fondos insuficientes");
                Console.WriteLine("");
                return saldo;

            }
            else
            {
                Console.WriteLine("Se ha retirado la cantidad de: " + cantidad);
                saldo = saldo - cantidad;
                Console.WriteLine("Su saldo actual es de " + saldo + "$");
                Console.WriteLine("");
                return saldo;


            }
            Console.ReadKey();

        }


    }

}
