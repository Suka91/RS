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
                
                /*Binary_Search */
                new TaskDescription 
                {
                    TaskTitle = "Binary_Search",
                    Level = 1,
                    DescriptionText = "Opis prvog zadatka."
                },
                new TaskDescription 
                {
                    TaskTitle = "Binary_Search",
                    Level = 2,
                    DescriptionText = "Opis prvog zadatka."
                }  ,
                new TaskDescription 
                {
                    TaskTitle = "Binary_Search",
                    Level = 3,
                    DescriptionText = "Opis prvog zadatka."
                }  ,

                /* Count_Number_Of_Vowel */
                new TaskDescription 
                {
                    TaskTitle = "Count_Number_Of_Vowel",
                    Level = 1,
                    DescriptionText = "Opis prvog zadatka."
                },
                new TaskDescription 
                {
                    TaskTitle = "Count_Number_Of_Vowel",
                    Level = 2,
                    DescriptionText = "Opis prvog zadatka."
                },
                new TaskDescription 
                {
                    TaskTitle = "Count_Number_Of_Vowel",
                    Level = 3,
                    DescriptionText = "Opis prvog zadatka."
                }
            };

            

           new List<Task>
            {
                /*Binary_Search */
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Binary_Search/version1/Binary_Search.py",
                    SolvedTaskPath = "~/Resources/Binary_Search/version1/Binary_Search_Solved.py",
                    WraperTaskPath = "~/Resources/Binary_Search/version1/Binary_Search_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Binary_Search/version1/Binary_Search_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Binary Search" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Binary_Search/version2/Binary_Search.py",
                    SolvedTaskPath = "~/Resources/Binary_Search/version2/Binary_Search_Solved.py",
                    WraperTaskPath = "~/Resources/Binary_Search/version2/Binary_Search_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Binary_Search/version2/Binary_Search_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Binary Search" &&  d.Level == 3)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Binary_Search/version3/Binary_Search.py",
                    SolvedTaskPath = "~/Resources/Binary_Search/version3/Binary_Search_Solved.py",
                    WraperTaskPath = "~/Resources/Binary_Search/version3/Binary_Search_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Binary_Search/version3/Binary_Search_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Binary Search" &&  d.Level == 2)
                },

                /* Count_Number_Of_Vowel */
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel.py",
                    SolvedTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_Solved.py",
                    WraperTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Count Number Of Vowel" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel.py",
                    SolvedTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_Solved.py",
                    WraperTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Count Number Of Vowel" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel.py",
                    SolvedTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_Solved.py",
                    WraperTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Count_Number_Of_Vowel/version1/Count_Number_Of_Vowel_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Count Number Of Vowel" &&  d.Level == 3)
                }
            }.ForEach(a => context.Tasks.Add(a));
            records.ForEach(a => context.Records.Add(a));
            //descriptions.ForEach(a => context.Descriptions.Add(a));
            
        }
    }
}