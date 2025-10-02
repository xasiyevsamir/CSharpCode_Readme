namespace AbstractionProject.Models
{
    internal class ProgrammerEngineer : Engineer
    {
        public virtual string Language { get; set; }

        public sealed override string Detail()
        {
           return $"{base.Detail()}  Knowledges: ({Knowledges.FirstOrDefault()})  Language: {Language}";
        }

        public override void Work()
        {
            Console.WriteLine("ProgrammerEngineer absract methoddur");
        }
    }

    internal class FrontEnd : ProgrammerEngineer
    {
        public override string Language { get => base.Language; set => base.Language = value; }
    }

}
