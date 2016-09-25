using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArena.Models
{
    public class Record
    {
        public virtual int RecordId { get; set; }
        public virtual int Score { get; set; }
        public virtual TimeSpan Time { get; set; }
        public virtual int NoCorrectAnswers { get; set; }
        public virtual string User { get; set; }
    }
}