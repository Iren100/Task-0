using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    public interface IMediaList : IElement
    {
        ICollection<IElement> Items { get; }
    }
}
