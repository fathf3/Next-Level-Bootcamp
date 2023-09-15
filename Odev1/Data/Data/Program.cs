// See https://aka.ms/new-console-template for more information

using Data.Models;
using Microsoft.EntityFrameworkCore;

NorthwindDbCotext context = new NorthwindDbCotext();

var result = context.Employees.ToList();

foreach (var item in result)
    Console.WriteLine($"{item.FirstName} {item.LastName} {item.Extension}");


var result2 = context.Orders.Where(x => x.EmployeeId == 3);

foreach (var item in result2)
    Console.WriteLine($"{item.OrderId} {item.OrderDate} {item.ShipCountry}");