using Grund;
using static Grund.GrundTypeWrapper;
namespace Grund
{
    public class SlanderLibrary 
    {

        //TODO: At some point the error stack needs to be sent here because these error messages are ass!

        //* The SlanderLibrary class contains a collection of static methods that can be called from Grund code.

        //* FUNCTIONS ********************************

        // The GF_WRITE_INLINE function takes a variable number of arguments, which can be any combination of strings, numbers,
        // booleans, null values, or lists. It prints each argument to the console on the same line, separated by spaces,
        // and then prints a newline character at the end.
        public static GrundDynamicTypeWrapper GF_WRITE_INLINE(GrundDynamicTypeWrapper[] args)
        {
        
            foreach (var arg in args)
            {
                if (arg.value is List<GrundDynamicTypeWrapper> list)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.Write(list.ElementAt(i).value);
                    }
                }
                else
                {
                    Console.Write(arg.value);
                }
            }
            Console.WriteLine();
            return new GrundDynamicTypeWrapper(null);
        }

        // The GF_WRITE function is similar to GF_WRITE_INLINE, but it does not print a newline character at the end.
        public static GrundDynamicTypeWrapper GF_WRITE(GrundDynamicTypeWrapper[] args)
        {
            foreach (var arg in args)
            {
                if (arg.value is List<GrundDynamicTypeWrapper> list)
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
            return new GrundDynamicTypeWrapper(null);
        }
        // Moves Console Cursors position
        public static GrundDynamicTypeWrapper GF_CURSOR_MOVE(GrundDynamicTypeWrapper[] args)
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
            return new GrundDynamicTypeWrapper(null);
        }
        //Standard Input
        public static GrundDynamicTypeWrapper GF_WRITE_INPUT(GrundDynamicTypeWrapper[] args)
        {
            object toReturn = Console.ReadLine();
            if (args != null && args.Length != 0)
            {
                if (args[0].value.ToString() == "INT")
                {
                    return new GrundDynamicTypeWrapper(int.Parse(toReturn.ToString()));
                }
                else if (args[0].value.ToString() == "FLOAT")
                {
                    return new GrundDynamicTypeWrapper(float.Parse(toReturn.ToString()));
                }
            }
            else
            {
                return new GrundDynamicTypeWrapper(toReturn.ToString());
            }
            throw new Exception("GRUND CRIES WHAT THE HELL HAPPENED INPUT STATEMENT DIED");
        }
        // Clear Screen
        public static GrundDynamicTypeWrapper GF_CLS(GrundDynamicTypeWrapper[] args)
        {
            Console.Clear();
            return new GrundDynamicTypeWrapper(null);
        }
        //Get key without stopping execution
        public static GrundDynamicTypeWrapper GF_GET_KEY(GrundDynamicTypeWrapper[] args)
        {
            //! As of native grund this peak no longer opperates as intended 
            //TODO: Find a solution to fix this no longer working
            if (Console.KeyAvailable) // Non-blocking peek 
            {
                object toReturn = Console.ReadKey(true).KeyChar;
                return new GrundDynamicTypeWrapper(toReturn.ToString());
            }
            else
            {
                 return new GrundDynamicTypeWrapper(null);
            }

            throw new Exception("GRUND CRIES WHAT THE HELL HAPPENED INPUT STATEMENT DIED");
        }
        //Random Value
        public static GrundDynamicTypeWrapper GF_RAND(GrundDynamicTypeWrapper[] args)
        {
            if ((args[0].value != null && args[1].value != null) && (args[0].value is int low && args[1].value is int high))
            {
                if (low >= 0)
                {
                    var random = new Random();
                    var rNum = random.Next(low, high);
                    return new GrundDynamicTypeWrapper(rNum);
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
        }
        public static GrundDynamicTypeWrapper GF_REPLACE_CHAR(GrundDynamicTypeWrapper[] args)
        {
            if (args[0].value != null && args[1].value != null && args[2].value != null)
            {
                string stringToSearch = args[0].value.ToString();
                int indexToReturn = int.Parse(args[2].value.ToString());
                char newChar = args[1].value.ToString()[0];
                if (indexToReturn >= 0 && indexToReturn < stringToSearch.Length)
                {
                    char[] chars = stringToSearch.ToCharArray();
                    chars[indexToReturn] = newChar;
                    return  new GrundDynamicTypeWrapper(new string(chars));
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
        public static GrundDynamicTypeWrapper GF_INDEX_CHAR(GrundDynamicTypeWrapper[] args)
        {
            if (args[0].value != null && args[1].value != null)
            {
                string stringToSearch = args[0].value.ToString();
                int indexToReturn = int.Parse(args[1].value.ToString());
                if (indexToReturn >= 0 && indexToReturn < stringToSearch.Length)
                {
                    return  new GrundDynamicTypeWrapper(stringToSearch[indexToReturn].ToString());
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
        public static GrundDynamicTypeWrapper GF_PARSER(GrundDynamicTypeWrapper[] args)
        {
            if (args[0].value != null && args[1].value != null)
            {
                string ParseType = args[0].value.ToString();
                object toReturn = args[1].value;
                if (ParseType == "INT")
                {
                    toReturn = int.Parse(toReturn.ToString());
                    return new GrundDynamicTypeWrapper(toReturn);
                }
                else if (ParseType == "FLOAT")
                {
                    toReturn = float.Parse(toReturn.ToString());
                    return new GrundDynamicTypeWrapper(toReturn);
                }
                else if (ParseType == "STRING")
                {
                    toReturn = toReturn.ToString();
                    return new GrundDynamicTypeWrapper(toReturn);
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
        public static GrundDynamicTypeWrapper GF_SLEEP(GrundDynamicTypeWrapper[]? args)
        {
            object timeToSleep = args[0].value;
            if (timeToSleep is int time)
            {
                Thread.Sleep(time);
            }
           return new GrundDynamicTypeWrapper(null);
        }
        public static GrundDynamicTypeWrapper GF_LIST_APPEND(GrundDynamicTypeWrapper[] args)
        {
            //Grabs the first list and the second value as arguments to the function 
            if (args[0].value != null && args[1].value != null)
            {
                //Store the first as value 
                var typeToStore = args[1];
                //save the second as list 
                List<GrundDynamicTypeWrapper> keyLookUp = args[0].value as List<GrundDynamicTypeWrapper>;
                keyLookUp.Add(typeToStore);
                args[0].value = keyLookUp;
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR LIST");
            }
             return new GrundDynamicTypeWrapper(null);
        }
        public static GrundDynamicTypeWrapper GF_LENGTH(GrundDynamicTypeWrapper[] args)
        {
            if (args.Length == 1 && (args[0].value is string str))
            {
                return new GrundDynamicTypeWrapper(str.Length);
            }
            else if (args.Length == 1 && args[0].value is List<GrundDynamicTypeWrapper> list)
            {
                return new GrundDynamicTypeWrapper(list.Count);
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR THRID ARGUMENT IS NOT INT");
            }
             return new GrundDynamicTypeWrapper(null);
        }
        public static GrundDynamicTypeWrapper GF_LIST_REMOVE(GrundDynamicTypeWrapper[] args)
        {
            if (args.Length == 2 && args[0].value is List<GrundDynamicTypeWrapper> gList && args[1].value is object)
            {
                gList.Remove(args[1]);
                args[0].value = gList;
            }
            else
            {
                throw new Exception("GRUND SAYS ERROR IN ARGUMENTS FIRST ARGUMENT IS NOT STRING OR SECOND ARGUMENT IS NOT INT");
            }
            return new GrundDynamicTypeWrapper(null);
        }
        public static GrundDynamicTypeWrapper GF_CONTAINS(GrundDynamicTypeWrapper[] args)
        {
            if (args.Length == 2 && args[0].value is Object gObject && args[1].value is object gValue)
            {
                //Yup this is clean 
                if (gObject is List<GrundDynamicTypeWrapper> glist)
                {
                    return  new GrundDynamicTypeWrapper(glist.Contains(gValue));
                }
                else if (gObject is string gstring && gValue is string gChar)
                {
                    return new GrundDynamicTypeWrapper(gstring.Contains(gChar));
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
                 throw new Exception("GRUND *HACKS AND VOMITS* IDFK NULL FOR LESS THAN");
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
            throw new Exception("GRUND STUPID CANNOT compare." + left.value.GetType() + right.value.GetType());
        }
        public static GrundDynamicTypeWrapper LessThanOrEqual(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value == null || right.value == null)
            {
                throw new Exception("GRUND *HACKS AND VOMITS* IDFK NULL FOR LESS THAN OR EQUAL");
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
        public static GrundDynamicTypeWrapper IsEqual(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value != null && right.value == null)
            {
                return new GrundDynamicTypeWrapper(false);
            }
            if (left.value == null && right.value != null)
            {
                return new GrundDynamicTypeWrapper(false);
            }
            if (left.value == null && right.value == null)
            {
                return new GrundDynamicTypeWrapper(true);
            }
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l == r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf == rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt == rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat == rInt);
            }
            if (left.value is string lfString && right.value is string rString)
            {
                return new GrundDynamicTypeWrapper(lfString == rString);
            }
            if (left.value is bool lfBool && right.value is bool rBool)
            {
                return new GrundDynamicTypeWrapper(lfBool.Equals(rBool));
            }
            throw new Exception("GRUND STUPID CANNOT compare." + left.GetType() + right.GetType());
        }
        public static GrundDynamicTypeWrapper IsNotEqual(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            return new GrundDynamicTypeWrapper(!(bool)(IsEqual(left, right).value));
        }
        //** Adding and Subtract
        //* Adding for variables 
        public static GrundDynamicTypeWrapper Add(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value is int v && right.value is int v1)
            {
                return new GrundDynamicTypeWrapper(v + v1);
            }
            else if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf + rf);
            }
            else if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt + rFloat);
            }
            else if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper (lfFloat + rInt);
            }
            else if (left.value is string || right.value is string)
            {
                return new GrundDynamicTypeWrapper ($"{left.value}{right.value}");
            }
            else if (left.value is List<GrundDynamicTypeWrapper> Llist && right.value is List<GrundDynamicTypeWrapper> Rlist)
            {
                List<GrundDynamicTypeWrapper> result = Llist;
                foreach (GrundDynamicTypeWrapper gdtw in Rlist)
                {
                    result.Add(gdtw);
                }
                return new GrundDynamicTypeWrapper(result);
            }
            throw new Exception("GRUND STUPID CANNOT ADD " + left.value.GetType() + " " + right.value.GetType());
        }

        //*Subtracting from the left and right arguments
        public static GrundDynamicTypeWrapper Sub(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l - r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf - rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt - rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat - rInt);
            }
            throw new Exception("GRUND STUPID CANNOT Subtract " + left.value.GetType() + " " + right.value.GetType());
        }
        //**Multiply the left and right arguments
        public static GrundDynamicTypeWrapper Mul(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l * r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf * rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt * rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat * rInt);
            }
            throw new Exception("GRUND STUPID CANNOT Multiply " + left.value.GetType() + " " + right.value.GetType());
        }
        public static GrundDynamicTypeWrapper Div(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l / r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf / rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt / rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat / rInt);
            }
            throw new Exception("GRUND STUPID CANNOT Divide " + left.value.GetType() + " " + right.value.GetType());
        }
        public static GrundDynamicTypeWrapper Mod(GrundDynamicTypeWrapper left, GrundDynamicTypeWrapper right)
        {
            if (left.value is int l && right.value is int r)
            {
                return new GrundDynamicTypeWrapper(l % r);
            }
            if (left.value is float lf && right.value is float rf)
            {
                return new GrundDynamicTypeWrapper(lf % rf);
            }
            if (left.value is int lInt && right.value is float rFloat)
            {
                return new GrundDynamicTypeWrapper(lInt % rFloat);
            }
            if (left.value is float lfFloat && right.value is int rInt)
            {
                return new GrundDynamicTypeWrapper(lfFloat % rInt);
            }
            throw new Exception("GRUND STUPID CANNOT Find Mod " + left.value.GetType() + " " + right.value.GetType());
        }
    }
}
