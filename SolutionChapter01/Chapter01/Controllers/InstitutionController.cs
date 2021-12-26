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
                    
                },
                new Institution(){
                    InstitutionID = 2,
                    Nome = "UniSanta",
                    Endereco = "Santa Catarina"
                },
                new Institution()
                {
                    InstitutionID = 3,
                    Nome = "UniSaoPaulo",
                    Endereco = "São Paula"
                },
                new Institution()
                {
                    InstitutionID = 4,
                    Nome = "UniSulgrandense",
                    Endereco = "Rio Grande do Sul"
                },
                new Institution()
                {
                    InstitutionID = 5,
                    Nome = "UniCarioca",
                    Endereco = "Rio de Janeiro"
                }
            };

        // Definition of an action called Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
