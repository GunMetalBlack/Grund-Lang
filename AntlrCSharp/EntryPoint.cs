using Antlr4.Runtime;

namespace Grund
{
    class Program
    {
        static void Main(string[] args)
        {
             foreach(string arg in args)  
            {  
              String fileToRun = arg;
              
            var fileName = fileToRun;

            var fileContent = File.ReadAllText(fileName);
            var inputStream = new AntlrInputStream(fileContent);
            var grundLexer = new GrundLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(grundLexer);
            var grundParser = new GrundParser(commonTokenStream);
            var grundContext = grundParser.program();
            var visitor = new GrundVisitorMain();        

            visitor.Visit(grundContext);
            }
        }
    }
}



