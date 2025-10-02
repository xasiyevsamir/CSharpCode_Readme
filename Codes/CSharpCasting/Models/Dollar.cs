

namespace CSharpCasting.Models
{
    internal class Dollar
    {
        public Dollar(double uSD)
        {
            USD = uSD;
        }

        public double USD { get; set; }
    }

    internal class Manat
    {
        public Manat(double aZN)
        {
            AZN = aZN;
        }

        public double AZN { get; set; }

        public static implicit operator Dollar(Manat dollar)
        {
            return new Dollar(dollar.AZN / 1.7);
        }
    }
}
