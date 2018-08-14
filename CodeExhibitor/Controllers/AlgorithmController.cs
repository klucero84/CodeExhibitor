using CodeExhibitor.Data;
using CodeExhibitor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlgorithmsLib.Sorting;

namespace CodeExhibitor.Controllers
{
    public class AlgorithmController : Controller
    {
        private readonly AlgorithmContext _algorithmContext;

        public AlgorithmController(AlgorithmContext context)
        {
            _algorithmContext = context;
        }

        public IActionResult Index()
        { 
            //get all our algorithms
            var results = _algorithmContext.Algorithms.ToList();
            //populate our names selectlistitem collection in a new model
            var model = new Algorithm();

            ViewData["NameList"] = GetSelectListItems(results);
            //assign our model to the view
            return View(model);
        }
        public async Task<IActionResult> Show(int id)
        {
            Algorithm result = await _algorithmContext.Algorithms.FirstOrDefaultAsync<Algorithm>(a => a.AlgorithmId == id);
            
            
            return View();
        }


        private IEnumerable<SelectListItem> GetSelectListItems(List<Algorithm> algorithms)
        {
            var selectList = new List<SelectListItem>();


            foreach (var algorithm in algorithms)
            {
                selectList.Add(new SelectListItem
                {
                    Value = algorithm.AlgorithmId.ToString(),
                    Text = algorithm.Name
                });
            }

            return selectList;
        }
    }


}
