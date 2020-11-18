using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeWeek1Day2
{
    [TestClass]
    public class ChallengeWeek1Day2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string super = "Supercalifragilisticexpialidocious";
            foreach (char c in super)
            {
                if(c == 'i')
                {
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine("Not I");
                }
            }
            int len = super.Length;
                Console.Write(len);

        }
        [TestMethod]

        public void Array()
        {
            string[] movie1 = { "Batman", "Inception", "Die Hard", "Pulp Fiction" };
                   
        }

        [TestMethod]

        public void ListOfDates()
        {
            List<DateTime> listofDates = new List<DateTime>();
            listofDates.Add(new DateTime(2020,12,25));
            DateTime now = DateTime.Now;
            listofDates.Add(now);
        }

        [TestMethod]

        public void NameAge()
        {
            string firstName = "Andrew";
            string lastName = "Steward";
            int age = 27;

            int ageDiffSubtraction = age - 7;
            int ageDiffAddition = age + 7;
            int ageDiffMultiplication = age * 7;
            int ageDiffDivision = age / 7;
            int ageDiffMod = age % 7;
            Console.WriteLine(ageDiffSubtraction);
            Console.WriteLine(ageDiffAddition);
            Console.WriteLine(ageDiffMultiplication);
            Console.WriteLine(ageDiffDivision);
            Console.WriteLine(ageDiffMod);
            
        }

        [TestMethod]

        public void SleepHours()
        {
            int sleepHours = 11;
            string wow = "Wow that's a lot of sleep!";
            string rested = "You should be pretty rested";
            string bummer = "Bummer";
            string needRest = "Oh man, get some sleep!";

            if (sleepHours > 10)
            {
                Console.WriteLine(wow);

            }
            else if (sleepHours > 8 && sleepHours < 10)
            {
                Console.WriteLine(rested);
            }
            else if (sleepHours > 4 && sleepHours < 8)
            {
                Console.WriteLine(bummer);
            }
            else
            {
                Console.WriteLine(needRest);
            }
            
        }

        [TestMethod]

        public void Mood()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are great");
                    break;
                case "Good":
                    Console.WriteLine("Glad you are good");
                    break;
                case "Okay":
                    Console.WriteLine("Ok");
                    break;
                case "Bad":
                    Console.WriteLine("I'm Sorry");
                    break;
                case ":(":
                    Console.WriteLine("Sad");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
