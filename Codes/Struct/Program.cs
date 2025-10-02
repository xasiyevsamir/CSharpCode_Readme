namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            area.Length = 10;
            area.Width = 20;
            Console.WriteLine($"Area: {area.CalculateArea()}");


            Area area1;
            area1.Length = 15;

            IArea area2 = new Area() { Length = 5, Width = 10 };
            area2.Name = "MyArea";
            
        }
    }

    interface IArea
    {
        string Name { get; set; }
        void AreaTest();
    }

    struct Area : IArea
    {
        public int Length;
        public int Width { get; set; }
        public string Name { get; set ; }

        public Area()
        {
            Length = 0;
            Width = 0;
        }
        public int CalculateArea()
        {
            return Length * Width;
        }

        public void AreaTest()
        {
           
        }
    }
}
