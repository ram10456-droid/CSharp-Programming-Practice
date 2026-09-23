static void Main(string[] args)
{
  int n = Convert.ToInt32(Console.ReadLine());
 for (int a = 2; a <= n; a++)
 {
     bool isPrime = true;

     for (int i = 2; i < a; i++)  // check divisibility
     {
         if (a % i == 0)
         {
             isPrime = false;
             break;
         }
     }

     if (isPrime)
     {
         Console.WriteLine(a);   // print prime number
     }
 }
