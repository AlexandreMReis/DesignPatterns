namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var singleResponsabilityDemo = new SingleResponsability.Demo();
            singleResponsabilityDemo.Execute();

            var openClosedPrincipleDemo = new OpenClosedPrinciple.Demo();
            openClosedPrincipleDemo.Execute();

            var lyskovSubstituitionPrincipleDemo = new LiskovSubstitutionPrinciple.Demo();
            lyskovSubstituitionPrincipleDemo.Execute();
        }
    }
}
