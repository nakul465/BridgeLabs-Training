// See https://aka.ms/new-console-template for more information
using MusicStreamingSystem;
using static MusicStreamingSystem.MusicSystem;
Artist arijit = new Artist("Arijit");
Artist atif = new Artist("Atif Aslam");
Artist ranveer = new Artist("Ranveer Allahbadia");

Track t1 = new Track("Song1", 2, arijit);
Track t2 = new Track("Song2", 2, atif);

Podcast p1 = new Podcast("Why Do humans Exist", 25, ranveer);
Podcast p2 = new Podcast("Death", 35, ranveer);

PlayList paylist1 = new PlayList("All Content");
PlayList paylist2 = new PlayList("All songs");
PlayList paylist3 = new PlayList("All podcasts");

Listener l1 = new Listener("Nakul",1);
Listener l2 = new Listener("Manish", 1);

paylist1.addContent(t1);
paylist1.addContent(t2);
paylist1.addContent(p1);
paylist1.addContent(p2);

arijit.addContent(t1);

atif.addContent(t2);

ranveer.addContent(p1);
ranveer.addContent(p2);

paylist2.addContent(t1);
paylist2.addContent(t2);

paylist3.addContent(p1);
paylist3.addContent(p2);

paylist1.displayContens();
paylist2.displayContens();
paylist3.displayContens();

t1.displayDetails();
p1.displayDetails();

Console.WriteLine("\n\nArijit:");
arijit.displayAllContent();
Console.WriteLine("\n\natif:");
atif.displayAllContent();
Console.WriteLine("\n\nranveer:");
ranveer.displayAllContent();

MusicPlayer.SharedMusicPlayer(l1, l2, t1);