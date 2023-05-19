
using SampleCoreApp;

Console.WriteLine("Testing C# Code");//New in C# 8.0, we have TOP LEVEL Statements where we can execute or create functions without a class creation. 

Console.WriteLine("Testing another piece of code");

EmployeeManager mgr = new EmployeeManager();
var data = mgr.GetAllEmployees();
foreach (var emp in data)
{
    Console.WriteLine(emp.Name);
}

TestClass cls = new TestClass();
cls.InstanceFunc();//call the instance method with the instance of the TestClass

TestClass.TestFunc();//Call the static method
class TestClass
{
    public static void TestFunc() => Console.WriteLine("Test Func");

    public void InstanceFunc() => Console.WriteLine("Instance func");
}
