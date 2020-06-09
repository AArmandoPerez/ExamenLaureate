using LaureateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaureatePhoneBookBusiness;
using System.Data;

namespace LaureatePhoneBookWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // View for Display record
        public ActionResult Save_Data()
        {
            return View();
        }
        // View for Update record
        public ActionResult Update_data(int id)
        {
            return View();
        }
        //Add record
        public JsonResult Add_record(Contacts contact)
        {

            try
            {
                string res = Business.Add_record(contact);

                return Json(res, JsonRequestBehavior.AllowGet);

            }
            catch (Exception)
            {
                string res = "failed";

                return Json(res, JsonRequestBehavior.AllowGet);

            }

        }
        // Display all records
        public JsonResult Get_data()
        {
            List<Contacts> list = Business.get_contacts();
            return Json(list, JsonRequestBehavior.AllowGet);
        }


        //Display records by id
        public JsonResult Get_databyid(int id)
        {

            List<Contacts> list = Business.get_RecordbyId(id);
            return Json(list, JsonRequestBehavior.AllowGet);

        }

        // Update records 
        public JsonResult update_record(Contacts contact)
        {

            try
            {

                //res = "Updated";

                string res = Business.update_record(contact);

                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                string res = "failed";
                return Json(res, JsonRequestBehavior.AllowGet);
            }


        }
        // Delete record
        public JsonResult delete_record(int id)
        {
           
            try
            {

                // res = "data deleted";
                string res = Business.deletedata(id);
                return Json(res, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {
                string res = "failed";
                return Json(res, JsonRequestBehavior.AllowGet);
            }


        }
    }
}