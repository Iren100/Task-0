using System;
using System.IO;
using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class AudioElement: Element, IDuratible, IPlayable
    {
        private FileInfo FileInfo { get; set; }
        public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

        public PlayableType PlayableType => PlayableType.Audio;

        public TimeSpan? Duration { get; }

        public AudioElement(Guid id, string name, TimeSpan? duration, FileInfo fileInfo)
          : base(id, name)
        {
            Duration = duration;
            FileInfo = fileInfo;
        }
    }
}
