using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_OOP_LinkedList.Model
{
    public class Track
    {
        //Field
        private string _title;
        private string _artist;
        private ushort _durationInSeconds;
        private string _genre;


        //Properties
        public string Title { get => _title; private set => _title = value; }
        public string Artist { get => _artist; private set => _artist = value; }
        public ushort DurationInSeconds { get => _durationInSeconds; private set => _durationInSeconds = value; }
        public string Genre { get => _genre; private set => _genre = value; }


        //Constructors
        public Track(string title, string artist, ushort durationInSeconds, string genre) 
        {
            Title = title;
            Artist = artist;
            DurationInSeconds = durationInSeconds;
            Genre = genre;
        }

        // Override ToString method to get track information
        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Duration: {DurationInSeconds}, Genre: {Genre}";
        }


    }
}
