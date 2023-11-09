using System;
using System.Collections.Generic;

namespace Tymakov
{
    public class Song
    {
        static private Song lastSong;
        public string Name { get; set; }
        public string Author { get; set; }
        public Song prev;

        public string Title()
        {
            return $"Song: {Name} by {Author}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Song);
        }

        public bool Equals(Song other)
        {
            return other != null &&
                   Name == other.Name &&
                   Author == other.Author;
        }

        public override int GetHashCode()
        {
            var hashCode = -468984958;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Author);
            return hashCode;
        }

        public Song(string name, string author, Song prev)
        {
            Name = name;
            Author = author;
            this.prev = prev;
            lastSong = this;
        }

        public Song(string name, string author) : this(name, author, null) { }
        public Song() : this("", "", null) { }
    }
}
