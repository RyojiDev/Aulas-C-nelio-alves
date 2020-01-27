
using HerdarVsContrato.Model.Enums;

namespace HerdarVsContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
