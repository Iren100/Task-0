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

        public void AddElement(IPlayable element)
        {
            Items.Add(element);
        }

        public void AddMediaList(IMediaList mediaList)
        {
            UserLists.Add(mediaList);
        }

        public void AddElementFromMediaList(IMediaList mediaList, IPlayable element)
        {
            mediaList.Items.Add(element);
        }

        public void RemoveElement(Guid id)
        {
            Items.Remove(IPlayableFindById(id));
        }

        public void RemoveMediaList(Guid id)
        {
            UserLists.Remove(IMediaListFindById(id));
        }

        public void RemoveElementFromMediaList(IMediaList mediaList, IPlayable element)
        {
            mediaList.Items.Remove(element);
        }

        public IPlayable IPlayableFindById(Guid id)
        {
            return Items.Where(f => ((IElement)f).Id == id).First();
        }

        public ICollection<IPlayable> FindElementsByName(string name)
        {
            return Items.Where(f => ((IElement)f).Name == name).ToList();
        }

        public IEnumerable<IPlayable> FindElementsByMediaList(Guid id, string name)
        {
            return IMediaListFindById(id).Items.Where(f => ((IElement)f).Name == name);
        }

        public IMediaList IMediaListFindById(Guid id)
        {
            return UserLists.Where(v => ((IElement)v).Id == id).First();
        }

        public IEnumerable<IMediaList> FindMediaLists(string name)
        {
            return UserLists.Where(v => ((IElement)v).Name == name);
        }

        #endregion
    }
}
