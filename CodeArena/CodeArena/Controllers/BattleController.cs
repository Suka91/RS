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

namespace CodeArena.Controllers
{

    public class BattleController : Controller
    {
        private BattleDBContext db = new BattleDBContext();

        private static BattleManager battleManager =  new BattleManager();

        private class BattleManager 
        {
            public List<int> taskIds { get; set; }
            public int tasksTaken { get; set; }
            public int currentTask { get; set; }

            public int currentLevel { get; set; }

            public Stopwatch sw;

            public BattleManager() { }

            public void  InitBattleManager(int Level, BattleDBContext dbContext) 
            {
                taskIds = dbContext.Tasks.Where(row => row.Description.Level == Level).Select(a => a.TaskId).ToList();
                currentLevel = Level;
                tasksTaken = 0;
                sw = new Stopwatch();
                sw.Start();
            }
            /* Choose random task from taskIds list, also removes it from list and increment tasks taken. */
            public void chooseCurrentTask()
            {
                Random rnd = new Random();
                int taskIdindex = rnd.Next(0, taskIds.Count);

                currentTask = taskIds[taskIdindex];
                taskIds.RemoveAt(taskIdindex);

                tasksTaken++;
            }
        }
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
        [HttpPost, ActionName("TaskDescription")]
        //[ValidateAntiForgeryToken]
        public ActionResult TaskDescription(int Level)
        {
            battleManager.InitBattleManager(Level,db);
            battleManager.chooseCurrentTask();
            return View(db.Tasks.Single(row => row.TaskId == battleManager.currentTask).Description);
        }
        //get
        public ActionResult TaskDescription()
        {
            battleManager.chooseCurrentTask();
            Console.WriteLine("{0} max level\n{1} current Task id\n", battleManager.currentLevel, battleManager.currentTask);
            return View(db.Tasks.Single(row => row.TaskId == battleManager.currentTask).Description);
        }

        public ActionResult Code()
        {

            //db.Tasks.Single(row => row.TaskId == battleManager.currentTask).UnsolvedTaskPath
            string[] taskCode = System.IO.File.ReadAllLines(Server.MapPath("~/Resources/Binary_Search/version1/Binary_Search.py"));
            ViewBag.TaskCode = taskCode;
            ViewBag.TaskTitle = db.Tasks.Single(row => row.TaskId == battleManager.currentTask).Description.TaskTitle;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}