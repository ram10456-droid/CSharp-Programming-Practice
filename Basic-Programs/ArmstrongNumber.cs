Static void Main(string []args)
{
   int a = Convert.ToInt32(Console.ReadLine());
 int result = a;
 int b = 0;
 while (a > 0)
 {
     int reminder = a % 10;
     b = b + (reminder * reminder * reminder);
     a = a / 10;

 }
 Console.WriteLine(b);
 if (b == result)
 {
     Console.WriteLine("what you given in put that was amstrong number");
 }
 else
 {
     Console.WriteLine("what you given in put that was non-amstrong number");
 }
}
