using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using SinglePageTask.DB;
using SinglePageTask.DB.Models;
using SinglePageTask.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinglePageTask.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetCustomers(string customerType)
        {
            MeetingDBContext dbContext = new MeetingDBContext();
            if (customerType == "Corporate")
            {
                var customers = dbContext.CorporateCustomers.ToList();
                return Json(customers, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var customers = dbContext.individualCustomers.ToList();
                return Json(customers, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult GetProductServices()
        {
            MeetingDBContext dBContext = new MeetingDBContext();
            return Json(dBContext.products.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetUnitForProduct(int productId) 
        {
            MeetingDBContext dBContext = new MeetingDBContext();
            var products = dBContext.products.ToList();
            var data = (from product in products
                        where product.Id == productId
                        select product).FirstOrDefault();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveMeeting(MeetingModelDTO meeting)
        {
            if (ModelState.IsValid)
            {
                MeetingDBContext dbContext = new MeetingDBContext();

                var newMeetingMinute = new Meeting_Minutes_Master_Tbl()
                {
                    CustomerType = meeting.CustomerType,
                    CustomerName = meeting.CustomerName,
                    MeetingAgenda = meeting.MeetingAgenda,
                    MeetingDate = meeting.MeetingDate.ToString(),
                    MeetingDiscussion = meeting.MeetingDiscussion,
                    AttendsFromClientSide = meeting.AttendsFromClientSide,
                    MeetingDecision = meeting.MeetingDecision,
                    AttendsFromHostSide = meeting.AttendsFromHostSide
                };

                dbContext.meetingMinutes.Add(newMeetingMinute);
                dbContext.SaveChanges();

                var details = meeting.MeetingDetails.ToList();
                foreach (var detail in details)
                {
                    dbContext.meetingMinutesDetails.Add(new Meeting_Minutes_Details_Tbl()
                    {
                        SL = detail.SL,
                        ProductService = detail.ProductService,
                        Unit = detail.Unit,
                        Quantity = detail.Quantity,
                        meetId = newMeetingMinute.Id
                    });
                }

                dbContext.SaveChanges();

                return RedirectToAction("index");
            }
            else { return View("index"); }
        }

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