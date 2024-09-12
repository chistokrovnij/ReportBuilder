﻿using Reporter;

List<Employee> employees = new()
{
    new Employee {Name = "Ivan", Salary = 100},
    new Employee {Name = "Boris", Salary = 150},
    new Employee {Name = "Fedor", Salary = 200},
};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeReportDirector(builder);

director.Builder();

var report = builder.GetReport();

Console.WriteLine(report);

Console.ReadKey();