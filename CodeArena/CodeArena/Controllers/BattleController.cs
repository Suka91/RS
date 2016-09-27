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
using System.IO;

namespace CodeArena.Controllers
{
    


    public class BattleController : Controller
    {
       /* public class HttpParamActionAttribute : ActionNameSelectorAttribute
        {
            public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
            {
                if (actionName.Equals(methodInfo.Name, StringComparison.InvariantCultureIgnoreCase))
                    return true;

                if (!actionName.Equals("Action", StringComparison.InvariantCultureIgnoreCase))
                    return false;

                var request = controllerContext.RequestContext.HttpContext.Request;
                return request[methodInfo.Name] != null;
            }
        }
        */
        private BattleDBContext db = new BattleDBContext();
        private UsersContext udb = new UsersContext();
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
            return View();
        }

        //post
        [HttpPost, ActionName("StartBattle")]
        //[ValidateAntiForgeryToken]
        public ActionResult StartBattle(int Level)
        {
            if (ModelState.IsValid && User.Identity.IsAuthenticated)
            {
                int BattleId = BattleManagerViewModel.StartBattle(User.Identity.Name, Level, db);
                BattleManagerViewModel.chooseCurrentTask(BattleId, db);
                Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
                return View("TaskDescription", battle);
            }
            return View("Index");
        }

       // [HttpParamActionAttribute]
        //[AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Retreat(int BattleId)
        {
            BattleManagerViewModel.finishBattle(BattleId, db);
            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            Record newRecord = new Record
            {
                Score = (int)(Math.Pow((10000 / (battle.EndTime - battle.StartTime)) * battle.CurrentLevel, battle.TasksCorrectCount) - 1),
                Time = TimeSpan.FromSeconds(battle.EndTime - battle.StartTime),
                NoCorrectAnswers = battle.TasksCorrectCount,
                User = battle.User
            };

            db.Records.Add(newRecord);
            db.SaveChanges();

            if (db.Records.Count() < 5)
            {
                List<Record> topRecords = db.Records.Where(r => r.User == battle.User).OrderByDescending(r => r.Score).ToList();
                ViewBag.topRecords = topRecords;
            }
            else
            {
                List<Record> topRecords = db.Records.Where(r => r.User == battle.User).OrderByDescending(r => r.Score).Take(5).ToList();
                ViewBag.topRecords = topRecords;
            }

            return View("Score", newRecord);
        }

       // [HttpParamActionAttribute]
       // [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TaskDescription(int BattleId)
        {
            if (BattleManagerViewModel.isBattleFinished(BattleId,db))
            {
                BattleManagerViewModel.finishBattle(BattleId, db);
                Battle battle = BattleManagerViewModel.getBattleById(BattleId,db);
                Record newRecord = new Record
                {
                    Score = (int)Math.Pow((10000 / (battle.EndTime - battle.StartTime)) * battle.CurrentLevel, battle.TasksCorrectCount)-1,
                                                Time = TimeSpan.FromSeconds(battle.EndTime - battle.StartTime), 
                                                NoCorrectAnswers = battle.TasksCorrectCount,
                                                User = battle.User };
                db.Records.Add(newRecord);
                db.SaveChanges();

                if (db.Records.Count() < 5)
                {
                    List<Record> topRecords = db.Records.Where(r => r.User == battle.User).ToList();
                    ViewBag.topRecords = topRecords;
                }
                else
                {
                    List<Record> topRecords = db.Records.Where(r => r.User == battle.User).OrderByDescending(r => r.Score).Take(5).ToList();
                    ViewBag.topRecords = topRecords;
                }

                return View("Score", newRecord);
            }
            else
            { 
                BattleManagerViewModel.chooseCurrentTask(BattleId, db);
                Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
                return View("TaskDescription", battle);
            }
        }

       // [HttpParamActionAttribute]
     //   [AcceptVerbs(HttpVerbs.Post)]
    /*    public ActionResult Score(int BattleId)
        {
            BattleManagerViewModel.getBattleById(BattleId, db);
            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            return View("Score", battle);
        }*/

        //get
        public ActionResult Code(int BattleId)
        {
            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            string taskCode = System.IO.File.ReadAllText(Server.MapPath(battle.CurrentTask.UnsolvedTaskPath));
            ViewBag.TaskCode = taskCode;
            ViewBag.TaskDescription =  battle.CurrentTask.Description.DescriptionText.ToString();
            return View(battle);
        }

        [HttpPost, ActionName("ReturnToCode")]
        //post
        public ActionResult ReturnToCode(int BattleId)
        {
            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            string taskCode = System.IO.File.ReadAllText(Server.MapPath(battle.CurrentTask.SolvedTaskPath));
            ViewBag.TaskCode = taskCode;
            ViewBag.TaskDescription = battle.CurrentTask.Description.DescriptionText.ToString();
            return View("Code", battle);
        }
        /*[HttpPost, ActionName("BattleReport")]
        [HttpParamActionAttribute]*/
      //  [HttpParamActionAttribute]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult BattleReport(int BattleId, String TaskCode)
        {
            string stringError  = "";

            Battle battle = BattleManagerViewModel.getBattleById(BattleId, db);
            System.IO.File.WriteAllText(Server.MapPath(battle.CurrentTask.SolvedTaskPath),TaskCode);
            ProcessStartInfo pythonInfo = new ProcessStartInfo();
            Process python = new Process();

            python.StartInfo.FileName = @"C:\Users\Dragutin\AppData\Local\Programs\Python\Python36\python.exe";
            python.StartInfo.Arguments = Server.MapPath(battle.CurrentTask.WraperTaskPath);
            python.StartInfo.CreateNoWindow = false;
            python.StartInfo.UseShellExecute = false;
            python.StartInfo.RedirectStandardError = true;
            python.StartInfo.WorkingDirectory = Server.MapPath(battle.CurrentTask.WraperTaskPath.Remove(battle.CurrentTask.WraperTaskPath.LastIndexOf("/")));
            python.Start();
            python.WaitForExit();

            stringError = python.StandardError.ReadToEnd();
            if(!String.IsNullOrEmpty(stringError))
            {
                ViewBag.TaskError = stringError;
            } else if (python.ExitCode != 0)
            {
                ViewBag.TaskError = "Output doesn't match expected.";
            }
            else if (python.ExitCode == 0)
            {
                BattleManagerViewModel.incrementCorrectTasks(BattleId, db);
            }
            python.Close();
            return View("BattleReport", battle);
        }
        public ActionResult Records()
        {
            List<Record> topRecords = db.Records.OrderByDescending(r => r.Score).ToList();
            ViewBag.topRecords = topRecords;
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}