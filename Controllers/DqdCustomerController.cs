using DqdLesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DqdLesson05.Controllers
{
    public class DqdCustomerController : Controller
    {
        // GET: DqdCustomer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DqdCustomerDetail()
        {
            var customer = new DqdCustomer()
            {
                customerid = 1,
                firstname = " Dang Quang",
                lastname = " Dung",
                address = "k22cnt1",
                yearObirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }

        // get: DqdListCustomer
        public ActionResult DqdListCustomer()
        {
            var list = new List<DqdCustomer>()
            {
                new DqdCustomer()
                {
                    customerid = 2,
                    firstname = " Dang Quang",
                    lastname = " hieu",
                    address = "k22cnt1",
                    yearObirth = 2004
                },
                new DqdCustomer()
                {
                    customerid = 3,
                    firstname = " Nguyen Khanh",
                    lastname = " Phuong",
                    address = "k72ctxh",
                    yearObirth = 2004
                },
                new DqdCustomer()
                {
                    customerid = 4,
                    firstname = " Nguyen Khanh",
                    lastname = " Phong",
                    address = "k72ctxh",
                    yearObirth = 2004
                },
            };
            ViewBag.list = list; // dua du lieu ra view bang doi tuong viewbag

            return View();
        }
    }
}