using System;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public abstract class Element: IElement
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Element(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
