using System.Reflection;
using System.Security.Cryptography;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. MethodIntro

            //MakeSalam();
            //MakeName("Elnur"); // -- argument
            //MakeName("Valeh"); // -- argument
            //Console.WriteLine(Sum(3, 5)); // -- arguments
            //Console.WriteLine(SumOrExtract(3, 7)); // -- arguments
            //Console.WriteLine(GetFristLetter("Book")); // -- argument
            //Console.WriteLine(CheckNumber(8,2)); // -- arguments




            // 2. Method params

            //Console.WriteLine(SumOfArray(21,34)); // -- arguments




            // 3. Method Default value

            //MakeFullName("Samir", "Xasiyev");   // -- arguments





            // 4. Method ref, out

            //int[] numbers = { 22,33 };
            //ChangeArrayIndex(numbers);   // -- arguments
            //Console.WriteLine(numbers[0]);

            //int number = 10;
            //Ref(ref number);             // -- argument
            //Console.WriteLine( number);


            //int number;
            //Out(out number);             // -- argument
            //Console.WriteLine(number);



            //int[] ints = new int[] { -10, 20, -5, 30 };

            //MakePositive(ref ints);                    // -- arguments
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}



            //string text = "Hello World";
            //ChangeStr(text);                   // -- argument
            //Console.WriteLine(text);



        }

        #region MethodIntro

        static void MakeSalam()
        {
            Console.WriteLine("Salam");
        }

        static void MakeName(string name) // parametr
        {
            Console.WriteLine($"Telebe adi: {name}");
        }

        //static int Sum(int a, int z) // parametrs
        //{
        //    return a + z;
        //}

        static int SumOrExtract(int num1, int num2) // parametrs
        {

            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num1 + num2;
            }
        }

        static char GetFristLetter(string name) // parametr
        {
            return name[0];
        }

        static bool CheckNumber(int r, int c) // parametr
        {
            return r > c;
        }


        #endregion

        #region Method params
        static int SumOfArray(params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        #endregion

        #region Method Default value
        static void MakeFullName(string name, string surname = "Veliyev")
        {
            Console.WriteLine(name + " " + surname);
        }
        #endregion

        #region Method Overloading ,imza
        static void Sum()
        {

        }
        static void Sum(int a)
        {

        }
        static void Sum(int a, int b)
        {

        }

        static void Sum(int a, int b, int c)
        {

        }
        static void Sum(int a, int b, int c, string d)
        {

        }

        #endregion

        #region Method ref, out

        static void ChangeArrayIndex(int[] arry) // parametrs
        {
            arry[0] = 88;
        }

        static void Ref(ref int num) // parametrs
        {
            num = 20;
        }

        static void Out(out int num) // parametrs
        {
            num = 60;
        }


        static void MakePositive(ref int[] array) // parametrs
        {
            int index = default;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > 0)
                {
                    array[index++] = array[i];
                }
                else
                {
                    array[index++] = 0;
                }
            }
        }

        static void ChangeStr(string text) // parametrs
        {
            string newtext = default;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    newtext += text[i];
                }
            }

            text = newtext;
        }
        #endregion
    }
}
