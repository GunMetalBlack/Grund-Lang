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
            grundParser.RemoveErrorListeners();
            grundParser.AddErrorListener(ThrowingErrorListener.INSTANCE);
            var grundContext = grundParser.program();
            var visitor = new GrundVisitorMain();        

            visitor.Visit(grundContext);
        }
    }
    public class ThrowingErrorListener : BaseErrorListener {
        
        public static ThrowingErrorListener INSTANCE = new ThrowingErrorListener();
        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e){
            throw new Exception("SYNTAX ERROR AT LINE " + line + ":" + charPositionInLine + " " + msg);
        }

        public ThrowingErrorListener() : base()
        {

        }
    }
}



