namespace String
{
    public class Program
    {
        static void Main(string[] args)
        {

           Array array= Array.CreateInstance(typeof(int),5);

            foreach(var i in array)
            {
                Console.WriteLine(i);
            }



            Type intArrayType = typeof(int[]);
            Console.WriteLine($"{intArrayType.Name} : {intArrayType.BaseType?.Name}");

            Type stringArrayType = typeof(string[]);
            Console.WriteLine($"{stringArrayType.Name} : {stringArrayType.BaseType?.Name}");

            string word = "Hello World";            
            string data= "Hello WorlD";
            string data1= "Hello WorlD";
            Console.WriteLine(data.Equals(data1, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Equals(data, data1, StringComparison.OrdinalIgnoreCase));

            int a = 0;
            a.CompareTo(word);
            Console.WriteLine(a);
            int[] ints = { 1, 2, 3 };

           
            Console.WriteLine(ints.Length);
            Console.WriteLine(ints.Rank);
            Console.WriteLine(ints[1]);
        }       
    }
}
