// See https://aka.ms/new-console-template for more information

using Solid.App.ISPGoodAndBad;
using Solid.App.LSP.Good;
using Solid.App.DIPGoodAndBad;


Console.WriteLine("Hello, World!");


//SalaryCalculator salaryCalculator = new SalaryCalculator();

// OCP Bay Way
//Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, SalaryType.Low)}");
//Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, SalaryType.Middle)}");
//Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, SalaryType.High)}");

// OCP Good Way
//Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculator())}");
//Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculator())}");
//Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculator())}");

// OCP Good Way 2
//Console.WriteLine($"Low Salary: {salaryCalculator.Calculate(1000, new LowSalaryCalculator().Calculate)}");
//Console.WriteLine($"Middle Salary: {salaryCalculator.Calculate(1000, new MiddleSalaryCalculator().Calculate)}");
//Console.WriteLine($"High Salary: {salaryCalculator.Calculate(1000, new HighSalaryCalculator().Calculate)}");

//Console.WriteLine($"Custom Salary: {salaryCalculator.Calculate(1000, x =>
//{
//    return x * 10;
//})}"); //kendi metodumuzu yazdık delegate ile

//LSP.Bad
//BasePhone phone = new IPhone();
//phone.Call();
//phone.TakePhoto();

//phone = new Nokia3310();
//phone.Call();
//phone.TakePhoto();


//LSP.Good
//BasePhone phone = new IPhone();
//phone.Call();
//((ITakePhoto)phone).TakePhoto();

//phone = new Nokia3310();
//phone.Call();


//DIP.GoodAndBad
var ProductService = new ProductService(new ProductRepositoryFromOracle());

ProductService.GetAll().ForEach(x => Console.WriteLine(x));
