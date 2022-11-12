public class SlanderLibrary{
   
//* FUNCTIONS ********************************
public static object?[] GF_WRITE_INLINE(object?[] args)
{
    foreach (var arg in args)
    {
        if(arg is List<object?> list)
        {
            Console.Write("[");
            for(int i = 0; i < list.Count; i++)
            {
                if(!(i == list.Count - 1 )){
                Console.Write(list.ElementAt(i) + ", ");
                }else
                {
                     Console.Write(list.ElementAt(i));
                }
            }
            Console.Write("]");
        }else{
        Console.Write(arg);
        }
    }
    Console.WriteLine();
    return null;
}
public static object?[] GF_WRITE(object?[] args)
{
   foreach (var arg in args)
    {
        if(arg is List<object?> list)
        {
            Console.Write("[");
            for(int i = 0; i < list.Count; i++)
            {
                if(!(i == list.Count - 1 )){
                Console.Write(list.ElementAt(i) + ", ");
                }else
                {
                     Console.Write(list.ElementAt(i));
                }
            }
            Console.Write("]");
        }else{
        Console.Write(arg);
        }
    }
    return null;
}
public static object? GF_WRITE_INPUT(object?[] args) 
{
    string ParseType = args[0].ToString();
    object toReturn = Console.ReadLine();
    if (ParseType == "INT")
        {
            toReturn = int.Parse(toReturn.ToString()); 
            return toReturn; 
        }
        else if (ParseType == "FLOAT")
        {
            toReturn = float.Parse(toReturn.ToString()); 
            return toReturn; 
        }else
        {
            return toReturn.ToString();
        }
}
public static object? GF_INDEX_CHAR(object?[] args)
{
    if(args[0] != null && args[1] != null)
    {
       string stringToSearch = args[0].ToString();
       int indexToReturn = int.Parse(args[1].ToString());
       if(!(stringToSearch.Length < indexToReturn))
       {
       return stringToSearch[indexToReturn];
       }else
       {
        throw new Exception("GRUND CRIES LEARN TO COUNT HIPPY OUT OF RANGE STRING INDEX " + indexToReturn);
       }
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS NULL REFERENCE *SPITS IN FACE*");
    }
}
public static object? GF_PARSER(object?[] args)
{
    if(args[0] != null && args[1] != null){
        string ParseType = args[0].ToString();
         object toReturn = args[1]; 
        if (ParseType == "INT")
        {
            toReturn = int.Parse(toReturn.ToString()); 
            return toReturn; 
        }else if (ParseType == "FLOAT")
        {
            toReturn = float.Parse(toReturn.ToString()); 
            return toReturn; 
        }else if (ParseType == "STRING")
        {
            toReturn = toReturn.ToString(); 
            return toReturn; 
        }else
        {
            throw new NotImplementedException();
        }   
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS NULL REFERENCE *SPITS IN FACE*");
    }
}
public static object?[] GF_LIST_CREATE(object[]? args, Dictionary<string,object?> Variables)
{   
    var nameObject = args[0];
    var name = nameObject as string;
    Variables[name] = new List<object?>();
    return null;
}
public static object?[] GF_LIST_APPEND(object?[] args, Dictionary<string,object?> Variables)
{
    if(args[0] != null && args[1] != null)
    {
        var typeToStore = args[1];
        List<object?> keyLookUp = args[0] as List<object?> ;
        keyLookUp.Add(typeToStore);
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR LIST");
    }
    return null;
}
public static object?[] GF_LIST_REPLACE(object?[] args, Dictionary<string,object?> Variables)
{
    if(args.Length == 3 && args[0] is string && args[2] is int)
    {
        var keyLookUp = args[0] as string;
        var typeToReplace = args[1]; 
        var argIndex = args[2];
        int indexToReplace = (int)(argIndex as int?);
        List<object?>? list = Variables[keyLookUp] as List<object?>;
        list[indexToReplace] = typeToReplace;
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR THRID ARGUMENT IS NOT INT");
    }
    return null;
}
public static object?[] GF_LIST_REMOVE(object?[] args, Dictionary<string,object?> Variables)
{
    if(args.Length == 2 && args[0] is string && args[1] is int)
    {
        var keyLookUp = args[0] as string;
        var typeToRemove = args[1]; 
        int indexToRemove = (int)(typeToRemove as int?);
        List<object?>? list = Variables[keyLookUp] as List<object?>;
        list.Remove(indexToRemove);
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR SECOND ARGUMENT IS NOT INT");
    }
    return null;
}   
public static object? GF_LIST_LOOKUP(object?[] args, Dictionary<string,object?> Variables)
{
    if(args.Length == 2 && args[0] is string && args[1] is int)
    {
        var keyLookUp = args[0] as string;
        var typeToLookup = args[1]; 
        int indexToFind = (int)(typeToLookup as int?);
        List<object?>? list = Variables[keyLookUp] as List<object?>;
        if(list == null){throw new Exception("GRUND: YOU FOOL THE LIST YOUR LOOKING FOR IS NULL");}
        if(indexToFind < list.Count){
            return list[indexToFind];
        }
        else
        {
            throw new Exception("GRUND: YELLS ITS EMPTY OR OUT OF RANGE");
        }
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR SECOND ARGUMENT IS NOT INT");
    }
}      
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    //** Bools

    public static bool boolOperators(object? left, object? right, string op)
    {
            if(op.Equals("AND"))
            {
                return left is bool l && right is bool r;
            }
            if(op.Equals("OR"))
            {
                return left is bool l || right is bool r;
            }

            throw new Exception("GRUND *HACKS AND VOMITS* IDFK HOW WE GOT HERE NOT A BOOL OPERATION");
    }

    public static bool GreaterThanOrEqual(object? left, object? right)
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
     public static bool GreaterThan(object? left, object? right)
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
     public static bool LessThan(object? left, object? right)
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
     public static bool LessThanOrEqual(object? left, object? right)
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
     public static bool IsEqual(object? left, object? right)
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
        if(left is string lfString && right is string rString)
        {
            return lfString == rString;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
     public static bool IsNotEqual(object? left, object? right)
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
        if(left is string lfString && right is string rString)
        {
            return lfString != rString;
        }
        throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
    }
    //** Adding and Subtract
        //* Adding for variables 
    public static object? Add(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l+r;
        }
        else if(left is float lf && right is float rf)
        {
            return lf+rf;
        }
        else if(left is int lInt && right is float rFloat)
        {
           return lInt+rFloat;
        }
        else if(left is float lfFloat && right is int rInt)
        {
            return lfFloat+rInt;
        }
        else if(left is string){
            return $"{left}{right}";
        }
        else if(right is string || right is string){
            return $"{left}{right}";
        }
        else if(left is List<object?> Llist && right is List<object?> Rlist)
        {
            List<object?> result = Llist;
            foreach(object? o in Rlist)
            {
                result.Add(o);
            }
            return result;
        }
        throw new Exception("GRUND STUPID CANNOT ADD}." + left.GetType() +" " + right.GetType());
    }
        
        //*Subtracting from the left and right arguments
    public static object? Sub(object? left, object? right)
    
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
    //**Multiply the left and right arguments
    public static object? Mul(object? left, object? right)
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
    public static object? Div(object? left, object? right)
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
    public static object? Mod(object? left, object? right)
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
}