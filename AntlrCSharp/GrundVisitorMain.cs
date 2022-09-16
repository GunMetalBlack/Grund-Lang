
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

    public override object? VisitConstant([NotNull] GrundParser.ConstantContext context)
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

    public override object VisitMultiplicativeExpression([NotNull] GrundParser.MultiplicativeExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.multOP().GetText();
        if(op == "*")
        {
           return Mul(left, right);
        }else if(op == "/")
        {
            return Div(left, right);
        }else if(op == "%")
        {
            return Mod(left, right);
        }
        else
        {
            throw new NotImplementedException();
        }        
    }

    private object? Mul(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l*r;
        }
        if(left is float lf && right is float rf)
        {
            return lf*rf;
        }
        if(left is int lInt && right is float rFloat)
        {
           return lInt*rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat*rInt;
        }
        throw new Exception("GRUND STUPID CANNOT Multiply}." + left.GetType() +" " + right.GetType());
    }
    private object? Div(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l/r;
        }
        if(left is float lf && right is float rf)
        {
            return lf/rf;
        }
        if(left is int lInt && right is float rFloat)
        {
           return lInt/rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat/rInt;
        }
        throw new Exception("GRUND STUPID CANNOT Multiply}." + left.GetType() +" " + right.GetType());
    }
    private object? Mod(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l%r;
        }
        if(left is float lf && right is float rf)
        {
            return lf%rf;
        }
        if(left is int lInt && right is float rFloat)
        {
           return lInt%rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat%rInt;
        }
        throw new Exception("GRUND STUPID CANNOT Find Mod}." + left.GetType() +" " + right.GetType());
    }

    public override object? VisitAdditiveExpression(GrundParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.addOP().GetText();
        if(op == "+")
        {
           return Add(left, right);
        }else if(op == "-")
        {
            return Sub(left, right);
        }else
        {
            throw new NotImplementedException();
        }
    }
    // Adding for variables 
    private object? Add(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l+r;
        }
        if(left is float lf && right is float rf)
        {
            return lf+rf;
        }
        if(left is int lInt && right is float rFloat)
        {
           return lInt+rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat+rInt;
        }
        if(left is string){
            return $"{left}{right}";
        }
        if(right is string || right is string){
            return $"{left}{right}";
        }
        throw new Exception("GRUND STUPID CANNOT ADD}." + left.GetType() +" " + right.GetType());
    }
        
        //Subtracting from the left and right arguments
    private object? Sub(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l-r;
        }
        if(left is float lf && right is float rf)
        {
            return lf-rf;
        }
        if(left is int lInt && right is float rFloat)
        {
           return lInt-rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat-rInt;
        }
        throw new Exception("GRUND STUPID CANNOT Subtract}." + left.GetType() +" " + right.GetType());
    }
}