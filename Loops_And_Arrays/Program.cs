// See https://aka.ms/new-console-template for more information
using System;

string course1 = "C";
string course2 = "C++";
string course3 = "C#";
string[] courses = new string[] { course1, course2, course3 };

Console.WriteLine("------Using For-----------");
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i]);
}
Console.WriteLine("------Using Foreach-----------");
foreach (var course in courses)
{
    Console.WriteLine(course);
}