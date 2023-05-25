using Antlr4.Runtime.Misc;
namespace Grund
{
    public class GrundTypeWrapper : GrundBaseVisitor<object?>
    {
        public struct GrundDynamicTypeWrapper
        {
            public object? value { get; set; }
            public GrundDynamicTypeWrapper(object? Value)
            {
                this.value = Value;
            }
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
