﻿namespace tp2.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } =string.Empty;
        public ICollection<Movie> Movies { get; set; }= new List<Movie>();


    }
}
