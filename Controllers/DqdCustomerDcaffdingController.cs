using DqdLesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DqdLesson05.Controllers
{
    public class DqdCustomerDcaffdingController : Controller
    {
        //Mockdata
        private static List<DqdCustomer> listCustomer = new List<DqdCustomer>()
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
    // GET: DqdCustomerDcaffding
    // listCustomer

    public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult DqdCreate()
        {
            var model = new DqdCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult DqdCreate(DqdCustomer model)
        {
            //them moi doi tuong khach hang vao danh sach du lieu
            listCustomer.Add(model);
            //return View(model);
            // chuyen ve trang danh sach
            return RedirectToAction("Index");
        }
        public ActionResult DqdEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.customerid == id);
            return View(customer);
        }
    }
}