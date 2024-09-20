using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
            //Console.WriteLine("Welcome to Acme Accounting Systems \n Remember, we’re “accounting");
            Console.WriteLine("What is your name?");// 
            String yourName = Console.ReadLine();  // Reading the name and assign the Text value on yourname identifyer
            Console.WriteLine("What course are you on ?");
            String course = Console.ReadLine();    // Reading the coures  and assign the Text value on course identifyer
            Console.WriteLine("What page Number ?");
            String pagen = Console.ReadLine();    // 
            String pagenumber = pagen.ToString(); // convert page number into String and set on pagenumber varible.
            Console.WriteLine("Do you need any help with anything ? Pleas answer \" true \" or \" false\" );
            String ans = Console.ReadLine(); // Reading the answer and assign the Text value on ans identifyer
            bool respond = bool.Parse(ans);
            Console.WriteLine("Is threre any other feedback you'd like to provide? Pleas be specific.");
            String feedback = Console.ReadLine(); // Reading the feed back and assign the Text value on feedback identifyer
            Console.WriteLine("How many hour did you study today ?");
            int studyhour = Console.ReadLine(); // Reading study hour and assign the Text value on studyhour identifyer
            Console.WriteLine("Thank you for your answers !");
        }
  }
}