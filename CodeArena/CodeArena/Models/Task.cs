using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArena.Models
{
    public class Task
    {
        public virtual int TaskId { get; set; }
        public virtual string UnsolvedTaskPath { get; set; }
        public virtual string SolvedTaskPath { get; set; }
        public virtual string WraperTaskPath { get; set; }
        public virtual string IOTestTaskPath { get; set; }
        public virtual TaskDescription Description { get; set; }
    }
}