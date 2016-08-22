using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArena.Models
{
    public class Battle
    {
        public virtual int BattleId { get; set; }
        public virtual Task CurrentTask { get; set; }
        public virtual int TasksTakenCount { get; set; }
        public virtual int currentLevel { get; set; }
        public virtual double StartTime { get; set; }
        public virtual double EndTime { get; set; }
        public virtual List<Task> TakenTasks { get; set; }


    }
}