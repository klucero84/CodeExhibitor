using CodeExhibitor.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View();
        }


    }


}
