using Iteration_Statements_Ex2_3;

Console.WriteLine("");
Console.WriteLine("numbers -1000 up to 1000");
methods.num1000();
Console.WriteLine("");
Console.WriteLine("numbers 3 up to 999");
methods.num999();

Console.WriteLine("");
Console.WriteLine("");

Console.Write("choose any number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

methods.choose1(num1);
Console.WriteLine("");
Console.WriteLine("");

Console.Write("choose any number again: ");
int num2 = Convert.ToInt32(Console.ReadLine());
methods.choose2(num2);
Console.WriteLine("");
Console.WriteLine("");

methods.EqOrNot(num1, num2);
Console.WriteLine("");
Console.WriteLine("");

methods.PosOrNeg(num1, num2);
Console.WriteLine("");
Console.WriteLine("");

methods.vote();
Console.WriteLine("");
Console.WriteLine("");

Console.Write("pick any number to multiply: ");
int numPicked = Convert.ToInt32(Console.ReadLine());

methods.range(numPicked);
Console.WriteLine("");
Console.WriteLine("");

methods.mult(numPicked);
