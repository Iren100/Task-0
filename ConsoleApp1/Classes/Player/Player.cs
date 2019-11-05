using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;

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
            Factory.Create(playable.PlayableType).Play(playable, playerContext);
        }

        public void Play(IEnumerable<IPlayable> playables)
        {
            foreach(IPlayable playable in playables)
                Factory.Create(playable.PlayableType).Play(playable, playerContext);
        }
    }
}
