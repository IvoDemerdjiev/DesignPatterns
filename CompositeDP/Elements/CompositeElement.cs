using System;
using System.Collections.Generic;

namespace CompositeDP
{
    public class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement element)
        {
            elements.Add(element);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
        "+ " + name);

            foreach (var element in elements)
            {
                element.Display(indent + 2);
            }
        }

        public override void Remove(DrawingElement element)
        {
            elements.Remove(element);
        }
    }
}
