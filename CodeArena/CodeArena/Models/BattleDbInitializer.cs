using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeArena.Models
{
    public class BattleDBInitializer
    : DropCreateDatabaseAlways<BattleDBContext>
    {
        protected override void Seed(BattleDBContext context)
        {
            var records = new List<Record>
            {
                new Record 
                { 
                    Score = 11000,
                    Time = new TimeSpan(0,5,0),
                    NoCorrectAnswers = 5
                }
            };
            var descriptions = new List<TaskDescription>
            {   
                new TaskDescription 
                {
                    //TaskDescriptionId = 1,
                    TaskTitle = "Prvi zadatak",
                    Level = 1,
                    DescriptionText = "Opis prvog zadatka."
                }   
            };

            

           new List<Task>
            {
                new Task
                {
                    TaskId = 1,
                    UnsolvedTaskPath = "putanja do zadatka.",
                    SolvedTaskPath = "putanja do user zadatka.",
                    WraperTaskPath = "putanja do wrappera.",
                    IOTestTaskPath = "putanja do testova.",
                    Description = descriptions.Single(d => d.TaskTitle == "Prvi zadatak")
                }
            }.ForEach(a => context.Tasks.Add(a));
            records.ForEach(a => context.Records.Add(a));
            //descriptions.ForEach(a => context.Descriptions.Add(a));
            
        }
    }
}