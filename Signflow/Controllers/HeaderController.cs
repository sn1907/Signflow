using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Signflow.Controllers
{
    public class HeaderController : Controller
    {
        // GET: Header
        //Horizontal__
        public ActionResult MenuClassic()
        {
            return View();
        }
        public ActionResult MenuClassicTransparent()
        {
            return View();
        }
        public ActionResult MenuBigLogo()
        {
            return View();
        }
        public ActionResult MenuSubLine()
        {
            return View();
        }
        public ActionResult MenuSubTitle()
        {
            return View();
        }
    
    //HorizontalMenus__
        public ActionResult MenuMiddleLogo()
    { 
        return View();
    }
        public ActionResult MenuMiddleLogoTop()
        {
            return View();
        }
        public ActionResult MenuMiddleBox()
        {
            return View();
        }
        public ActionResult MenuIcons()
        {
            return View();
        }
        public ActionResult MenuIconsTop()
        {
            return View();
        }

        //SideMenus__
        public ActionResult SideClassic()
        {
            return View();
        }
        public ActionResult SideLateral()
        {
            return View();
        }
        public ActionResult SideSimple()
        {
            return View();
        }
    }
}