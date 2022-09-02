using System;
using System.Collections.Generic;

namespace TodoApi.Model
{
    public class Employee
    {
        public long Id { get; set; }
        public string fullName { get; set; }
        public string jobTitle { get; set; }
        public string salary{get; set;}

        public Employee(){

        }
 
        public Employee(string _fullName, string _jobTitle, string _salary){
            fullName = _fullName;
            jobTitle = _jobTitle;
            salary = _salary;
        }
 

        public virtual void doWork(){
            Console.WriteLine("Employee work");
        }

    }
}