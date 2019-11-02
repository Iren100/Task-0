using System;
using ConsoleApp1.Interfaces;
using System.Collections.Generic;

namespace ConsoleApp1.Classes
{
    class VideoPlayerAdapter : IPlayableAdapter
    {
        public void Play(IPlayable playable, IPlayerContext playerContext)
        {
            Console.WriteLine("Проигрывание видео-файла");
        }

        public void Play(IEnumerable<IPlayable> playables, IPlayerContext playerContext)
        {
            Console.WriteLine("Проигрывание видео-файлов");
        }
    }
}
