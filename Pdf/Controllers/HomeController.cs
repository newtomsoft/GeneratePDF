using Pdf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pdf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pdf = new GeneratePdf();
            var newPdf = pdf.TestPdf();
            Response.Clear();
            Response.ContentType = "application/pdf"; string pdfName = "User";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + pdfName + ".pdf");
            Response.ContentType = "application/pdf";
            Response.Buffer = true;
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.BinaryWrite(newPdf);
            Response.End();
            Response.Close();
            return View();
        }

        
    }
}