namespace AbstractionProject.Models
{
    internal class DesingEngineer : Engineer
    {
        public string MarkUpLanguage { get; set; }


        public override string Detail()
        {
            return $"{base.Detail()}  Knowledges: ({Knowledges.FirstOrDefault()})  MarkUpLanguage: {MarkUpLanguage}";
        }




        public override void Work()
        {
            Console.WriteLine("DesingEngineer absract method");
        }
    }
}
