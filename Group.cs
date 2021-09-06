using System;
using System.Collections.Generic;
using System.Text;

namespace Ls15
{
    public enum position { solo, back, gitara }
    public class Group : IGroup
    {
        public string GropName { get; set; }
        public IBand Band { get; set; }
        public List<IAlbume> Albumes { get; set; }
    }

    public class Person : IPerson
    {
        public int Name { get; set; }
        public position Position { get; set; }
    }
    public class Band : IBand
    {
        public List<IPerson> MyBand { get; set; }
        public int Foundation { get; set; }
    }
    public class Song : ISong
    {
        public string SongName { get; set; }
    }
    public class Albume : IAlbume
    {
        public List<ISong> Songs { get; set; }
        public int AlbumeYear { get; set; }
        public string AlbumeGenre { get; set; }
        public string AlbumeName { get; set; }
    }
}
