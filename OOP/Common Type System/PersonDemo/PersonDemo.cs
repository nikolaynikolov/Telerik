using PersonInfo;
using System;
class PersonInfoDemo
{
    static void Main()
    {
        Person peshoPeshov = new Person("Pesho Peshov", new DateTime(1981, 5, 12));
        Console.WriteLine(peshoPeshov);
        Person newPerson = new Person("Gosho Georgiev");
        Console.WriteLine(newPerson);
    }
}