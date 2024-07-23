﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISKOV.Entities
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Student subscribed to offline course.");
        }
    }
}
