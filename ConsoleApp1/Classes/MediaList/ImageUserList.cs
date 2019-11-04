using System;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;
using System.IO;

namespace ConsoleApp1.Classes
{
    public class ImageUserList: Element, IMediaList, IPlayable
    {
        public ICollection<IPlayable> Items { get; private set; }

        public PlayableType PlayableType => PlayableType.Image;

        public StreamReader Stream => throw new NotImplementedException();

        public ImageUserList(Guid id, string name, ICollection<IPlayable> items)
            : base(id, name)
        {
            Items = items;
        }
    }
}
