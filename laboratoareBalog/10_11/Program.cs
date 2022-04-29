using System;

namespace _10_11
{
    internal class Program
    {
        static void Main()
        {
           

        }
    }
}




/*class Program // exemplu simplu, NU SE UTILIZEZA using System; -----> Ex1 
{
    static void Main(string[] args) // svm + Tab + Tab 
    {
        System.Console.WriteLine("exemplu simplu"); // returneaza stringul "exemplu simplu"
    }
}*/


/*using System; // se utilizeza "libraria" System -----> Ex2 
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!"); // returneaza stringul "Hello World"
    }
}*/


/*using System; -----> Ex3

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!"); // "Console." este o CLASA 
        }
    }
}
*/


// #1 ConsoleApp | instructions: for running the program copy-paste it in the main method 
/*// write an int with Console.WriteLine
int valueInt = 4;
Console.WriteLine(valueInt);

// write a string with the method
string valueString = "Your string";
Console.WriteLine(valueString);

// write a bool with the method
bool valueBool = false;
Console.WriteLine(valueBool);

// Output:
4
Your string
False
*/


/*// #2 ConsoleApp | this program uses no arguments ---> "static void Main(){}"
Console.WriteLine("A");
Console.WriteLine(); // empty line
Console.WriteLine("B");

Output: 
A

B
*/


/*// #3 ConsoleApp | program care utilizeaza concatenarea & WriteLine 
string name = "USER";
int id = 100;
// a string is created before WriteLine is called 
Console.WriteLine(name + ": " + id);

// Output:
USER: 100
*/


/*// #4 ConsoleApp | Write & WriteLine 
string name = "USER";
int id = 100;
// write 3 parts to the same line 
Console.Write(name);
Console.Write(": ");
Console.WriteLine(id);

//Output: 
USER: 100;
*/


/*// #5 ConsoleApp | tiparirea sirului concatenat folosind sir formatat 
  // this program uses Console.WriteLine with format strings
string value1 = "Dot";
string value2 = "Net";
string value3 = "Perls";
Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);

//Output:
Dot, Net, Perls
*/


/*// #6 ConsoleApp | sum of 2 integers 
int firstNumber = 5, secondNumber = 10, result;
result = firstNumber + secondNumber;
Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);

// Output: 
5 + 10 = 15;
*/


/*// #7 ConsoleApp | Citirea unui sir de la tastatura
string testString; // string = sir de caractere 
Console.Write("Enter a string: ");
testString = Console.ReadLine();
Console.WriteLine("You entered '{0}' ", testString);

// Output:
stringulIntrodus
*/


/*// #8 ConsoleApp | Read() & ReadKey()
int userInput;

Console.WriteLine("Press any key to continue...");
Console.ReadKey(); // Read & ReadKey sunt metode ce apartin de clasa "Console"
Console.WriteLine();

Console.Write("Input using Read() - ");
userInput = Console.Read();
Console.WriteLine("ASCII value = {0}", userInput); // se afiseaza valoarea ASCII a primei litere din string 
// pentru stringul "labrador" => l = 108 (ASCII) 

// Output: 
108
*/

/*// #9 ConsoleApp | valori numerice

string userInput;
int intVal;
double doubleVal;

// se utilizeza clasa Convert

Console.Write("Enter integer value: ");
userInput = Console.ReadLine();
// Converts to inger type 
intVal = Convert.ToInt32(userInput);
Console.WriteLine("You entered {0}", intVal);

Console.Write("Enter double value: ");
userInput = Console.ReadLine();
// Converts to double type 
doubleVal = Convert.ToDouble(userInput);
Console.WriteLine("You entered {0}", doubleVal);

// for int 15 and double 10.3 

// Output: 
15 10.3 
*/


/*// #10 ConsoleApp | Sum of 2 integers
 
Console.WriteLine("Write the first integer: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the second integer: ");
int second = Convert.ToInt32(Console.ReadLine());
int result = first + second;
Console.WriteLine($"The result is {result}");
Console.ReadKey();

// for first = 123 & second = 456 

// Output: 
579
*/


/*// #11 ConsoleApp | Parse Method ---> Multiplication of a & b 

float a, b, p;

Console.WriteLine("a: ");
a = float.Parse(Console.ReadLine());

Console.WriteLine("b: ");
b = float.Parse(Console.ReadLine());

p = a * b;

Console.WriteLine("{0} * {1} = {2}", a, b, p);

// for a = 3 and b = 10

// Output:
30
*/


/*// #12 ConsoleApp | Aria cerc

float r;
const float pi = 3.14159F; // "F" = float;

Console.WriteLine("Enter radius of circle");
r = float.Parse(Console.ReadLine()); // (raza cercului)
float a = pi * r * r; // pi * r^2 (formula matematica)
Console.WriteLine("Area is : = {0} ", a);

// for radius = 5

// Output: 
78.53975

*/