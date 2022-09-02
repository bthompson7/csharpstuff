using System;
using System.Collections;

namespace TodoApi.Model
{
    public class Developer : Employee
    {

        public Developer() : base(){
            department = "Developer Department";
            salary = "80000";
            jobTitle = "Software Developer";

        }

        public override void doWork(){
            Console.WriteLine("Developer work!");
        }
    }
}