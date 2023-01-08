
using Antlr4.Runtime.Misc;
using Antlr4.Runtime;
using Grund;
using System.Collections.Concurrent;
public struct GrundStackFrame
{
    public string name;
    // This dictionary contains all the global variables
    public Dictionary<string, object?> variables { get; }
    
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
    private List<string> ImmutableVariables { get; } = new();
    private Dictionary<string, object?> Variables { get; } = new();
    private Dictionary<string, Dictionary<string, object?>> StaticStructMembers { get; } = new();
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
        //* List Functions
        var FUNC_ID_GF_LISTCREATE = "GF_LIST_CREATE";
        var FUNC_ID_GF_LISTADD = "GL_ADD";
        var FUNC_ID_GF_LENGTH = "GF_LENGTH";
        var FUNC_ID_GF_LISTREMOVE = "GF_LIST_REMOVE";
        var FUNC_ID_GF_LISTLOOKUP = "GF_LIST_LOOKUP";
        var FUNC_ID_GF_WRITE_INPUT = "GF_INPUT";
        var FUNC_ID_GF_GET_KEY = "GF_KEY";
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
        Variables[FUNC_ID_GF_LENGTH] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LENGTH(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LENGTH);
        Variables[FUNC_ID_GF_LISTLOOKUP] = new Func<object?[], object?>(listname => SlanderLibrary.GF_LIST_LOOKUP(listname, Variables)); ImmutableVariables.Add(FUNC_ID_GF_LISTLOOKUP);
        Variables[FUNC_ID_GF_WRITE_INPUT] = new Func<object?[], object?>(SlanderLibrary.GF_WRITE_INPUT); ImmutableVariables.Add(FUNC_ID_GF_WRITE_INPUT);
        Variables[FUNC_ID_GF_GET_KEY] = new Func<object?[], object?>(SlanderLibrary.GF_GET_KEY); ImmutableVariables.Add(FUNC_ID_GF_GET_KEY);
        Variables[FUNC_ID_GF_PARSER] = new Func<object?[], object?>(SlanderLibrary.GF_PARSER); ImmutableVariables.Add(FUNC_ID_GF_PARSER);
        Variables[FUNC_ID_GF_INDEX_CHAR] = new Func<object?[], object?>(SlanderLibrary.GF_INDEX_CHAR); ImmutableVariables.Add(FUNC_ID_GF_INDEX_CHAR);
    }

    public object? ExecuteUserDefinedFunction(GrundParser.FunctionCallContext context, GrundParser.FunctionDefinitionContext functionLookup) {
        
        // Grab the function name and any expressions it has and turns into an array 
        var name = context.IDENTIFIER().GetText();
        var args = context.expression().Select(Visit).ToArray();

        if(functionLookup == null) {
            return null;
        }
        // If we have a function then create a new scope for the function and go through each expression and adds it to the stack
        StackFrames.Push(new GrundStackFrame(name));
        if (functionLookup.parameter() != null && context.expression() != null)
        {
            //Exception for if the expression count and function args don't match.
            if (functionLookup.parameter().Count() != args.Count()) { throw new Exception("GRUND SCREAMS, EXPECTED " + ((GrundParser.FunctionDefinitionContext)(Variables[name])).parameter().Count().ToString() + " PARAMETERS BUT HAD " + args.Count().ToString() + " VALUES STUPID! LINE: " + context.Start.Line.ToString()); }
            for (int i = 0; i < functionLookup.parameter().Count(); i++)
            {
                GetVariablesInCurrentStackFrame()[(functionLookup.parameter(i).GetText())] = args[i];
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
        var args = context.expression().Select(Visit).ToArray();

        // Handle scoped functions
        if (GetVariablesInCurrentStackFrame().ContainsKey(name))
        {
            // Handle user-defined functions
            {
                if(GetVariablesInCurrentStackFrame()[name] is GrundParser.FunctionDefinitionContext functionLookup)
                {
                    return ExecuteUserDefinedFunction(context, functionLookup);
                }
            }
            // Handle build-in Grund functions
            if(GetVariablesInCurrentStackFrame()[name] is Func<object?[], object?> func)
            {
                return func(args);
            }
        }

        // Handle global functions
        if (Variables.ContainsKey(name))
        {
            // Handle user-defined functions
            {
                if(Variables[name] is GrundParser.FunctionDefinitionContext functionLookup)
                {
                    return ExecuteUserDefinedFunction(context, functionLookup);
                }
            }
            // Handle build-in Grund functions
            if(Variables[name] is Func<object?[], object?> func)
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
        //This is how we defined variables (entire function)
        if (context.listAccession() != null)
        {
            //In this fun guy is how we define lists and accessing lists like x[1] = 3; should set the value of x[1] to 3
            var varName = context.listAccession().IDENTIFIER().GetText();
            var indexToFind = Visit(context.listAccession().expression());
            var toReplaceValue = Visit(context.expression());
            //Every variable with an underscore in the beginning should be added to the global variable list if its a list object
            if (varName[0] == '_' && Variables[varName] is List<object?> _list)
            {
                try
                {
                    //We get the current list that it's parsing and we take the expression of [>1<] 1 and force it to be an int
                    //after we simply access the index of the list and add the value we wish to replace.
                    _list[int.Parse(indexToFind.ToString())] = toReplaceValue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new Exception("GRUND SAYS OUT OF RANGE ERROR: " + varName + " Learn TO COUNT. LINE: " + context.Start.Line.ToString());
                }
            }
            else if (GetVariablesInCurrentStackFrame()[varName] is List<object?> list)
            {
                // same thing as above but it adds it to the current scope instead
                try
                {
                    list[int.Parse(indexToFind.ToString())] = toReplaceValue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new Exception("GRUND SAYS OUT OF RANGE ERROR: " + varName + " Learn TO COUNT. LINE: " + context.Start.Line.ToString());
                }
            }
        }
         else if(context.memberAssignment() != null)
        {
            var value = Visit(context.expression());
            var structInstanceName = context.memberAssignment().memberAccession().IDENTIFIER(0).GetText();
            var memberName = context.memberAssignment().memberAccession().IDENTIFIER(1)?.GetText() ?? context.memberAssignment().memberAccession().functionCall()?.IDENTIFIER()?.GetText();
           
            if (structInstanceName == null || memberName == null)
            {
                throw new Exception("Grund: how It's Impossible due to syntax");
            }
            
            if(GetVariablesInCurrentStackFrame().ContainsKey(structInstanceName) && GetVariablesInCurrentStackFrame()[structInstanceName] is Dictionary<string, object?> scopeStruct)
            {   
                if(scopeStruct.ContainsKey("GF_STRUK_POINTER_PLEASE_DON'T_USE")  && StaticStructMembers.ContainsKey(scopeStruct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()))
                {
                 StaticStructMembers[scopeStruct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()][memberName] = value;
                }
                else if(scopeStruct.ContainsKey(memberName) != null)
                {
                  scopeStruct[memberName] = value;
                }                  
            }
            else if(Variables.ContainsKey(structInstanceName) && Variables[structInstanceName] is Dictionary<string, object?> Struct)
            {
                if(Struct.ContainsKey("GF_STRUK_POINTER_PLEASE_DON'T_USE")  && StaticStructMembers.ContainsKey(Struct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()))
                {
                    StaticStructMembers[Struct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()][memberName] = value;
                }
                else if(Struct.ContainsKey(memberName) != null)
                {
                    Struct[memberName] = value;
                }  
            }
        }
        else if(context.CLASSPOINTER() != null)
        {
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());
            Dictionary<string, object?> newStuctMembers = new Dictionary<string, object?>();
            foreach(KeyValuePair<string, object?> kvp in (Dictionary<string, object?>)value)
            {
                newStuctMembers.Add(kvp.Key, kvp.Value);
            }
            if (varName[0] == '_')
            {
                
                Variables[varName] = newStuctMembers;
            }
            else
            {
                GetVariablesInCurrentStackFrame()[varName] = newStuctMembers;
            }
        }
        else
        {
            // If its not a list do this for everything else that needs to be assigned as a variable
            var varName = context.IDENTIFIER().GetText();
            var value = Visit(context.expression());
            if (varName[0] == '_')
            {
                Variables[varName] = value;
            }
            else
            {
                GetVariablesInCurrentStackFrame()[varName] = value;
            }
        }
        return null;
    }
    // Helper function to reduce boilerplate. Sends all variables from current scope for evaluation.
    public Dictionary<string, object?> GetVariablesInCurrentStackFrame()
    {
        return StackFrames.First().variables;
    }

    public override object VisitListAccession([NotNull] GrundParser.ListAccessionContext context)
    {
        // This is how we return a value at an index for example if(x[2] < 0). x[2] should return a value
        var varName = context.IDENTIFIER().GetText();
        var varIndex = Visit(context.expression());
        //Checks if variable is in current scope and is a list.
        if (GetVariablesInCurrentStackFrame().ContainsKey(varName))
        {
            if (GetVariablesInCurrentStackFrame()[varName] is List<object?> list)
            {
                //If it is then we return the value at the lists index
                try
                {
                    return list.ElementAt(int.Parse(varIndex.ToString()));
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new Exception("GRUND SAYS OUT OF RANGE ERROR: " + varName + " Learn TO COUNT. LINE: " + context.Start.Line.ToString());
                }
            }

            throw new Exception("GRUND SAYS SYNTAX ERROR: " + varName + " IS NOT LIST. LINE: " + context.Start.Line.ToString());
        }
        //Checks if the variable is in global scope if it failed to be found in the stack
        else if (Variables.ContainsKey(varName))
        {
            if (Variables[varName] is List<object?> list)
            {
                try
                {
                    return list.ElementAt(int.Parse(varIndex.ToString()));
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new Exception("GRUND SAYS OUT OF RANGE ERROR: " + varName + " Learn TO COUNT. LINE: " + context.Start.Line.ToString());
                }
            }
            throw new Exception("GRUND SAYS SYNTAX ERROR: " + varName + " IS NOT LIST");
        }
        throw new Exception(" GRUND OGGA No variable defined for " + varName);
    }

public override object? VisitStrucDefinition(GrundParser.StrucDefinitionContext context)
{
    // Return early if there are no lines in the struct definition
    var lines = context.block().line();
    if (lines == null || !lines.Any())
    {
        return null;
    }

    var structName = context.IDENTIFIER().GetText();
    var structMembers = new Dictionary<string, object?>();
    foreach (var line in lines)
    {
        if(line.functionDefinition() != null)
        {
            // Process function definitions
            var methodName = line.functionDefinition().IDENTIFIER().GetText();
            var methodValue = line.functionDefinition();
            structMembers.Add(methodName, methodValue);
        }
        else if(line.statement().blockScopeAssignment() != null)
        {
            var assignmentCount = line.statement().blockScopeAssignment().assignment();
            var staticMembers = new Dictionary<string, object?>();
            foreach (var assignment in assignmentCount)
            {
                var staticFieldName = assignment.IDENTIFIER().GetText();
                var staticFieldValue = Visit(assignment.expression());
                staticMembers.Add(staticFieldName, staticFieldValue);
            }
            if(!(structMembers.ContainsKey("GF_STRUK_POINTER_PLEASE_DON'T_USE")))
            {
            structMembers.Add("GF_STRUK_POINTER_PLEASE_DON'T_USE",structName);
            }
            StaticStructMembers.Add(structName, staticMembers);
        }
        else if(line.statement().assignment().THIS() != null)
        {
            // Process instance field assignments
            var thisFieldName = line.statement().assignment().IDENTIFIER().GetText();
            var thisFieldValue = Visit(line.statement().assignment().expression());
            structMembers.Add(thisFieldName , thisFieldValue);
        }
    }

    // Check if the struct contains a constructor
    if (!(structMembers.ContainsKey(structName) && structMembers[structName] is GrundParser.FunctionDefinitionContext))
    {
        // Log a warning message if the struct does not contain a constructor
        throw new Exception("Grund sighs: STRUK " + structName + " is missing constructor definition " + "Make sure the constructor has the same name as the STRUK");
    }
    
    // Add the struct members to the global Variables dictionary
    Variables.Add(structName,structMembers);
    return null;
}
    public override object VisitMemberAccession([NotNull] GrundParser.MemberAccessionContext context)
    {
        var structInstanceName = context.IDENTIFIER(0).GetText();
        var memberName = context.IDENTIFIER(1)?.GetText() ?? context.functionCall()?.IDENTIFIER()?.GetText();
        if (structInstanceName == null || memberName == null)
        {
            throw new Exception("Grund: how It's Impossible due to syntax");
        }

        object? value = null;
        if(GetVariablesInCurrentStackFrame().ContainsKey(structInstanceName) && GetVariablesInCurrentStackFrame()[structInstanceName] is Dictionary<string, object?> scopeStruct)
        {   
            if(scopeStruct.ContainsKey("GF_STRUK_POINTER_PLEASE_DON'T_USE")  && StaticStructMembers.ContainsKey(scopeStruct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()))
            {
                value = StaticStructMembers[scopeStruct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()][memberName];
            }
            else if(scopeStruct.GetValueOrDefault(memberName) != null)
            {
             value = scopeStruct.GetValueOrDefault(memberName);
            }            
      
        }
        else if(Variables.ContainsKey(structInstanceName) && Variables[structInstanceName] is Dictionary<string, object?> Struct)
        {
            if(Struct.ContainsKey("GF_STRUK_POINTER_PLEASE_DON'T_USE")  && StaticStructMembers.ContainsKey(Struct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()))
            {
                value = StaticStructMembers[Struct["GF_STRUK_POINTER_PLEASE_DON'T_USE"].ToString()][memberName];
            }
            else if(Struct.GetValueOrDefault(memberName) != null)
            {
              value = Struct.GetValueOrDefault(memberName);
            }  
        }
        if (value != null)
        {
            if (value is GrundParser.FunctionDefinitionContext functionDefinition && context.functionCall() != null)
            {
                return ExecuteUserDefinedFunction(context.functionCall(), functionDefinition);
            }
            else if(!(value is Antlr4.Runtime.Tree.IParseTree))
            {
                return value;
            }
            else
            {
                return Visit((Antlr4.Runtime.Tree.IParseTree)value);
            }
        }else
        {
            throw new Exception("GRUND Says theres no value for that class there jimbo? "+ "LINE: " + context.Start.Line.ToString());
        }
        
        return null;
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
        }else
        {
            while (!(parentContext is GrundParser.StrucDefinitionContext))
            {
                // Get the parent of the parent context
                parentContext = parentContext.Parent;

                // If the parent is null, we've reached the root of the tree
                if (parentContext == null)
                {
                    // We didn't find a StrucDefinitionContext, so we can kill Grund
                    throw new Exception("GRUNDS SPITS: No maide- ? I mean class definition?");
                }
            }
            if(parentContext is GrundParser.StrucDefinitionContext structDef){
                if(StaticStructMembers.ContainsKey(structDef.IDENTIFIER().GetText()))
                {
                    return StaticStructMembers[structDef.IDENTIFIER().GetText()][varName];
                }
            }
        }
        throw new Exception(" GRUND OGGA No variable defined for " + varName + " LINE: " + context.Start.Line.ToString());

    } 
    //**Converts variable string to variable type 
    public override object? VisitConstant([NotNull] GrundParser.ConstantContext context)
    {
        if (context.INTEGER() is { } i)
        {
            return int.Parse(i.GetText());
        }
        if (context.FLOAT() is { } f)
        {
            return float.Parse(f.GetText());
        }
        if (context.STRING() is { } s)
        {
            return s.GetText()[1..^1];
        }
        if (context.BOOL() is { } b)
        {
            return b.GetText() == "true";
        }
        if (context.NULL() is { })
        {
            return null;
        }

        throw new NotImplementedException();
    }

    public override object VisitCollections([NotNull] GrundParser.CollectionsContext context)
    {
        if (context.list() is { } l)
        {
            return l.expression().Select(Visit).ToList();
        }
        throw new Exception("GRUND SLAMS FIST NOT VALID COLLECTIONS LINE: " + context.Start.Line.ToString());
    }

    public override object VisitMultiplicativeExpression([NotNull] GrundParser.MultiplicativeExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

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
        var toIncrement = context.IDENTIFIER().GetText();
        if (op == "++")
        {
            if (GetVariablesInCurrentStackFrame().ContainsKey(toIncrement) && GetVariablesInCurrentStackFrame()[toIncrement] is int intR)
            {
                GetVariablesInCurrentStackFrame()[toIncrement] = intR += 1;
                return GetVariablesInCurrentStackFrame()[toIncrement];
            }
            else if (Variables.ContainsKey(toIncrement) && Variables[toIncrement] is float floatR)
            {
                Variables[toIncrement] = floatR += 1;
                return Variables[toIncrement];
            }
        }
        else if (op == "--")
        {
            if (GetVariablesInCurrentStackFrame().ContainsKey(toIncrement) && GetVariablesInCurrentStackFrame()[toIncrement] is int intR)
            {
                GetVariablesInCurrentStackFrame()[toIncrement] = intR -= 1;
                return GetVariablesInCurrentStackFrame()[toIncrement];
            }
            else if (Variables.ContainsKey(toIncrement) && Variables[toIncrement] is float floatR)
            {
                Variables[toIncrement] = floatR -= 1;
                return Variables[toIncrement];
            }
        }
        throw new Exception("GRUND *HACKS AND BLOOD VOMITS* YOU'RE TRYING TO INCREASE SOMETHING OTHER THAN INT OR FLOAT!" + context.Start.Line.ToString() + "Value: " + toIncrement);
    }

    public override object? VisitAdditiveExpression(GrundParser.AdditiveExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

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
            Variables.Add(context.IDENTIFIER().GetText(), context);
        }
        return null;
    }
    //* Function Logic calls Like If Statements and while loops
    public override object? VisitWhileBlock([NotNull] GrundParser.WhileBlockContext context)
    {
        Func<object?, bool> condition = context.WHILE().GetText() == "WHILE"
        ? IsTrue
        : IsFalse
        ;

        if (condition(Visit(context.expression())))
        {
            do
            {
                Visit(context.block());
            } while (condition(Visit(context.expression())));
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

        Func<object?, bool> condition = context.IFBLOCK().GetText() == "IF"
         ? IsTrue
         : IsFalse
         ;
        if (condition(Visit(context.expression())))
        {
            Visit(context.block());
        }
        else if (context.elseIfBlock() != null)
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
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));
        var op = context.boolOP().GetText();

        return true;
    }
    private bool IsTrue(object? value)
    {
        if (value is bool b)
        {
            return b;
        }
        throw new Exception("GRUND STUPID THINKS THIS IS BOOL BUT IS NOT");
    }
    public bool IsFalse(object? value) => !IsTrue(value);
}
