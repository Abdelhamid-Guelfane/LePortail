using LePortail.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LePortail.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting;

        public HomeController(ILogger<HomeController> logger, 
            Microsoft.AspNetCore.Hosting.IHostingEnvironment hosting)
        {
            _logger = logger;
            hosting = this.hosting;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        PortailDB dbContext = new PortailDB();
        public IActionResult Affichage()
        {
            List<Candidat> candidats = dbContext.Candidat.ToList();
            return View(candidats);
        }

        [HttpPost]
        public IActionResult Postuler(Candidat candidat)
        {
            if (ModelState.IsValid)
            {
                //if (candidat.CvCandidat != null)
                //{
                //    string dirName = $"{ candidat.Nom } { candidat.Prenom}";
                //    String fichierCv = Path.Combine(hosting.WebRootPath, $"LesCvs/{dirName}/") ;
                //    String cvPath = Path.Combine(fichierCv, candidat.CvCandidat.FileName);
                //    candidat.CvCandidat.CopyTo(new FileStream(cvPath, FileMode.Create));
                //    candidat.CheminDuCv = candidat.CvCandidat.FileName;
                //}
                dbContext.Candidat.Add(candidat);
                dbContext.SaveChanges();
                return RedirectToAction("AjouterCv");
            }
            return View();
        }

        public IActionResult Postuler()
        {
            return View();
        }

        public IActionResult Supprimer(int id)
        {
            Candidat data = this.dbContext.Candidat.Where(e => e.IdCandidat == id).FirstOrDefault();
            if (data != null)
            {   
                Directory.Delete($"~/LesCVs/{data.CheminDuCv}");
                dbContext.Candidat.Remove(data);
                dbContext.SaveChanges();
            }
            
            return RedirectToAction("Affichage");  
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}