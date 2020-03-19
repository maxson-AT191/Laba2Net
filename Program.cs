using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2Net
{
    class CHETIROXYGOLNIK
    {
        public double X_a = -3, Y_a = 3, X_b = 5, Y_b = 3, X_c = -3, Y_c = -1, X_d = 5, Y_d = -1,side1,side2,side3,side4, dig, per, plo;

        public double GetSizeofside()
        {
            Console.WriteLine("Размер первой стороны: ");
            side1 = Math.Sqrt(Math.Pow(X_b- X_a,2)+ Math.Pow(Y_b- Y_a,2));
            Console.WriteLine(side1);
            Console.WriteLine("Размер второй стороны: ");
            side2 = Math.Sqrt(Math.Pow(X_d - X_b, 2) + Math.Pow(Y_d - Y_b, 2));
            Console.WriteLine(side2);
            Console.WriteLine("Размер третьей стороны: ");
            side3 = Math.Sqrt(Math.Pow(X_d - X_c, 2) + Math.Pow(Y_d - Y_c, 2));
            Console.WriteLine(side3);
            Console.WriteLine("Размер четвертой стороны: ");
            side4 =  Math.Sqrt(Math.Pow(X_c - X_a, 2) + Math.Pow(Y_c - Y_a, 2));
            Console.WriteLine(side4);
            return 0;
        }
        public double GetArea()
        {
            Console.WriteLine("Площадь: ");
             plo = side3 * side4;
            Console.WriteLine(plo);
            return 0;
        }
        public double GetPerimetr()
        {
            Console.WriteLine("Периметр: ");
            per = side1 + side2 + side3 + side4;
            Console.WriteLine(per);
            return 0;
        }
        public double GetDiagonal()
        {
            Console.WriteLine("Диагональ: ");
            dig = Math.Sqrt(Math.Pow(side3, 2) + Math.Pow(side4, 2));
            Console.WriteLine(dig);
            return 0;
        }
 
   
    }
    class Program
    {
        static void Main(string[] args)
        {
            CHETIROXYGOLNIK lab = new CHETIROXYGOLNIK();
            lab.GetSizeofside();
            lab.GetDiagonal();
            lab.GetPerimetr();
            lab.GetArea();
            Console.ReadKey();

        }
    }
}
