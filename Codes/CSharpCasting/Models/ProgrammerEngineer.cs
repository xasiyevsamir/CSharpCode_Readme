

namespace CSharpCasting.Models
{
    internal class ProgrammerEngineer : Engineer
    {
        public string[] Languages { get; set; }

        public override void Detail()
        {
            Console.WriteLine("programmer detail");
        }
    }
}
