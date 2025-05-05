namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MakeSalam();
            //MakeName("Elnur"); // -- argument
            //MakeName("Valeh"); // -- argument
            //Console.WriteLine(Sum(3, 5)); // -- arguments
            //Console.WriteLine(SumOrExtract(3, 7)); // -- arguments
            //Console.WriteLine(GetFristLetter("Book")); // -- argument
            //Console.WriteLine(CheckNumber(8,2)); // -- arguments
            //Console.WriteLine(SumOfArray(21,34)); // -- params
            //MakeFullName("Samir", "Xasiyev");
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
        static void MakeFullName(string name,string surname="Veliyev")
        {
            Console.WriteLine(name+" "+surname);
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

        static void Sum(int a, int b,int c)
        {

        }
        static void Sum(int a, int b, int c,string d)
        {

        }

        #endregion

        #region Method Overloading ,imza
        //static void Sum()
        //{

        //}
        

        #endregion
    }
}
