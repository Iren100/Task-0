using System;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class ImagePlayerAdapter : IPlayableAdapter
    {
        public void Play(IPlayable playable, IPlayerContext playerContext)
        {
            Console.WriteLine("Проигрывание файла изображения");
        }
    }
}
