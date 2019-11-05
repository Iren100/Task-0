using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Classes
{
    class PlayableAdapterFactory : IPlayableAdapterFactory
    {
        private PlayableType PlayableType { get; }

        public PlayableAdapterFactory(PlayableType playableType)
        {
            PlayableType = playableType;
        }

        public IPlayableAdapter Create()
        {
            switch (PlayableType)
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
