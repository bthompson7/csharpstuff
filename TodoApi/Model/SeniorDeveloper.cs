using System;
using System.Collections;

namespace TodoApi.Model
{
    public class SeniorDeveloper : Employee
    {

        public SeniorDeveloper() : base(){
            department = "Senior Developer Department";
            salary = "100000";
            jobTitle = "Senior Software Developer";
        }

        public override void doWork(){
            Console.WriteLine("Senior Developer work!");
        }
    }
}