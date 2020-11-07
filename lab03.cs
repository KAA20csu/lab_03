using System;

namespace lab_03_my_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число диапазона:");
            double chislo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число диапазона:");
            double chislo2 = Double.Parse(Console.ReadLine());
            int MaxX = 0;
            Max(chislo, chislo2, ref MaxX);
            Console.WriteLine("Введите степень, в которую хотите возвести число:");
            double stepen = Double.Parse(Console.ReadLine());
            double chisloy = Math.Round( Math.Pow(chislo, stepen), 2);
            double chisloy2 = Math.Round(Math.Pow(chislo2, stepen), 2);
            int MaxY = 0;
            Max(chisloy, chisloy2, ref MaxY);
            OneStroka(MaxX, MaxY);
            SecondStroka(MaxX, MaxY);
            ThirdStroka(MaxX, MaxY);
            Func( chislo, chislo2, MaxX, MaxY, stepen);
        }
        static void Max(double chislo, double chislo2, ref int Max)
        {
            
            int i = 0;
            for(; chislo <= chislo2; chislo += 0.01)
            {
                if (i > 0)
                {
                    if (Convert.ToString(Math.Round(chislo, 2)).Length > Convert.ToString(Math.Round(chislo - 0.01, 2)).Length)
                    {
                        Max = 0;
                        Max = Convert.ToString(Math.Round(chislo, 2)).Length;
                        
                    }
                }
                i++;
            }
        }

        static void OneStroka(int MaxX, int MaxY)
        {
            Console.Write("|-");
            Drop(MaxX);
            Console.Write("-|-");
            Drop(MaxY);

            Console.WriteLine("-|");
            
        }
        static void Drop(int Max)
        {
            for (int i = 0; i < Max; i++)
            {
                Console.Write("-");
            }
        }
        static void SecondStroka(int MaxX, int MaxY)
        {
            Console.Write("|x");
            prob(MaxX);
            Console.Write(" | ");
            prob(MaxY);
            Console.WriteLine("y|");
        }
        static void prob(int Max)
        {
            for(int i = 0; i < Max; i++)
            {
                Console.Write(" ");
            }
        }
        static void ThirdStroka(int MaxX, int MaxY)
        {
            Console.Write("|-");
            Drop(MaxX);
            Console.Write("-|-");
            Drop(MaxY);
            Console.WriteLine("-|");
        }
        static void Func(double chislo, double chislo2, int MaxX, int MaxY, double stepen)
        {
            int i = 1;
            double y;
            for (; chislo <= chislo2; chislo += 0.01)
            {
                y = Math.Round(Math.Pow(Math.Round(chislo, 2), stepen), 2);

                tabl(MaxX, MaxY, chislo, y);
            } 

        }
        static void tabl(int MaxX, int MaxY, double chislo, double y)
        {
            Console.Write("| ");
            probel(MaxX, chislo);
            Console.Write(" | ");
            probel(MaxY, y);
            Console.WriteLine(" |");
        }
        static void probel(int Max, double chislo)
        {
            for(int i = 0; i < Max; i++)
            {
                Console.Write(" ");
            }
            Console.Write(chislo);
        }
    }
}
