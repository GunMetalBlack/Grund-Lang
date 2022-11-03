public class SlanderLibrary{
   
//* FUNCTIONS ********************************
public static object?[] GF_WRITE(object?[] args)
{
    foreach (var arg in args)
    {
        Console.Write(arg);
    }
    Console.WriteLine();
    return null;
}
public static object? GF_WRITE_INPUT(object?[] args)
{
    string toReturn = Console.ReadLine();
    Object? obj = toReturn;
    return obj.ToString();
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
    if(args.Length == 2 && args[0] is string)
    {
        var typeToStore = args[1];
        var keyLookUp = args[0] as string;
        if(args[1] is string){typeToStore = args[1] as string;}else{typeToStore = args[1];} 
        List<object?>? list = Variables[keyLookUp] as List<object?>;
        list.Add(typeToStore);
    }else
    {
        throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR TO MANY ARGUMENTS");
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
        Console.WriteLine(indexToFind);
        Console.WriteLine(list.Count);
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