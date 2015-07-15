using StudentUnit;
using StudentUnit.Enums;
using System;
class StudentDemo
{
    static void Main()
    {
        Student[] students = new Student[]
{
new Student(
"Pesho",
"Peshov",
"Stamatov",
"123-45-6789",
"Bulgaria, Sofia, Tzarigradsko shose 1",
"088 1111 2222",
"Pesho@gmail.com",
3,
Speciality.Biology,
University.SofiaUnivercity,
School.Science),
new Student(
"Ivan",
"Ivanov",
"Georgiev",
"123-45-6780",
"Bulgaria, Sofia, Tzarigradsko shose 2",
"088 1111 2223",
"Ivan@gmail.com",
1,
Speciality.Mathematics,
University.PlovdivUnivercity,
School.Science),
new Student(
"Dragan",
"Draganov",
"Petrov",
"088 1111 2224",
"Bulgaria, Sofia, Tzarigradsko shose 3",
"012 9858 9900",
"Dragan@gmail.com",
4,
Speciality.Mathematics,
University.Uacg,
School.CivilEngineering),
new Student(
"Penka",
"Borisova",
"Slavkova",
"123-45-6779",
"Bulgaria, Sofia, Tzarigradsko shose 4",
"088 1111 2225",
"Penka@gmail.com",
2,
Speciality.History,
University.Unss,
School.Management),
new Student(
"Vanq",
"Petrova",
"Ivanova",
"088 1111 2226",
"Bulgaria, Sofia, Tzarigradsko shose 5",
"031 7861 9238",
"Vanq@gmail.com",
4,
Speciality.Literature,
University.SofiaUnivercity,
School.Literature),
new Student(
"Ilia",
"Valov",
"Petrov",
"124-45-6789",
"Bulgaria, Sofia, Tzarigradsko shose 6",
"088 1111 2227",
"Ilia@gmail.com",
4,
Speciality.History,
University.PlovdivUnivercity,
School.History),
};
        Array.Sort(students);
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}