using ConsoleApp1.Enums;
using System.IO;

namespace ConsoleApp1.Interfaces
{
    public interface IPlayable
    {
        PlayableType PlayableType { get;  }

        StreamReader Stream { get; }
    }
}
