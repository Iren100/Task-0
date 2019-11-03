using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class AudioPlayableAdapterFactory : IPlayableAdapterFactory
    {
        public IPlayableAdapter Create()
        {
            return new AudioPlayerAdapter();
        }
    }
}
