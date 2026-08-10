using System;
using System.Reflection;
using static MusicStreamingSystem.MusicSystem;

namespace MusicStreamingSystem
{
	public class MusicSystem
	{
		interface IDownloadable
		{
			void download();
		}
		public abstract class Content
		{
			public string title { get; set; }
			public int duration { get; set; }
			public Artist singer;
			public Content(string title, int duration,Artist singer)
			{
				this.duration = duration;
				this.title = title;
				this.singer = singer;
			}
			public abstract void displayDetails();

		}
		public class Track:Content, IDownloadable
        {
			public string genre { get; set; }
            public Track(string title, int duration, Artist singer) : base(title, duration, singer)
            {
				this.genre = "basic track";
            }
            public Track(string title, int duration, Artist singer, string genre) : base(title, duration, singer)
			{
				this.genre = genre;
			}
            public override void displayDetails()
			{
				Console.WriteLine($"\nTitle : {title}\nDuration : {duration}\nArtist : {singer.name}\nGenre : {genre}");
			}
			public void download()
			{
				Console.WriteLine($"Downloading Track Title : {title}");
			}
        }
		public class Podcast : Content
        {
			public Podcast(string title, int duration, Artist singer) : base(title, duration, singer)
            {
            }
            public override void displayDetails()
            {
                Console.WriteLine($"\nTitle : {title}\nDuration : {duration}\nArtist : {singer.name}");
            }
        }
        public class Artist
        {
            public string name { get; }
            List<Content> content;
            public Artist(string name)
            {
                content = new List<Content>();
                this.name = name;
            }
            public void addContent(Content content)
            {
                this.content.Add(content);
            }
            public void displayAllContent()
            {
                foreach (Content c in content)
                {
                    Console.WriteLine($"Title : {c.title}\nDuration : {c.duration}\nArtist : {this.name}\n");
                }
            }
        }
        public class PlayList
		{
			private string name;
			List<Content> playlist;
			public PlayList(string name)
			{
				this.name = name;
				playlist = new List<Content>();
            }
			public void addContent(Content c)
			{
				playlist.Add(c);
			}
            public void displayContens()
			{
                foreach (Content c in playlist)
                {
                    Console.WriteLine($"\nTitle : {c.title}\nDuration : {c.duration}\nArtist : {c.singer.name}\n");
					if(c is Track)
					{
						Console.WriteLine($"Genre : {((Track)c).genre}");
					}
                }
            }
		}
		public static class MusicPlayer
		{
			public static void playMusic(Content content)
			{
				Console.WriteLine($"Now playing {content.title} by {content.singer.name}");
			}
			public static void SharedMusicPlayer(Listener l1,Listener l2,Content content)
			{

				Console.WriteLine($"Now {l1.Name} and {l2.Name} are playing {content.title}");
			}
		}
		public class Listener
		{
			private string name;
			private int uid;
			public string Name
			{
				get
				{
					return name;
				}
			}
			public Listener(string name,int uid)
			{
				this.uid = uid;
				this.name = name;
			}
			public void displayDetails()
			{
				Console.WriteLine($"name : {name}\nuid : {uid}");
			}
		}
	}
}

