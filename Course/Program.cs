﻿using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

#region FirstClassTest
Order order = new Order { 
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.Processing.ToString();
Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(os);
#endregion

#region WorkerIncomeContracts
Console.Write("Enter departmens's name: ");
string deptName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(deptName);
Worker worker = new Worker(name, level, salary, dept);

Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.addContract(contract);
}

Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
#endregion

#region StringBuilderPost
Comment c1 = new Comment("Have a nice trip.");
Comment c2 = new Comment("Wow that's awesome!");
Post p1 = new Post(
    DateTime.Now,
    "Travelling ot New Zealand",
    "I'm going to visit this wonderful country!",
    12
);
p1.AddComment(c1);
p1.AddComment(c2);

Comment c3 = new Comment("Good night.");
Comment c4 = new Comment("May the Force be with you.");
Post p2 = new Post(
    DateTime.Now,
    "Good night guys",
    "See you tomorrow",
    12
);
p2.AddComment(c3);
p2.AddComment(c4);

Console.WriteLine(p1);
Console.WriteLine(p2);
#endregion