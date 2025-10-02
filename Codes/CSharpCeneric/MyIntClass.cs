namespace CSharpCeneric
{
    internal class MyIntClass
    {
        public int[] array;

        public MyIntClass()
        {
            array = new int[0];
        }

        public void Add(int value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }

        public void AddRange(int[] values)
        {
            int oldLength = array.Length;
            Array.Resize(ref array, array.Length + values.Length);
            for (int i = 0; i < values.Length; i++)
            {
                array[oldLength + i] = values[i];
            }
        }

        public void GetAll()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
