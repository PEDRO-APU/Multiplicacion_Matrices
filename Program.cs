using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacionMatrices
{ 
    class Matriz
    {
        private int[,] mat1;
        private int[,] mat2;
        private int[,] mat3;
        public void Ingresar(int f_m1, int c_m1, int f_m2, int c_m2)
        {
            mat1 = new int[f_m1, c_m1];
            Console.WriteLine("Primer  -  Matriz:");
            for (int fila = 0; fila < f_m1; fila++)
            {
                for (int col = 0; col < c_m1; col++)
                {
                    Console.Write("Ingrese posicion [" + (fila + 1) + "," + (col + 1) + "]: ");
                    string num;
                    num = Console.ReadLine();
                    mat1[fila, col] = int.Parse(num);
                }
            }
            mat2 = new int[f_m2, c_m2];
            Console.WriteLine("Segunda  - matriz:");
            for (int fila = 0;fila < f_m2; fila++)
            {
                for (int col = 0; col< c_m2;col++) {
                    Console.Write("Ingrese posicion [" + (fila + 1) + "," + (col + 1) + "]: ");
                    string num;
                    num = Console.ReadLine();
                    mat2[fila, col] = int.Parse(num);
                }
            }
           
            mat3 = new int[f_m1, c_m2];
            for (int fila = 0;fila < f_m1; fila++)
            {
               
                for (int col=0;col < c_m2; col++)
                {
                    mat3[fila, col] = 0;
                    for (int z = 0; z < c_m1; z++)
                    {
                        mat3[fila, col] = (mat1[fila, z] * mat2[z, col]) + mat3[fila, col];
                    }  
                  
                }
            }
           

        }

        public void Imprimir(int f, int c)
        {
            for (int fila = 0; fila < f; fila++)
            {
                for (int col = 0; col < c; col++)
                {
                    Console.Write(mat3[fila, col] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    class Program
    {       
       
        static void Main(string[] args)
        {
            Console.WriteLine("Primer matriz");
            Console.WriteLine("Cantidad filas: ");
            int f_m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad columnas");
            int c_m1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segunda matriz");
            Console.WriteLine("Cantidad filas: ");
            int f_m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad columnas");
            int c_m2 = int.Parse(Console.ReadLine());

            Matriz matrix = new Matriz();
            if (c_m1 == f_m2)
            {
                matrix.Ingresar(f_m1, c_m1, f_m2, c_m2);
                matrix.Imprimir(f_m1, c_m2);
            }           
            Console.ReadKey();


        }
    }
}
