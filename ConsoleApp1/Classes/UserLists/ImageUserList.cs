using System;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Classes
{
    public class ImageUserList: Element, IMediaList, IPlayable
    {
        public ICollection<IElement> Items { get; private set; }

        public PlayableType PlayableType => PlayableType.Image;

        public ImageUserList(Guid id, string name, ICollection<IElement> items)
            : base(id, name)
        {
            Items = items;
        }
    }
}
