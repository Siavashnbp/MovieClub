using MovieClub.Entities.Genres;
using MovieClub.Entities.Ratings;
using MovieClub.Entities.RentInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieClub.Entities.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Genre? Genre { get; set; }
        public int GenreId { get; set; }
        public List<Rating> Ratings { get; set; }
        public string Director { get; set; }
        public int Count { get; set; }
        public AgeRestriction AgeRestriction { get; set; }
        public RentInformation RentInformation { get; set; }
    }
    public enum AgeRestriction
    {
        None,
        Under18,
        Under14
    }
}
