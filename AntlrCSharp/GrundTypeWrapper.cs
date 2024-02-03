using Antlr4.Runtime.Misc;
namespace Grund
{
    public class GrundTypeWrapper : GrundBaseVisitor<object?>
    {
        public class GrundDynamicTypeWrapper
        {
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
