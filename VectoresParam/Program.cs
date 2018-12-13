using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresParam
{
    class Program
    {
        const int MAX = 10;
        static void Main(string[] args)
        {
            int[] x = new int[MAX];
            string[] nombres = new string[MAX];

            leer(x);
            imprimir(x);

            ordenar(x);
            Console.WriteLine("\nVector ordenado");
            imprimir(x);

            if (buscar(x, 15))
                Console.WriteLine("\n15 encontrado");
            else
                Console.WriteLine("\n15 NO EXISTE");

            //TRABAJANDO CON EL VECTOR DE CADENAS DE CARACTERES
            Console.WriteLine("\nINGRESE LOS NOMBRES");
            leerNombres(nombres);
            imprimirNombres(nombres);

            Console.ReadKey();
        }

        public static void ordenar(int []x)
        {
            
            
            int aux = 0;
            for(int i=0; i< x.Length; i++)
               for(int j=i+1; j < (x.Length); j++)
                  if(x[i]>x[j])
                    {//intercambiar elementos del vector
                        aux = x[i];
                        x[i] = x[j];
                        x[j] = aux;
                    }
        }

        public static void leerNombres( string[] x)
        {
            for(int i=0; i<MAX; i++)
            {
                Console.WriteLine("\nIngresa el elemento {0}",i+1);
                x[i] =Console.ReadLine();
            }
        }

        public static void leer(int[] x)
        {
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine("\nIngresa el elemento {0}", i + 1);
                x[i] = Int32.Parse(Console.ReadLine());
            }
        }

        public static void imprimir(int[] x)
        {
            foreach(int num in x)
            {
                Console.WriteLine("\nElemento {0} ",num);
            }
        }

        public static void imprimirNombres(string[] x)
        {
            foreach (string num in x)
            {
                Console.WriteLine("\nElemento {0} ", num);
            }
        }

        public static bool buscar(int[] x, int y)
        {
            bool encontrado = false;
            foreach (int num in x)
            {
                if (num == y)
                {
                    encontrado = true;
                    break;
                }
            }
            return encontrado;
        }
        public static bool buscar2(int []x, int y)
        {
            bool encontrado = false;
            int i = 0;
            while(i<MAX && encontrado == false)
            {
                if (x[i] == y)
                    encontrado = true;
                i++;
            }
            return encontrado;
        }


    }
}
