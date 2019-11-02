using System.Collections.Generic;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class Player: IPlayer
    {
        public IPlayableAdapterFactory Factory { get; set; }

        public Player(IPlayableAdapterFactory playableAdapterFactory)
        {
            Factory = playableAdapterFactory;
        }

        public void Play(IPlayable playable, IPlayerContext playerContext)
        {
            Factory.Create().Play(playable, playerContext);
        }

        public void Play(IEnumerable<IPlayable> playables, IPlayerContext playerContext)
        {
            Factory.Create().Play(playables, playerContext);
        }
    }
}
