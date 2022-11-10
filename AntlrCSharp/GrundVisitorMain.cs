
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
public struct GrundStackFrame {
    public string name;
    public Dictionary<string, object?> variables {get;}
    public bool inherit = false;

    public GrundStackFrame(string name) {
        this.name = name;
        variables = new(); 
    }

}

public class GrundVisitorMain:GrundBaseVisitor<object?>
{

    private Stack<GrundStackFrame> StackFrames {get;} = new();
    private List<string> ImmutableVariables {get;} = new();
    private Dictionary<string, object?> Variables {get;} = new();
    private Dictionary<string, GrundParser.FunctionDefinitionContext> FunctionIDs {get;} = new();
    public GrundVisitorMain()
    {   
        //Math
        var ID_PI = "G_PI";
        var ID_E = "G_E";
        //FUNK NAMES BUILT IN
        var FUNC_ID_WRITE = "GF_WRITE";
        var FUNC_ID_WRITE_INLINE = "GF_WRITE_INLINE";
        //* List Functions
        var FUNC_ID_GF_LISTCREATE = "GF_LIST_CREATE";
        var FUNC_ID_GF_LISTADD = "GF_LIST_APPEND";
        var FUNC_ID_GF_LISTREPLACE = "GF_LIST_REPLACE";
        var FUNC_ID_GF_LISTREMOVE = "GF_LIST_REMOVE";
        var FUNC_ID_GF_LISTLOOKUP = "GF_LIST_LOOKUP";
        var FUNC_ID_GF_WRITE_INPUT = "GF_WRITE_INPUT";
        var FUNC_ID_GF_PARSER = "GF_PARSER";
        var FUNC_ID_GF_INDEX_CHAR = "GF_INDEX_CHAR";
        //** Important Create Variables for FunctionCallContext and Built in Math Standards
        StackFrames.Push(new GrundStackFrame("base"));
        Variables[ID_PI] = Math.PI; ImmutableVariables.Add(ID_PI);
        Variables[ID_E] = Math.E; ImmutableVariables.Add(ID_E);
        //** FunctionCall
        Variables[FUNC_ID_WRITE] = new Func<object?[], object?>(SlanderLibrary.GF_WRITE); ImmutableVariables.Add(FUNC_ID_WRITE); 
        Variables[FUNC_ID_WRITE_INLINE] = new Func<object?[], object?>(SlanderLibrary.GF_WRITE_INLINE); ImmutableVariables.Add(FUNC_ID_WRITE_INLINE); ImmutableVariables.Add(FUNC_ID_WRITE_INLINE); 
        Variables[FUNC_ID_GF_LISTCREATE] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_CREATE(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTCREATE);
        Variables[FUNC_ID_GF_LISTADD] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_APPEND(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTADD);
        Variables[FUNC_ID_GF_LISTREMOVE] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_REMOVE(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTREMOVE);
        Variables[FUNC_ID_GF_LISTREPLACE] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_REPLACE(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTREPLACE);
        Variables[FUNC_ID_GF_LISTLOOKUP] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_LOOKUP(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTLOOKUP);
        Variables[FUNC_ID_GF_WRITE_INPUT] = new Func<object?[], object?>(SlanderLibrary.GF_WRITE_INPUT); ImmutableVariables.Add(FUNC_ID_GF_WRITE_INPUT);
        Variables[FUNC_ID_GF_PARSER] = new Func<object?[], object?>(SlanderLibrary.GF_PARSER); ImmutableVariables.Add(FUNC_ID_GF_PARSER);
         Variables[FUNC_ID_GF_INDEX_CHAR] = new Func<object?[], object?>(SlanderLibrary.GF_INDEX_CHAR); ImmutableVariables.Add(FUNC_ID_GF_INDEX_CHAR);
    }


    public override object? VisitFunctionCall(GrundParser.FunctionCallContext context)
    {
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();
        if (!Variables.ContainsKey(name) && !FunctionIDs.ContainsKey(name))
        {
            throw new Exception("GRUND SAYS THE FUNCTION IS NOT DEFINED TAKE THE L"+ "The Function name is " + name);
        }
        if(FunctionIDs.ContainsKey(name))
        {
            StackFrames.Push(new GrundStackFrame(name));
            if(FunctionIDs[name].paramater() != null && context.expression() != null)
            {
                if(FunctionIDs[name].paramater().Count() != args.Count()){throw new Exception("GRUND SCREAMS, EXPECTED " + FunctionIDs[name].paramater().Count().ToString() + " PARAMETERS BUT HAD "+ args.Count().ToString() + " VALUES STUPID!");}
                for(int i = 0; i < FunctionIDs[name].paramater().Count(); i++)
                {
                        GetVariablesInCurrentStackFrame()[(FunctionIDs[name].paramater(i).GetText())] = args[i]; 
                }
            }
            Visit(FunctionIDs[name].block());
            StackFrames.Pop();
            if(Variables.ContainsKey("_return")){
            return Variables["_return"];
            }else
            {
                return null;
            }
            throw new Exception("GRUND CANNOT FIND _return IN THE FUNCTION PLEASE RETURN");
        }
        if(Variables[name] is not Func<object?[], object?> func)
        {
            throw new Exception("GRUND SAYS COMMON USE A REAL FUNCTION" + " THIS IS NOT A FUNCTION " + name);
        }else
        {
             return func(args);
        }
    }

    //** Below is the implementation if Parsing Variables
    public override object VisitAssignment([NotNull] GrundParser.AssignmentContext context)
    {
        
        var varName = context.IDENTIFIER().GetText();
        var value = Visit(context.expression());
        if(varName[0] == '_')
        {
        Variables[varName] = value;
        }
        else
        {
         GetVariablesInCurrentStackFrame()[varName] = value;
        }
        return null;
    }

    public Dictionary<string, object? > GetVariablesInCurrentStackFrame()
    {
        return StackFrames.First().variables;
    }

    public override object VisitListAccession([NotNull] GrundParser.ListAccessionContext context)
    {
         var varName = context.IDENTIFIER().GetText();
         var varIndex = Visit(context.expression());
        if(GetVariablesInCurrentStackFrame().ContainsKey(varName))
        {
            if(GetVariablesInCurrentStackFrame()[varName] is List<object?> list)
            {
               return list.ElementAt(int.Parse(varIndex.ToString()));
            }
             throw new Exception("GRUND SAYS SYNTAX ERROR: " + varName +" IS NOT LIST");
        }
        else if(Variables.ContainsKey(varName))
        {
            if(Variables[varName] is List<object?> list)
            {
               return list.ElementAt(int.Parse(varIndex.ToString()));
            }
             throw new Exception("GRUND SAYS SYNTAX ERROR: " + varName +" IS NOT LIST");
        }
        throw new Exception(" GRUND OGGA No variable defined for " + varName);
    }

    public override object VisitIdentifierExpression([NotNull] GrundParser.IdentifierExpressionContext context)
    {
        var varName = context.IDENTIFIER().GetText();

        if(GetVariablesInCurrentStackFrame().ContainsKey(varName))
        {
            return GetVariablesInCurrentStackFrame()[varName];
        }
        else if(Variables.ContainsKey(varName))
        {
            return Variables[varName];
        }

        throw new Exception(" GRUND OGGA No variable defined for " + varName);

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

    public override object VisitCollections([NotNull] GrundParser.CollectionsContext context)
    {
        if(context.list() is { } l)
        {
            return  l.expression().Select(Visit).ToList();
        }
        throw new Exception("GRUND SLAMS FIST NOT VALID COLLECTIONS");
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
            if(!FunctionIDs.ContainsKey(context.IDENTIFIER().GetText()))
            {
                 FunctionIDs.Add(context.IDENTIFIER().GetText(),context);
            }
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
    public override object VisitBooleanExpression([NotNull] GrundParser.BooleanExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));
        var op = context.boolOP().GetText();

        return true;
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
