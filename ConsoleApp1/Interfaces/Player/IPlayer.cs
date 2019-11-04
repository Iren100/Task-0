using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    public interface IPlayer
    {
        IPlayableAdapterFactory Factory { get; set; }

        void Play(IPlayable playable);

        void Play(IEnumerable<IPlayable> playable);
    }
}
