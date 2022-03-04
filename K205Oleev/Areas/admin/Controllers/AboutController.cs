using DataAccess;
using Entities;
using Helper.Methods;
using K205Oleev.Areas.admin.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace K205Oleev.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class AboutController : Controller
    {
        private readonly AboutServices _services;

        public AboutController(AboutServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
          var about = _services.GetAll();
            
            return View(about);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(List<string> Title, List<string> Description, List<string> LangCode, List<string> SEO, string PhotoURL)
        {

            for (int i = 0; i < Title.Count; i++)
            {
                _services.CreateAbout(Title[i], Description[i], LangCode[i], SEO[i], PhotoURL);
            }


            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            //EditVM editVM = new()
            //{
            //    AboutLanguages = _context.AboutLanguages.Include(x => x.About).Where(x => x.AboutID == id).ToList(),
            //    About = _context.Abouts.FirstOrDefault(x => x.ID == id.Value)
            //};


            //return View(editVM);
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int AboutID,List<int> LangID, List<string> Title, List<string> Description, List<string> LangCode)
        {
            //for (int i = 0; i < Title.Count; i++)
            //{
            //    SEO seo = new();

            //    AboutLanguage aboutLanguage = new()
            //    {
            //        ID = LangID[i],
            //        Title = Title[i],
            //        Description=Description[i],
            //        SEO = seo.SeoURL(Title[i]),
            //        LangCode = LangCode[i],
            //        AboutID = AboutID
            //    };
            //    var updatedEntity = _context.Entry(aboutLanguage);
            //    updatedEntity.State = EntityState.Modified;
            //}
            //    _context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }
       
    }
}
