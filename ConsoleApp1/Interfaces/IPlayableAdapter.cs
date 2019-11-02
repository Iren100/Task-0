using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    public interface IPlayableAdapter
    {
        void Play(IPlayable playable, IPlayerContext playerContext);

        void Play(IEnumerable<IPlayable> playable, IPlayerContext playerContext);
    }
}
