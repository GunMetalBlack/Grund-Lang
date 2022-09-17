
using Antlr4.Runtime.Misc;

public class GrundVisitorMain:GrundBaseVisitor<object?>
{
    private Dictionary<string, object?> Variables {get;} = new();
    private List<string> ImmutableVariables {get;} = new();

    public GrundVisitorMain()
    {   
        //Math
        var ID_PI = "G_PI";
        var ID_E = "G_E";
        //FUNK NAMES BUILT IN
        var FUNC_ID_WRITE = "GF_WRITE";
        //** Important Create Variables for FunctionCallContext and Built in Math Standards
        Variables[ID_PI] = Math.PI; ImmutableVariables.Add(ID_PI);
        Variables[ID_E] = Math.E; ImmutableVariables.Add(ID_E);
        //** FunctionCall
        Variables[FUNC_ID_WRITE] = new Func<object?[], object?>(GF_WRITE); ImmutableVariables.Add(FUNC_ID_WRITE); 
    }

    private object?[] GF_WRITE(object?[] args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
        return null;
    }

    public override object? VisitFunctionCall(GrundParser.FunctionCallContext context)
    {
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if (!Variables.ContainsKey(name))
        {
            throw new Exception("GRUND SAYS THE FUNCTION IS NOT DEFINED TAKE THE L"+ "The Function name is " + name);
        }

        if(Variables[name] is not Func<object?[], object?> func)
            throw new Exception("GRUND SAYS COMMON USE A REAL FUNCTION" + "THIS IS NOT A FUNCTION " + name);
            
        
         return func(args);
    }

    //** Below is the implementation if Parsing Variables
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
    //**Converts variable string to variable type 
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
        throw new Exception("GRUND STUPID CANNOT Divide}." + left.GetType() +" " + right.GetType());
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
    //* Adding for variables 
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
        
        //*Subtracting from the left and right arguments
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
    
    //* Creating FUNCTION Definitions
    public override object? VisitFunctionDefinition([NotNull] GrundParser.FunctionDefinitionContext context)
    {
        Visit(context.block());
        return null;
    }
    
    //* Function Logic calls Like If Statements and WHile loops
    public override object? VisitWhileBlock([NotNull] GrundParser.WhileBlockContext context)
    {
        Func<object?, bool> condition = context.WHILE().GetText() == "WHILE" 
        ? IsTrue 
        : IsFalse
        ;

        if(condition(Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            }while(condition(Visit(context.expression())));
        }
        else
        {
            Visit(context.elseIfBlock());
        }
        return null;
    }

    //* IF Statements
    public override object? VisitIfBlock([NotNull] GrundParser.IfBlockContext context)
    {
       Func<object?, bool> condition = context.IFBLOCK().GetText() == "WHILE" 
        ? IsTrue 
        : IsFalse
        ;

        if(condition(Visit(context.expression())))
        {
                Visit(context.block());
        }
        else
        {
            Visit(context.elseIfBlock());
        }
        return null;
    }
    public override object? VisitComparisonExpression([NotNull] GrundParser.ComparisonExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.compareOP().GetText();

        if(op == "==")
        {
            return IsEqual(left, right);
        }
        if(op == "!=")
        {
            return IsNotEqual(left, right);
        }
        if(op == ">")
        {
            return GreaterThan(left, right);
        }
        if(op == ">=")
        {
            return GreaterThanOrEqual(left, right);
        }
        if(op == "<")
        {
            return LessThan(left, right);
        }
        if(op == "<=")
        {
            return LessThanOrEqual(left, right);
        }
        throw new NotImplementedException();
    }
    private bool GreaterThanOrEqual(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l > r;
        }
        if(left is float lf && right is float rf)
        {
            return lf > rf;
        }
        if(left is int lInt && right is float rFloat)
        {
            return lInt > rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat > rInt;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    private bool GreaterThan(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l >= r;
        }
        if(left is float lf && right is float rf)
        {
            return lf >= rf;
        }
        if(left is int lInt && right is float rFloat)
        {
            return lInt >= rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat >= rInt;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    private bool LessThan(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l < r;
        }
        if(left is float lf && right is float rf)
        {
            return lf < rf;
        }
        if(left is int lInt && right is float rFloat)
        {
            return lInt < rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat < rInt;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    private bool LessThanOrEqual(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l <= r;
        }
        if(left is float lf && right is float rf)
        {
            return lf <= rf;
        }
        if(left is int lInt && right is float rFloat)
        {
            return lInt <= rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat <= rInt;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    private bool IsEqual(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l == r;
        }
        if(left is float lf && right is float rf)
        {
            return lf == rf;
        }
        if(left is int lInt && right is float rFloat)
        {
            return lInt == rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat == rInt;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    private bool IsNotEqual(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l != r;
        }
        if(left is float lf && right is float rf)
        {
            return lf != rf;
        }
        if(left is int lInt && right is float rFloat)
        {
            return lInt != rFloat;
        }
        if(left is float lfFloat && right is int rInt)
        {
            return lfFloat != rInt;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    private bool IsTrue(object? value)
    {
        if(value is bool b){
            return b;
        }
        throw new Exception("GRUND STUPID THINKS THIS IS BOOL BUT IS NOT");
    }
    public bool IsFalse(object? value) => !IsTrue(value);
}
