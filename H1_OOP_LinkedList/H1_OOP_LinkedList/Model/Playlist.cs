using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_LinkedList.Model
{
    public class Playlist
    {
        //Field
        private string _name;
        private LinkedList<Track> _myPlaylist;



        //Properties
        public string Name { get => _name; private set => _name = value; }
        internal LinkedList<Track> MyPlaylist { get => _myPlaylist; set => _myPlaylist = value; }

        //Constructors
        public Playlist(string name)
        {
            Name = name;
            MyPlaylist = new LinkedList<Track>();
        }

        //Methods to add track to playlist as the first one, generate a success method
        public string AddToFirst(Track track)
        {
            MyPlaylist.AddFirst(track);
            return $"\"{track.Title}\" added to your playlist as the first!";
        }
        public string AddToLast(Track track)
        {
            MyPlaylist.AddLast(track);
            return $"\"{track.Title}\" added to your playlist!";
        }


        /// <summary>
        /// show all elements in a linked list
        /// </summary>
        /// <returns></returns>
        public string ShowWholePlaylist()
        {
            StringBuilder content = new StringBuilder();
            foreach (Track track in MyPlaylist)
            {
                content.AppendLine(track.ToString());
            }
            return content.ToString();
        }
        /// <summary>
        /// Remove a track by name
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public string RemoveTrackByTitle(string title)
        {
            // check if list is empty
            if (MyPlaylist.Count == 0)
            {
                return "Your playlist is empty!";
            }

            /* retrieve the track by name
            * Track found: remove + generate delete message
            * 
            * MyPlaylist.Single(track => track.Title == title);
            * throws exception if no element
            * return no found message
            * Use try catch to handle no found situation
            */

            try
            {
                Track trackToDelete = MyPlaylist.Single(track => track.Title == title);
                MyPlaylist.Remove(trackToDelete);
                return $"\"{title}\" removed from your playlist!";
            }
            catch
            {
                return $"\"{title}\" is not in your playlist!";
            }
        }

        public string AddNewBeforATrack(string title, Track newTrack)
        {
            
            // check if playlist is empty
            if (MyPlaylist.Count == 0)
            {
                return "Your playlist is empty!";
            }

            /*Retrieve the track you want to insert before
             * here use .SingleOrDefault(), which returns null if no found
             * if it is null, return no found message
             * if element found, add newTrack before it  and return add success message
             */
            Track? addBefore = MyPlaylist.SingleOrDefault(track => track.Title == title);;
            if(addBefore == null)
            {
                return "Place no found";
            }
            else
            {
                /* The AddBefore method of LinkedList<T> expects a LinkedListNode<T> object, 
                 * not an element of type T (a Track object). 
                 * NO----MyPlaylist.AddBefore(addBefore, newTrack);----
                 * 
                 * first find the node corresponding to the track you want to insert before, 
                 * then use that node as a reference for the AddBefore method.
                */
                LinkedListNode<Track>? addBeforeNode = MyPlaylist.Find(addBefore);
                MyPlaylist.AddBefore(addBeforeNode, newTrack);
                return $"\"{newTrack.Title}\" inserted before \"{addBefore.Title}\".";
            }
           
        }
    }
}
