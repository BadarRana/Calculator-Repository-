using system;
class program
{
  static void main()
  {
    Console.Writeline("Rana Badar Munir");
    Console.Writeline("24-ST-015");
    Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Division: {a / b}");
  }
}
