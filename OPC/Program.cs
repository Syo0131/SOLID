using OPC.Entities;
using System;

namespace OPC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student(1, "jose");
            Course onlineCourse = new OnlineCourse();
            onlineCourse.Subscribe(student);

            Course offlineCourse = new OfflineCourse();
            offlineCourse.Subscribe(student);
        }

    }
}