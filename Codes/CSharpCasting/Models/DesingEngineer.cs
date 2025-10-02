

namespace CSharpCasting.Models
{
    internal class DesingEngineer : Engineer
    {
        public string[] Tools { get; set; }
        public override void Detail()
        {
            Console.WriteLine("desing detail");
        }
    }
}
