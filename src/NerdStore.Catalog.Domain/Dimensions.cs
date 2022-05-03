using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalog.Domain
{
    public class Dimensions
    {
        public decimal Heigth { get; private set; }
        public decimal Width { get; private set; }
        public decimal Depth { get; private set; }
        public Dimensions(decimal heigth, decimal width, decimal depth)
        {
            AssertionConcern.ValidateLessOrEqualThanMin(heigth, 1, "O campo altura não pode ser menor ou igual a 0");
            AssertionConcern.ValidateLessOrEqualThanMin(width, 1, "O campo altura não pode ser menor ou igual a 0");
            AssertionConcern.ValidateLessOrEqualThanMin(depth, 1, "O campo altura não pode ser menor ou igual a 0");

            Heigth = heigth;
            Width = width;
            Depth = depth;
        }
        public string FormattedDescription()
        {
            return $"LxAxP: {Width} x {Heigth} x {Depth}";
        }

        public override string ToString()
        {
            return FormattedDescription();
        }
    }
}
