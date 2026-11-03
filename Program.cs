using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso07_semana12
{
    internal class Program
    {
        static public void numero_naturales()
        {
            Console.WriteLine("Ingrese un numero de N:");
            int N = int.Parse(Console.ReadLine());
            int S = 0;
            for (int c = 1; c <= N; c++)
            {
                S = S + c;
            }
            Console.WriteLine("La suma es: " + S);
        }
        static public int sumaNN_con_recursividad(int N)
        {
            if (N == 1)
            {
                return 1;
            }
            return N + sumaNN_con_recursividad(N - 1);
        }
        static public int suma_de_pares_con_recursividad(int N)
        {
            if (N < 2)
            {
                return 0;
            }
            if (N % 2 != 0)
            {
                return suma_de_pares_con_recursividad(N - 1);
            }
            return N + suma_de_pares_con_recursividad(N - 2);
        }
        static public int factorial_con_recursividad(int N)
        {
            if (N <= 1)
            {
                return 1;
            }
            return N * factorial_con_recursividad(N - 1);
        }
        static public int exponencial_con_recursividad(int N)
        {
            if (N == 0)
            {
                return 1;
            }
            return 2 * exponencial_con_recursividad(N - 1);
        }
        static public int contador_con_recursividad(int N3)
        {
            Console.WriteLine(N3);
            if (N3 == 0)
            {
                return 0;
            }
            return contador_con_recursividad(N3 - 1);
        }
        static public void mostrar_arreglo_con_recursividad(int[] numeros, int indice)
        {
            if (indice == numeros.Length)
            {
                return;
            }
            Console.WriteLine("Posicion " + indice + ": " + numeros[indice]);
            mostrar_arreglo_con_recursividad(numeros, indice + 1);
        }
        static public int suma_arreglo_con_recursividad(int[] numeros, int indice)
        {
            if (indice == numeros.Length)
            {
                return 0;
            }
            return numeros[indice] + suma_arreglo_con_recursividad(numeros, indice + 1);
        }
        static void Main(string[] args)
        {
            int opc;
            bool valor = true;
            while (valor)
            {
                Console.Clear();
                Console.WriteLine("*******************************************************");
                Console.WriteLine("********* Menu de opciones de recursividad ************");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("[1] Suma de N numeros naturales");
                Console.WriteLine("[2] Suma de N numeros naturales con recursividad");
                Console.WriteLine("[3] Suma de N numeros pares con recursividad");
                Console.WriteLine("[4] Factorial de N con recursividad");
                Console.WriteLine("[5] Exponencial de N con recursividad");
                Console.WriteLine("[6] Contador de N con recursividad");
                Console.WriteLine("[7] Arreglos de N con recursividad");
                Console.WriteLine("[8] Salir");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Ingrese una opcion:");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        numero_naturales();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un numero de N:");
                        int N = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + sumaNN_con_recursividad(N));
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un numero de N:");
                        int n = int.Parse(Console.ReadLine());
                        Console.WriteLine("La suma es: " + suma_de_pares_con_recursividad(n));
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Ingrese un numero de N:");
                        int F = int.Parse(Console.ReadLine());
                        Console.WriteLine("El factorial es: " + factorial_con_recursividad(F));
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Ingrese un numero de E:");
                        int E = int.Parse(Console.ReadLine());
                        Console.WriteLine("El exponencial es: " + exponencial_con_recursividad(E));
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Ingrese un numero de N:");
                        int N3;
                        N3 = int.Parse(Console.ReadLine());
                        contador_con_recursividad(N3);
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine("Ingrese la cantidad de numeros:");
                        int cantidad = int.Parse(Console.ReadLine());
                        int[] numeros = new int[cantidad];
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Ingrese el numero " + (i + 1) + ":");
                            numeros[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Los numeros ingresados son:");
                        mostrar_arreglo_con_recursividad(numeros, 0);
                        Console.WriteLine("La suma de los numeros es: " + suma_arreglo_con_recursividad(numeros, 0));
                        Console.ReadKey();
                        break;
                    case 8:
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}