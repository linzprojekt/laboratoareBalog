using System;

namespace _10_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // problema1();
            // problema2();
            // problema3();
            // problema4();
            // problema5();
            // problema6();
             problema7();
            // problema8();
            // problema9();
            // problema10();

        }

        private static void problema1() // Aria (formula lui Heron) & SemiPerimetrul unui triunghi 
        {
            float a, b, c;
            float p, S;

            Console.Write("a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("a: ");
            b = float.Parse(Console.ReadLine());

            Console.Write("a: ");
            c = float.Parse(Console.ReadLine());

            p = (a + b + c) / 2;
            S = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Semiperimetrul triunghiului este: {0} ", p); // Console.WriteLine ($"Semiperimetrul triunghiului este {p}"); 
            Console.WriteLine("Aria triunghiului este: {0} ", S);          //Console.WriteLine ($"Aria triunghiului este {S}"); ---> Varianta "Moderna" 
        }

        private static void problema2() // Inversarea valorilor a 2 numere
        {
            int a, b, x;

            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("valoarea lui a este: {0}" + "\n" + "valoarea lui b este: {1}", a,b);

            x = a;
            a = b;
            b = x;

            Console.WriteLine("a inversat cu b este: {0}" + "\n" +  "b inversat cu a este: {1}", a, b); 

        }

        private static void problema3() // Sa se exprime in secunde un numar exprimat in ore, minute & secunde 
        {
            int ore, minute, secunde;

            Console.Write("ore: ");
            ore = int.Parse(Console.ReadLine());

            Console.Write("minute: ");
            minute = int.Parse(Console.ReadLine());

            Console.Write("secunde: ");
            secunde = int.Parse(Console.ReadLine());

            int sec = ore * 3600 + minute * 60 + secunde;

            Console.WriteLine("Total secunde = {0}", sec);

        }

        private static void problema4() // Arie laterala, totala & Volum cilindru; Aria laterala =2*π*R*H ; Aria totala = Aria laterala + 2*π*R*R ; Volum = π*R*R*h
        {
            float raza, h, pi, ariaLaterala, ariaTotala, volum;
            pi = 3.1415926F;

            Console.Write("raza: ");
            raza = float.Parse(Console.ReadLine());

            Console.Write("inaltime: ");
            h = float.Parse(Console.ReadLine());

            ariaLaterala = 2 * pi * raza * h;
            ariaTotala = ariaLaterala + 2 * pi * raza * raza;
            volum = pi * raza * raza * h;

            Console.WriteLine($"Aria laterala este: {ariaLaterala}");
            Console.WriteLine($"Aria totala este: {ariaTotala}");
            Console.WriteLine($"Volum este: {volum}");
        }

        private static void problema5() // Operatori Aritmetici
        {
            int a, b;
            float a1, b1, c1, c;

            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            a1 = a;
            b1 = b;

            Console.WriteLine($"Parte intreaga a impartirii este: {a/b}");
            Console.WriteLine($"Restul impartirii este: {a%b}");
            Console.WriteLine($"Modulul sau Valoarea Absoluta este: {Math.Abs(a)} ");
            Console.WriteLine($"Radicalul este: {Math.Sqrt(a)}");

            c = a / b; // variabila c preia numai partea intreaga (catul intreg)

            c1 = a1 / b1; // variabila c1 preia partea zecimala
            Console.WriteLine($"Catul real este: {c1}");
        }


        private static void problema6() // Sa se exprime in ore, minute, secunde un numar exprimat in secunde
        {
            int ore, minute, s, secunde, diferentaSecunde;

            Console.Write("Introduceti numarul de secunde: "); 
            secunde = int.Parse(Console.ReadLine());

            ore = secunde / 3600;
            diferentaSecunde = secunde - ore * 3600;
            minute = diferentaSecunde / 60;
            s = secunde - ore * 3600 - minute * 60;

            Console.WriteLine($"orele sunt: {ore}");
            Console.WriteLine($"minutele sunt: {minute}");
            Console.WriteLine($"secundele sunt: {secunde}");

        }

        private static void problema7() // Determinati ultimile 2 CIFRE ale P dintre a & b 
        {
            int p, a, b, u, pu;

            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            p = a * b;
            Console.WriteLine($"produsul este: {p}");

            int uz = p % 100;
            u = uz % 10;
            pu = uz / 10;


            Console.WriteLine($"pu: {pu}"); // ??? 
            Console.WriteLine($"ultima cifra a produsului dintre a & b este: {u}");


        }

    }
}
