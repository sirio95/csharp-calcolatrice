using NPOI.SS.Formula.Functions;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Somma di 2 e 3: {CalcoliHelper.SommaInt(2, 3)}");
            Console.WriteLine($"Somma di 2.32 e 3.50: {CalcoliHelper.SommaDouble(2.32, 3.50)}");
            Console.WriteLine($"Differenza di 12345 e 5436: {CalcoliHelper.Differenza(12345, 5436)}");
            Console.WriteLine($"Differenza di 1298.765 e 564.875: {CalcoliHelper.DifferenzaDouble(1298.765, 564.875)}");
            Console.WriteLine($"Moltiplicazione di 1324 e 765: {CalcoliHelper.Moltiplicazione(1234, 765)}");
            Console.WriteLine($"Moltiplicazione di 12.987 e 67.453: {CalcoliHelper.MoltiplicazioneDouble(12.987, 67.543)}");
            Console.WriteLine($"Valore assoluto di -158: {CalcoliHelper.ValoreAssolutoInt(-158)}");
            Console.WriteLine($"Valore assoluto di -58.9874: {CalcoliHelper.ValoreAssolutoDouble(-58.9874)}");
            Console.WriteLine($"Minimo tra 564 e 561: {CalcoliHelper.MinimoInt(564, 561)}");
            Console.WriteLine($"Minimo tra 12.34562 e 12.9856: {CalcoliHelper.MassimoDouble(12.34562, 12.9856)}");
            Console.WriteLine($"Massimo tra 876 e 954: {CalcoliHelper.MassimoInt(876, 954)}");
            Console.WriteLine($"Massimo tra 16.45372 e 16.87435: {CalcoliHelper.MassimoDouble(16.45372, 16.87435)}");
            Console.WriteLine($"2 alla potenza di 15: {CalcoliHelper.Potenze(2, 15)}");


            
            
            
        }

        public static class CalcoliHelper
        {
            public static int SommaInt(int num1, int num2)
            {
                return num1 + num2;
            }

            public static double SommaDouble(double num1, double num2)
            {
                return num1 + num2;
            }

            public static int Differenza(int num1, int num2)
            {
                if(num1>num2) { return num1 - num2; }
                else { return num2 - num1; }
            }
            public static double DifferenzaDouble(double num1, double num2)
            {
                if (num1 > num2) { return (double)num1 - (double)num2; }
                else { return (double)num2 - (double)num1; }
            }
            public static int Moltiplicazione(int num1, int num2)
            {
                return num1 * num2;
            }
            public static double MoltiplicazioneDouble(double num1, double num2)
            {
                return num1 * num2;
            }
            public static int ValoreAssolutoInt(int num1) { return Math.Abs(num1); }
            public static double ValoreAssolutoDouble(double num1) { return Math.Abs((double)num1); }

            public static int MinimoInt(int num1, int num2)
            {
                if (num1 > num2) { return num2; }
                else if (num1 < num2) { return num1; }
                else 
                {
                    throw new ArgumentException($"{num1} e {num2} sono uguali"); 
                }
            }
            public static double MinimoDouble(double num1, double num2)
            {
                if(num1 > num2) { return (double)num2; }
                else if (num1 < num2) { return (double)num1; }
                else throw new ArgumentException($"{num1} e {num2} sono uguali");
            }
            public static int MassimoInt(int num1, int num2)
            {
                if (num1 > num2) { return num1; }
                else if (num1 < num2) { return num2; }
                else
                {
                    throw new ArgumentException($"{num1} e {num2} sono uguali");
                }
            }
            public static double MassimoDouble(double num1, double num2)
            {
                if (num1 > num2) { return (double)num1; }
                else if (num1 < num2) { return (double)num2; }
                else throw new ArgumentException($"{num1} e {num2} sono uguali");
            }
            public static long Potenze(int numBase, int numEsponente)
            {
                if (numBase == 0)
                    return 0;
                else if (numEsponente == 0 || numBase == 1)
                    return 1;
                else if (numBase == 0 && numEsponente == 0)
                    throw new ArgumentException($"{numBase} elevato a {numEsponente} non è definito");
                else
                {
                    var potenza = 1;
                    for (long i = 0; i < numEsponente; i++)
                        potenza *= numBase;
                    return potenza;
                }                
            }


        }
    }
}