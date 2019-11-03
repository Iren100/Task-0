using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes
{
    class MediaStorage: IMediaStorage
    {
        public ICollection<IElement> Items { get; private set; }
        public ICollection<IMediaList> UserLists { get; private set; }

        public MediaStorage(ICollection<IElement> items, ICollection<IMediaList> userlists)
        {
            Items = items;
            UserLists = userlists;
        }

        // мое

        #region Operations

        public void AddElement(IElement element)
        {
            Items.Add(element);
        }

        public void AddMediaList(IMediaList mediaList)
        {
            UserLists.Add(mediaList);
        }

        public void AddElementFromMediaList(IMediaList mediaList, IElement element)
        {
            mediaList.Items.Add(element);
        }

        public void RemoveElement(Guid id)
        {
            Items.Remove(IElementFindById(id));
        }

        public void RemoveMediaList(Guid id)
        {
            UserLists.Remove(IMediaListFindById(id));
        }

        public void RemoveElementFromMediaList(IMediaList mediaList, IElement element)
        {
            mediaList.Items.Remove(element);
        }

        //public IElement IElementFindById(Guid id)
        //{
        //    return UserLists.Select(m => m.Items).Select(v => v.Where(f => f.Id == id)).First().First();
        //}

        public IElement IElementFindById(Guid id)
        {
            return Items.Where(f => f.Id == id).First();
        }

        //public IEnumerable<IElement> FindElementsByName(string name)
        //{
        //    return UserLists.Select(m => m.Items).Select(v => v.Where(f => f.Name == name)).First();
        //}

        public ICollection<IElement> FindElementsByName(string name)
        {
            return Items.Where(f => f.Name == name).ToList();
        }

        public IEnumerable<IElement> FindElementsByMediaList(Guid id, string name)
        {
            return IMediaListFindById(id).Items.Where(f => f.Name == name);
        }

        public IMediaList IMediaListFindById(Guid id)
        {
            return UserLists.Where(v => v.Id == id).First();
        }

        public IEnumerable<IMediaList> FindMediaLists(string name)
        {
            return UserLists.Where(v => v.Name == name);
        }

        #endregion
    }
}
