using MiProyecto;
using System.Linq.Expressions;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Bienvenidos a mi programa en GIT");

//SalaryEmployee e1=new SalaryEmployee();
Employee Employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActived = true,
    Salary = 1815453.45M,
};
Console.WriteLine(Employee1);

Employee Employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActived = true,
    Sales = 320000000M,
    CommissionPercentaje=0.03F,
};
Console.WriteLine(Employee2);