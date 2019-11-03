using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class VideoPlayableAdapterFactory : IPlayableAdapterFactory
    {
        public IPlayableAdapter Create()
        {
            return new VideoPlayerAdapter();
        }
    }
}
