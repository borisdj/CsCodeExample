using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Globalization;
using System.Xml.Linq;
//using System.ServiceModel.Syndication;
//using Excel = Microsoft.Office.Interop.Excel;

namespace CsCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // - LINE COMMENT

            /*
            SEGMENT COMMENT
            */

            // break point(F5, F10), refactor, search and replace, Go to def., Find all ref., (un)comment

            #region MyRegion
            // your collapsible code here
            #endregion

            #region Output
            Console.Write("OUTPUT");
            Console.WriteLine("Program is running.");

            Console.WriteLine();
            #endregion

            #region Variables
            // VARIABLES (local - must be assigned)
            // primitive(built in) type / object (value range)
            /*
            bool    / Boolean   (true, false)                   [default: false]
            int     / Int32     (+- 2,147,483,647)              [default: 0]
            long    / Int64     (+- 9,223,372,036,854,775,807)  [default: 0]
            float               (+- 3.40282347 E+38)            [default: 0]
            double              (+- 1.7976931348623157 E+308)   [default: 0]
            decimal / Decimal   (+- E+28 precision)             [default: 0]
            char    / Char                                      [default: '']
            string  / String                                    [default: null, nullable]
            var // can be any type
            */
            #endregion

            #region Naming Conventions
            /*
            local variables - nonCapitalLetter, camelCase
            Class, Function(Method - in a class) and Property name - CapitalLetter, PascalCase
            DO choose easily readable identifier names(exmample HorizontalAlignment more English-readable than AlignmentHorizontal)
            DO favor readability over brevity.
            The property name CanScrollHorizontally is better than ScrollableX (an obscure reference to the X-axis).
            DO NOT use underscores(Hungarian notation), hyphens, or any other nonalphanumeric characters.
            AVOID using identifiers that conflict with keywords of widely used programming languages.
            */
            #endregion

            #region Declaration
            // Declaration of variable (camelCase Notation)
            bool isAdmin;
            int counter;
            double sum;
            decimal number;
            char character;
            string name;

            // Assignment of variable
            isAdmin = true;
            counter = 5;
            sum = 3.14;
            number = 18.65m;
            character = 'a';

            name = "Ben Benito";

            System.Console.WriteLine("c" + counter);

            // Declaration and Assignment
            bool isActive = true;

            // Nullable
            bool? isEnded = null;
            string city = null;

            // Cast
            int inputAmount = 126;
            decimal secondAmount = inputAmount; // implicit cast
            int thirdAmount = (int)secondAmount; // explicit cast
            string strNum = "1234";
            int outputNum = int.Parse(strNum);

            System.Console.WriteLine("DECLARATION");
            System.Console.WriteLine("T of F: " + isAdmin);
            System.Console.WriteLine("Counter: " + counter);
            System.Console.WriteLine("Sum: " + sum);
            System.Console.WriteLine("Number: " + number);
            System.Console.WriteLine("Letter: " + character);
            System.Console.WriteLine("Word or Sentance: " + name);
            System.Console.WriteLine("Active: " + isActive);
            System.Console.WriteLine("Finished: " + isEnded);

            // string interpolation
            System.Console.WriteLine("City Name: " + city); // Old way to concatenate strings
            System.Console.WriteLine("City Name: {0}", city);
            System.Console.WriteLine($"City Name: {city}"); // Newest way

            System.Console.WriteLine();
            #endregion

            #region Operators
            // Arithmetic Operators
            // = + - * / %
            int x = 10, y = 6, result;
            result = x + y;

            System.Console.WriteLine("OPERATORS");
            System.Console.WriteLine("a + b = " + x + " + " + y + " = " + result);
            System.Console.WriteLine("a + b = {0} + {1} = {2}", x, y, result);

            x = x * 2;
            //x *= 2;

            x = x + 1;
            //x++;

            //x = x - 1;
            //x--;

            System.Console.WriteLine("x = x * 2 + 1 = " + x);
            System.Console.WriteLine("r = x++ = " + x++);
            System.Console.WriteLine("x= " + x);
            System.Console.WriteLine("r = ++x = " + ++x);
            System.Console.WriteLine("x = " + x);
            System.Console.WriteLine("");

            // Relation Operators
            // == !=  > >= < <=

            // Logical Operators
            // && AND
            // || OR
            // !  NOT
            #endregion

            #region Selection Statements
            System.Console.WriteLine("SELECTION STATEMENTS");
            // if, else, switch, case

            bool print = true;

            if (print)
                System.Console.WriteLine("true - ");

            print = false;

            if (print)
                System.Console.WriteLine("false - no output");

            if (!print)
                System.Console.WriteLine("not false = true - output");

            int age = 20;
            if (age > 18)
                System.Console.WriteLine("Adult");
            else
                System.Console.WriteLine("Minor");

            int value = 23; // value range 0-29
            string clause = "Value is from-to: ";

            if (value > 0 && value < 10)
                System.Console.WriteLine(clause + "0-9");
            else if (value > 10 && value < 20)
                System.Console.WriteLine(clause + "10-19");
            else if (value > 20 && value < 30)
                System.Console.WriteLine(clause + "20-29");
            else
                System.Console.WriteLine(clause + "> 30");


            int mod = value % 3;

            if (mod == 1)
                System.Console.WriteLine("Remainder 1");
            else if (mod == 2)
                System.Console.WriteLine("Remainder 2");
            else
                System.Console.WriteLine("Divisible with 3");

            switch (mod)
            {
                case 1:
                    System.Console.WriteLine("Remainder 1");
                    break;
                case 2:
                    System.Console.WriteLine("Remainder 2");
                    break;
                default:
                    System.Console.WriteLine("Divisible with 3");
                    break;
            }

            int? year = null;

            System.Console.WriteLine("Correct ?? " + (year ?? 2013)); // (??) - null coalescing operator

            year = 2012;
            System.Console.WriteLine("Correct ? :" + (year < 2013 ? "Previous year" : "Current year")); // (? :) - conditional operator, ternary

            #endregion

            #region Iteration Statements
            System.Console.WriteLine("ITERATION STATEMENTS");
            // for, while, do, foreach, in

            // Jump statements
            // break, continue, default, return, (go to)

            // Exception handling statements
            // throw, try-catch


            System.Console.Write("For loop: ");

            for (int i = 1; i <= 5; i++)
                System.Console.Write(i + " ");

            System.Console.WriteLine("");
            System.Console.Write("While a): ");
            int k = 40;
            //do
            while (k < 20)
            {
                k = k * 2;
                System.Console.Write(k + " ");
            } //while (k < 20);

            System.Console.WriteLine("");
            System.Console.Write("While b): ");
            k = 1;
            while (k < 20)
            {
                k = k * 2;
                if (k == 8)
                    break;
                System.Console.Write(k + " ");
            }

            System.Console.WriteLine("");
            System.Console.Write("While c): ");
            k = 1;
            while (k < 20)
            {
                k = k * 2;
                if (k == 8)
                    continue;
                System.Console.Write(k + " ");
            }

            System.Console.Write("\n\n");
            #endregion

            #region Arrays
            System.Console.WriteLine("ARRAYS");

            double[] fiveDayPrices = new double[5]; // fixed size;
            fiveDayPrices[0] = 3.45;
            fiveDayPrices[1] = 3.55;
            fiveDayPrices[2] = 3.58;
            fiveDayPrices[3] = 3.30;
            fiveDayPrices[4] = 3.32;

            System.Console.Write("Five day prices: ");
            for (int i = 0; i < 5; i++)
                System.Console.Write(fiveDayPrices[i] + " ");

            System.Console.Write("\nFive day prices backwards: ");
            for (int i = fiveDayPrices.Length - 1; i >= 0; i--)
                System.Console.Write(fiveDayPrices[i] + " ");

            System.Console.Write("\nForeach: ");
            foreach (var element in fiveDayPrices)
                System.Console.Write(element + " ");

            System.Console.WriteLine("");

            System.Console.WriteLine("Matrix");
            // Multidimensional arrays
            // Two-dimensional array. 
            int[,] matrix = new int[3, 3]; // fixed size;

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    System.Console.Write(matrix[i, j] + " ");

            System.Console.WriteLine();

            int[,] matrixB = new int[3, 3]; // fixed size;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    matrixB[i, j] = (i * 3) + j + 1;
                    System.Console.Write(matrixB[i, j] + " ");
                    if ((j + 1) % 3 == 0)
                        System.Console.WriteLine("");
                }

            // A similar array with string elements. 
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            // Three-dimensional array. 
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };


            System.Console.WriteLine("Dif. Matrix");
            // Array(Jagged) that can have different row size
            int[][] jaggedArray = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                jaggedArray[i] = new int[(i + 1)];
                for (int j = 0; j < (i + 1); j++)
                {
                    jaggedArray[i] = new int[(i + 1)];
                    jaggedArray[i][j] = (i * 3) + j + 1;
                    System.Console.Write(jaggedArray[i][j] + " ");
                    if ((j + 1) % (i + 1) == 0)
                        System.Console.WriteLine("");
                }
            }

            // List
            List<string> words = new List<string>();
            words.Add("one");
            words.Add("two");
            words.Add("three");
            words.Add("four");
            words.Add("five");
            words.Remove("three");

            System.Console.WriteLine("");
            foreach (var word in words)
                System.Console.Write(word + " ");

            System.Console.WriteLine("\n" + words[1]);
            System.Console.WriteLine(words.ElementAt(1));

            List<char> letters = new List<char>() { 'a', 'b', 'c' };

            foreach (var letter in letters)
                System.Console.Write(letter + " ");

            // Dictionary
            Dictionary<String, int> accounts = new Dictionary<String, int>();
            accounts.Add("Cash", 110);
            accounts.Add("Receivable", 120);
            accounts.Add("Supplies", 130);
            accounts.Add("Insurance", 150);

            int account;
            accounts.TryGetValue("Supplies", out account);

            System.Console.Write("\nSupplies account: " + account);


            List<string> sentences = new List<string>();
            sentences.Add("I am playing");
            sentences.Add("I play");
            sentences.Add("You are going");
            sentences.Add("You go");
            sentences.Add("He is running");
            sentences.Remove("He runs");

            // Lambda expresion =>
            IEnumerable<string> ingEndSentences = sentences.Where(a => a.EndsWith("ing")); // StartsWidth, Contains
            List<string> ingEndSentences2 = sentences.Where(a => a.EndsWith("ing")).ToList(); // StartsWidth, Contains

            System.Console.WriteLine("\nING:");
            foreach (var sentence in ingEndSentences2)
                System.Console.WriteLine(sentence);

            List<string> ingEndSentences3 = new List<string>();
            foreach (var sentence in sentences)
                if (sentence.EndsWith("ing"))
                    ingEndSentences3.Add(sentence);

            #endregion

            #region Parsing and Exceptions
            System.Console.WriteLine("\n\nPARSING AND EXCEPTIONS");

            string customNumStr = "324erer";
            int customNum;
            var validNum = int.TryParse(customNumStr, out customNum);
            if (validNum)
                System.Console.WriteLine(customNum);
            else
                System.Console.WriteLine("Parse Error");

            try
            {
                customNum = int.Parse(customNumStr);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Exception:\n" + ex.StackTrace + "\n");
                //throw new Exception("Exception on Parsing string to int.");
            }
            #endregion

            #region Functions
            System.Console.WriteLine("\nFUNCTIONS");
            // Access Modifiers
            //   public    - most accessible
            //   protected - in class where declared and all derived classes
            //   internal  - within files in the same assembly
            //   private   - only in class where declared

            // Output: return type(one) - [void = no return], side effects

            // Input: arguments

            // keyword static - can be called without object instantiation

            PrintText("To be printed.");
            PrintText("End.");

            decimal num1 = 12.3m;
            decimal num2 = 2.5m;
            int num3 = 3;

            decimal summary = Divide(num1, num2); // num1, num2 are Arguments - values on function call
            System.Console.WriteLine("{0} / {1} = {2}", num1, num2, summary);

            System.Console.WriteLine("{0} * {1} * {2} = {3}", num1, num2, num3, Multiple(num1, num2, num3));
            System.Console.WriteLine("{0} * {1} = {2}", num1, num2, Multiple(num1, num2));
            System.Console.WriteLine("{0} * {0} = {1}", num1, Multiple(num1));

            System.Console.WriteLine("5! = " + Fact(5)); //Recursion
            System.Console.WriteLine("6! = " + Factorial(6));

            System.Console.WriteLine("Log10(136) = " + Math.Log10(136));

            #endregion

            #region Enum
            System.Console.WriteLine("\nENUM"); // Enumerator

            Gender wordGender = Gender.Neutrum;
            Gender word2Gender = (Gender)1; // cast

            System.Console.WriteLine("word Gender: " + wordGender);
            System.Console.WriteLine("word2 Gender: " + word2Gender);
            if (wordGender == Gender.Neutrum)
            {
                System.Console.WriteLine("word Gender: " + wordGender.ToString());
                System.Console.WriteLine("word Gender Id: " + (int)wordGender);
            }

            Sex personSex = Sex.Male;
            System.Console.WriteLine("Sex: " + personSex.ToString());
            System.Console.WriteLine("Sex: " + personSex.GetDescription());

            System.Console.WriteLine("All Genders:");
            foreach (Gender gender in Enum.GetValues(typeof(Gender)))
                System.Console.WriteLine("- {0}", gender.GetDescription());


            #endregion

            #region Classes
            System.Console.WriteLine("\nCLASSES");

            decimal xReal = 2, xImag = 3;
            decimal yReal = 4, yImag = 5;
            decimal zReal, zImag;

            zReal = Add(xReal, yReal);
            zImag = Add(xImag, yImag);

            ComplexNumber xComplex = new ComplexNumber(2, 3);
            ComplexNumber yComplex = new ComplexNumber(4, 5);
            ComplexNumber zComplex = xComplex.Add(yComplex);


            // System Class
            DateTime currentDate = DateTime.Now;
            System.Console.WriteLine("DateTime.Now() = {0}", currentDate);
            System.Console.WriteLine("Date = {0} ", currentDate.ToString("dd.MM.yyyy"));
            System.Console.WriteLine("Date = {0:dd.MM.yyyy} ", currentDate);
            System.Console.WriteLine("Year = " + currentDate.Year);

            // Custom Classes
            // ComplexNumber
            System.Console.WriteLine("");
            System.Console.WriteLine(ComplexNumber.Format);
            System.Console.WriteLine(ComplexNumber.GetDescription());

            ComplexNumber complex0 = new ComplexNumber();
            complex0.Real = 1;

            ComplexNumber complex1 = new ComplexNumber(5, 3);
            double r = complex1.Real;

            ComplexNumber complex2 = new ComplexNumber();
            complex2.Real = 6;
            complex2.Imag = 7;

            ComplexNumber complex3;
            complex3 = new ComplexNumber()
            {
                Real = 4,
                Imag = 2
            };

            MoreComplexNumber complex4 = new MoreComplexNumber(4, 2);
            MoreComplexNumber complex = new MoreComplexNumber();

            ComplexNumber summation = complex1.Add(complex2).Add(complex3);
            //ComplexNumber summation2 = ComplexNumber.Add(ComplexNumber.Add(complex1, complex2), complex3);

            ComplexNumber division = complex1.Divide(complex2);

            System.Console.WriteLine("c0 = " + complex0);
            System.Console.WriteLine("c1 = " + complex1);
            System.Console.WriteLine("c2 = " + complex2.ToString());
            System.Console.WriteLine("c3 = " + complex3.ToDiffString());
            System.Console.WriteLine("c4 = " + complex4.ToDiffString());

            System.Console.WriteLine("\nsummation = " + summation.ToDiffString());
            System.Console.WriteLine("division = " + division.ToDiffString());
            System.Console.WriteLine("minus = " + new ComplexNumber(2, -5).ToDiffString());
            System.Console.WriteLine("real = " + new ComplexNumber(7, 0).ToDiffString());

            System.Console.WriteLine("c1(modul) = " + complex1.Modul());
            System.Console.WriteLine("c1 ^ 0 =" + complex1.Pow(0));
            System.Console.WriteLine("c1 ^ 1 =" + complex1.Pow(1));
            System.Console.WriteLine("c1 ^ 2 =" + complex1.Pow(2));
            System.Console.WriteLine("c1 ^ 4 =" + complex1.Pow(2));
            System.Console.WriteLine("c1 ^ (-2) =" + complex1.Pow(-2));

            List<ComplexNumber> roots = complex1.Nroot(3);
            System.Console.WriteLine("c1 ^ (1/3) = ");
            foreach (var c in roots)
                System.Console.WriteLine(c);

            // User
            User user = new User()
            {
                FirstName = "John",
                LastName = "Reacher",
                PersonSex = Sex.Male,
                BirthDate = DateTime.Parse("12/5/1987"),
                UserName = "Johnny",
                Email = "joe@gmail.com",
                Company = "Google",
                YearsOfService = 5,
                Sallary = 2000/*,
                HomeAddress = new Address()
                {
                    City = "Banjaluka",
                    Street = "Jevrejska"
                }*/
            };

            user.ResetPassword("1234abc!");

            user.HomeAddress = new Address()
            {
                City = "London",
                Street = "Baker Street"
            };

            System.Console.WriteLine("\nUSER: " + user);
            System.Console.WriteLine("Year of Birth: " + user.BirthDate.Year);
            System.Console.WriteLine("Year of Birth: " + user.HomeAddress.City);

            Square Square = new Square(4);
            System.Console.WriteLine("Square(side:4), area = " + Square.CalcArea());

            #endregion

            #region InputConsole
            System.Console.WriteLine("INPUT (console)");
            string input = null;

            while (input != "")
            {
                System.Console.Write("\nInput number:");
                input = System.Console.ReadLine();
                int inputNum;
                bool inputValid = int.TryParse(input, out inputNum);
                if (inputValid)
                    System.Console.WriteLine("Number is valid. (Press Enter to Finish)\n");
                else
                    System.Console.WriteLine("Number is not valid.(Press Enter to Finish)\n");
            }
            #endregion

            #region InputFile
            System.Console.WriteLine("INPUT (file)");
            System.Console.Write("\nInput file path(Enter for no file, 'd' for default[ComplexIn.csv]): ");

            string desktop_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//";

            string filePath = null;
            string inputFilePath = System.Console.ReadLine();
            if (inputFilePath == "d")
                inputFilePath = "ComplexIn.csv";
            if (inputFilePath != "")
                filePath = desktop_path + inputFilePath;

            string output_file = "ComplexOut.csv";
            string line = null;
            char separator = ',';

            List<ComplexNumber> complexNumbers = new List<ComplexNumber>();

            if (inputFilePath != "")
                using (StreamReader str_reader = new StreamReader(filePath))
                {
                    str_reader.ReadLine(); // skips first line as it contains names of columns
                    while ((line = str_reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(separator);
                        complexNumbers.Add(new ComplexNumber(Double.Parse(values[0]), Double.Parse(values[1])));
                    }

                    //output all objects to the file
                    string output_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    using (StreamWriter wr = new StreamWriter(desktop_path + output_file))
                    {
                        wr.WriteLine("Real,Imag");
                        foreach (var complexNumber in complexNumbers)
                            wr.WriteLine(complexNumber.ToCSV());
                    }
                }
            #endregion

            System.Console.WriteLine("Press Enter for Quit.");
            System.Console.ReadKey();
            // Don't copy code, all that is repeated should be in functions
        }

        public static decimal Add(decimal xRealOrImag, decimal yRealOrImag)
        {
            decimal zRealOrImag = xRealOrImag + yRealOrImag;
            return zRealOrImag;
        }

        public static string[] ConvertToStringArray(System.Array values)
        {
            string[] theArray = new string[values.Length];
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }
            return theArray;
        }

        public static void PrintText(string input) // Name Convention: PascalCase Notation
        {
            System.Console.WriteLine(input);
        }

        public static decimal Divide(decimal dividend, decimal divisor)
        {
            return dividend / divisor;
            // decimal result = dividend / divisor;
            // return result;
        } // dividend and divisor are Parameters, refer to names

        public static decimal Multiple(decimal m1, decimal m2, decimal m3 = 1) // optional parameters
        {
            return m1 * m2 * m3;
        }

        public static decimal Multiple(decimal m1) // Function Overloading - same function name, different number of arguments (or type)
        {
            return m1 * m1;
        }

        public static int Fact(int n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }

        ///<summary>
        ///Calculates factorial of given number
        ///</summary>
        public static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }

        public static void RunMartinGaleSimulation()
        {
            Console.WriteLine("* Martingale Simulation *");

            Random random = new Random();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int totalMoneyAmount = 2500;
            int lastMoneyAmount = 0;
            int sequenceLength = 0;
            int lastSequenceLength = 0;
            int investedMoney = 1;

            int win = 0;
            int lost = 0;

            for (int j = 0, i; j < 100; j++)
            {
                totalMoneyAmount = 2500;
                investedMoney = 1;
                sequenceLength = 0;
                dict = new Dictionary<int, int>();

                for (i = 0; i < 1000000; i++)
                {
                    int randomValue = random.Next(0, 2);
                    if (randomValue == 0) // win
                    {
                        totalMoneyAmount += investedMoney * 2;
                        investedMoney = 1;
                        sequenceLength++;
                    }
                    else // lost
                    {
                        lastMoneyAmount = totalMoneyAmount;
                        lastSequenceLength = sequenceLength;

                        totalMoneyAmount -= investedMoney;
                        investedMoney = investedMoney * 2;

                        if (sequenceLength > 0)
                        {
                            if (dict.ContainsKey(sequenceLength))
                                dict[sequenceLength]++;
                            else
                                dict.Add(sequenceLength, 1);

                            sequenceLength = 0;
                        }
                    }

                    //if(i % 100000 == 0)
                    //    Console.WriteLine(i + " = " + totalMoneyAmount);

                    if (totalMoneyAmount <= 0)
                    {
                        lost++;
                        break;
                    }
                }
                if (i == 1000000)
                    win++;
            }
            Console.WriteLine("win: " + win);
            Console.WriteLine("lost: " + lost);

            /*Console.WriteLine("SequenceLength: Occurrences");
            var list = dict.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, dict[key]);
            }*/
            Console.ReadKey();
        }
    }
}
