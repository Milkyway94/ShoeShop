using Models.Dao;
using Models.EF;
using ShoeShop.Areas.admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using ShoeShop.Common;

namespace ShoeShop.Areas.admin.Controllers
{
    public class NhomSanPhamController : Controller
    {
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var nhomsp = new NhomsanphamDao();
            var model = nhomsp.ListAll(page, pagesize);
            return PartialView(model);

        }
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: admin/NhomSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/NhomSanPham/Create
        [HttpPost]
        public ActionResult Create(NhomSanPham collection)
        {
                if (ModelState.IsValid)
                {
                    var dao = new NhomsanphamDao();
                    long id = dao.Insert(collection);
                    if (id > 0)
                    {
                        return RedirectToAction("Index", "Nhomsanpham");
                    }
                    else
                    {
                        ModelState.AddModelError("", CommonConstant.INSERT_FAIL);
                    }
                }
            return View("Index", "Nhomsanpham");
        }

        // GET: admin/NhomSanPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: admin/NhomSanPham/Edit/5
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

        // GET: admin/NhomSanPham/Delete/5
        public ActionResult Delete(int id)
        {
            var dao = new NhomsanphamDao();
            if(dao.Delete(id))
            {
                return View("Index");
            }
            else
            {
                ModelState.AddModelError("", CommonConstant.DELETE_FAIL);
            }
            return View("Index");
        }

        // POST: admin/NhomSanPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, NhomSanPham collection)
        {
            try
            {
                return View("Index");   
            }
            catch
            {
                return View();
            }
        }
    }
}
