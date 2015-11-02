using SubGridModel.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubGridModel.Models
{
    public class MainTheatresGrid
    {
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public Dictionary<int, string> ElementColumns { get; set; }
        public List<MoviesSubgrid> MoviesList { get; set; }
        public List<MovieLocations> LocationsList
        {
            get
            {
                var a = new List<MovieLocations>();
                a.Add(new MovieLocations { Name = "San Diego", ContactNum = "432636457" });
                a.Add(new MovieLocations { Name = "San Francisco", ContactNum = "235346356"});
                a.Add(new MovieLocations { Name = "Sacramento", ContactNum = "2356357468" });              
                return a;
            }
        }
    }

    public class MoviesSubgrid
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public List<tbl_MovieCast> CastList { get; set; }
        public float Rating { get; set; }

    }

    public class MovieLocations
    {
        public string Name { get; set; }
        public string ContactNum { get; set; }
    }

}