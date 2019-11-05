using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Classes
{
    class PlayableAdapterFactory : IPlayableAdapterFactory
    {
        public IPlayableAdapter Create(PlayableType playableType)
        {
            switch (playableType)
            {
                case PlayableType.Audio:
                    {
                        return new AudioPlayerAdapter();
                        break;
                    }
                case PlayableType.Video:
                    {
                        return new VideoPlayerAdapter();
                        break;
                    }
                case PlayableType.Image:
                    {
                        return new ImagePlayerAdapter();
                        break;
                    }
                default:
                    {
                        return new AudioPlayerAdapter();
                        break;
                    }
            }
        }
    }
}
