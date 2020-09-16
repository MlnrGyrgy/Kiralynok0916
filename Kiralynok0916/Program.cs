using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok0916
{
    class Tabla
    {
        char[,] tomb;
        char UresCella;
        int UresSorokSzama;
        int UresOszlopokSzama;
        public void Elhelyezes()
        {

        }
        public void FajlbaIr()
        {

        }
        public void Megjelenit()
        {

        }
        public Tabla(char ch)
        {
            tomb = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tomb[i, j] = UresCella;
                }
            }
        }
        public int UresOszlop()
        {
            return 0;
        }
        public int UresSor()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");
            Console.ReadKey();
        }
    }
}
