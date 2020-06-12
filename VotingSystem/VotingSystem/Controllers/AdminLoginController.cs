using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VotingSystem.Models;

namespace VotingSystem.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        AdminLoginDataAccessLayer al = new AdminLoginDataAccessLayer();
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminLogin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminLogin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminLogin/Create
        [HttpPost]
        public ActionResult Create(AdminLoginModel a)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    if (al.AdminLogin(a) == true)
                    {
                        Session["AEmail"] = a.AEmail.ToString();
                        ViewBag.Message = "Login successfull";
                        return RedirectToAction("Welcome", "AdminLogin");
                    }
                    else
                    {
                        return View();
                    }
                }
                return View();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public ActionResult Welcome()
        {
            ViewBag.AEmail = Session["AEmail"].ToString();
            return View();
        }


        // GET: AdminLogin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminLogin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminLogin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminLogin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
