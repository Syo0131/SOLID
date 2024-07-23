﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPC.Entities
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Student subscribed to online course.");
        }
    }
}
