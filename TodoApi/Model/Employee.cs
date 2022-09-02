using System;
using System.Collections;

namespace TodoApi.Model
{
    public class Employee
    {
        public long Id { get; set; }
        public string fullName { get; set; }
        public string jobTitle { get; set; }
        public string salary{get; set;}
        public string department{get; set;}

        public Employee(){
           department = "Employee Department";
        }
 
        public Employee(string _fullName, string _jobTitle, string _salary, string _department){
            fullName = _fullName;
            jobTitle = _jobTitle;
            salary = _salary;
            department = _department;
        }

        public virtual void doWork(){
            Console.WriteLine("Employee work");
        }

    }
}