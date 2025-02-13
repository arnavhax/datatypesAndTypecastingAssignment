using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace datatypesAndTypecastingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Problem statements for type casting in C# 
            //              1.Convert an Integer to a Double:
            //              Declare an int variable and assign a value.
            //              Convert it to a double using implicit casting.
            //              Print both values.
            int integer_var = 583;

            double double_var = (double)integer_var;

            Console.WriteLine($"Declared and initialised integer variable and typecasted it to double : ");
            Console.WriteLine($"Integer Variable : {integer_var}");
            Console.WriteLine($"Double Variable : {double_var}");

            //            2.Convert a Character to an Integer(ASCII Value):
            //            Declare a char variable(e.g., 'A').
            //            Convert it to an int to get its ASCII value.
            //            Print the result.
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;

            char character_var = 'Z';
            int ascii_of_character_var = (int)character_var;
            Console.WriteLine($"Declared and initialised character variable and typecasted it to integer to get ascii value : ");
            Console.WriteLine($"Character Variable : {character_var}");
            Console.WriteLine($"Ascii Value : {ascii_of_character_var}");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;

            //            3.Convert a Double to an Integer:
            //            Declare a double variable with a decimal value.
            //            Explicitly cast it to an int.
            //            Print both values and observe the data loss.

            double_var = 12.22222d;
            //integer_var = (int)double_var;
            integer_var = Convert.ToInt32(double_var);
            
            Console.WriteLine($"Declared and initialised double variable with decimal value and explicitly typecasted to integer to display data loss : ");
            Console.WriteLine($"Double Variable : {double_var}");
            Console.WriteLine($"Integer Variable : {integer_var}");

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;

            //            4.Truncate a Float Value:
            //            Declare a float variable with a decimal value.
            //Convert it to an int using explicit casting.
            //Print both values and note the truncated decimal.

            float float_var = 54.213f;
            integer_var = (int)float_var;





        }
    }
}
