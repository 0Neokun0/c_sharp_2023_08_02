// C# program to illustrate the
// read-only property
using System;

public class Student
{

    // Declare counter field as cnt
    private static int cnt;

    // to define constructor
    public Student()
    {

        // increment the counter
        // using constructor
        cnt++;
    }

    // Declare counter property
    public static int Counter
    {

        // read-only property
        get
        {
            return cnt;
        }
    }
}

class StudentTest
{

    // Main Method
    public static void Main(string[] args)
    {

        // create three instances of
        // Student class it call constructor
        // three times which increase the counter
        Student s1 = new Student();
        Student s2 = new Student();
        Student s3 = new Student();

        // s1.Counter = 10;
        // Compile Time Error: Can't set value of
        // Counter because it is read only.

        Console.WriteLine("Total No of Student: " + Student.Counter);

        // Program Give Warning
        // The variable `s1' is assigned but its value is never used
    }
}
