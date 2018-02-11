
using System;
using System.Collections.Generic;

namespace Teht2_CD
{

    /// <summary>
    /// Data structure for a CD
    /// Holds CD name, artist, genre, price and a list of tracks
    /// </summary>
    class CompactDisk
    {
        public String Name { get; set; }
        public String Artist { get; set; }
        public String Genre { get; set; }
        public String Price { get; set; }
        private List<Track> tracks;

        public CompactDisk(String name, String artist, String genre, String price)
        {
            this.Name = name;
            this.Artist = artist;
            this.Genre = genre;
            this.Price = price;
            this.tracks = new List<Track>();
        }

        /// <summary>
        /// Get the track listing
        /// </summary>
        /// <returns>an array of Track objects</returns>
        public List<Track> TrackList()
        {
            return new List<Track>(tracks);
        }
        /// <summary>
        /// Get the desired track
        /// </summary>
        /// <param name="number">the number of the track, indexed from 1</param>
        /// <returns>the track asked for</returns>
        public Track Track(int number)
        {
            if (number < 1 || number > tracks.Count)
            {
                return null;
            }
            else return tracks[number - 1];
        }

        /// <summary>
        /// Adds a track to the track list
        /// </summary>
        /// <param name="track">Track to add</param>
        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }

        public override String ToString()
        {
            return "Name: " + Name + "\nArtist: " + Artist + "\nGenre: " + Genre + "\nPrice: " + Price + "\nTracks: " + tracks.Count + "\n";

        }
    }
}