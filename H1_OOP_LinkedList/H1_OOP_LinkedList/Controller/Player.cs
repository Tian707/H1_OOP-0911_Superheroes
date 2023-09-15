using H1_OOP_LinkedList.Model;
using H1_OOP_LinkedList.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_LinkedList.Controller
{
    public class Player
    {
        public void Play()
        {
            // Create new tracks:
            Track track1 = new Track("Bohemian Rhapsody", "Queen", 354, "Rock");
            Track track2 = new Track("Imagine", "John Lennon", 183, "Pop");
            Track track3 = new Track("Hotel California", "Eagles", 391, "Rock");
            Track track4 = new Track("Billie Jean", "Michael Jackson", 295, "Pop");
            Track track5 = new Track("Stairway to Heaven", "Led Zeppelin", 482, "Rock");
            Track track6 = new Track("Let It Be", "The Beatles", 243, "Rock");
            Track track7 = new Track("Thriller", "Michael Jackson", 357, "Pop");
            Track track8 = new Track("Boogie Wonderland", "Earth, Wind & Fire", 250, "Funk");
            Track track9 = new Track("Sweet Child o' Mine", "Guns N' Roses", 356, "Rock");
            


            //new a Display instance to use Display method
            Playlist playlist = new Playlist("Favorite 2023");

            //new a Playlist instance to use Playlist method
            Display display = new Display();

            // Add track 1-9 to playlist
            display.Print(playlist.AddToFirst(track1));
            display.Print(playlist.AddToLast(track2));
            display.Print(playlist.AddToLast(track3));
            display.Print(playlist.AddToLast(track4));
            display.Print(playlist.AddToLast(track5));
            display.Print(playlist.AddToLast(track6));
            display.Print(playlist.AddToLast(track7));
            display.Print(playlist.AddToLast(track8));
            display.Print(playlist.AddToLast(track9));
            
            // Show all tracks and info
            display.Print($"\n{playlist.ShowWholePlaylist()}");

            // remove "Stairway to Heaven" from playlist
            display.Print($"\nRemove {track5.Title} from playlist:");
            display.Print(playlist.RemoveTrackByTitle("Stairway to Heaven"));

            // Show all tracks and info
            display.Print("\nPlaylist updated:");
            display.Print(playlist.ShowWholePlaylist());

            // create track10 that will be inserted into playlist
            Track track10 = new Track("Like a Rolling Stone", "Bob Dylan", 369, "Rock");
            // Add track 10 "Like a Rolling Stone" before track 6 "Let It Be"
            display.Print($"\ntrack \"{track10.Title}\" created and will be added to the playlist before \"{track6.Title}\" ");
            display.Print(playlist.AddNewBeforATrack("Let It Be", track10));

            // Show all tracks and info
            display.Print("\nPlaylist updated:");
            display.Print(playlist.ShowWholePlaylist());
        }


    }
}
