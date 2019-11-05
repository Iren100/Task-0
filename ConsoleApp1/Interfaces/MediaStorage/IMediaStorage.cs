using System;
using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    interface IMediaStorage
    {
        void AddPlayable(IPlayable IPlayable);

        void AddMediaList(IMediaList mediaList);

        void AddPlayableFromMediaList(IMediaList mediaList, IPlayable IPlayable);

        void RemoveIPlayable(Guid id);

        void RemoveMediaList(Guid id);

        void RemoveIPlayableFromMediaList(IMediaList mediaList, IPlayable IPlayable);

        IPlayable IPlayableFindById(Guid id);

        IEnumerable<IPlayable> IPlayablesFindByName(string name);

        IEnumerable<IPlayable> IPlayablesFindByMediaList(Guid id, string name);

        IMediaList IMediaListFindById(Guid id);

        IEnumerable<IMediaList> IMediaListsFindByName(string name);
    }
}
