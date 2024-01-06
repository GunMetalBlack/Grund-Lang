
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
using Grund;
using static Grund.GrundTypeWrapper;

public class GrundStackFrame
{
    public string name;
    // This dictionary contains all the global variables
    public Dictionary<string, GrundDynamicTypeWrapper> variables { get; }
    private bool allowImplicitDefintionOfStrukFields;

    public bool inherit = false;
    // This stack frame dictates  the inheritance and scope for the language
    public GrundStackFrame(string name, bool allowImplicitDefintionOfStrukFields = false)
    {
        this.name = name;
        this.allowImplicitDefintionOfStrukFields = allowImplicitDefintionOfStrukFields;
        variables = new();
    }

    public void setAllowImplicitDefintionOfStrukFields(bool allowImplicitDefintionOfStrukFields) {
        this.allowImplicitDefintionOfStrukFields = allowImplicitDefintionOfStrukFields;
    }

    public bool getAllowImplicitDefintionOfStrukFields() {
        return allowImplicitDefintionOfStrukFields;
    }

}

public interface IGrundStruklike
{
    GrundDynamicTypeWrapper? getMember(GrundVisitorMain instance, string name);
    string getStrukName();
}

public class GrundStrukInstance : IGrundStruklike
{
  

    public GrundStruk typeStruk;
    public Dictionary<string, GrundDynamicTypeWrapper> instanceMembers = new Dictionary<string, GrundDynamicTypeWrapper>();
    
    public GrundDynamicTypeWrapper? getMember(GrundVisitorMain context, string name)
    {
        if (instanceMembers.ContainsKey(name)) return instanceMembers[name];
        var staticMember = typeStruk.getMember(context, name);
        if (staticMember != null) return staticMember;
        if (context.GetAllowImplicitDefintionOfStrukFieldsInCurrentStackFrame())
        {
            instanceMembers[name] = new GrundDynamicTypeWrapper(null);
            return instanceMembers[name];
        }
        return null;
    }

    public string getStrukName()
    {
        return typeStruk.getStrukName();
    }

}

public class GrundStruk : IGrundStruklike
{
    public GrundStruk? parent;
    public Dictionary<string, GrundDynamicTypeWrapper> strukMembers = new Dictionary<string, GrundDynamicTypeWrapper>();
    public string name;

    public GrundStruk(GrundStruk? parent, string name)
    {
        this.parent = parent;
        this.name = name;
    }

    public GrundDynamicTypeWrapper instantiate(GrundVisitorMain gvm, GrundParser.FunctionCallExpressionContext context)
    {
        GrundStrukInstance instance = new GrundStrukInstance();
        instance.typeStruk = this;
        GrundDynamicTypeWrapper instanceWrapped = new GrundDynamicTypeWrapper(instance);
        GrundParser.FunctionDefinitionExpressionContext constructor = (GrundParser.FunctionDefinitionExpressionContext)(strukMembers["init"].value);
        gvm.ExecuteUserDefinedFunction(context, constructor, instanceWrapped, true);
        return instanceWrapped;
    }

    public GrundDynamicTypeWrapper? getMember(GrundVisitorMain context, string name)
    {
        if (strukMembers.ContainsKey(name)) return strukMembers[name];
        else if (parent != null) return parent.getMember(context, name);
        else return null;
    }

    public string getStrukName()
    {
        return this.name;
    }

}

public class GrundVisitorMain : GrundBaseVisitor<object?>
{
    public Stack<GrundStackFrame> StackFrames { get; } = new();
    public Dictionary<string, GrundDynamicTypeWrapper> Variables { get; } = new();
    public Dictionary<string, Dictionary<string, GrundDynamicTypeWrapper>> StaticStructMembers { get; } = new();
    
    public GrundVisitorMain()
    {
        // These are all the global static variables that are defined for the language
        // All functions in  Grund that are language dependent Like GF_WRITE are variables

        //Math
        var ID_PI = "G_PI";
        var ID_E = "G_E";

        //FUNK NAMES BUILT IN
        var FUNC_ID_WRITE = "GF_WRITE";
        var FUNC_ID_WRITE_INLINE = "GF_WRITE_LN";
        var FUNC_ID_GF_SLEEP = "GF_SLEEP";
        var FUNC_ID_GF_LENGTH = "GF_LENGTH";
        var FUNC_ID_GF_WRITE_INPUT = "GF_INPUT";
        var FUNC_ID_GF_GET_KEY = "GF_KEY";
        var FUNC_ID_GF_PARSER = "GF_PARSER";
        var FUNC_ID_GF_INDEX_CHAR = "GF_INDEX_CHAR";
        var FUNC_ID_GF_CLS = "GF_CLS";
        var FUNC_ID_GF_CURSOR_MOVE = "GF_CURSOR_MOVE";
        var FUNC_ID_GF_RAND = "GF_RANDOM";
        var FUNC_ID_GF_CONTAINS = "GF_CONTAINS";

        //* List Functions
        var FUNC_ID_GL_REMOVE = "GL_REMOVE";
        var FUNC_ID_GL_LIST_ADD = "GL_ADD";

        //** Important Create Variables for FunctionCallExpressionContext and Built in Math Standards
        StackFrames.Push(new GrundStackFrame("base"));
        Variables[ID_PI] = new GrundDynamicTypeWrapper(Math.PI);
        Variables[ID_E] = new GrundDynamicTypeWrapper(Math.E);

        //** FunctionCall Creation
        Variables[FUNC_ID_WRITE] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_WRITE));
        Variables[FUNC_ID_WRITE_INLINE] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_WRITE_INLINE));
        Variables[FUNC_ID_GF_SLEEP] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_SLEEP));
        Variables[FUNC_ID_GL_LIST_ADD] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_LIST_APPEND));
        Variables[FUNC_ID_GL_REMOVE] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_LIST_REMOVE));
        Variables[FUNC_ID_GF_LENGTH] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_LENGTH));
        Variables[FUNC_ID_GF_CONTAINS] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_CONTAINS));
        Variables[FUNC_ID_GF_WRITE_INPUT] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_WRITE_INPUT));
        Variables[FUNC_ID_GF_GET_KEY] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_GET_KEY));
        Variables[FUNC_ID_GF_PARSER] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_PARSER));
        Variables[FUNC_ID_GF_INDEX_CHAR] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_INDEX_CHAR));
        Variables[FUNC_ID_GF_CLS] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_CLS));
        Variables[FUNC_ID_GF_CURSOR_MOVE] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_CURSOR_MOVE));
        Variables[FUNC_ID_GF_RAND] = new GrundDynamicTypeWrapper(new Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper>(SlanderLibrary.GF_RAND));
    }

    public Dictionary<string, GrundDynamicTypeWrapper> GetVariablesInCurrentStackFrame()
    {
        return StackFrames.First().variables;
    }

    public bool GetAllowImplicitDefintionOfStrukFieldsInCurrentStackFrame()
    {
        foreach(GrundStackFrame frame in StackFrames)
        {
            if(frame.getAllowImplicitDefintionOfStrukFields()) return true;
        }
        return false;
    }

    public object? ExecuteUserDefinedFunction(GrundParser.FunctionCallExpressionContext context, GrundParser.FunctionDefinitionExpressionContext functionLookup, GrundDynamicTypeWrapper? struklike = null, bool allowImplicitDefintionOfStrukFields = false)
    {

        // Grab the function name and any expressions it has and turns into an array 
        var name = context.IDENTIFIER().GetText();
        object?[] args = context.expression().Select(Visit).ToArray();
        if (struklike != null) args = args.Prepend(struklike).ToArray();
        if (functionLookup == null)
        {
            return null;
        }
        // If we have a function then create a new scope for the function and go through each expression and adds it to the stack
        StackFrames.Push(new GrundStackFrame(name));
        StackFrames.First().setAllowImplicitDefintionOfStrukFields(allowImplicitDefintionOfStrukFields);
        if (functionLookup.parameter() != null && context.expression() != null)
        {
            //Exception for if the expression count and function args don't match.
            if (functionLookup.parameter().Count() != args.Count()) { throw new Exception("GRUND SCREAMS, EXPECTED " + ((GrundParser.FunctionDefinitionExpressionContext)(Variables[name].value)).parameter().Count().ToString() + " PARAMETERS BUT HAD " + args.Count().ToString() + " VALUES STUPID! LINE: " + context.Start.Line.ToString()); }
            for (int i = 0; i < functionLookup.parameter().Count(); i++)
            {
                GetVariablesInCurrentStackFrame()[(functionLookup.parameter(i).GetText())] = (GrundDynamicTypeWrapper)args[i];
            }
        }
        //If we do have a function call then we visit the stuff in the function!
        Visit(functionLookup.block());
        //After thats over we simply exit the current scope.
        StackFrames.Pop();
        //This is my work around for a proper return statement instead its a global variable that can be used at the end of the function
        if (Variables.ContainsKey("_return"))
        {
            return Variables["_return"];
        }
        else
        {
            return null;
        }
    }

    public override object VisitFunctionCallExpression([NotNull] GrundParser.FunctionCallExpressionContext context)
    {
        // Grab the function name and any expressions it has and turns into an array 
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).OfType<GrundDynamicTypeWrapper>().ToArray();
        // Handle scoped functions
        if (GetVariablesInCurrentStackFrame().ContainsKey(name))
        {
            object? thingBeingInvoked = GetVariablesInCurrentStackFrame()[name].value;
            // Handle user-defined functions
            {
                if (thingBeingInvoked is GrundParser.FunctionDefinitionExpressionContext functionLookup)
                {
                    return ExecuteUserDefinedFunction(context, functionLookup);
                }
                else if (thingBeingInvoked is GrundStruk strukToInstantiate)
                {
                    return strukToInstantiate.instantiate(this, context);
                }
            }
            // Handle build-in Grund functions
            if (thingBeingInvoked is Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper> func)
            {
                return func(args);
            }
        }

        // Handle global functions
        else if (Variables.ContainsKey(name))
        {
            object? thingBeingInvoked = Variables[name].value;
            // Handle user-defined functions
            {
                if (thingBeingInvoked is GrundParser.FunctionDefinitionExpressionContext functionLookup)
                {
                    return ExecuteUserDefinedFunction(context, functionLookup);
                }
                else if (thingBeingInvoked is GrundStruk strukToInstantiate)
                {
                    return strukToInstantiate.instantiate(this, context);
                }
            }
            // Handle build-in Grund functions
            if (thingBeingInvoked is Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper> func)
            {
                return func(args);
            }
        }

        // Wasn't user-defined or global - throw an exception
        throw new Exception("GRUND SAYS COMMON USE A REAL FUNCTION THIS IS NOT A FUNCTION " + name + " LINE: " + context.Start.Line.ToString());

    }

    public override object VisitAssignment([NotNull] GrundParser.AssignmentContext context)
    {   
        GrundDynamicTypeWrapper gLeft = null;
        GrundDynamicTypeWrapper gRight = null;
        try {
            gLeft = (GrundDynamicTypeWrapper)Visit(context.expression(0));
            gRight = (GrundDynamicTypeWrapper)Visit(context.expression(1));
        }
        catch(InvalidCastException exception) {
            throw new Exception("GRUND: ONE OF THE VARIABLES WASN'T WRAPPED IN A GRUND TYPE THIS IS NOT YOUR FAULT IT'S CALLED SLANDER LIBRARY FOR A REASON REEEEEEEEEEEE LINE: " + context.Start.Line.ToString());
        }

        if ((gLeft is not GrundDynamicTypeWrapper) || (gRight is not GrundDynamicTypeWrapper))
        {
            throw new Exception("GRUND SAYS ERROR: " + " assignment died somewhere not sure. LINE: " + context.Start.Line.ToString());
        }
        // If its not a list do this for everything else that needs to be assigned as a variable
        gLeft.value = gRight.value;

        return null;
    }


    public override object VisitDeclarationsExpression([NotNull] GrundParser.DeclarationsExpressionContext context)
    {
        var varName = context.declaration().IDENTIFIER().GetText();
        // todo: verify that variable doesn't already exist
        // foreach (KeyValuePair<string, GrundDynamicTypeWrapper> kv in GetVariablesInCurrentStackFrame())
        // {

        // }
        if (varName[0] == '_')
        {
            Variables[varName] = new GrundDynamicTypeWrapper(null);
            return Variables[varName];
        }
        else
        {
            GetVariablesInCurrentStackFrame()[varName] = new GrundDynamicTypeWrapper(null);
            return GetVariablesInCurrentStackFrame()[varName];
        }
    }

    public override object VisitListAccessionExpression([NotNull] GrundParser.ListAccessionExpressionContext context)
    {
        // This is how we return a value at an index for example if(x[2] < 0). x[2] should return a value
        GrundDynamicTypeWrapper gList = null;
        GrundDynamicTypeWrapper gInt = null;
        try {
            gList = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(0))).value;
            gInt = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(1))).value;
        }
        catch(InvalidCastException exception) {
            throw new Exception("GRUND: ONE OF THE VARIABLES WASN'T WRAPPED IN A GRUND TYPE THIS IS NOT YOUR FAULT IT'S CALLED SLANDER LIBRARY FOR A REASON REEEEEEEEEEEE LINE: " + context.Start.Line.ToString());
        }
        //Checks if variable is in current scope and is a list.
        if (gList.value is List<GrundDynamicTypeWrapper> list)
        {
            //If it is then we return the value at the lists index
            try
            {
                return list.ElementAt(int.Parse(gInt.value.ToString()));
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("GRUND SAYS OUT OF RANGE ERROR: " + " Learn TO COUNT. LINE: " + context.Start.Line.ToString());
            }
        }

        throw new Exception("GRUND SAYS ERROR: " + " IS NOT LIST. LINE: " + context.Start.Line.ToString());
    }

    public override object VisitThrowExpression([NotNull] GrundParser.ThrowExpressionContext context)
    {
        throw new Exception("GRUND: PROGRAM THREW INTENTIONAL EXCEPTION ON LINE " + context.Start.Line.ToString());
    }

    public override object VisitStrucDefinitionExpression([NotNull] GrundParser.StrucDefinitionExpressionContext context)
    {
        //FIXME: Fix Structs for future versions
        // Return early if there are no lines in the struct definition
        var lines = context.strucDefinition().block().line();
        if (lines == null || !lines.Any())
        {
            return null;
        }
        
        var structName = context.strucDefinition().Parent.Parent.GetChild(0).GetChild(0).GetChild(1).GetText();
        var struk = new GrundStruk(null, structName);

        foreach (var line in lines)
        {
            if (line.expression() is GrundParser.FunctionDefinitionExpressionContext functionDefinition)
            {
                // Process function definitions
                var methodName = functionDefinition.IDENTIFIER().GetText();
                GrundDynamicTypeWrapper methodValue = new GrundDynamicTypeWrapper(functionDefinition);
                struk.strukMembers.Add(methodName, methodValue);
            }
            else if (line.blockScopeAssignment() != null)
            {
                var assignmentCount = line.blockScopeAssignment().assignment();
                foreach (var assignment in assignmentCount)
                {
                    var staticFieldName = assignment.expression(0).GetText();
                    GrundDynamicTypeWrapper staticFieldValue = new GrundDynamicTypeWrapper(Visit(assignment.expression(1)));
                    struk.strukMembers.Add(staticFieldName, staticFieldValue);
                }
            }
        }

        // Check if the struct contains a constructor
        if (struk.getMember(this, "init") == null)
        {
            // Log a warning message if the struct does not contain a constructor
            throw new Exception("Grund sighs: STRUK " + " is missing constructor definition " + "Make sure the constructor has the same name as the INIT");
        }
        
        return new GrundDynamicTypeWrapper(struk);
    }


    public GrundDynamicTypeWrapper FindVariableInCurrentState(string identifier)
    {
        if (GetVariablesInCurrentStackFrame().ContainsKey(identifier)) return GetVariablesInCurrentStackFrame()[identifier];
        if (Variables.ContainsKey(identifier)) return Variables[identifier];
        return null;
    }

    public override object? VisitDotExpression([NotNull] GrundParser.DotExpressionContext context)
    {

        // a.b().c()
        // Visit LHS, make sure that it's a GrundStruk or a GrundStrukInstance
        var leftSide = context.expression(0);
        var struklikeWrapped = Visit(leftSide) as GrundDynamicTypeWrapper;
        var struklike = struklikeWrapped.value as IGrundStruklike;
        if (!(struklike is IGrundStruklike))
        {
            throw new Exception("GRUND: SCREAMS YOU FUCKED UP AND TRIED TO ACCESS THE MEMBERS OF SOMETHING THAT ISN'T A STRUK OR AN OBJECT");
        }

        // Get the RHS - it's either an identifier (member that we need to look up and return) OR it's a function call
        // that we need to invoke/visit.
        var rightSide = context.expression(1);
        // If it's an identifier, then lookup member and return it
        if (rightSide is GrundParser.IdentifierExpressionContext)
        {
            object? member = struklike.getMember(this, rightSide.GetText());
            if (member == null) throw new Exception("GRUND: YO DAWG THAT MEMBER \"" + rightSide.GetText() + "\" DOESN'T EXIST IN \"" + struklike.getStrukName() + "\" " + (struklike is GrundStruk ? "STRUK" : "STRUKINSTANCE") +", BUD!");
            return member;
        }
        // If it's a function call, then lookup member, execute it, and return its result
        else if (rightSide is GrundParser.FunctionCallExpressionContext functionCallExpression)
        {
            var functionCall = functionCallExpression;
            string functionName = functionCall.IDENTIFIER().GetText();
            object? member = struklike.getMember(this, functionName).value;
            if (!(member is GrundParser.FunctionDefinitionExpressionContext)) throw new Exception("GRUND: REEEEEEEEEEEE METHOD \"" + functionName + "\" DOES NOT EXIST FOR \"" + struklike.getStrukName() + "\" STRUKLIKE!");
            return ExecuteUserDefinedFunction(functionCall, (GrundParser.FunctionDefinitionExpressionContext)member, struklikeWrapped);
        }
        else {
            throw new Exception("GRUND: YOU MESSED UP THERE BUDDY THE RIGHT HAND SIDE OF A DOT EXPRESSION HAS TO BE AN IDENTIFIER OR A FUNCTION CALL WHAT'D YA DO");
        }
    }


    public override object VisitIdentifierExpression([NotNull] GrundParser.IdentifierExpressionContext context)
    {
        // Pretty simple, this function returns the value of the variable for example if a variable is defined as y = 4.
        // then y < 3. y by itself should be 4
        var varName = context.IDENTIFIER().GetText();
        var parentContext = context.Parent;
        // Get the parent context
        if (GetVariablesInCurrentStackFrame().ContainsKey(varName))
        {
            return GetVariablesInCurrentStackFrame()[varName];
        }
        else if (Variables.ContainsKey(varName))
        {
            return Variables[varName];
        }
        throw new Exception(" GRUND OGGA No variable defined for " + varName + " LINE: " + context.Start.Line.ToString());

    }



    public override object VisitMultiplicativeExpression([NotNull] GrundParser.MultiplicativeExpressionContext context)
    {
        var left = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(0))).value;
        var right = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(1))).value;

        var op = context.multOP().GetText();
        if (op == "*")
        {
            return SlanderLibrary.Mul(left, right);
        }
        else if (op == "/")
        {
            return SlanderLibrary.Div(left, right);
        }
        else if (op == "%")
        {
            return SlanderLibrary.Mod(left, right);
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    public override object? VisitInlineIncrementExpression(GrundParser.InlineIncrementExpressionContext context)
    {
        string op = context.inlineOP().GetText();
        GrundDynamicTypeWrapper toIncrement = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression())).value;
        if (op == "++")
        {
            if (toIncrement.value is int gInt)
            {
                toIncrement.value = gInt + 1;
            }
            else if (toIncrement.value is float gFloat)
            {
                toIncrement.value = gFloat + 1;
            }
        }
        else if (op == "--")
        {
            if (toIncrement.value is int gInt)
            {
                toIncrement.value = gInt - 1;
            }
            else if (toIncrement.value is float gFloat)
            {
                toIncrement.value = gFloat - 1;
            }
        }
        else
        {
            throw new Exception("GRUND *HACKS AND BLOOD VOMITS* YOU'RE TRYING TO INCREASE SOMETHING OTHER THAN INT OR FLOAT!" + context.Start.Line.ToString() + "Value: " + toIncrement);
        }
        return null;
    }

    public override object? VisitAdditiveExpression(GrundParser.AdditiveExpressionContext context)
    {
        GrundDynamicTypeWrapper left = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(0))).value;
        GrundDynamicTypeWrapper right = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(1))).value;

        var op = context.addOP().GetText();
        if (op == "+")
        {
            return SlanderLibrary.Add(left, right);
        }
        else if (op == "-")
        {
            return SlanderLibrary.Sub(left, right);
        }
        else
        {
            throw new NotImplementedException();
        }
    }
    //* Creating FUNCTION Definitions

    public override object? VisitFunctionDefinitionExpression([NotNull] GrundParser.FunctionDefinitionExpressionContext context)
    {
        if (!Variables.ContainsKey(context.IDENTIFIER().GetText()))
        {
            Variables.Add(context.IDENTIFIER().GetText(), new GrundDynamicTypeWrapper(context));
        }
        else if (Variables.ContainsKey(context.IDENTIFIER().GetText()))
        {
            Variables[context.IDENTIFIER().GetText()] = new GrundDynamicTypeWrapper(context);
        }
        return null;
    }

    //* Function Logic calls Like If Statements and while loops
    public override object? VisitWhileBlock([NotNull] GrundParser.WhileBlockContext context)
    {
        Func<GrundDynamicTypeWrapper, GrundDynamicTypeWrapper> condition = context.WHILE().GetText() == "WHILE"
        ? IsTrue
        : IsFalse
        ;

        if (condition((GrundDynamicTypeWrapper)Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            } while (condition((GrundDynamicTypeWrapper)Visit(context.expression())));
        }
        else if (context.elseIfBlock() != null)
        {
            Visit(context.elseIfBlock());
        }
        return null;
    }

    //* IF Statements
    public override object? VisitIfBlock([NotNull] GrundParser.IfBlockContext context)
    {

        Func<GrundDynamicTypeWrapper, GrundDynamicTypeWrapper> condition = context.IFBLOCK().GetText() == "IF" ? IsTrue : IsFalse;

        if (condition((GrundDynamicTypeWrapper)Visit(context.expression())))
        {
            Visit(context.block());
        }
        else if (context.elseIfBlock() != null)
        {
            Visit(context.elseIfBlock());
        }
        return null;
    }

    //**Converts variable string to variable type 
    public override object? VisitConstant([NotNull] GrundParser.ConstantContext context)
    {
        if (context.INTEGER() is { } i)
        {
            return new GrundDynamicTypeWrapper(int.Parse(i.GetText()));
        }
        if (context.FLOAT() is { } f)
        {
            return new GrundDynamicTypeWrapper(float.Parse(f.GetText()));
        }
        if (context.STRING() is { } s)
        {
            return new GrundDynamicTypeWrapper(s.GetText()[1..^1]);
        }
        if (context.BOOL() is { } b)
        {
            return new GrundDynamicTypeWrapper(b.GetText() == "true");
        }
        if (context.NULL() is { })
        {
            return new GrundDynamicTypeWrapper(null);
        }

        throw new NotImplementedException();
    }
    public override object? VisitComparisonExpression([NotNull] GrundParser.ComparisonExpressionContext context)
    {
        GrundDynamicTypeWrapper left = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(0))).value;
        GrundDynamicTypeWrapper right = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(1))).value;

        var op = context.compareOP().GetText();

        if (op == "==")
        {
            return SlanderLibrary.IsEqual(left, right);
        }
        if (op == "!=")
        {
            return SlanderLibrary.IsNotEqual(left, right);
        }
        if (op == ">")
        {
            return SlanderLibrary.GreaterThan(left, right);
        }
        if (op == ">=")
        {
            return SlanderLibrary.GreaterThanOrEqual(left, right);
        }
        if (op == "<")
        {
            return SlanderLibrary.LessThan(left, right);
        }
        if (op == "<=")
        {
            return SlanderLibrary.LessThanOrEqual(left, right);
        }
        throw new NotImplementedException();
    }
    public override object VisitCollections([NotNull] GrundParser.CollectionsContext context)
    {
        if (context.list() is { } l)
        {
            // .Cast<GrundDynamicTypeWrapper>()
            // .Select((a) => new GrundDynamicTypeWrapper(a))
            List<GrundDynamicTypeWrapper> unwrapped = l.expression().Select(Visit).Cast<GrundDynamicTypeWrapper>().ToList();
            return new GrundDynamicTypeWrapper(unwrapped);
        }
        throw new Exception("GRUND SLAMS FIST NOT VALID COLLECTIONS LINE: " + context.Start.Line.ToString());
    }
    public override object VisitBooleanExpression([NotNull] GrundParser.BooleanExpressionContext context)
    {
        GrundDynamicTypeWrapper left = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(0))).value;
        GrundDynamicTypeWrapper right = (GrundDynamicTypeWrapper)new GrundDynamicTypeWrapper(Visit(context.expression(1))).value;
        var op = context.boolOP().GetText();
        return SlanderLibrary.boolOperators(left, right, op);
    }
    private GrundDynamicTypeWrapper IsTrue(GrundDynamicTypeWrapper wrapper)
    {
        if (wrapper.value is bool b)
        {
            return new GrundDynamicTypeWrapper(b);
        }
        throw new Exception("GRUND STUPID THINKS THIS IS BOOL BUT IS NOT");
    }
    public GrundDynamicTypeWrapper IsFalse(GrundDynamicTypeWrapper wrapper)
    {
        GrundDynamicTypeWrapper opposite = IsTrue(wrapper);
        opposite.value = !(bool)opposite.value;
        return opposite;
    }
}

