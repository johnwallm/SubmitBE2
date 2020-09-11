using SubmitBE.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;



namespace SubmitBE.Controllers
{
    public class HomeController : Controller
    {
     
        
        //
        //FOR GETTING THE IMAGE OR FOR PROMPTING THE PAGE WITH CHOOSE FILE
        //

        
        int UserInformationID = 4;
        string CaseLocation = "makati";
        int EnvironmentalConcernID = 2;
        string XCoordinates = "1";
        string YCoordinates = "2";
        int UpdatedStatusID = 4;
        string Notes = "Water";
        int VolunteerID = 4;

        public ActionResult AddImage()
        {
            CaseReport c1 = new CaseReport();
            return View(c1);
        }
        //
        //FOR GETTING THE IMAGE OR FOR PROMPTING THE PAGE WITH CHOOSE FILE
        //
        [HttpPost]
        public ActionResult AddImage(CaseReport model, HttpPostedFileBase imgInp)
        {
            var db = new TeraEntities3();
            if (imgInp!= null)
            {
                model.CaseReportPhoto = new byte[imgInp.ContentLength];
                imgInp.InputStream.Read(model.CaseReportPhoto, 0, imgInp.ContentLength);
            }

            db.CaseReports.Add(model);
            db.SaveChanges();
            return View(model);
        }

        //for image retrieving OR SHOWING
        public ActionResult GetImage()
        {
            return View();
        }
    }
}