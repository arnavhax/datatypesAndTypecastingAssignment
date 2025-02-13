using System;

namespace datatypesAndTypecastingAssignment
{
    
    internal class Program
    {
        enum DaysOfWeek
        {
           
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        

        static void PrintSeparator()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string('=', 120));
            Console.ResetColor();
        }
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
            PrintSeparator();

            char character_var = 'Z';
            int ascii_of_character_var = (int)character_var;
            Console.WriteLine($"Declared and initialised character variable and typecasted it to integer to get ascii value : ");
            Console.WriteLine($"Character Variable : {character_var}");
            Console.WriteLine($"Ascii Value : {ascii_of_character_var}");

            PrintSeparator();

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

            PrintSeparator();

            //            4.Truncate a Float Value:
            //            Declare a float variable with a decimal value.
            //Convert it to an int using explicit casting.
            //Print both values and note the truncated decimal.

            float float_var = 54.213f;
            integer_var = (int)float_var;

            Console.WriteLine($"Declared and initialised float variable with decimal value and explicitly typecasted to integer to display truncation : ");
            Console.WriteLine($"Float Variable : {float_var}");
            Console.WriteLine($"Integer Variable : {integer_var}");

            PrintSeparator();

            //            5.Convert a String to an Integer:
            //            Declare a string variable with a numeric value(e.g., "100").
            //Convert it to an int using Convert.
            //Print the result.

            string string_var = "100";

            integer_var = Convert.ToInt32(string_var);

            Console.WriteLine($"Declared and initialised string variable with numeric value and converted it to integer : ");
            Console.WriteLine($"String Variable : {string_var}");
            Console.WriteLine($"Integer Variable : {integer_var}");

            PrintSeparator();

            //            6.Convert a Boolean to an Integer:
            //            Declare a bool variable(true or false).
            //Convert it to an int using Convert.
            //Print the result(true → 1, false → 0).

            bool bool_var = true;
            integer_var = Convert.ToInt32(bool_var);
            Console.WriteLine("Declared and initialised a boolean variable to TRUE and converted it to integer");
            Console.WriteLine($"boolean_variable : {bool_var}");
            Console.WriteLine($"Integer Variable : {integer_var}");

            PrintSeparator();

            //            7.Convert a String to an Integer using Parse():
            //Declare a string with a numeric value.
            //Convert it to an int using int.Parse().
            //Print the result.

            string_var = "12000";
            integer_var = int.Parse(string_var);
            Console.WriteLine("Declared and initialised a string variable to \"12000\" and converted it into integer using parse");
            Console.WriteLine($"String Variable : {string_var}");
            Console.WriteLine($"Integer Variable : {integer_var}");

            PrintSeparator();

            //            8.Handle Non - Numeric String using TryParse():
            //Declare a string variable with a non - numeric value(e.g., "ABC").
            //Try to convert it to an int using int.TryParse().
            //Print whether the conversion was successful.

            string_var = "ABC";
            bool isConversionSuccessful = int.TryParse(string_var, out integer_var);
            Console.WriteLine("Declared and initialised a string variable to \"ABC\" and tried to convert it into integer using TryParse");
            if (isConversionSuccessful) Console.WriteLine($"Conversion Successful : Integer variable is {integer_var}");
            else Console.WriteLine($"Conversion Unsuccessful : Integer variable is {integer_var}");

            PrintSeparator();

            //            9.User Input Conversion:
            //Read a number from the console as a string.
            //Convert it to double using Convert.ToDouble().
            //Multiply the number by 10 and print the result.


            Console.WriteLine("Reading a number as string from console");
            string? string_var_nullable = Console.ReadLine();
            double_var = Convert.ToDouble(string_var_nullable);
            double_var *= 10;
            Console.WriteLine($"Converted the number to double using Convert class and multiplied it by 10");
            Console.WriteLine($"Double variable :  {double_var}");

            PrintSeparator();

            //            10.Temperature Converter(Celsius to Fahrenheit):
            //Take a user input in string format for temperature in Celsius.
            //Convert it to double and apply the formula.
            //Display the converted temperature in Fahrenheit.

            Console.WriteLine("Temperature Converter(Celsius to Fahrenheit)");

            Console.WriteLine("Enter the temperature in Celsius : ");

            int temperature_in_celsius = Convert.ToInt32(Console.ReadLine());
            double temp = (double)temperature_in_celsius;

            double temperature_in_fahrenheit = (temp * 9 / 5) + 32;

            Console.WriteLine($"Temperature in Celsius : {temperature_in_celsius}");
            Console.WriteLine($"Temperature in Fahrenheit : {temperature_in_fahrenheit}");


            PrintSeparator();

            //            Task 1 : Declare and initialize variables using the
            //following data types &Print their values to the console.
            //- int, float, double, decimal string, bool

            int int_var = 10;
            float float_var1 = 10.5f;
            double double_var1 = 10.5d;
            decimal decimal_var = 10.5m;
            string string_var1 = "Hello World";
            bool bool_var1 = true;
            Console.WriteLine("Task 1 : Declare and initialize variables using the following data types & Print their values to the console.");
            Console.WriteLine($"int_var : {int_var}");
            Console.WriteLine($"float_var : {float_var1}");
            Console.WriteLine($"double_var : {double_var1}");
            Console.WriteLine($"decimal_var : {decimal_var}");
            Console.WriteLine($"string_var : {string_var1}");
            Console.WriteLine($"bool_var : {bool_var1}");
            PrintSeparator();

//            Task 2 : Print minimum, maximum and default values
//for various datatypes.

            Console.WriteLine("Task 2 : Print minimum, maximum and default values for various datatypes.");
            Console.WriteLine($"int : Min Value : {int.MinValue} Max Value : {int.MaxValue} Default Value : {default(int)}");
            Console.WriteLine($"float : Min Value : {float.MinValue} Max Value : {float.MaxValue} Default Value : {default(float)}");
            Console.WriteLine($"double : Min Value : {double.MinValue} Max Value : {double.MaxValue} Default Value : {default(double)}");
            Console.WriteLine($"decimal : Min Value : {decimal.MinValue} Max Value : {decimal.MaxValue} Default Value : {default(decimal)}");
            Console.WriteLine($"string : Default Value : {default(string)}");
            Console.WriteLine($"bool : Default Value : {default(bool)}");
            PrintSeparator();

            //            Task 3 : Difference between default values if the
            //datatypes are made nullable.

            Console.WriteLine("Task 3 : Difference between default values if the datatypes are made nullable. ");

            int int_var_not_nullable = default;
            int? int_var_nullable = default;

            float float_var_not_nullable = default;
            float? float_var_nullable = default;

            double double_var_not_nullable = default;
            double? double_var_nullable = default;

            decimal decimal_var_not_nullable = default;
            decimal? decimal_var_nullable = default;

            string string_var_not_nullable = default;
            string? string_var_nullable1 = default;
            bool bool_var_not_nullable = default;
            bool? bool_var_nullable = default;

            Console.WriteLine($"int : Not Nullable : {int_var_not_nullable} Nullable : {int_var_nullable}");
            Console.WriteLine($"float : Not Nullable : {float_var_not_nullable} Nullable : {float_var_nullable}");
            Console.WriteLine($"double : Not Nullable : {double_var_not_nullable} Nullable : {double_var_nullable}");
            Console.WriteLine($"decimal : Not Nullable : {decimal_var_not_nullable} Nullable : {decimal_var_nullable}");
            Console.WriteLine($"string : Not Nullable : {string_var_not_nullable} Nullable : {string_var_nullable1}");
            Console.WriteLine($"bool : Not Nullable : {bool_var_not_nullable} Nullable : {bool_var_nullable}");
            PrintSeparator();

            //            Task 4 : Write a program using enum to print the day of
            //week in text, if input is provided as a number.
            //Example : If input is 4, expected output is Thursday!

            Console.WriteLine("Week in text, if input is provided as a number");
            Console.WriteLine("Enter the number : ");
            if (int.TryParse(Console.ReadLine(), out int day) && day >= 1 && day <= 7)
            {
                DaysOfWeek dayOfWeek = (DaysOfWeek)day;
                Console.WriteLine($"Day of the week : {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            PrintSeparator();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to exit, All tasks complete");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;






        }
    }
}
