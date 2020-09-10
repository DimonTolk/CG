using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CG.Models;

namespace CG.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            int A;
            int B;
            int C;
            int D;
            int K;
            if (user.N<=10)
            {
                A = 0; 
                B = 1; 
                C = 4; 
                D = 3;
                K = 10;
            }
            else if (user.N <= 20)
            {
                A = 1;
                B = 2;
                C = 3;
                D = 2;
                K = 20;
            }
            else if (user.N <= 30)
            {
                A = 2;
                B = 3;
                C = 2;
                D = 1;
                K = 30;
            }
            else
            {
                A = 3;
                B = 4;
                C = 1;
                D = 0;
                K = 35;
            }
            int XA = K - user.N + A;
            int XB = XA + user.G + B;
            int XC = XA + user.P + C;
            int XD = XC + D;



            int YA = XA + user.G + A; 
            int YB = YA + user.P + B;
            int YC = YB + user.G + C;
            int YD = YC - user.P + D;


            string points = $"[{XA},{YA}],[{XB},{YB}],[{XC},{YC}],[{XD},{YD}]";

            ViewBag.points = points;
            return View();
        }
    }
}