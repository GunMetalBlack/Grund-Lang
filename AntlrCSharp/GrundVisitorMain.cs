
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
public struct GrundStackFrame {
    public string name;
    public Dictionary<string, object?> variables {get;}
    public bool inherit = false;

    public GrundStackFrame(string name, bool inherit = false) {
        this.name = name;
        variables = new();
        this.inherit = inherit;
    }

}

public class GrundVisitorMain:GrundBaseVisitor<object?>
{

    private Stack<GrundStackFrame> StackFrames {get;} = new();
    private List<string> ImmutableVariables {get;} = new();
    private Dictionary<string, object?> Variables {get;} = new();
    public GrundVisitorMain()
    {   
        //Math
        var ID_PI = "G_PI";
        var ID_E = "G_E";
        //FUNK NAMES BUILT IN
        var FUNC_ID_WRITE = "GF_WRITE";
        //* List Functions
        var FUNC_ID_GF_LISTCREATE = "GF_LIST_CREATE";
        var FUNC_ID_GF_LISTADD = "GF_LIST_APPEND";
        var FUNC_ID_GF_LISTREPLACE = "GF_LIST_REPLACE";
        var FUNC_ID_GF_LISTREMOVE = "GF_LIST_REMOVE";
        var FUNC_ID_GF_LISTLOOKUP = "GF_LIST_LOOKUP";
        //** Important Create Variables for FunctionCallContext and Built in Math Standards
        StackFrames.Push(new GrundStackFrame("global"));
        Variables[ID_PI] = Math.PI; ImmutableVariables.Add(ID_PI);
        Variables[ID_E] = Math.E; ImmutableVariables.Add(ID_E);
        //** FunctionCall
        Variables[FUNC_ID_WRITE] = new Func<object?[], object?>(SlanderLibrary.GF_WRITE); ImmutableVariables.Add(FUNC_ID_WRITE); 
        Variables[FUNC_ID_GF_LISTCREATE] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_CREATE(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTCREATE);
        Variables[FUNC_ID_GF_LISTADD] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_APPEND(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTADD);
        Variables[FUNC_ID_GF_LISTREMOVE] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_REMOVE(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTREMOVE);
        Variables[FUNC_ID_GF_LISTREPLACE] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_REPLACE(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTREPLACE);
        Variables[FUNC_ID_GF_LISTLOOKUP] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_LOOKUP(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTLOOKUP);
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
            throw new Exception("GRUND SAYS COMMON USE A REAL FUNCTION" + " THIS IS NOT A FUNCTION " + name);
            
        
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
           return SlanderLibrary.Mul(left, right);
        }else if(op == "/")
        {
            return SlanderLibrary.Div(left, right);
        }else if(op == "%")
        {
            return SlanderLibrary.Mod(left, right);
        }
        else
        {
            throw new NotImplementedException();
        }        
    }
    public override object? VisitAdditiveExpression(GrundParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var op = context.addOP().GetText();
        if(op == "+")
        {
           return SlanderLibrary.Add(left, right);
        }else if(op == "-")
        {
            return SlanderLibrary.Sub(left, right);
        }else
        {
            throw new NotImplementedException();
        }
    }    
    //* Creating FUNCTION Definitions
    public override object? VisitFunctionDefinition([NotNull] GrundParser.FunctionDefinitionContext context)
    {
        
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
        else if(context.elseIfBlock() != null)
        {
            Visit(context.elseIfBlock());
        }
        return null;
    }

    //* IF Statements
    public override object? VisitIfBlock([NotNull] GrundParser.IfBlockContext context)
    {
       Func<object?, bool> condition = context.IFBLOCK().GetText() == "IF" 
        ? IsTrue 
        : IsFalse
        ;        
        if(condition(Visit(context.expression())))
        {
                Visit(context.block());
        }
        else if(context.elseIfBlock() != null)
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
            return SlanderLibrary.IsEqual(left, right);
        }
        if(op == "!=")
        {
            return SlanderLibrary.IsNotEqual(left, right);
        }
        if(op == ">")
        {
            return SlanderLibrary.GreaterThan(left, right);
        }
        if(op == ">=")
        {
            return SlanderLibrary.GreaterThanOrEqual(left, right);
        }
        if(op == "<")
        {
            return SlanderLibrary.LessThan(left, right);
        }
        if(op == "<=")
        {
            return SlanderLibrary.LessThanOrEqual(left, right);
        }
        throw new NotImplementedException();
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
