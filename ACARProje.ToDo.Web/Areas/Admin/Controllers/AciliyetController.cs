using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACARProje.ToDo.Business.Interfaces;
using ACARProje.ToDo.Entities.Concrete;
using ACARProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACARProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AciliyetController : Controller
    {
        public readonly IAciliyetService _aciliyetService;
        public AciliyetController(IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "aciliyet";
            List<Aciliyet> aciliyetler = _aciliyetService.GetirHepsi();
            List<AciliyetListViewModel> model = new List<AciliyetListViewModel>();

            foreach (var item in aciliyetler)
            {
                AciliyetListViewModel aciliyetModel = new AciliyetListViewModel();
                aciliyetModel.Id = item.Id;
                aciliyetModel.Tanim = item.Tanim;
                model.Add(aciliyetModel);
            }
            return View(model);
        }

        public IActionResult EkleAciliyet()
        {
            TempData["Active"] = "aciliyet";

            return View(new AciliyetAddViewModel());
        }

        [HttpPost]
        public IActionResult EkleAciliyet(AciliyetAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Kaydet(new Aciliyet()
                {

                    Tanim = model.Tanim
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult GuncelleAciliyet(int id)
        {
            TempData["Active"] = "aciliyet";

            var aciliyet = _aciliyetService.GetirIdile(id);
            AciliyetUpdateViewModel model = new AciliyetUpdateViewModel
            {
                Id = aciliyet.Id,
                Tanim = aciliyet.Tanim
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult GuncelleAciliyet(AciliyetUpdateViewModel model)
        {

            if (ModelState.IsValid)
            {
                _aciliyetService.Guncelle(new Aciliyet
                {
                    Id = model.Id,
                    Tanim = model.Tanim

                });
                return RedirectToAction("Index");
            }
         

            return View(model);
        }
    }
}
