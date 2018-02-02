using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MF_Modelo;
using System.Security.Principal;
using System.Configuration;

namespace SIIFMFv2_FE.Controllers
{

    //https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/basic-authentication

    public class HomeController : Controller
    {
        SPEIContext db = new SPEIContext();
        MFTool tools = new MFTool();

        public ActionResult Index()
        {
            string strUsuario = User.Identity.Name.Remove(0, 10);

            string strNivel = tools.devuelveNivel(strUsuario); //, ConfigurationManager.AppSettings["NivelesAutorizados"]);
            System.Web.HttpContext.Current.Session["Nivel"] = strNivel;

            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}