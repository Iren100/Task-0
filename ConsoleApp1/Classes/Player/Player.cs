using System.Collections.Generic;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class Player: IPlayer
    {
        private IPlayerContext playerContext = new PlayerContext();

        public IPlayableAdapterFactory Factory { get; set; }

        public Player(IPlayableAdapterFactory playableAdapterFactory)
        {
            Factory = playableAdapterFactory;
        }

        public void Play(IPlayable playable)
        {
            Factory.Create().Play(playable, playerContext);
        }

        public void Play(IEnumerable<IPlayable> playables)
        {
            foreach(IMediaList playable in playables)
                Factory.Create().Play(playable, playerContext);
        }
    }
}
