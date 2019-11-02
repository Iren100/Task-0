using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    public interface IPlayer
    {
        IPlayableAdapterFactory Factory { get; set; }

        void Play(IPlayable playable, IPlayerContext playerContext);

        void Play(IEnumerable<IPlayable> playable, IPlayerContext playerContext);
    }
}
