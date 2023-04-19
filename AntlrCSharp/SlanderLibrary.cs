using Grund;
using static Grund.GrundTypeWrapper;
namespace Grund
{
    public class SlanderLibrary
    {

        //* The SlanderLibrary class contains a collection of static methods that can be called from Grund code.

        //* FUNCTIONS ********************************

        // The GF_WRITE_INLINE function takes a variable number of arguments, which can be any combination of strings, numbers,
        // booleans, null values, or lists. It prints each argument to the console on the same line, separated by spaces,
        // and then prints a newline character at the end.
        public static object?[] GF_WRITE_INLINE(GrundDynamicTypeWrapper[] args)
        {
        
            foreach (var arg in args)
            {
                if (arg.value is List<object?> list)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (!(i == list.Count - 1))
                        {
                            Console.Write(list.ElementAt(i));
                        }
                        else
                        {
                            Console.Write(list.ElementAt(i));
                        }
                    }
                }
                else
                {
                    Console.Write(arg.value);
                }
            }
            Console.WriteLine();
            return null;
        }
        // The GF_WRITE function is similar to GF_WRITE_INLINE, but it does not print a newline character at the end.
        public static object?[] GF_WRITE(GrundDynamicTypeWrapper[] args)
        {
            foreach (var arg in args)
            {
                if (arg.value is List<object?> list)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (!(i == list.Count - 1))
                        {
                            Console.Write(list.ElementAt(i));
                        }
                        else
                        {
                            Console.Write(list.ElementAt(i));
                        }
                    }
                }
                else
                {
                    Console.Write(arg.value);
                }
            }
            return null;
        }
        // Moves Console Cursors position
        public static object?[] GF_CURSOR_MOVE(GrundDynamicTypeWrapper[] args)
        {
            if (args.Length == 2)
            {
                if (args[0].value is int x && args[1].value is int y)
                {
                    Console.SetCursorPosition(x, y);
                }
                else
                {
                    throw new Exception("Grund Screams: USE INT'S YOU MORON! CURSOR CAN'T MOVE!");
                }
            }
            else
            {
                throw new Exception("Grund: DUDE REALLY YOUR MISSING ARGS! FOR CURSOR");
            }
            return null;
        }
        //Standard Input
        public static object? GF_WRITE_INPUT(GrundDynamicTypeWrapper[] args)
        {
            object toReturn = Console.ReadLine();
            if (args != null && args.Length != 0)
            {
                if (args[0].value.ToString() == "INT")
                {
                    return int.Parse(toReturn.ToString());
                }
                else if (args[0].value.ToString() == "FLOAT")
                {
                    return float.Parse(toReturn.ToString());
                }
            }
            else
            {
                return toReturn.ToString();
            }
            throw new Exception("GRUND CRIES WHAT THE HELL HAPPENED INPUT STATEMENT DIED");
        }
        // Clear Screen
        public static object?[] GF_CLS(GrundDynamicTypeWrapper[] args)
        {
            Console.Clear();
            return null;
        }
        //Get key without stopping execution
        public static object? GF_GET_KEY(GrundDynamicTypeWrapper?[] args)
        {
            if (Console.KeyAvailable) // Non-blocking peek
            {
                object toReturn = Console.ReadKey(true).KeyChar;
                return toReturn.ToString();
            }
            else
            {
                return null;
            }

            throw new Exception("GRUND CRIES WHAT THE HELL HAPPENED INPUT STATEMENT DIED");
        }
        //Random Value
        public static object? GF_RAND(GrundDynamicTypeWrapper[] args)
        {
            if ((args[0].value != null && args[1].value != null) && (args[0].value is int low && args[1].value is int high))
            {
                if (low >= 0)
                {
                    var random = new Random();
                    var rNum = random.Next(low, high);
                    return rNum;
                }
                else
                {
                    throw new Exception("GRUND CRIES WHAT THE HELL HAPPENED YOU CANNOT USE NEGATIVE NUMBERS FOR LOW IN RAND FUNCTION");
                }
            }
            else
            {
                throw new Exception("GRUND PUNCHES YOU IN THE FACE YOU'RE MISSING ARGUMENTS SIR");
            }
            return null;
        }
        public static object? GF_INDEX_CHAR(GrundDynamicTypeWrapper[] args)
        {
            if (args[0].value != null && args[1].value != null)
            {
                string stringToSearch = args[0].value.ToString();
                int indexToReturn = int.Parse(args[1].value.ToString());
                if (indexToReturn >= 0 && indexToReturn < stringToSearch.Length)
                {
                    return stringToSearch[indexToReturn].ToString();
                }
                else
                {
                    throw new Exception("GRUND CRIES LEARN TO COUNT HIPPY OUT OF RANGE STRING INDEX " + indexToReturn);
                }
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS NULL REFERENCE *SPITS IN FACE*");
            }
        }
        public static object? GF_PARSER(GrundDynamicTypeWrapper[] args)
        {
            if (args[0].value != null && args[1].value != null)
            {
                string ParseType = args[0].value.ToString();
                object toReturn = args[1].value;
                if (ParseType == "INT")
                {
                    toReturn = int.Parse(toReturn.ToString());
                    return toReturn;
                }
                else if (ParseType == "FLOAT")
                {
                    toReturn = float.Parse(toReturn.ToString());
                    return toReturn;
                }
                else if (ParseType == "STRING")
                {
                    toReturn = toReturn.ToString();
                    return toReturn;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS NULL REFERENCE *SPITS IN FACE*");
            }
        }
        public static object?[] GF_SLEEP(GrundDynamicTypeWrapper[]? args)
        {
            object timeToSleep = args[0].value;
            if (timeToSleep is int time)
            {
                Thread.Sleep(time);
            }
            return null;
        }
        public static object?[] GF_LIST_APPEND(GrundDynamicTypeWrapper[] args)
        {
            //Grabs the first list and the second value as arguments to the function 
            if (args[0].value != null && args[1].value != null)
            {
                //Store the first as value 
                var typeToStore = args[1].value;
                //save the second as list 
                List<object?> keyLookUp = args[0].value as List<object?>;
                keyLookUp.Add(typeToStore);
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR LIST");
            }
            return null;
        }
        public static object? GF_LENGTH(GrundDynamicTypeWrapper[] args, Dictionary<string, object?> Variables)
        {
            if (args.Length == 1 && !(args[0].value is List<object?>))
            {
                var lengthProp = args[0].value.GetType().GetProperty("Length");
                if (lengthProp != null)
                {
                    return lengthProp.GetValue(args[0].value, null);
                }
            }
            else if (args.Length == 1 && args[0].value is List<object?> list)
            {
                return list.Count;
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR THRID ARGUMENT IS NOT INT");
            }
            return null;
        }
        public static object?[] GF_LIST_REMOVE(GrundDynamicTypeWrapper[] args)
        {
            if (args.Length == 2 && args[0].value is List<object?> gList && args[1].value is object gValue)
            {
                gList.Remove(gValue);
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR SECOND ARGUMENT IS NOT INT");
            }
            return null;
        }
        public static object? GF_CONTAINS(GrundDynamicTypeWrapper[] args)
        {
            if (args.Length == 2 && args[0].value is Object gObject && args[1].value is object gValue)
            {
                //Yup this is clean 
                if (gObject is List<object?> glist)
                {
                    return glist.Contains(gValue);
                }
                else if (gObject is string gstring && gValue is string gChar)
                {
                    return gstring.Contains(gChar);
                }
                else
                {
                    throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR LIST. AND / OR SECOND ARGUMENT IS NOT OBJECT OR STRING");
                }
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR LIST. AND / OR SECOND ARGUMENT IS NOT OBJECT");
            }
        }














        //** Bools

        public static GrundDynamicTypeWrapper boolOperators(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right, string op)
        {
            if (left.value is bool l && right.value is bool r)
            {
                if (op.Equals("AND"))
                {
                    return new GrundDynamicTypeWrapper (l && r);
                }
                if (op.Equals("OR"))
                {
                    return new GrundDynamicTypeWrapper (l || r);
                }
            }
            throw new Exception("GRUND *HACKS AND VOMITS* IDFK HOW WE GOT HERE NOT A BOOL OPERATION");
        }

        public static GrundDynamicTypeWrapper GreaterThan(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value == null || right.value == null)
            {
                throw new Exception("GRUND *HACKS AND VOMITS* IDFK NULL FOR GREATER THAN");
            }
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l > r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf > rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt > rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat > rInt);
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.value.GetType() + right.value.GetType());
        }
        public static GrundDynamicTypeWrapper GreaterThanOrEqual(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value == null || right.value == null)
            {
                 throw new Exception("GRUND *HACKS AND VOMITS* IDFK NULL FOR GREATER THAN OR EQUAL");
            }
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l >= r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return  new GrundDynamicTypeWrapper(lf >= rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt >= rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat >= rInt);
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.value.GetType() + right.value.GetType());
        }
        public static GrundDynamicTypeWrapper LessThan(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value == null || right.value == null)
            {
                 throw new Exception("GRUND *HACKS AND VOMITS* IDFK NULL FOR GREATER THAN OR EQUAL");
            }
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l < r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return  new GrundDynamicTypeWrapper(lf < rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt < rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return  new GrundDynamicTypeWrapper(lfFloat < rInt);
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
        }
        public static GrundDynamicTypeWrapper LessThanOrEqual(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value == null || right.value == null)
            {
                return new GrundDynamicTypeWrapper(left.value == right.value);
            }
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l <= r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf <= rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt <= rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat <= rInt);
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.value.GetType() + right.value.GetType());
        }
        public static bool IsEqual(object? left, object? right)
        {
            if (left == null || right == null)
            {
                return left == right;
            }
            if (left != null && right == null)
            {
                return false;
            }
            if (left == null && right != null)
            {
                return false;
            }
            if (left is int l && right is int r)
            {
                return l == r;
            }
            if (left is float lf && right is float rf)
            {
                return lf == rf;
            }
            if (left is int lInt && right is float rFloat)
            {
                return lInt == rFloat;
            }
            if (left is float lfFloat && right is int rInt)
            {
                return lfFloat == rInt;
            }
            if (left is string lfString && right is string rString)
            {
                return lfString == rString;
            }
            if (left is bool lfBool && right is bool rBool)
            {
                return lfBool.Equals(rBool);
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
        }
        public static bool IsNotEqual(object? left, object? right)
        {
            if (left == null && right != null)
            {
                return left != right;
            }
            if (left != null && right == null)
            {
                return left != right;
            }
            if (left is int l && right is int r)
            {
                return l != r;
            }
            if (left is float lf && right is float rf)
            {
                return lf != rf;
            }
            if (left is int lInt && right is float rFloat)
            {
                return lInt != rFloat;
            }
            if (left is float lfFloat && right is int rInt)
            {
                return lfFloat != rInt;
            }
            if (left is string lfString && right is string rString)
            {
                return lfString != rString;
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
        }
        //** Adding and Subtract
        //* Adding for variables 
        public static object? Add(object? left, object? right)
        {
            if (left is int l && right is int r)
            {
                return l + r;
            }
            else if (left is float lf && right is float rf)
            {
                return lf + rf;
            }
            else if (left is int lInt && right is float rFloat)
            {
                return lInt + rFloat;
            }
            else if (left is float lfFloat && right is int rInt)
            {
                return lfFloat + rInt;
            }
            else if (left is string)
            {
                return $"{left}{right}";
            }
            else if (right is string || right is string)
            {
                return $"{left}{right}";
            }
            else if (left is List<object?> Llist && right is List<object?> Rlist)
            {
                List<object?> result = Llist;
                foreach (object? o in Rlist)
                {
                    result.Add(o);
                }
                return result;
            }
            throw new Exception("GRUND STUPID CANNOT ADD}." + left.GetType() + " " + right.GetType());
        }

        //*Subtracting from the left and right arguments
        public static object? Sub(object? left, object? right)

        {
            if (left is int l && right is int r)
            {
                return l - r;
            }
            if (left is float lf && right is float rf)
            {
                return lf - rf;
            }
            if (left is int lInt && right is float rFloat)
            {
                return lInt - rFloat;
            }
            if (left is float lfFloat && right is int rInt)
            {
                return lfFloat - rInt;
            }
            throw new Exception("GRUND STUPID CANNOT Subtract}." + left.GetType() + " " + right.GetType());
        }
        //**Multiply the left and right arguments
        public static object? Mul(object? left, object? right)
        {
            if (left is int l && right is int r)
            {
                return l * r;
            }
            if (left is float lf && right is float rf)
            {
                return lf * rf;
            }
            if (left is int lInt && right is float rFloat)
            {
                return lInt * rFloat;
            }
            if (left is float lfFloat && right is int rInt)
            {
                return lfFloat * rInt;
            }
            throw new Exception("GRUND STUPID CANNOT Multiply}." + left.GetType() + " " + right.GetType());
        }
        public static object? Div(object? left, object? right)
        {
            if (left is int l && right is int r)
            {
                return l / r;
            }
            if (left is float lf && right is float rf)
            {
                return lf / rf;
            }
            if (left is int lInt && right is float rFloat)
            {
                return lInt / rFloat;
            }
            if (left is float lfFloat && right is int rInt)
            {
                return lfFloat / rInt;
            }
            throw new Exception("GRUND STUPID CANNOT Divide}." + left.GetType() + " " + right.GetType());
        }
        public static object? Mod(object? left, object? right)
        {
            if (left is int l && right is int r)
            {
                return l % r;
            }
            if (left is float lf && right is float rf)
            {
                return lf % rf;
            }
            if (left is int lInt && right is float rFloat)
            {
                return lInt % rFloat;
            }
            if (left is float lfFloat && right is int rInt)
            {
                return lfFloat % rInt;
            }
            throw new Exception("GRUND STUPID CANNOT Find Mod}." + left.GetType() + " " + right.GetType());
        }
    }
}
