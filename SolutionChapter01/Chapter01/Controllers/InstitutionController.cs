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
            new List<Institution>()
            {
                new Institution()
                {
                    InstitutionID = 1,
                    Name = "UniParaná",
                    Address = "Paraná"
                    
                },
                new Institution(){
                    InstitutionID = 2,
                    Name = "UniSanta",
                    Address = "Santa Catarina"
                },
                new Institution()
                {
                    InstitutionID = 3,
                    Name = "UniSaoPaulo",
                    Address = "São Paula"
                },
                new Institution()
                {
                    InstitutionID = 4,
                    Name = "UniSulgrandense",
                    Address = "Rio Grande do Sul"
                },
                new Institution()
                {
                    InstitutionID = 5,
                    Name = "UniCarioca",
                    Address = "Rio de Janeiro"
                }
            };

        // Definition of an action called Index
        public IActionResult Index()
        {
            return View(institutions);
        }
    }
}
