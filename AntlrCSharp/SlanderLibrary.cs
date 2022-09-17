public class SlanderLibrary{
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