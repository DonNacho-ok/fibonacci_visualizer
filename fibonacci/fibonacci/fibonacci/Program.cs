using System;

namespace fibonacci
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            uint elementos = 0;
            Console.WriteLine("Bienvenido al visualizador de elementos de la serie de Fibonacci");
            Console.WriteLine("Ingrese la cantidad de elementos que quiere visualizar");
            while (elementos == 0)
            { 
                try
                {
                    elementos = uint.Parse(Console.ReadLine());
                    var ListaElementos = FiboList(elementos);
                    Console.Clear();
                    if (elementos > 0)
                    {
                        Console.WriteLine("Aquí tiene: ");
                        foreach (int numero in ListaElementos)
                        {
                            if (numero == ListaElementos[0])
                            {
                                Console.Write(numero);
                            }
                            else
                            {
                                Console.Write(", " + numero);
                            }
                        }
                    }
                    else if (elementos == 0)
                    {
                        Console.WriteLine("No queres ningun numero? weno, como quieras we.");
                        elementos = 1;
                    }
                }
                catch
                {
                    Console.WriteLine("Error, Intenta otra vez.");
                }
            }
        }


        static int[] FiboList(uint elementos)
        {
            int[] fibo = new int[1];
            if (elementos > 2)
            {
                fibo = new int[elementos];
                fibo[0] = 0;
                fibo[1] = 1;
                for (int i = 2; i < elementos; i++)
                {
                    fibo[i] = fibo[i - 1] + fibo[i - 2];
                }
            }
            else if (elementos == 2)
            {
                fibo = new int[elementos];
                fibo[0] = 0;
                fibo[1] = 1;
            }
            else if (elementos == 1)
            {
                fibo = new int[elementos];
                fibo[0] = 0;
            }
            return fibo;
        }
    }
}
