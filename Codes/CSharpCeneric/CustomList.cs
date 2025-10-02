

using CSharpCeneric.Models;

namespace CSharpCeneric
{
    internal class CustomList<T/*,U*/> /*where T : class,IComparable, new()*/ // bir neçə constraint eyni anda istifadə oluna bilər
        // Generic Constraints
        //  where T : class  // - yalnızca referans tipler üçün
        //  where T : struct // - yalnızca dəyər tipler üçün
        //  where T : new()  // - yalnızca boş constructor olan tiplər üçün
        //  where T : IComparable<T> // yalnızca IComparable interface-ni implement edən tiplər üçün
        //  where T : BaseClass // T yalnızca BaseClass-dan törəyən tiplər üçün
        //  where T : U // T tipi U tipinə bərabər və ya ondan törəyən tip olmalıdır
        //  Where T : notnull // T tipi null ola bilməz
        //  where T : unmanaged // T tipi unmanaged (yəni, yalnız dəyər tipləri və pointerlər) olmalıdır
        //  where T : System.Enum // T tipi yalnız enum ola bilər
    {
        public T[] array;

        public CustomList()
        {
            array = new T[0];
        }

        public void Add(T value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }

        public void AddRange(T[] values)
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
