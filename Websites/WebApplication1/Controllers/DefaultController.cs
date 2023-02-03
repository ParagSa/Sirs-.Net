using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        //public IActionResult Index(int? id)
        //{
        //    if(id==null)
        //        return NotFound();
        //    else
        //        return View();
        //    //return View("index1");
        //}
        //public IActionResult Index(int? id, int? x)
        //{
        //     return View();
        //    //return View("index1");
        //}

        //http://localhost:5108/default/index/100?a=10&b=20&c=30
        //http://localhost:5108/default/index/100?c=30
//        public IActionResult Index(int? id, int? a, int? b, int? c)
        public IActionResult Index(int? id, int a=0, int b=0, int c=0)
        {
            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;


            return View();
            //return View("index1");
        }
    }
}
