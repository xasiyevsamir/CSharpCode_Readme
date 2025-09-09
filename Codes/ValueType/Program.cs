namespace ValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "123.45";
            // string tipli dəyişən yaradılır, dəyəri "123.45"

            decimal number = decimal.Parse(str);
            // decimal.Parse → string-i decimal tipinə çevirir
            // str = "123.45" → number = 123.45

            decimal number2;
            // Yeni decimal dəyişən elan edilir

            bool success = decimal.TryParse("200.5", out number2);
            // decimal.TryParse → string-i decimal tipinə çevirməyə çalışır
            // Əgər uğurlu olarsa, number2 = 200.5 və success = true olur
            // Əgər uğursuz olarsa, success = false və number2 default dəyər alır (0.0)

            Console.WriteLine(number2);
            // Çap edir: 200.5

            Console.WriteLine(success);
            // Çap edir: True


            //string str = "123.45";
            //// string tipli dəyişən yaradılır, dəyəri "123.45"

            //double number = double.Parse(str);

            //string str = "123";
            //// string tipli dəyişən yaradılır, dəyəri "123"

            //int number = int.Parse(str);
            //// int.Parse → string-i int tipinə çevirir
            //// str = "123" → number = 123


            //string str = "123";
            //// string tipli dəyişən yaradılır, dəyəri "123"

            //byte number = byte.Parse(str);
        }
    }
}
