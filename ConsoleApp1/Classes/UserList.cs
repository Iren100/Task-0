using System;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;

namespace ConsoleApp1.Classes
{
    public abstract class UserList: Element, IMediaList, IPlayable
    {
        public ICollection<IElement> Items { get; private set; }

        public PlayableType PlayableType => throw new NotImplementedException();

        public UserList(Guid id, string name, ICollection<IElement> items)
            : base(id, name)
        {
            Items = items;
        }
    }
}
