using System;
using System.Collections.Generic;

namespace TodoApi.Model
{
    public class Developer : Employee
    {
        public Developer() : base(){

        }

        public override void doWork(){
            Console.WriteLine("Developer work!");
        }
    }
}