using SubGridModel.MockData;
using SubGridModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SubGridModel.Grids
{
    public class BuildGrids
    {
        public List<MainTheatresGrid> BuildMovieSubGrids(List<tbl_Movie> moviesList)
        {
            List<MainTheatresGrid> revGridItemsList = new List<MainTheatresGrid>();
            var theatres = from a in moviesList
                             group a by a.TheatreId into theatreGroup
                             orderby theatreGroup.Key
                             select theatreGroup;


            //Use projection to group containers into assays
            revGridItemsList = (
                                from theatreGroup in theatres.Take(10)
                                select new MainTheatresGrid
                                {
                                    TheatreId = theatreGroup.Key,
                                    //TheatreName =
                                    
                                    //ElementColumns = BuildElementColumns(searchParam.ElementId, searchParam.LabProcessId),
                                    MoviesList = (from movies in
                                                     (from movies in theatreGroup
                                                      group movies by movies.MovieId into movieGroup
                                                      orderby movieGroup.Key
                                                      select movieGroup)
                                                 select new MoviesSubgrid
                                                 {
                                                     MovieName = movies.Where(a => a.MovieId == movies.Key).FirstOrDefault().MovieName,
                                                     Rating = movies.Where(a => a.MovieId == movies.Key).FirstOrDefault().MovieRating,
                                                     CastList = movies.Where(a => a.MovieId == movies.Key).FirstOrDefault().tbl_MovieCast.ToList()
                                                 }).ToList()
                                }).ToList();
            return revGridItemsList;
        }
    }
}