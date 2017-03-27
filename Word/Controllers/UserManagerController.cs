using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Word.Models;

namespace Word.Controllers
{
    public class UserManagerController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: UserManager
        public ActionResult Index()
        {
            
            return View(db.UserManager.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            // cái này để gọi giao diện Create
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserManager um)
        {
            // nếu tên ko nhập thì cái ModelState.IsValid này false
            if (ModelState.IsValid) //check valid trong model nếu có, tý a dạy valid model
            {
                db.UserManager.Add(um); //đoạn này là thêm vào cái db.UserManager
                db.SaveChanges(); // đoạn này là lưu xuống db
                return RedirectToAction("Index"); // đoạn này return lại cái view index
            }

            //nếu sai valid thì sẽ return lại model đã nhập để đỡ phải nhập lại
            return View(um);
        }
    }
}