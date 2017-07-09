using System;

namespace CompositeDP
{
    public class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement element)
        {
            Console.WriteLine(
        "Cannot add to a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
           new String('-', indent) + " " + name);
        }

        public override void Remove(DrawingElement element)
        {
            Console.WriteLine(
        "Cannot remove from a PrimitiveElement");
        }
    }
}
