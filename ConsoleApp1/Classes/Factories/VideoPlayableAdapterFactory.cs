using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class VideoPlayableAdapterFactory : IPlayableAdapterFactory
    {
        public IPlayableAdapter Adapter { get; set; }

        public IPlayableAdapter Create()
        {
            return new VideoPlayerAdapter();
        }
    }
}
