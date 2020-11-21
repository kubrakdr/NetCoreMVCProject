using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCProject.Interfaces;

namespace NetCoreMVCProject.Controllers
{
   
    public class HomeController : Controller
    {

        IUrunRepository _urunRepository;

        public HomeController(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }

        public IActionResult Index()
        {
           

            return View(_urunRepository.HepsiniGetir());
        }

        
    }
}
