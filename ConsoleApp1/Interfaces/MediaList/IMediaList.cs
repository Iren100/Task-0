using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    public interface IMediaList : IElement, IPlayable
    {
        ICollection<IPlayable> Items { get; }
    }
}
