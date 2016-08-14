using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArena.Models
{
    public class TaskDescription
    {
        public virtual int TaskDescriptionId { get; set; }
        public virtual string TaskTitle { get; set; }
        public virtual int Level { get; set; }
        public virtual string DescriptionText { get; set; }
        public virtual List<Task> Tasks { get; set; }
    }
}