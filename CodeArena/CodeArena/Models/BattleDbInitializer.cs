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
            var descriptions = new List<TaskDescription>
            {   
                
                /*Binary_Search */
                new TaskDescription 
                {
                    TaskTitle = "Binary Search",
                    Level = 1,
                    DescriptionText = string.Format("Please write a binary search function which searches an item in a sorted list.{0}The function should return the index of element to be searched in the list.", Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Binary Search",
                    Level = 2,
                    DescriptionText = string.Format("Please write a binary search function which searches an item in a sorted list.{0}The function should return the index of element to be searched in the list.", Environment.NewLine)
                }  ,
                new TaskDescription 
                {
                    TaskTitle = "Binary Search",
                    Level = 3,
                    DescriptionText = string.Format("Please write a binary search function which searches an item in a sorted list.{0}The function should return the index of element to be searched in the list.", Environment.NewLine)
                }  ,

                /* Count_Number_Of_Vowel */
                new TaskDescription 
                {
                    TaskTitle = "Count Number Of Vowel",
                    Level = 1,
                    DescriptionText = string.Format("Write function which  count the number of each vowel in a string and return dictionary{0}of counted vowel.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Count Number Of Vowel",
                    Level = 2,
                    DescriptionText = string.Format("Write function which  count the number of each vowel in a string and return dictionary{0}of counted vowel.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Count Number Of Vowel",
                    Level = 3,
                   DescriptionText = string.Format("Write function which  count the number of each vowel in a string and return dictionary{0}of counted vowel.",Environment.NewLine)
                },

                /* Dec_To_Bin*/
                new TaskDescription 
                {
                    TaskTitle = "Decimal To Binary",
                    Level = 1,
                    DescriptionText = string.Format("Write function that print binary number for the input decimal using recursion",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Decimal To Binary",
                    Level = 2,
                    DescriptionText = string.Format("Write function that print binary number for the input decimal using recursion",Environment.NewLine)
                },
                 new TaskDescription 
                {
                    TaskTitle = "Decimal To Binary",
                    Level = 3,
                    DescriptionText = string.Format("Write function that print binary number for the input decimal using recursion",Environment.NewLine)
                },

                /*Even_Numbers*/
                new TaskDescription 
                {
                    TaskTitle = "Even Numbers",
                    Level = 1,
                    DescriptionText = string.Format("Implement function which exclude all numbers from the list that are not even and{0}return new list of even numbers",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Even Numbers",
                    Level = 2,
                    DescriptionText =  string.Format("Implement function which exclude all numbers from the list that are not even and{0}return new list of even numbers",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Even Numbers",
                    Level = 3,
                    DescriptionText =  string.Format("Implement function which exclude all numbers from the list that are not even and{0}return new list of even numbers",Environment.NewLine)
                },

                /*Factorial*/
                new TaskDescription 
                {
                    TaskTitle = "Factorial",
                    Level = 1,
                    DescriptionText = string.Format("Implement a recursive function that find the factorial of an integer",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Factorial",
                    Level = 2,
                    DescriptionText = string.Format("Implement a recursive function that find the factorial of an integer",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Factorial",
                    Level = 3,
                    DescriptionText = string.Format("Implement a recursive function that find the factorial of an integer",Environment.NewLine)
                },

                /*Fibonacci*/
                new TaskDescription 
                {
                    TaskTitle = "Fibonacci",
                    Level = 1,
                    DescriptionText =  string.Format("Define recursive fibonacci function that find n-th fibonacci number",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Fibonacci",
                    Level = 2,
                    DescriptionText =  string.Format("Define recursive fibonacci function that find n-th fibonacci number",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Fibonacci",
                    Level = 3,
                    DescriptionText =  string.Format("Define recursive fibonacci function that find n-th fibonacci number",Environment.NewLine)
                },

                /*HCF*/
                new TaskDescription 
                {
                    TaskTitle = "HCF",
                    Level = 1,
                    DescriptionText = string.Format("Define function that takes two integers and calculate highest common factor",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "HCF",
                    Level = 2,
                    DescriptionText = string.Format("Define function that takes two integers and calculate highest common factor",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "HCF",
                    Level = 3,
                    DescriptionText = string.Format("Define function that takes two integers and calculate highest common factor",Environment.NewLine)
                },

                /*LCM*/
                new TaskDescription 
                {
                    TaskTitle = "LCM",
                    Level = 1,
                    DescriptionText = string.Format("Define function that takes two integers and calculate least common multiple",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "LCM",
                    Level = 2,
                   DescriptionText = string.Format("Define function that takes two integers and calculate least common multiple",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "LCM",
                    Level = 3,
                    DescriptionText = string.Format("Define function that takes two integers and calculate least common multiple",Environment.NewLine)
                },
                
                /*Leap_Year*/
                new TaskDescription 
                {
                    TaskTitle = "Leap Year",
                    Level = 1,
                    DescriptionText =  string.Format("Implement function that examines is the year leap",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Leap Year",
                    Level = 2,
                    DescriptionText =  string.Format("Implement function that examines is the year leap",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Leap Year",
                    Level = 3,
                    DescriptionText =  string.Format("Implement function that examines is the year leap",Environment.NewLine)
                },

                /*Math_Formula*/
                new TaskDescription 
                {
                    TaskTitle = "Math Formula",
                    Level = 1,
                    DescriptionText = string.Format("Write a program that calculates and prints the value according to the given formula:{0}Q = Square root of [(2 * C * D)/H]{0}Following are the fixed values of C and H:{0}C is 50. H is 30.{0}D is the variable whose values should be input to your program in a comma-separated sequence.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Math Formula",
                    Level = 2,
                    DescriptionText =string.Format("Write a program that calculates and prints the value according to the given formula:{0}Q = Square root of [(2 * C * D)/H]{0}Following are the fixed values of C and H:{0}C is 50. H is 30.{0}D is the variable whose values should be input to your program in a comma-separated sequence.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Math Formula",
                    Level = 3,
                    DescriptionText = string.Format("Write a program that calculates and prints the value according to the given formula:{0}Q = Square root of [(2 * C * D)/H]{0}Following are the fixed values of C and H:{0}C is 50. H is 30.{0}D is the variable whose values should be input to your program in a comma-separated sequence.",Environment.NewLine)
                },

                /*Matrix_Addition*/
                new TaskDescription 
                {
                    TaskTitle = "Matrix Addition",
                    Level = 1,
                    DescriptionText = "Write a function that take two matrices as arguments and return their additon."
                },
                new TaskDescription 
                {
                    TaskTitle = "Matrix Addition",
                    Level = 2,
                    DescriptionText =  "Write a function that take two matrices as arguments and return their additon."
                },
                new TaskDescription 
                {
                    TaskTitle = "Matrix Addition",
                    Level = 3,
                    DescriptionText =  "Write a function that take two matrices as arguments and return their additon."
                },

                /*Matrix_Transponse*/
                new TaskDescription 
                {
                    TaskTitle = "Matrix Transponse",
                    Level = 1,
                    DescriptionText =  "Write a function that take matrix as argument and return transponse matrix."
                },
                new TaskDescription 
                {
                    TaskTitle = "Matrix Transponse",
                    Level = 2,
                    DescriptionText = "Write a function that take matrix as argument and return transponse matrix."
                },
                new TaskDescription 
                {
                    TaskTitle = "Matrix Transponse",
                    Level = 3,
                    DescriptionText = "Write a function that take matrix as argument and return transponse matrix."
                },
                /*Palindrome*/
                new TaskDescription 
                {
                    TaskTitle = "Palindrome",
                    Level = 1,
                    DescriptionText = "Write function that check if string is palindrome (when reading string from end is the same as reading it from begining)."
                },
                new TaskDescription 
                {
                    TaskTitle = "Palindrome",
                    Level = 2,
                    DescriptionText = "Write function that check if string is palindrome (when reading string from end is the same as reading it from begining)."
                },
                new TaskDescription 
                {
                    TaskTitle = "Palindrome",
                    Level = 3,
                    DescriptionText = "Write function that check if string is palindrome (when reading string from end is the same as reading it from begining)."
                },
                /*Pow_Numbers*/
                new TaskDescription 
                {
                    TaskTitle = "Power Numbers",
                    Level = 1,
                    DescriptionText = string.Format("Write a function that takes takes list of numbers as first parameter{0}and return list of items that are pow(item,second_param)",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Power Numbers",
                    Level = 2,
                    DescriptionText = string.Format("Write a function that takes takes list of numbers as first parameter{0}and return list of items that are pow(item,second_param)",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Power Numbers",
                    Level = 3,
                    DescriptionText = string.Format("Write a function that takes takes list of numbers as first parameter{0}and return list of items that are pow(item,second_param)",Environment.NewLine)
                },
                /*Prime_Numbers*/
                new TaskDescription 
                {
                    TaskTitle = "Prime Numbers",
                    Level = 1,
                    DescriptionText = string.Format("Write a function that takes all prime numbers in interval between low_range and up_range",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Prime Numbers",
                    Level = 2,
                    DescriptionText = string.Format("Write a function that takes all prime numbers in interval between low_range and up_range",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Prime Numbers",
                    Level = 3,
                    DescriptionText = string.Format("Write a function that takes all prime numbers in interval between low_range and up_range",Environment.NewLine)
                },
                /*Print_Factors*/
                new TaskDescription 
                {
                    TaskTitle = "Compute Factors",
                    Level = 1,
                    DescriptionText = string.Format("Write a function that takes  a number and prints the factors",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Compute Factors",
                    Level = 2,
                    DescriptionText = string.Format("Write a function that takes  a number and prints the factors",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Compute Factors",
                    Level = 3,
                    DescriptionText =string.Format("Write a function that takes  a number and prints the factors",Environment.NewLine)
                },
                /*Random_Divisible*/
                new TaskDescription 
                {
                    TaskTitle = "Random Divisible",
                    Level = 1,
                    DescriptionText = string.Format(" Please write a program to output a random number, which is divisible by 5 and 7, between x and y.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Random Divisible",
                    Level = 2,
                    DescriptionText = string.Format(" Please write a program to output a random number, which is divisible by 5 and 7, between x and y.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Random Divisible",
                    Level = 3,
                    DescriptionText = string.Format(" Please write a program to output a random number, which is divisible by 5 and 7, between x and y.",Environment.NewLine)
                },
                /*Remove_Duplicates*/
                new TaskDescription 
                {
                    TaskTitle = "Remove Duplicates",
                    Level = 1,
                    DescriptionText = string.Format("Write a program that accepts a sequence of whitespace separated words as input{0}and prints the words after removing all duplicate words and sorting them alphanumerically.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Remove Duplicates",
                    Level = 2,
                    DescriptionText = string.Format("Write a program that accepts a sequence of whitespace separated words as input{0}and prints the words after removing all duplicate words and sorting them alphanumerically.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Remove Duplicates",
                    Level = 3,
                    DescriptionText = string.Format("Write a program that accepts a sequence of whitespace separated words as input{0}and prints the words after removing all duplicate words and sorting them alphanumerically.",Environment.NewLine)
                },
                /*Remove_Punctuations*/
                new TaskDescription 
                {
                    TaskTitle = "Remove Punctuations",
                    Level = 1,
                    DescriptionText = string.Format("Write a function that remove all punctuations from text.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Remove Punctuations",
                    Level = 2,
                    DescriptionText = string.Format("Write a function that remove all punctuations from text.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Remove Punctuations",
                    Level = 3,
                    DescriptionText = string.Format("Write a function that remove all punctuations from text.",Environment.NewLine)
                },
                /*Tuples*/
                new TaskDescription 
                {
                    TaskTitle = "Tuples",
                    Level = 1,
                    DescriptionText = string.Format("Write a function which accepts a sequence of comma-separated numbers from console{0}and generate a list and a tuple which contains every number.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Tuples",
                    Level = 2,
                    DescriptionText = string.Format("Write a function which accepts a sequence of comma-separated numbers from console{0}and generate a list and a tuple which contains every number.",Environment.NewLine)
                },
                new TaskDescription 
                {
                    TaskTitle = "Tuples",
                    Level = 3,
                    DescriptionText = string.Format("Write a function which accepts a sequence of comma-separated numbers from console{0}and generate a list and a tuple which contains every number.",Environment.NewLine)
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
                },

                /*Dec_To_Bin*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Dec_To_Bin/version1/Dec_To_Bin.py",
                    SolvedTaskPath = "~/Resources/Dec_To_Bin/version1/Dec_To_Bin_Solved.py",
                    WraperTaskPath = "~/Resources/Dec_To_Bin/version1/Dec_To_Bin_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Dec_To_Bin/version1/Dec_To_Bin_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Decimal To Binary" &&  d.Level == 2)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Dec_To_Bin/version2/Dec_To_Bin.py",
                    SolvedTaskPath = "~/Resources/Dec_To_Bin/version2/Dec_To_Bin_Solved.py",
                    WraperTaskPath = "~/Resources/Dec_To_Bin/version2/Dec_To_Bin_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Dec_To_Bin/version2/Dec_To_Bin_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Decimal To Binary" &&  d.Level == 1)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Dec_To_Bin/version3/Dec_To_Bin.py",
                    SolvedTaskPath = "~/Resources/Dec_To_Bin/version3/Dec_To_Bin_Solved.py",
                    WraperTaskPath = "~/Resources/Dec_To_Bin/version3/Dec_To_Bin_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Dec_To_Bin/version3/Dec_To_Bin_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Decimal To Binary" &&  d.Level == 3)
                },

                /*Even_Numbers*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Even_Numbers/version1/Even_Numbers.py",
                    SolvedTaskPath = "~/Resources/Even_Numbers/version1/Even_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Even_Numbers/version1/Even_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Even_Numbers/version1/Even_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Even Numbers" &&  d.Level == 3)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Even_Numbers/version2/Even_Numbers.py",
                    SolvedTaskPath = "~/Resources/Even_Numbers/version2/Even_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Even_Numbers/version2/Even_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Even_Numbers/version2/Even_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Even Numbers" &&  d.Level == 2)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Even_Numbers/version3/Even_Numbers.py",
                    SolvedTaskPath = "~/Resources/Even_Numbers/version3/Even_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Even_Numbers/version3/Even_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Even_Numbers/version3/Even_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Even Numbers" &&  d.Level == 1)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Even_Numbers/version4/Even_Numbers.py",
                    SolvedTaskPath = "~/Resources/Even_Numbers/version4/Even_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Even_Numbers/version4/Even_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Even_Numbers/version4/Even_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Even Numbers" &&  d.Level == 1)
                },

                /*Factorial*/
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Factorial/version1/Factorial.py",
                    SolvedTaskPath = "~/Resources/Factorial/version1/Factorial_Solved.py",
                    WraperTaskPath = "~/Resources/Factorial/version1/Factorial_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Factorial/version1/Factorial_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Factorial" &&  d.Level == 1)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Factorial/version2/Factorial.py",
                    SolvedTaskPath = "~/Resources/Factorial/version2/Factorial_Solved.py",
                    WraperTaskPath = "~/Resources/Factorial/version2/Factorial_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Factorial/version2/Factorial_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Factorial" &&  d.Level == 2)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Factorial/version3/Factorial.py",
                    SolvedTaskPath = "~/Resources/Factorial/version3/Factorial_Solved.py",
                    WraperTaskPath = "~/Resources/Factorial/version3/Factorial_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Factorial/version3/Factorial_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Factorial" &&  d.Level == 3)
                },

                /*Fibonacci*/
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Fibonacci/version1/Fibonacci.py",
                    SolvedTaskPath = "~/Resources/Fibonacci/version1/Fibonacci_Solved.py",
                    WraperTaskPath = "~/Resources/Fibonacci/version1/Fibonacci_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Fibonacci/version1/Fibonacci_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Fibonacci" &&  d.Level == 3)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Fibonacci/version2/Fibonacci.py",
                    SolvedTaskPath = "~/Resources/Fibonacci/version2/Fibonacci_Solved.py",
                    WraperTaskPath = "~/Resources/Fibonacci/version2/Fibonacci_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Fibonacci/version2/Fibonacci_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Fibonacci" &&  d.Level == 1)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/Fibonacci/version3/Fibonacci.py",
                    SolvedTaskPath = "~/Resources/Fibonacci/version3/Fibonacci_Solved.py",
                    WraperTaskPath = "~/Resources/Fibonacci/version3/Fibonacci_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Fibonacci/version3/Fibonacci_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Fibonacci" &&  d.Level == 2)
                },

                /*HCF*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/HCF/version1/HCF.py",
                    SolvedTaskPath = "~/Resources/HCF/version1/HCF_Solved.py",
                    WraperTaskPath = "~/Resources/HCF/version1/HCF_Wrapper.py",
                    IOTestTaskPath = "~/Resources/HCF/version1/HCF_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "HCF" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/HCF/version2/HCF.py",
                    SolvedTaskPath = "~/Resources/HCF/version2/HCF_Solved.py",
                    WraperTaskPath = "~/Resources/HCF/version2/HCF_Wrapper.py",
                    IOTestTaskPath = "~/Resources/HCF/version2/HCF_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "HCF" &&  d.Level == 3)
                },
                 new Task
                {
                    UnsolvedTaskPath = "~/Resources/HCF/version3/HCF.py",
                    SolvedTaskPath = "~/Resources/HCF/version3/HCF_Solved.py",
                    WraperTaskPath = "~/Resources/HCF/version3/HCF_Wrapper.py",
                    IOTestTaskPath = "~/Resources/HCF/version3/HCF_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "HCF" &&  d.Level == 1)
                },

                /*LCM*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/LCM/version1/LCM.py",
                    SolvedTaskPath = "~/Resources/LCM/version1/LCM_Solved.py",
                    WraperTaskPath = "~/Resources/LCM/version1/LCM_Wrapper.py",
                    IOTestTaskPath = "~/Resources/LCM/version1/LCM_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "HCF" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/LCM/version2/LCM.py",
                    SolvedTaskPath = "~/Resources/LCM/version2/LCM_Solved.py",
                    WraperTaskPath = "~/Resources/LCM/version2/LCM_Wrapper.py",
                    IOTestTaskPath = "~/Resources/LCM/version2/LCM_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "HCF" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/LCM/version3/LCM.py",
                    SolvedTaskPath = "~/Resources/LCM/version3/LCM_Solved.py",
                    WraperTaskPath = "~/Resources/LCM/version3/LCM_Wrapper.py",
                    IOTestTaskPath = "~/Resources/LCM/version3/LCM_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "HCF" &&  d.Level == 3)
                },

                /*Leap_Year*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Leap_Year/version1/Leap_Year.py",
                    SolvedTaskPath = "~/Resources/Leap_Year/version1/Leap_Year_Solved.py",
                    WraperTaskPath = "~/Resources/Leap_Year/version1/Leap_Year_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Leap_Year/version1/Leap_Year_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Leap Year" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Leap_Year/version2/Leap_Year.py",
                    SolvedTaskPath = "~/Resources/Leap_Year/version2/Leap_Year_Solved.py",
                    WraperTaskPath = "~/Resources/Leap_Year/version2/Leap_Year_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Leap_Year/version2/Leap_Year_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Leap Year" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Leap_Year/version3/Leap_Year.py",
                    SolvedTaskPath = "~/Resources/Leap_Year/version3/Leap_Year_Solved.py",
                    WraperTaskPath = "~/Resources/Leap_Year/version3/Leap_Year_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Leap_Year/version3/Leap_Year_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Leap Year" &&  d.Level == 3)
                },
               
                /*Math_Formula*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Math_Formula/version1/Math_Formula.py",
                    SolvedTaskPath = "~/Resources/Math_Formula/version1/Math_Formula_Solved.py",
                    WraperTaskPath = "~/Resources/Math_Formula/version1/Math_Formula_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Math_Formula/version1/Math_Formula_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Math Formula" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Math_Formula/version2/Math_Formula.py",
                    SolvedTaskPath = "~/Resources/Math_Formula/version2/Math_Formula_Solved.py",
                    WraperTaskPath = "~/Resources/Math_Formula/version2/Math_Formula_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Math_Formula/version2/Math_Formula_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Math Formula" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Math_Formula/version3/Math_Formula.py",
                    SolvedTaskPath = "~/Resources/Math_Formula/version3/Math_Formula_Solved.py",
                    WraperTaskPath = "~/Resources/Math_Formula/version3/Math_Formula_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Math_Formula/version3/Math_Formula_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Math Formula" &&  d.Level == 3)
                },

                /*Matrix_Addition*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Matrix_Addition/version1/Matrix_Addition.py",
                    SolvedTaskPath = "~/Resources/Matrix_Addition/version1/Matrix_Addition_Solved.py",
                    WraperTaskPath = "~/Resources/Matrix_Addition/version1/Matrix_Addition_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Matrix_Addition/version1/Matrix_Addition_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Matrix Addition" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Matrix_Addition/version2/Matrix_Addition.py",
                    SolvedTaskPath = "~/Resources/Matrix_Addition/version2/Matrix_Addition_Solved.py",
                    WraperTaskPath = "~/Resources/Matrix_Addition/version2/Matrix_Addition_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Matrix_Addition/version2/Matrix_Addition_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Matrix Addition" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Matrix_Addition/version3/Matrix_Addition.py",
                    SolvedTaskPath = "~/Resources/Matrix_Addition/version3/Matrix_Addition_Solved.py",
                    WraperTaskPath = "~/Resources/Matrix_Addition/version3/Matrix_Addition_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Matrix_Addition/version3/Matrix_Addition_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Matrix Addition" &&  d.Level == 3)
                },

                /*Palindrome*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Palindrome/version1/Palindrome.py",
                    SolvedTaskPath = "~/Resources/Palindrome/version1/Palindrome_Solved.py",
                    WraperTaskPath = "~/Resources/Palindrome/version1/Palindrome_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Palindrome/version1/Palindrome_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Palindrome" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Palindrome/version2/Palindrome.py",
                    SolvedTaskPath = "~/Resources/Palindrome/version2/Palindrome_Solved.py",
                    WraperTaskPath = "~/Resources/Palindrome/version2/Palindrome_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Palindrome/version2/Palindrome_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Palindrome" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Palindrome/version3/Palindrome.py",
                    SolvedTaskPath = "~/Resources/Palindrome/version3/Palindrome_Solved.py",
                    WraperTaskPath = "~/Resources/Palindrome/version3/Palindrome_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Palindrome/version3/Palindrome_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Palindrome" &&  d.Level == 3)
                },
                /*Pow_Numbers*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Pow_Numbers/version1/Pow_Numbers.py",
                    SolvedTaskPath = "~/Resources/Pow_Numbers/version1/Pow_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Pow_Numbers/version1/Pow_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Pow_Numbers/version1/Pow_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Power Numbers" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Pow_Numbers/version2/Pow_Numbers.py",
                    SolvedTaskPath = "~/Resources/Pow_Numbers/version2/Pow_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Pow_Numbers/version2/Pow_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Pow_Numbers/version2/Pow_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Power Numbers" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Pow_Numbers/version3/Pow_Numbers.py",
                    SolvedTaskPath = "~/Resources/Pow_Numbers/version3/Pow_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Pow_Numbers/version3/Pow_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Pow_Numbers/version3/Pow_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Power Numbers" &&  d.Level == 3)
                },
                /*Prime_Numbers*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Prime_Numbers/version1/Prime_Numbers.py",
                    SolvedTaskPath = "~/Resources/Prime_Numbers/version1/Prime_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Prime_Numbers/version1/Prime_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Prime_Numbers/version1/Prime_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Prime Numbers" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Prime_Numbers/version2/Prime_Numbers.py",
                    SolvedTaskPath = "~/Resources/Prime_Numbers/version2/Prime_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Prime_Numbers/version2/Prime_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Prime_Numbers/version2/Prime_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Prime Numbers" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Prime_Numbers/version3/Prime_Numbers.py",
                    SolvedTaskPath = "~/Resources/Prime_Numbers/version3/Prime_Numbers_Solved.py",
                    WraperTaskPath = "~/Resources/Prime_Numbers/version3/Prime_Numbers_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Prime_Numbers/version3/Prime_Numbers_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Prime Numbers" &&  d.Level == 3)
                },
                /*Print_Factors*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Print_Factors/version1/Print_Factors.py",
                    SolvedTaskPath = "~/Resources/Print_Factors/version1/Print_Factors_Solved.py",
                    WraperTaskPath = "~/Resources/Print_Factors/version1/Print_Factors_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Print_Factors/version1/Print_Factors_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Compute Factors" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Print_Factors/version2/Print_Factors.py",
                    SolvedTaskPath = "~/Resources/Print_Factors/version2/Print_Factors_Solved.py",
                    WraperTaskPath = "~/Resources/Print_Factors/version2/Print_Factors_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Print_Factors/version2/Print_Factors_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Compute Factors" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Print_Factors/version3/Print_Factors.py",
                    SolvedTaskPath = "~/Resources/Print_Factors/version3/Print_Factors_Solved.py",
                    WraperTaskPath = "~/Resources/Print_Factors/version3/Print_Factors_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Print_Factors/version3/Print_Factors_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Compute Factors" &&  d.Level == 3)
                },
                /*Random_Divisible*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Random_Divisible/version1/Random_Divisible.py",
                    SolvedTaskPath = "~/Resources/Random_Divisible/version1/Random_Divisible_Solved.py",
                    WraperTaskPath = "~/Resources/Random_Divisible/version1/Random_Divisible_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Random_Divisible/version1/Random_Divisible_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Random Divisible" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Random_Divisible/version2/Random_Divisible.py",
                    SolvedTaskPath = "~/Resources/Random_Divisible/version2/Random_Divisible_Solved.py",
                    WraperTaskPath = "~/Resources/Random_Divisible/version2/Random_Divisible_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Random_Divisible/version2/Random_Divisible_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Random Divisible" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Random_Divisible/version3/Random_Divisible.py",
                    SolvedTaskPath = "~/Resources/Random_Divisible/version3/Random_Divisible_Solved.py",
                    WraperTaskPath = "~/Resources/Random_Divisible/version3/Random_Divisible_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Random_Divisible/version3/Random_Divisible_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Random Divisible" &&  d.Level == 3)
                },
                /*Remove_Duplicates*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Remove_Duplicates/version1/Remove_Duplicates.py",
                    SolvedTaskPath = "~/Resources/Remove_Duplicates/version1/Remove_Duplicates_Solved.py",
                    WraperTaskPath = "~/Resources/Remove_Duplicates/version1/Remove_Duplicates_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Remove_Duplicates/version1/Remove_Duplicates_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Remove Duplicates" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Remove_Duplicates/version2/Remove_Duplicates.py",
                    SolvedTaskPath = "~/Resources/Remove_Duplicates/version2/Remove_Duplicates_Solved.py",
                    WraperTaskPath = "~/Resources/Remove_Duplicates/version2/Remove_Duplicates_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Remove_Duplicates/version2/Remove_Duplicates_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Remove Duplicates" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Remove_Duplicates/version3/Remove_Duplicates.py",
                    SolvedTaskPath = "~/Resources/Remove_Duplicates/version3/Remove_Duplicates_Solved.py",
                    WraperTaskPath = "~/Resources/Remove_Duplicates/version3/Remove_Duplicates_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Remove_Duplicates/version3/Remove_Duplicates_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Remove Duplicates" &&  d.Level == 3)
                },
                /*Remove_Punctuations*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Remove_Punctuations/version1/Remove_Punctuations.py",
                    SolvedTaskPath = "~/Resources/Remove_Punctuations/version1/Remove_Punctuations_Solved.py",
                    WraperTaskPath = "~/Resources/Remove_Punctuations/version1/Remove_Punctuations_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Remove_Punctuations/version1/Remove_Punctuations_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Remove Punctuations" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Remove_Punctuations/version2/Remove_Punctuations.py",
                    SolvedTaskPath = "~/Resources/Remove_Punctuations/version2/Remove_Punctuations_Solved.py",
                    WraperTaskPath = "~/Resources/Remove_Punctuations/version2/Remove_Punctuations_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Remove_Punctuations/version2/Remove_Punctuations_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Remove Punctuations" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Remove_Punctuations/version3/Remove_Punctuations.py",
                    SolvedTaskPath = "~/Resources/Remove_Punctuations/version3/Remove_Punctuations_Solved.py",
                    WraperTaskPath = "~/Resources/Remove_Punctuations/version3/Remove_Punctuations_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Remove_Punctuations/version3/Remove_Punctuations_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Remove Punctuations" &&  d.Level == 3)
                },
                /*Tuples*/
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Tuples/version1/Tuples.py",
                    SolvedTaskPath = "~/Resources/Tuples/version1/Tuples_Solved.py",
                    WraperTaskPath = "~/Resources/Tuples/version1/Tuples_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Tuples/version1/Tuples_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Tuples" &&  d.Level == 1)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Tuples/version2/Tuples.py",
                    SolvedTaskPath = "~/Resources/Tuples/version2/Tuples_Solved.py",
                    WraperTaskPath = "~/Resources/Tuples/version2/Tuples_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Tuples/version2/Tuples_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Tuples" &&  d.Level == 2)
                },
                new Task
                {
                    UnsolvedTaskPath = "~/Resources/Tuples/version3/Tuples.py",
                    SolvedTaskPath = "~/Resources/Tuples/version3/Tuples_Solved.py",
                    WraperTaskPath = "~/Resources/Tuples/version3/Tuples_Wrapper.py",
                    IOTestTaskPath = "~/Resources/Tuples/version3/Tuples_IO.py",
                    Description = descriptions.Single(d => d.TaskTitle == "Tuples" &&  d.Level == 3)
                }
            }.ForEach(a => context.Tasks.Add(a));
            
        }
    }
}