using System;
using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var MediaStorage = new MediaStorage(new List<IPlayable>(), new List<IMediaList>());

            var Directory = Environment.CurrentDirectory;

            //аудио

            Guid id = Guid.NewGuid();
            IPlayable element = new AudioElement(id, "AudioElement", null, new System.IO.FileInfo(Directory + "\\Баста.mp3"));
            MediaStorage.AddPlayable(element);

            Player player = new Player(new PlayableAdapterFactory());

            player.Play(MediaStorage.IPlayableFindById(id));

            //видео

            id = Guid.NewGuid();
            element = new VideoElement(id, "VideoElement", null, new System.IO.FileInfo(Directory + "\\Баста.mp4"));
            MediaStorage.AddPlayable(element);

            player.Play(MediaStorage.IPlayableFindById(id));

            //список

            Guid idMediaList = Guid.NewGuid();
            IMediaList UserList = new AudioUserList(idMediaList, "AudioUserList", (ICollection<IPlayable>)MediaStorage.IPlayablesFindByName("AudioElement"));
            MediaStorage.AddMediaList(UserList);

            id = Guid.NewGuid();
            element = new AudioElement(id, "AudioElement2", null, new System.IO.FileInfo(Directory + "\\Баста.mp3"));
            MediaStorage.AddPlayableFromMediaList(UserList, element);

            IMediaList mls = MediaStorage.IMediaListFindById(idMediaList);
            
            player.Play(mls.Items);

            Console.ReadLine();
        }
    }
}
