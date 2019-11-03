using System;
using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    interface IMediaStorage
    {
        void AddElement(IElement element);

        void AddMediaList(IMediaList mediaList);

        void AddElementFromMediaList(IMediaList mediaList, IElement element);

        void RemoveElement(Guid id);

        void RemoveMediaList(Guid id);

        void RemoveElementFromMediaList(IMediaList mediaList, IElement element);

        IElement IElementFindById(Guid id);

        ICollection<IElement> FindElementsByName(string name);

        IEnumerable<IElement> FindElementsByMediaList(Guid id, string name);

        IMediaList IMediaListFindById(Guid id);

        IEnumerable<IMediaList> FindMediaLists(string name);
    }
}
