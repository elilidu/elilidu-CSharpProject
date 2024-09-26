using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
            /* Console.WriteLine("Hello World!");
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
         // Adding two number and display the result
         int num1 = 5;
         int num2 = 7;
         int total = num1 + num2;
         Console.WriteLine("The sum is  " + total);

         // Subtract two number and display the result
         int num3 = 5;
         int num4 = 7;
         int diff = num1 - num2;
         Console.WriteLine("The differnce is  " + diff);

         // Multiple two number and display the result
         int num5 = 5;
         int num6 = 7;
         int mul = num1 + num2;
         Console.WriteLine("The productis  " + mul);

         // Divided a number and display the result
         double num7 = 5.0;
         double num8 = 7.0;
         double div = num2 / num1;
         Console.WriteLine("Division is  " + div);
         Console.ReadLine();

         //Takes an input from the user, multiplies it by 50 and display the result
         Console.WriteLine("enter the number larger than 10,000,000");
         string userinput = Console.ReadLine();
         long mul1 = long.Parse(userinput) * 50;
         Console.WriteLine("The resulte is" + mul1);
         Console.ReadLine();

         //Takes an input from the user, adds 25 and display the result
         Console.WriteLine("enter any Integetr number");
         string usernum = Console.ReadLine();
         long mul2 = long.Parse(usernum) * 25;
         Console.WriteLine("The resulte is" + mul2);
         Console.ReadLine();

         //Takes an input from the user, divides it by 12.5 and display the resulte
         Console.WriteLine("enter any number");
         string usernum2 = Console.ReadLine();
         Double div1 = Double.Parse(usernum2) / 12.5;
         Console.WriteLine("The resulte is" + div1);
         Console.ReadLine();

         //Takes an input from the user, checks if it is greater than 50 and diplay the resulte
         Console.WriteLine("enter any number");
         string usernum3 = Console.ReadLine();
         bool isLargeNum = int.Parse(usernum3) > 50;
         Console.WriteLine(isLargeNum.ToString());
         Console.ReadLine();

         //Takes an input from the user, divides it by 7 and display the remainder
         Console.WriteLine("enter any Integetr number");
         string usernum4 = Console.ReadLine();
         long num = long.Parse(usernum4) % 7;
         Console.WriteLine("The remender is  " + num);*/

           //Read Age, DUI and number of speed ticket then if he qualified all criteria
           // display true if not so, display false
           /* Console.WriteLine("What is your age?");
            int age= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI Answer yes or no?");
            string Console.ReadLine();
            Console.WriteLine("How many speed tickets do you have?");
            int nuOfTibker=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualifide for insurance?");
            bool qual = (age>15) && !ans)&& (nuOfTibker<=3);
            Console.WriteLine(qual);
            Console.ReadLine();

            //Branching demo if/else statements
            if(1==1)
            {
                Console.WriteLine("1 equals 1!");
            }
            else
            {
                Console.WriteLine("1 dose not equals 1");
            }

            //else if statement
            string name = "Adam";
            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if(name == "Brett")
            {
                Console.WriteLine("Your name is not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse. Your name is nit Brett");
            }

            //Ternery operator demo
            int num1 = 7;
            int num2 = 12;

            string resualt = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(resualt);
            */
            
            
            
            
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
           
            Console.WriteLine("Pleas Enter your  package Weight");
            int Pacweight = Convert.ToInt32(Console.ReadLine());

            if (pacweight >50 )
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.WriteLine(resualt);
            }
                else 
                {
                    Console.WriteLine("Pleas Enter your  package width");
                    int Pacwidth = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Pleas Enter your  package height");
                    int Pacheigh = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Pleas Enter your  package length");

                    if (Pacwidth > 50 && Pacheigh > 50 && Paclength > 50)
                    {
                        Console.WriteLine("Package too big to be shipped via Package Express.");
                        Console.WriteLine(resualt);
                    }
                    else
                    {
                        int result = (Pacwidth * Pacheigh * Paclength) * Pacweight / 100;
                        Console.WriteLine("Your estimated total for shipping this package is  ." +"$"+ result + "\n Thank You!");
                        Console.WriteLine(resualt);
                    }

                }

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            //while loop and display 1 up to 10
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            //do while loop and show 10 up to 0
            int num2 = 10;
            do
            {
                Console.WriteLine(num2);
                num2--;
            }
            while (num2 > 0);

            // String Concatenates
            string string2 = "String";
            string string3 = "Concatenation Illustration";
            Console.WriteLine("This is" + string2 + string3);

            //Changing string to UPPERCASE
            string name = "Hi jone";
            Console.WriteLine(name.ToUpper());

            // String bulder object
            StringBuilder Mystr = new StringBuilder();
            Mystr.Append("It is used for dynamic string manipulation, " +
                "such as building strings from many smaller strings or " +
                "appending new characters to an existing string.");
            Console.WriteLine(Mystr);
            Console.ReadLine();


        }
    }