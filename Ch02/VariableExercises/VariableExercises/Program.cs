using System;

namespace VariableExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort int1 = 52130;
            sbyte int2 = -115;
            int int3 = 4825932;
            byte int4 = 97;
            short int5 = -10000;
            short int6 = 20000;
            byte int7 = 224;
            int int8 = 970700000;
            byte int9 = 112;
            sbyte int10 = -44;
            int int11 = -1000000;
            short int12 = 1990;
            long int13 = 123456789123456789;

            float real11 = 5;
            double real12 = 5;
            decimal real13 = 5;
            float real21 = -5.01F;
            double real22 = -5.01;
            decimal real23 = -5.01M;
            float real31 = 34.567839023F;
            double real32 = 34.567839023;
            decimal real33 = 34.567839023M;
            float real41 = 12.345F;
            double real42 = 12.345;
            decimal real43 = 12.345M;
            float real51 = 8923.1234857F;
            double real52 = 8923.1234857;
            decimal real53 = 8923.1234857M;
            float real61 = 3456.091124875956542151256683467F;
            double real62 = 3456.091124875956542151256683467;
            decimal real63 = 3456.091124875956542151256683467M;
            double real64 = 3456.091124;

            Console.WriteLine("real61 (float):   " + real61);
            Console.WriteLine("real62 (double):  " + real62);
            Console.WriteLine("real63 (decimal): " + real63);
            Console.WriteLine("real64 (double):  " + real64);
            Console.WriteLine("real61 == real62: " + (real61 == real62).ToString());

            Console.WriteLine("(decimal)real62 == real63: " + ((decimal)real62 == real63).ToString());
            bool equal = Math.Abs((decimal)real62 - real63) <= 0.000001M;
            Console.WriteLine("(decimal)real62 within 0.000001 of real63: " + equal);

            Console.WriteLine("real62 == (double)real63: " + (real62 == (double)real63).ToString());
            equal = Math.Abs(real62 - (double)real63) <= 0.000001;
            Console.WriteLine("real62 within 0.000001 of (double)real63: " + equal);

            Console.WriteLine("real62 == real64: " + (real62 == real64).ToString());
            equal = Math.Abs(real62 - real64) <= 0.000001;
            Console.WriteLine("real62 within 0.000001 of real64: " + equal);

            int hexint = 0x100;
            Console.WriteLine(hexint);

            char myChar = '\u0048';
            Console.WriteLine(myChar);

            bool isMale = true;

            string word1 = "Hello";
            string word2 = "World";
            object phrase = word1 + ", " + word2 + "!";
            string anotherPhrase = (string)phrase;
            Console.WriteLine(anotherPhrase);

            string quoteQuote = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quoteQuote);
            quoteQuote = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(quoteQuote);

            Console.WriteLine("    oo       oo     ");
            Console.WriteLine("  o    o   o    o   ");
            Console.WriteLine("o        o        o ");
            Console.WriteLine(" o               o ");
            Console.WriteLine("   o           o   ");
            Console.WriteLine("     o       o     ");
            Console.WriteLine("       o   o       ");
            Console.WriteLine("         o          ");

            int five = 5;
            int ten = 10;
            int temp = five;
            five = ten;
            ten = temp;
            Console.WriteLine("five = " + five);
            Console.WriteLine("ten = " + ten);

            Console.ReadKey();
        }
    }
}
