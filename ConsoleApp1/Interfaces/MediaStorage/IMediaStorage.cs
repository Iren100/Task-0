using System;
using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    interface IMediaStorage
    {
        void AddElement(IPlayable element);

        void AddMediaList(IMediaList mediaList);

        void AddElementFromMediaList(IMediaList mediaList, IPlayable element);

        void RemoveElement(Guid id);

        void RemoveMediaList(Guid id);

        void RemoveElementFromMediaList(IMediaList mediaList, IPlayable element);

        IPlayable IPlayableFindById(Guid id);

        ICollection<IPlayable> FindElementsByName(string name);

        IEnumerable<IPlayable> FindElementsByMediaList(Guid id, string name);

        IMediaList IMediaListFindById(Guid id);

        IEnumerable<IMediaList> FindMediaLists(string name);
    }
}
