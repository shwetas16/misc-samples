using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SubGridModel.MockData
{
    public class LoadData
    {
        public List<tbl_Movie> LoadMoviesData()
        {
            List<tbl_Movie> moviesList = new List<tbl_Movie>();
            for (int i = 0; i < 6; i++)
            {
                moviesList.Add(new tbl_Movie { MovieId = 1234, MovieName = "The Martian", MovieRating = 8.5f, TheatreId = 1111, tbl_MovieCast = CreateCastList(1234) });
                moviesList.Add(new tbl_Movie { MovieId = 3456, MovieName = "The Intern", MovieRating = 6.5f, TheatreId = 1111, tbl_MovieCast = CreateCastList(3456) });
                moviesList.Add(new tbl_Movie { MovieId = 7890, MovieName = "Jurassic World", MovieRating = 7.5f, TheatreId = 1123, tbl_MovieCast = CreateCastList(7890) });
            }
            return moviesList;
        }

      

        public List<tbl_MovieCast> CreateCastList(int movieId)
        {
            List<tbl_MovieCast> newCastList = new List<tbl_MovieCast>();
            if (movieId == 1234)
            {
                newCastList.Add(new tbl_MovieCast { ActorFName = "Matt", ActorLName = "Damon" });
                newCastList.Add(new tbl_MovieCast { ActorFName = "Jessica", ActorLName = "Chastain" });
                newCastList.Add(new tbl_MovieCast { ActorFName = "Kate", ActorLName = "Mara" });
            }
            else if (movieId == 3456)
            {
                newCastList.Add(new tbl_MovieCast { ActorFName = "Anne", ActorLName = "Hathaway" });
                newCastList.Add(new tbl_MovieCast { ActorFName = "Robert", ActorLName = "De Niro" });
                newCastList.Add(new tbl_MovieCast { ActorFName = "Nat", ActorLName = "Wolff" });
            }
            else
            {
                newCastList.Add(new tbl_MovieCast { ActorFName = "Chris", ActorLName = "Pratt" });
                newCastList.Add(new tbl_MovieCast { ActorFName = "Bryce", ActorLName = "Howard" });                
            }

            return newCastList;
        }
    }
}