﻿using System;
using System.IO;
using ConsoleApp1.Enums;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    public class AudioElement: Element, IMediaStreamable, IPlayable
    {
        public FileInfo FileInfo { get; private set; }
        public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

        public TimeSpan Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PlayableType PlayableType => PlayableType.Audio;

        public AudioElement(Guid id, string name)
          : base(id, name)
        {
        }
    }
}