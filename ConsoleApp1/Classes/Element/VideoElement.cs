using System;
using System.IO;
using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class VideoElement: Element, IDuratible, IPlayable
    {
        private FileInfo FileInfo { get; set; }
        public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

        public TimeSpan? Duration { get; }

        public PlayableType PlayableType => PlayableType.Video;

        public VideoElement(Guid id, string name, TimeSpan? duration)
          : base(id, name)
        {
            Duration = duration;
        }
    }
}
