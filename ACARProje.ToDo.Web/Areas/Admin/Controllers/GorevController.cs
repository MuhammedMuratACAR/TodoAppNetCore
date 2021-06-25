using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACARProje.ToDo.Business.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using ACARProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ACARProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";

           List<Gorev> gorevler= _gorevService.GetirAciliyetIleTamamlanmayan();
            List<GorevListViewModel> models = new List<GorevListViewModel>();
            foreach (var item in gorevler)
            {
                GorevListViewModel model = new GorevListViewModel
                {
                    Aciklama = item.Aciklama,
                    Aciliyet = item.Aciliyet,
                    AciliyetId = item.AciliyetId,
                    Ad = item.Ad,
                    Durum = item.Durum,
                    Id = item.Id,
                    OlusturulmaTarih = item.OlusturulmaTarih
                };
                models.Add(model);
                

            }
            return View(models);
        }

        public IActionResult EkleGorev()
        {
            TempData["Active"] = "gorev";
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");
            return View(new GorevAddViewModel());
        }


        [HttpPost]
        public IActionResult EkleGorev(GorevAddViewModel model)
        {
            TempData["Active"] = "gorev";
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev()
                {

                    Ad = model.Ad,
                    Aciklama=model.Aciklama,
                    AciliyetId=model.AciliyetId

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
