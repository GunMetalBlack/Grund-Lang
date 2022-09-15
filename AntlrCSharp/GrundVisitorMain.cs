
using Antlr4.Runtime.Misc;

public class GrundVisitorMain:GrundBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables {get;} = new();

    public override object VisitAssignment([NotNull] GrundParser.AssignmentContext context)
    {
        var varName = context.IDENTIFIER().GetText();

        var value = Visit(context.expression());

        Variables[varName] = value;

        return null;
    }

    public override object VisitIdentifierExpression([NotNull] GrundParser.IdentifierExpressionContext context)
    {
        var varName = context.IDENTIFIER().GetText();

        if(!Variables.ContainsKey(varName))
        {
            throw new Exception(" GRUND OGGA No variable defined for " + varName);
        }
        return Variables[varName];
    }

    public override object VisitConstant([NotNull] GrundParser.ConstantContext context)
    {
        if(context.INTEGER() is { } i)
        {
            return int.Parse(i.GetText());
        }
        if(context.FLOAT() is { } f)
        {
            return float.Parse(f.GetText());
        }
        if(context.STRING() is { } s)
        {
            return s.GetText()[1..^1];
        }
        if(context.BOOL() is { } b) {
            return b.GetText() == "true";
        }
        if(context.NULL() is { }){
            return null;
        }

        throw new NotImplementedException();
    }

}