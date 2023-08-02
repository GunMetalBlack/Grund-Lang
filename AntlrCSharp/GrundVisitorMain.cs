
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
using Grund;
using static Grund.GrundTypeWrapper;

public struct GrundStackFrame
{
    public string name;
    // This dictionary contains all the global variables
    public Dictionary<string, GrundDynamicTypeWrapper> variables { get; }

    public bool inherit = false;
    // This stack frame dictates  the inheritance and scope for the language
    public GrundStackFrame(string name)
    {
        this.name = name;
        variables = new();
    }

}

public class GrundVisitorMain : GrundBaseVisitor<object?>
{

    private Stack<GrundStackFrame> StackFrames { get; } = new();
    private Dictionary<string, GrundDynamicTypeWrapper> Variables { get; } = new();
    private Dictionary<string, Dictionary<string, GrundDynamicTypeWrapper>> StaticStructMembers { get; } = new();
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

        //** Important Create Variables for FunctionCallContext and Built in Math Standards
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

    public object? ExecuteUserDefinedFunction(GrundParser.FunctionCallContext context, GrundParser.FunctionDefinitionContext functionLookup, object? structInstance = null)
    {

        // Grab the function name and any expressions it has and turns into an array 
        var name = context.IDENTIFIER().GetText();
        object?[] args = context.expression().Select(Visit).ToArray();
        if (structInstance != null) args = args.Prepend(structInstance).ToArray();
        if (functionLookup == null)
        {
            return null;
        }
        // If we have a function then create a new scope for the function and go through each expression and adds it to the stack
        StackFrames.Push(new GrundStackFrame(name));
        if (functionLookup.parameter() != null && context.expression() != null)
        {
            //Exception for if the expression count and function args don't match.
            if (functionLookup.parameter().Count() != args.Count()) { throw new Exception("GRUND SCREAMS, EXPECTED " + ((GrundParser.FunctionDefinitionContext)(Variables[name].value)).parameter().Count().ToString() + " PARAMETERS BUT HAD " + args.Count().ToString() + " VALUES STUPID! LINE: " + context.Start.Line.ToString()); }
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

    public override object? VisitFunctionCall(GrundParser.FunctionCallContext context)
    {
        // Grab the function name and any expressions it has and turns into an array 
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).OfType<GrundDynamicTypeWrapper>().ToArray();

        // Handle scoped functions
        if (GetVariablesInCurrentStackFrame().ContainsKey(name))
        {
            // Handle user-defined functions
            {
                if (GetVariablesInCurrentStackFrame()[name].value is GrundParser.FunctionDefinitionContext functionLookup)
                {
                    return ExecuteUserDefinedFunction(context, functionLookup);
                }
            }
            // Handle build-in Grund functions
            if (GetVariablesInCurrentStackFrame()[name].value is Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper> func)
            {
                return func(args);
            }
        }

        // Handle global functions
        if (Variables.ContainsKey(name))
        {
            // Handle user-defined functions
            {
                if (Variables[name].value is GrundParser.FunctionDefinitionContext functionLookup)
                {
                    return ExecuteUserDefinedFunction(context, functionLookup);
                }
            }
            // Handle build-in Grund functions
            if (Variables[name].value is Func<GrundDynamicTypeWrapper[], GrundDynamicTypeWrapper> func)
            {
                return func(args);
            }
        }

        // Wasn't user-defined or global - throw an exception
        throw new Exception("GRUND SAYS COMMON USE A REAL FUNCTION THIS IS NOT A FUNCTION " + name + " LINE: " + context.Start.Line.ToString());

    }

    //** Below is the implementation if Parsing Variables
    public override object VisitAssignment([NotNull] GrundParser.AssignmentContext context)
    {
        var gLeft = (GrundDynamicTypeWrapper)Visit(context.expression(0));
        var gRight = (GrundDynamicTypeWrapper)Visit(context.expression(1));

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
        // If its not a list do this for everything else that needs to be assigned as a variable
        // This should INIT the Var idk why I was trying to override here
        //TODO: Make Sure to Update The Documentation You Stupid Ape
        var varName = context.declaration().IDENTIFIER().GetText();
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
        //TODO: IDK when it should crash here maybe do some Type Checks at some Point
        //throw new Exception("GRUND ERROR: Um TESTING? DECLARATIONS");
        throw new Exception("GRUND SAYS WHAT THE ACTUAL FUCK: " + " DECLARATION FAILED. LINE: " + context.Start.Line.ToString());

    }
    // Helper function to reduce boilerplate. Sends all variables from current scope for evaluation.
    public Dictionary<string, GrundDynamicTypeWrapper> GetVariablesInCurrentStackFrame()
    {
        return StackFrames.First().variables;
    }

    public override object VisitListAccessionExpression([NotNull] GrundParser.ListAccessionExpressionContext context)
    {
        // This is how we return a value at an index for example if(x[2] < 0). x[2] should return a value
        var gList = Visit(context.expression(0));
        var gInt = Visit(context.expression(1));
        //Checks if variable is in current scope and is a list.
        if (gList is List<object?> list)
        {
            //If it is then we return the value at the lists index
            try
            {
                return list.ElementAt(int.Parse(gInt.ToString()));
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("GRUND SAYS OUT OF RANGE ERROR: " + " Learn TO COUNT. LINE: " + context.Start.Line.ToString());
            }
        }

        throw new Exception("GRUND SAYS ERROR: " + " IS NOT LIST. LINE: " + context.Start.Line.ToString());
    }

    public override object? VisitStrucDefinition(GrundParser.StrucDefinitionContext context)
    {
        //FIXME: Fix Structs for future versions
        // // Return early if there are no lines in the struct definition
        // var lines = context.block().line();
        // if (lines == null || !lines.Any())
        // {
        //     return null;
        // }

        // var structName = context.IDENTIFIER(0).GetText();
        // var structMembers = new Dictionary<string, GrundDynamicTypeWrapper>();
        // var staticMembers = new Dictionary<string, GrundDynamicTypeWrapper>();
        // if (context.EXTENDS() != null && context.IDENTIFIER(1).GetText() != null)
        // {
        //     var parentStructName = context.IDENTIFIER(1).GetText();
        //     Dictionary<string, object?> parentStruct = (Dictionary<string, object?>)Variables[parentStructName];
        //     foreach (KeyValuePair<string, object> kvp in parentStruct)
        //     {
        //         if (structMembers.ContainsKey(kvp.Key))
        //         {
        //             structMembers[kvp.Key] = kvp.Value;
        //         }
        //         else
        //         {
        //             structMembers.Add(kvp.Key, kvp.Value);
        //         }
        //     }
        //     staticMembers.Add("STRUK_PARENT_POINTER_PLEASE_DON'T_USE", parentStructName);
        // }
        // //Overrides Parent Static Struct pointers Its pointer is THE PARENT_POINTER 
        // //GF_STRUCT_POINTER is a pointer name  
        // structMembers["GF_STRUK_POINTER_PLEASE_DON'T_USE"] = structName;
        // foreach (var line in lines)
        // {
        //     if (line.functionDefinition() != null)
        //     {
        //         // Process function definitions
        //         var methodName = line.functionDefinition().IDENTIFIER().GetText();
        //         var methodValue = line.functionDefinition();
        //         structMembers.Add(methodName, methodValue);
        //     }
        //     else if (line.statement().blockScopeAssignment() != null)
        //     {
        //         var assignmentCount = line.statement().blockScopeAssignment().assignment();
        //         foreach (var assignment in assignmentCount)
        //         {
        //             var staticFieldName = assignment.expression(0).GetText();
        //             var staticFieldValue = Visit(assignment.expression(1));
        //             staticMembers.Add(staticFieldName, staticFieldValue);
        //         }
        //     }
        // }

        // // Check if the struct contains a constructor
        // if (!(structMembers.ContainsKey(structName) && structMembers[structName] is GrundParser.FunctionDefinitionContext))
        // {
        //     // Log a warning message if the struct does not contain a constructor
        //     throw new Exception("Grund sighs: STRUK " + structName + " is missing constructor definition " + "Make sure the constructor has the same name as the STRUK");
        // }
        // // Add the struct members to the global Variables dictionary
        // StaticStructMembers.Add(structName, staticMembers);
        // Variables.Add(structName, structMembers);
        throw new NotImplementedException();
        return null;
    }

    public object? FindVariableInCurrentState(string identifier)
    {
        if (GetVariablesInCurrentStackFrame().ContainsKey(identifier)) return GetVariablesInCurrentStackFrame()[identifier];
        if (Variables.ContainsKey(identifier)) return Variables[identifier];
        return null;
    }

    public object? LookupStructMember(Dictionary<string, object?> structMembers, string memberName, out bool memberIsStatic, out bool success)
    {
        // // We need to return whether or not the member that we find is static (using the "out" keyword in the parameter declaration rather
        // // than returning it directly). We don't know if it's static or not yet, so for now we assume true.
        // memberIsStatic = true;
        // // Same goes for success - assuming success until we fail
        // success = true;
        // // Static struct members are stored as dictionary which is itself stored in another dictionary "StaticStructMembers" using the struct name as the key.
        // // We are attempting to access a static member via an instance of the struct, so we need to know the struct name (not the instance name) to use as the
        // // key for lookup in the dictionary. We accomplish this using "GF_STRUK_POINTER_PLEASE_DON'T_USE", a (poorly named named but there's no going back)
        // // instance member string containing the struct name that we automatically inserted during instance construction.
        // string? structPointerString = structMembers.GetValueOrDefault("GF_STRUK_POINTER_PLEASE_DON'T_USE", null)?.ToString();
        // // Lookup the static members for this struct, and return a value if one is found for this member name.
        // if (structPointerString != null && StaticStructMembers.ContainsKey(structPointerString) && (StaticStructMembers.GetValueOrDefault(structPointerString, null)?.GetValueOrDefault(memberName, null) != null))
        // {
        //     return StaticStructMembers.GetValueOrDefault(structPointerString, null)?.GetValueOrDefault(memberName, null);
        // }
        // // If we didn't find a match in our own static members, try looking in our parent struct (the one that we are declared to extend from), and then its
        // // parent struct, and then its parent struct, etc. Similarly to the magic "GF_STRUK_POINTER_PLEASE_DON'T_USE" instance member used before, each struct
        // // contains a magic static member "STRUK_PARENT_POINTER_PLEASE_DON'T_USE" to retrieve the name of its parent struct for this purpose.
        // if ((StaticStructMembers.GetValueOrDefault(structPointerString, null)?.GetValueOrDefault("STRUK_PARENT_POINTER_PLEASE_DON'T_USE", null)) is string parentKey && parentKey != null)
        // {
        //     // Check immediate parent struct
        //     if (StaticStructMembers.GetValueOrDefault(parentKey, null).ContainsKey(memberName))
        //     {
        //         return StaticStructMembers.GetValueOrDefault(parentKey, null)?.GetValueOrDefault(memberName, null);
        //     }
        //     // Recursively check parents of parent
        //     return RecursiveParentStructLookUp(StaticStructMembers.GetValueOrDefault(parentKey, null)?.GetValueOrDefault("STRUK_PARENT_POINTER_PLEASE_DON'T_USE", null).ToString(), memberName);
        // }
        // // If we've made it to this point, then no match was found for static members.
        // // Now we check if it's an instance variable, flag it as such, and return its value.
        // memberIsStatic = false;
        // if (structMembers.ContainsKey(memberName))
        // {
        //     return structMembers.GetValueOrDefault(memberName, null);
        // }
        // // Otherwise, the member cannot be found anywhere (either static or instance, in the current struct or its parents). Flag as such and return null.
        // success = false;
        throw new NotImplementedException();
        return null;
    }

    public object? RecursiveParentStructLookUp(string structParentPointerString, string memberName)
    {
        // //If we can find the parent struct pointer and the value it pulls is real then we return the value else we check the grandparents pointer and value!!!
        // if (StaticStructMembers.ContainsKey(structParentPointerString) && StaticStructMembers.GetValueOrDefault(structParentPointerString, null)?.GetValueOrDefault(memberName, null) != null)
        // {
        //     return StaticStructMembers.GetValueOrDefault(structParentPointerString, null)?.GetValueOrDefault(memberName, null);
        // }
        // else if ((StaticStructMembers.GetValueOrDefault(structParentPointerString, null)?.GetValueOrDefault("STRUK_PARENT_POINTER_PLEASE_DON'T_USE", null)) != null)
        // {
        //     RecursiveParentStructLookUp(StaticStructMembers.GetValueOrDefault(structParentPointerString, null)?.GetValueOrDefault("STRUK_PARENT_POINTER_PLEASE_DON'T_USE", null).ToString(), memberName);
        // }
        throw new NotImplementedException();
        return null;
    }
    public override object VisitDotExpression([NotNull] GrundParser.DotExpressionContext context)
    {
        // var structInstanceName = context.IDENTIFIER(0).GetText();
        // var memberName = context.IDENTIFIER(1)?.GetText() ?? context.functionCall()?.IDENTIFIER()?.GetText();
        // if (structInstanceName == null || memberName == null)
        // {
        //     throw new Exception("Grund: how It's Impossible due to syntax");
        // }
        // if (FindVariableInCurrentState(structInstanceName) is Dictionary<string, object?> structMembers)
        // {
        //     bool memberIsStatic = false;
        //     bool success = false;
        //     object? value = LookupStructMember(structMembers, memberName, out memberIsStatic, out success);
        //     if (!success)
        //     {
        //         string? structName = structMembers.GetValueOrDefault("GF_STRUK_POINTER_PLEASE_DON'T_USE", null)?.ToString();
        //         throw new Exception("GRUND Says theres no value for " + structInstanceName + "." + memberName + " in that class " + (structName == null ? "UNKNOWN" : structName) + " there jimbo?" + "LINE: " + context.Start.Line.ToString());
        //     }
        //     if (value is GrundParser.FunctionDefinitionContext functionDefinition && context.functionCall() != null)
        //     {
        //         return ExecuteUserDefinedFunction(context.functionCall(), functionDefinition, memberIsStatic ? null : structMembers);
        //     }
        //     else if (!(value is Antlr4.Runtime.Tree.IParseTree))
        //     {
        //         return value;
        //     }
        //     return Visit((Antlr4.Runtime.Tree.IParseTree)value);
        // }
        // else
        // {
        //     throw new Exception("GRUND Says that class instance doesn't exist there jimbo? " + "LINE: " + context.Start.Line.ToString());
        // }
        throw new NotImplementedException();
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
        else
        {
            while (!(parentContext is GrundParser.StrucDefinitionContext))
            {
                // Get the parent of the parent context
                parentContext = parentContext.Parent;

                // If the parent is null, we've reached the root of the tree
                if (parentContext == null)
                {
                    // We didn't find a StrucDefinitionContext, so we can kill Grund
                    throw new Exception("GRUNDS SPITS: No maide- ? I mean class definition? OR  GRUND OGGA No variable defined for " + varName + " LINE: " + context.Start.Line.ToString());
                }
            }
            if (parentContext is GrundParser.StrucDefinitionContext structDef)
            {
                if (StaticStructMembers.ContainsKey(structDef.IDENTIFIER(0).GetText()))
                {
                    return StaticStructMembers[structDef.IDENTIFIER(0).GetText()][varName];
                }
            }
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

    public override object? VisitInLineIncrement(GrundParser.InLineIncrementContext context)
    {
        string op = context.inLineOP().GetText();
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
    public override object? VisitFunctionDefinition([NotNull] GrundParser.FunctionDefinitionContext context)
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
