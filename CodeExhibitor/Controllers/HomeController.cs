using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeExhibitor.Models;
using CodeExhibitor.Data;
using Microsoft.EntityFrameworkCore;

namespace CodeExhibitor.Controllers
{
    public class HomeController : Controller
    {
        private readonly AlgorithmContext _algorithmContext;

        public HomeController(AlgorithmContext context)
        {
            _algorithmContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About(int? id)
        {
            if (id == null) {
                return View();
                //Exception e = new Exception("No id given to about");
            }

            Algorithm algorithm = await _algorithmContext.Algorithms.FirstOrDefaultAsync<Algorithm>(a => a.AlgorithmId == id);
            ViewData["Description"] = algorithm.Description;
            ViewData["Code"] = algorithm.Code;
            ViewData["Objective"] = algorithm.Objective;
            ViewData["BigO"] = algorithm.BigONotation;
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
