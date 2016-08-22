using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using CodeArena.Models;

namespace CodeArena.ViewModels
{
    public class BattleManagerViewModel
    {

        public static int StartBattle(int Level, BattleDBContext dbContext) 
        {
            int BattleId;
            if(dbContext.Battles.Any())
                 BattleId = dbContext.Battles.Max(b=>b.BattleId) + 1;
            else 
                BattleId = 1;

            List<Task> tempList = dbContext.Tasks.Where(row => row.Description.Level == Level).ToList();
            List<Task> shuffledList = new List<Task>();
            var rnd = new Random();
            int i = 0;
            while (i < 5)
            {
                var index = rnd.Next(0, tempList.Count);
                shuffledList.Add(tempList[index]);
                tempList.RemoveAt(index);
                i++;
            }
            Battle newBattle = new Battle { BattleId = BattleId, currentLevel = Level, StartTime = DateTime.Now.TimeOfDay.TotalSeconds, TasksTakenCount = 0, TakenTasks = shuffledList };
            dbContext.Battles.Add(newBattle);
            dbContext.SaveChanges();
            return BattleId;
        }
        /* Choose task from Battle, also removes it from list and increment tasks taken. */
        public static void chooseCurrentTask(int BattleId, BattleDBContext dbContext)
        {

            List<Task> taskList = dbContext.Battles.Single(b => b.BattleId == BattleId).TakenTasks;
            Task newTask = taskList.First();
            dbContext.Battles.Single(b => b.BattleId == BattleId).TakenTasks.Remove(newTask);
            dbContext.Battles.Single(b => b.BattleId == BattleId).CurrentTask = newTask;
            dbContext.Battles.Single(b => b.BattleId == BattleId).TasksTakenCount ++;
            dbContext.SaveChanges();
        }
        public static Battle getBattleById(int BattleId, BattleDBContext dbContext)
        {
            Battle battle = dbContext.Battles.Single(b => b.BattleId == BattleId);
            return battle;
        }
    }
}