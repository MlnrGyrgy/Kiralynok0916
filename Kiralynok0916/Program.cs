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
        public void Elhelyezes(int N)
        {
            //1. Véletlen helyérték létrehozása
            //  -Random osztály [0,7]
            //  - véletlen sor, oszlop kell
            //  - elhelyezzük a 'K'-t csak akkor, 
            //  -         HA!!4négy4! üres -> #
            Random vel = new Random();
            for (int i = 0; i < N; i++)
            {
                int sor = vel.Next(0, 8);
                int oszlop = vel.Next(0, 8);
                while (tomb[sor, oszlop] == 'K')
                {
                   sor = vel.Next(0, 8);
                   oszlop = vel.Next(0, 8);
                }
                tomb[sor, oszlop] = 'K';
            }
        }
        public void FajlbaIr()
        {
            
        }
        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(tomb[i,j]+ " ");  
                }
                Console.WriteLine("");
            }
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
        public bool UresOszlop(int oszlop)
        {
            while (true)
            {
                int i = 0;
                if(tomb[oszlop, i] == 'K' && tomb[oszlop, i] != '#')
                {
                    i++;
                    return false;
                }
                else { return true; }
            }
   
        }
        public bool UresSor(int sor)
        {
            int i = 0;
            while (true)
            {
                if (tomb[sor, i] == 'K' && tomb[sor, i] != '#')
                {
                    i++;
                    return false;
                    
                }
                else { return true; }
                
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");

            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla: ");
            t.Megjelenit();
            t.Elhelyezes(15);
            Console.WriteLine();
            t.Megjelenit();
            Console.ReadKey();
        }
    }
}
