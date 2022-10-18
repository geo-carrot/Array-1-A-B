using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace _5857
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№1");
            int[] array = new int[20];
            Random rnd = new Random();
            for (int a = 0; a < 20; a++)
            {
                array[a] = rnd.Next(-600, 100);
            }
            int maxValue = array.Max<int>();
            int minValue = array.Min<int>();
            Console.WriteLine("max:" + " " + maxValue);
            Console.WriteLine("min:" + " " + minValue);





            Console.WriteLine("№2");
            Random r = new Random();
            int min = 0;
            int max = 1000;
            int[] A = new int[20];
            int[] B = new int[20];


            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(min, max);
                if (A[i] <= 888)
                {
                    B[i] = A[i];
                }
            }
            Array.Sort(B);
            Array.Reverse(B);
            Console.WriteLine(string.Join("\n\r", B));

           
                  
            
          
        }
    }
}