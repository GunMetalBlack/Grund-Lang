using Antlr4.Runtime.Misc;
namespace Grund
{
    //One shutters to think tf he did this for but it was worth it. Silly nulls didn't work. :D
    public class GrundTypeWrapper : GrundBaseVisitor<object?>
    {
        public class GrundDynamicTypeWrapper
        {
            //He do you have a value abstraction system to do advanved operations with your built in data? Also you want to pass that data and make it editable from a copy of that data
            //! Welcome to hell
            public object? value;
            public GrundDynamicTypeWrapper(object? Value)
            {
                this.value = Value;
            }
            //C# wizard methods for If statements because Im Lazy
            public static implicit operator bool(GrundDynamicTypeWrapper instance)
            {
                return (bool)instance.value;
            }
        }
    }
}
