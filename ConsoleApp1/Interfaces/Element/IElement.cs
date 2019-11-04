using System;

namespace ConsoleApp1.Interfaces
{
    public interface IElement
    {
        Guid Id { get; }
        string Name { get; set; }
    }
}
