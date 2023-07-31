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

        public override object VisitCollections([NotNull] GrundParser.CollectionsContext context)
        {
            if (context.list() is { } l)
            {
                return new GrundDynamicTypeWrapper(l.expression().Select(Visit).ToList());
            }
            throw new Exception("GRUND SLAMS FIST NOT VALID COLLECTIONS LINE: " + context.Start.Line.ToString());
        }
    }
}
