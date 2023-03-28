using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class Program
    {
        class MainClass
        {
            public static void main(string[] args)
            {

                int a = 5;
                int b = 30;
                int c = 4;

                int suma = a + b + c;

                Console.WriteLine("la suma es" + suma);

                Console.ReadLine();
            }
        }
    }
    namespace ejecicio_basicos_DDR_2
    {
        class MainClass
        {
            public static void main(string[] args)
            {

                Console.WriteLine("yeis rodriguez");
                String nombre = Console.ReadLine();

                Console.WriteLine("bogota");
                string ciudad = Console.ReadLine();

                Console.WriteLine("hola" + nombre + "bienvedio a" + ciudad);

                Console.ReadLine();

            }
        }
    }

    namespace ejeercico_basico_DDR_3
    {
        class MainClass
        {
            public static void main(string[] args)

            {
                Console.WriteLine("escibe tu nombre ");
                string nombre = Console.ReadLine();

                Console.WriteLine("escribe tu edad ");
                string texto = Console.ReadLine();

                int edad = Convert.ToInt32(texto);

                Console.WriteLine("te llamas " + nombre + " y tienes " + edad + " años");


                Console.ReadLine();

            }
        }

    }

    namespace ejercicio_basicos_DDR_4
    {
        class MainClass
        {
            public static void main(string[] args)
            {
                Console.WriteLine("Escribeme el primer numero");
                int num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Escribeme el segundo numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 >= num2)
                {
                    Console.WriteLine("El primer numero es mayor o igual que le segundo");
                }
                else
                {
                    Console.WriteLine("El segundo numero es mayor que el primero");
                    Console.WriteLine();
                }
            }
        }
    }
}

     
        











