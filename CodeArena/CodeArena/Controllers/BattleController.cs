using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeArena.Models;
using System.Diagnostics;
using System.Reflection;
using CodeArena.ViewModels;

namespace CodeArena.Controllers
{

    public class BattleController : Controller
    {
        private BattleDBContext db = new BattleDBContext();

        //
        // GET: /Battle/

        public ActionResult Index()
        {
            return View(db.Tasks.ToList());
        }

        //
        // GET: /Battle/Details/5

        public ActionResult Details(int id = 0)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        //
        // GET: /Battle/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Battle/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(task);
        }

        //
        // GET: /Battle/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        //
        // POST: /Battle/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(task);
        }

        //
        // GET: /Battle/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        //
        // POST: /Battle/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Task task = db.Tasks.Find(id);
            db.Tasks.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ChooseLevel()
        {
            int maxLevel = db.Descriptions.Max(row => row.Level);
            ViewBag.maxLevel = maxLevel;
            Console.WriteLine(maxLevel);
            return View();
        }
        //post
        [HttpPost, ActionName("StartBattle")]
        //[ValidateAntiForgeryToken]
        public ActionResult StartBattle(int Level)
        {
            int BattleId = BattleManagerViewModel.StartBattle(Level,db);
            BattleManagerViewModel.chooseCurrentTask(BattleId,db);
            Battle battle = BattleManagerViewModel.getBattleById(BattleId,db);
            return View("TaskDescription",battle);
        }
        //get
        public ActionResult TaskDescription(int BattleId)
        {
            BattleManagerViewModel.chooseCurrentTask(BattleId, db);
            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            return View(battle);
        }
        //get
        public ActionResult Code(int BattleId)
        {
            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            string[] taskCode = System.IO.File.ReadAllLines(Server.MapPath(battle.CurrentTask.UnsolvedTaskPath));
            ViewBag.TaskCode = taskCode;
            return View(battle);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}