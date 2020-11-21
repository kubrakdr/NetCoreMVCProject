using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCProject.Repositories;

namespace NetCoreMVCProject.Controllers
{
    public class UrunlerController : Controller
    {
        public IActionResult Index()
        {


            ITest test = new DpTest();
             ViewBag.Ad = test.GetirAd("Kübra");


            UrunRepository urunRepository = new UrunRepository();

            return View(urunRepository.HepsiniGetir());
        }
        
        public IActionResult Index1()
        {
            UrunRepository urunRepository = new UrunRepository();

            return View(urunRepository.HepsiniGetir());
        }

        public interface ITest
        {
            string GetirAd(string ad);
        }
        public class Test: ITest
        {
            public string GetirAd(string ad)
            {
                return ad;
            }

        }
        public class DpTest : ITest
        {
            public string GetirAd(string ad)
            {
                return "Dp" + ad;

            }
        }

    }
}
