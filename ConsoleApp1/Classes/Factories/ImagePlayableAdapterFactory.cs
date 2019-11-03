using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class ImagePlayableAdapterFactory : IPlayableAdapterFactory
    {
        public IPlayableAdapter Create()
        {
            return new ImagePlayerAdapter();
        }
    }
}
