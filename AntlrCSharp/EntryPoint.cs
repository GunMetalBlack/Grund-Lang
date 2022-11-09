using Antlr4.Runtime;

namespace Grund
{
    class Program
    {
        static void Main(string[] args)
        {
             string combineFileContents = "";
             foreach(string arg in args)  
            {  
                String fileToRun = arg;
                var fileName = fileToRun;
                var fileContent = File.ReadAllText(fileName);
                combineFileContents += fileContent;
            }
            var inputStream = new AntlrInputStream(combineFileContents);
            var grundLexer = new GrundLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(grundLexer);
            var grundParser = new GrundParser(commonTokenStream);
            var grundContext = grundParser.program();
            var visitor = new GrundVisitorMain();        

            visitor.Visit(grundContext);
        }
    }
}



