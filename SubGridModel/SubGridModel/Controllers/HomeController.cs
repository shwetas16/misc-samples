using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SubGridModel.MockData;
using SubGridModel.Grids;
using SubGridModel.Models;
using SubGridModel.Helpers;

namespace SubGridModel.Controllers
{
    public class HomeController : Controller
    {
        private IGridMvcHelper gridMvcHelper;
        public ActionResult Index()
        {
            return RedirectToAction("MoviesInTheaterGrid");
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MoviesInTheaterGrid()
        {
            gridMvcHelper = new GridMvcHelper();
            List<tbl_Movie> moviesList = new LoadData().LoadMoviesData();
            var model = new BuildGrids().BuildMovieSubGrids(moviesList);
            return View(gridMvcHelper.GetAjaxGrid(model.AsQueryable()));
        }
    }
}