using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////шаблон стратегия
            
            ////создание плейера + аудио элемента+ чтобы работало, создать конструктор с файлом
            //Playable player = new Playable(new AudioElement(new Guid(), "Music1"));

            ////проигрывание
            //player.Play();

            //player.Player = new VideoElement(new Guid(), "Video1");

            //player.Play();

            //Console.ReadLine();
        }

        //продолжительность
        interface IDuratible
        {
            TimeSpan Duration {get; set;}
        }

        //
        interface IMediaStreamable
        {
            StreamReader Stream { get; }
        }

        //   
        public interface IElement
        {
            Guid Id { get; }
            string Name { get; set; }
        }

        //
        public interface IMediaList: IElement
        {
            ICollection<IElement> Items { get; }
        }

        // 1 класс
        public abstract class Mediateka
        {
            public ICollection<IElement> Items { get; private set; }
            public ICollection<IMediaList> UserLists { get; private set; }

            public Mediateka(ICollection<IElement> items, ICollection<IMediaList> userlists)
            {
                Items = items;
                UserLists = userlists;
            }

            // мое

            public void AddElement(IElement element)
            {
                Items.Add(element);
            }

            public void DeleteElement(IElement element)
            {
                Items.Remove(element);
            }

            public void AddElement(IMediaList mediaList)
            {
                UserLists.Add(mediaList);
            }

            public void DeleteElement(IMediaList mediaList)
            {
                UserLists.Remove(mediaList);
            }

            public void AddElement(IMediaList mediaList, IElement element)
            {
                mediaList.Items.Add(element);
            }

            public void DeleteElement(IMediaList mediaList, IElement element)
            {
                mediaList.Items.Add(element);
            }

            IElement FindElement(string name)
            {
                return Items.Where(v => v.Name == name).First();
            }

            IElement FindMediaList(string name)
            {
                return UserLists.Where(v => v.Name == name).First();
            }

            IElement FindElementByMediaLists(string name)
            {
                return UserLists.Select(m => m.Items).Select(v=>v.Where(f=>f.Name == name)).First().First();
            }
        }

        // 2 класс
        public abstract class Element : IElement
        {
            public Guid Id { get; private set; }
            public string Name { get; set; }

            public Element(Guid id, string name)
            {
                Id = id;
                Name = name;
            }
        }

        // 3 класс
        public class UserList : Element, IMediaList, IPlayer
        {
            public ICollection<IElement> Items { get; private set; }

            public UserList(Guid id, string name, ICollection<IElement> items)
                :base (id, name)
            {
                Items = items;
            }

            void IPlayer.Player()
            {
                //какие-то операции проигрывания списка
            }
        }

        // 4 класс
        public abstract class AudioElement : Element, IMediaStreamable, IDuratible, IPlayer
        {
            public FileInfo FileInfo { get; private set; }
            public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

            public TimeSpan Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public AudioElement(Guid id, string name)
              : base(id, name)
            {
            }

            void IPlayer.Player()
            {
                //какие-то операции проигрывания, например:
                string line = Stream.ReadLine();
                Stream.Close();
                Stream.Dispose();
                Console.WriteLine("Проигрывание аудио:" + line);
            }
        }

        //интерфейс плейера
        public interface IPlayer
        {
            void Player();
        }

        //интерфейс проигрываемого файла
        public interface IPlayable
        {
            void Play();
        }

        // мое

        // 5 класс
        public abstract class VideoElement : Element, IMediaStreamable, IDuratible, IPlayer
        {
            public FileInfo FileInfo { get; private set; }
            public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

            public TimeSpan Duration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public VideoElement(Guid id, string name)
              : base(id, name)
            {
            }

            void IPlayer.Player()
            {
                //какие-то операции проигрывания, например:
                string line = Stream.ReadLine();
                Stream.Close();
                Stream.Dispose();
                Console.WriteLine("Проигрывание видео:" + line);
            }
        }

        // 6 класс
        public abstract class ImageElement : Element, IMediaStreamable, IPlayer
        {
            public FileInfo FileInfo { get; private set; }
            public StreamReader Stream { get { return new StreamReader(FileInfo.FullName); } }

            public ImageElement(Guid id, string name)
              : base(id, name)
            {
            }

            void IPlayer.Player()
            {
                //какие-то операции проигрывания, например:
                string line = Stream.ReadLine();
                Stream.Close();
                Stream.Dispose();
                Console.WriteLine("Показ изображения:" + line);
            }
        }

        //плейер
        public abstract class Playable: IPlayable
        {
            public IPlayer Player { private get; set; }

            public Playable(IPlayer player)
            {
                Player = player;
            }

            public void Play()
            {
                //проигрывание
                //throw new NotImplementedException();
                Player.Player();
            }
        }

    }
}
