using System;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Enums;
using System.IO;

namespace ConsoleApp1.Classes
{
    public abstract class UserList: Element, IMediaList, IPlayable
    {
        public ICollection<IPlayable> Items { get; private set; }

        public PlayableType PlayableType => throw new NotImplementedException();

        public StreamReader Stream => throw new NotImplementedException();

        public UserList(Guid id, string name, ICollection<IPlayable> items)
            : base(id, name)
        {
            Items = items;
        }
    }
}
