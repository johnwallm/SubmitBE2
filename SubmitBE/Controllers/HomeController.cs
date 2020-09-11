using SubmitBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubmitBE.Controllers
{
    public class HomeController : Controller
    {
     
        private TeraEntities3 db = new TeraEntities3();
        //
        //FOR GETTING THE IMAGE OR FOR PROMPTING THE PAGE WITH CHOOSE FILE
        //

        
        //int UserInformationID = 4;
        //string CaseLocation = "makati";
        //int EnvironmentalConcernID = 2;
        //string XCoordinates = "1";
        //string YCoordinates = "2";
        //int UpdatedStatusID = 4;
        //string Notes = "Water";
        //int VolunteerID = 4;

        public ActionResult AddImage()
        {
            CaseReport c1 = new CaseReport();
            return View(c1);
        }
        //
        //FOR GETTING THE IMAGE OR FOR PROMPTING THE PAGE WITH CHOOSE FILE
        //
        [HttpPost]
        public ActionResult AddImage(CaseReport model, HttpPostedFileBase image1)
        {
            var db = new TeraEntities3();
            if (image1!= null)
            {
                model.CaseReportPhoto = new byte[image1.ContentLength];
                image1.InputStream.Read(model.CaseReportPhoto, 0, image1.ContentLength);
            }

            db.CaseReports.Add(model);
            db.SaveChanges();
            return View(model);
        }

        //for image retrieving OR SHOWING
        public ActionResult GetImage()
        {
            return View(db.CaseReports.ToList());
        }
    }
}