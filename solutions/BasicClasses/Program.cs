Employee e1 = new Employee("Hank Hill", 1001, 100);
Employee e2 = new Employee("Luann Platter", 1002, 126);

Console.WriteLine($"{e1._name} has made {e1._ytdSalary} so far this year and has {e1._ytdTax} withheld");
Console.WriteLine($"{e2._name} has made {e2._ytdSalary} so far this year and has {e2._ytdTax} withheld");

e1.Pay();
e2.Pay();
e1.Pay();

Console.WriteLine("------- Payday! -----------");
Console.WriteLine($"{e1._name} has made {e1._ytdSalary} so far this year and has {e1._ytdTax} withheld");
Console.WriteLine($"{e2._name} has made {e2._ytdSalary} so far this year and has {e2._ytdTax} withheld");

