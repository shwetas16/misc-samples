using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubGridModel.MockData
{
    public class tbl_Movie
    {
        public int MovieId {get; set;}
        public string MovieName {get; set;}
        public float MovieRating { get; set; }
        public int TheatreId {get; set;}
        public virtual ICollection<tbl_MovieCast> tbl_MovieCast { get; set; }
    }

    public class tbl_Theatre
    {
        public int TheatreID { get; set; }
        public string TheatreName { get; set; }
        //public virtual ICollection<tbl_Movie> tbl_Movie { get; set; }
    }

    public class tbl_MovieCast
    {
        public int ActorId { get; set; }
        public string ActorFName { get; set; }
        public string ActorLName { get; set; }
        public int MovieID { get; set; }
        public virtual tbl_Movie tbl_Movie { get; set; }
    }
}