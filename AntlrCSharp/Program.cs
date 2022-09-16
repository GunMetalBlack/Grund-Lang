using Antlr4.Runtime;
var fileName = "test.GRD";

var fileContent = File.ReadAllText(fileName);
    var inputStream = new AntlrInputStream(fileContent);
        
        var grundLexer = new GrundLexer(inputStream);
        CommonTokenStream commonTokenStream = new CommonTokenStream(grundLexer);
        var grundParser = new GrundParser(commonTokenStream);
        var grundContext = grundParser.program();
        var visitor = new GrundVisitorMain();        
       
        visitor.Visit(grundContext);
        