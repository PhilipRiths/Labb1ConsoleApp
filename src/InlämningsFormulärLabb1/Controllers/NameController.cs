using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InlämningsFormulärLabb1.Controllers
{
    public class NameController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        private const string ThumpsUpImage =
          "http://www.clipartkid.com/images/248/family-guy-buzz-Wrxpjl-clipart.jpeg";

        private const string ThumpsDownImage = "https://img.memesuper.com/231480335ac4701f43471cd88ad102c2_down-votes-thumbs-down-meme_400-226.jpeg";
        private const string ExplosionImage = "http://combiboilersleeds.com/images/explosion/explosion-2.jpg";
     

        public IActionResult ShowImage(string name)
        {
            if (name == null) name = string.Empty;

            var newName = name.ToLower().Trim();

            switch (newName)
            {
                case "stewie":
                    throw new Exception("Data error ");
                case "peter":
                    ViewBag.Image = ExplosionImage;
                    break;
                case "lois":
                case "meg":
                case "chris":
                case "brian":
                    ViewBag.Image = ThumpsUpImage;
                    break;
                default:
                    ViewBag.Image = ThumpsDownImage;
                    break;
            }

            return View();
        }
    }
}

