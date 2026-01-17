Employee e1 = new Employee("Hank Hill", 1001, 100);
Employee e2 = new Employee("Luann Platter", 1002, 126);

e2.HomeAddress = new Address("84 Rainey St", null, "Arlen", "TX", "78701");
e1.WorkAddress = new Address("901 Strickland Hwy", null, "Arlen", "TX", "78701");

Console.WriteLine($"{e1.Name} has made {e1.YtdSalary} so far this year and has {e1.YtdTax} withheld");
Console.WriteLine($"{e2.Name} has made {e2.YtdSalary} so far this year and has {e2.YtdTax} withheld");

e1.Pay();
e2.Pay();
e1.Pay();

Console.WriteLine("------- Payday! -----------");
Console.WriteLine($"{e1.Name} has made {e1.YtdSalary} so far this year and has {e1.YtdTax} withheld");
Console.WriteLine($"{e2.Name} has made {e2.YtdSalary} so far this year and has {e2.YtdTax} withheld");

Console.WriteLine(e1);
Console.WriteLine(e2);