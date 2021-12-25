using Chapter01.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter01.Controllers
{
    public class InstitutionController : Controller
    {
        private static IList<Institution> institutions =
            new List<Institution>
            {
                new Institution()
                {
                    InstitutionID = 1,
                    Nome = "UniParaná",
                    Endereco = "Paraná"
                    
                }
            };

        // Definition of an action called Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
