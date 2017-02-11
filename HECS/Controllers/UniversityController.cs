using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HECS.Controllers
{
    public class UniversityController : Controller
    {
        //
        // GET: /University/

        public ActionResult Index(string Id)
        {
            ViewBag.SubPage = Id;
            return View();
        }
        public ActionResult Medical_University_of_Sofia()
        {
            return PartialView("_Medical_University_of_Sofia");
        }
        public ActionResult Sofia_University_St_Kliment_Ohridski()
        {
            return PartialView("_Sofia_University_St_Kliment_Ohridski");
        }
        public ActionResult UNIVERSITY_OF_FORESTRY()
        {
            return PartialView("_UNIVERSITY_OF_FORESTRY");
        }
        public ActionResult University_of_Architecture()
        {
            return PartialView("_University_of_Architecture");
        }
        public ActionResult MEDICINA_YNIVERSITET_PLOVDIV()
        {
            return PartialView("_MEDICINA_YNIVERSITET_PLOVDIV");
        }
        public ActionResult Plovdiv_University_Paisii_Hilendarski()
        {
            return PartialView("_Plovdiv_University_Paisii_Hilendarski");
        }
        public ActionResult Medical_University_of_Varna_ProfDrParaskevStoyanov()
        {
            return PartialView("_Medical_University_of_Varna_ProfDrParaskevStoyanov");
        }

        public ActionResult National_Sports_Academy()
        {
            return PartialView("_National_Sports_Academy");
        }
        public ActionResult Technical_University_of_Sofia()
        {
            return PartialView("_Technical_University_of_Sofia");
        }

        public ActionResult NursingSofia()
        {
            return PartialView("_NursingSofia");
        }

        public ActionResult Veterinery()
        {
            return PartialView("_Veterinery");
        }

        public ActionResult TrakiaUniversity()
        {
            return PartialView("_TrakiaUniversity");
        }

        public ActionResult Lasi()
        {
            return PartialView("_Lasi");
        }

        public ActionResult GrPopa()
        {
            return PartialView("_GrPopa");
        }

        public ActionResult Ovidius()
        {
            return PartialView("_Ovidius");
        }

    }
}
