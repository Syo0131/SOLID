using System;

public class program
{
    public static void main() 
    { 
        Student student = new Student();
        Course onlineCourse = new OnlineCourse();
        onlineCourse.Subscribe(student);

        Course offlineCourse = new OfflineCourse();
        offlineCourse.Subscribe(student);
    }

}
