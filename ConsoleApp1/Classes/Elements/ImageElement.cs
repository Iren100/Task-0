using System;
using System.IO;
using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class ImageElement: Element, IMediaStreamable, IPlayable
    {
        public FileInfo FileInfo { get; private set; }
        public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

        public PlayableType PlayableType => PlayableType.Image;

        public ImageElement(Guid id, string name)
          : base(id, name)
        {
        }
    }
}
