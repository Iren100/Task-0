using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class MediaStorage: IMediaStorage
    {
        public ICollection<IPlayable> Items { get; private set; }
        public ICollection<IMediaList> UserLists { get; private set; }

        public MediaStorage(ICollection<IPlayable> items, ICollection<IMediaList> userlists)
        {
            Items = items;
            UserLists = userlists;
        }

        // мое

        #region Operations

        public void AddPlayable(IPlayable IPlayable)
        {
            Items.Add(IPlayable);
        }

        public void AddMediaList(IMediaList mediaList)
        {
            UserLists.Add(mediaList);
        }

        public void AddPlayableFromMediaList(IMediaList mediaList, IPlayable IPlayable)
        {
            mediaList.Items.Add(IPlayable);
        }

        public void RemoveIPlayable(Guid id)
        {
            Items.Remove(IPlayableFindById(id));
        }

        public void RemoveMediaList(Guid id)
        {
            UserLists.Remove(IMediaListFindById(id));
        }

        public void RemoveIPlayableFromMediaList(IMediaList mediaList, IPlayable IPlayable)
        {
            mediaList.Items.Remove(IPlayable);
        }

        public IPlayable IPlayableFindById(Guid id)
        {
            return Items.Where(f => ((IElement)f).Id == id).First();
        }

        public IEnumerable<IPlayable> IPlayablesFindByName(string name)
        {
            return Items.Where(f => ((IElement)f).Name == name).ToList();
        }

        public IEnumerable<IPlayable> IPlayablesFindByMediaList(Guid id, string name)
        {
            return IMediaListFindById(id).Items.Where(f => ((IElement)f).Name == name);
        }

        public IMediaList IMediaListFindById(Guid id)
        {
            return UserLists.Where(v => v.Id == id).First();
        }

        public IEnumerable<IMediaList> IMediaListsFindByName(string name)
        {
            return UserLists.Where(v => v.Name == name);
        }

        #endregion
    }
}
