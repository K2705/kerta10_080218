using System;
using System.Collections.Generic;

namespace Teht2_CD
{
    class Program
    {
        static void Main(string[] args)
        {
            CompactDisk CD = new CompactDisk("Unholy Savior", "Battle Beast", "Heavy Metal", "14.99€");

            CD.AddTrack(new Track("Lionheart", 293));
            CD.AddTrack(new Track("Unholy Savior", 336));
            CD.AddTrack(new Track("I Want the World... and Everything in It", 277));
            CD.AddTrack(new Track("Madness", 241));
            CD.AddTrack(new Track("Sea of Dreams", 301));
            CD.AddTrack(new Track("Speed and Danger", 278));
            CD.AddTrack(new Track("Touch in the Night", 267));
            CD.AddTrack(new Track("The Black Swordsman", 75));
            CD.AddTrack(new Track("Hero's Quest", 150));
            CD.AddTrack(new Track("Far Far Away", 226));
            CD.AddTrack(new Track("Angel Cry", 213));
            CD.AddTrack(new Track("Push It To The Limit", 199));
            CD.AddTrack(new Track("Wild Child", 311));
            Console.Write(CD);

            List<Track> CDTracks = CD.TrackList();
            foreach (Track t in CDTracks)
            {
                Console.WriteLine(t);
            }
        }
    }
}
