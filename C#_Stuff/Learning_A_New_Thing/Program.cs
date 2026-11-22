// Console.WriteLine(" ");
// Console.WriteLine("Hello, \tWorld!");
// Console.WriteLine(" ");
// Console.WriteLine("I am \tSwapnanil\n");

// Console.WriteLine("The Present time is\t" + DateTime.Now + "\n");

// Using writeline will lways move the to the next line after printing the text.
// Using write will not move to the next line after printing the text.

// Console.Write("I\t");
// Console.Write("am\t");
// Console.Write("Swapnanil\n"); 

// Console.Write("What is your name?\t -> ");
// string name = Console.ReadLine();
// Console.WriteLine("Hello, " + name + "!");

// Console.Write("Tell us your name: ");
// string name = Console.ReadLine();
// Console.Write("Tell us your age: ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");

// Console.Write("Enter your name and Your Age: (Without  your name first and then a space and then your age)");
// string[] namage = Console.ReadLine().Split(' ');
// string name = namage[0];
// int age = Convert.ToInt32(namage[1]);
// Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");

// Console.Write("Like This put your name age city you were born and that's it with one space separating each of them: ");
// string[] name_age_city = Console.ReadLine()!.Split(' ');
// string name = name_age_city[0];
// int age = Convert.ToInt32(name_age_city[1]);
// string city = name_age_city[2];
// Console.WriteLine("Hello, " + name + "! You are " + age + " years old and you were born in " + city + ".");
// string text = "Say, my name, Puzy";

// Console.WriteLine(text.ToUpper());
// Console.WriteLine(text.Length);
// Console.WriteLine(text.Replace("Puzy", "Pussy"));

// Console.Write("Whzzup?: ");
// string stat = Console.ReadLine();
// Console.WriteLine($"that's it {stat}!");

// Console.Write("Hey there, how should we address you friend? -> ");
// string name = Console.ReadLine();
// Console.WriteLine($"Hello, {name.ToUpper()}! It's nice to meet you.");


// Console.Write("In the next tab please type your name: \t");
// string Name = Console.ReadLine();
// Console.WriteLine($"Hello, {Name}, It is a pleaseure making your acquinatance");

// Console.Write("Your name Sir? -> ");
// string name = Console.ReadLine();
// Console.Write("Your age Sir? -> ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Hello, {name}! You are {age} years old.");

// string name = "Swapnanil";
// int age = 20;
// bool issadult = true;
// decimal height = 5.9m;

// var name = "Swapnanil";
// var age = 20;
// var status = true;
// var height = 5.9m;

// Console.WriteLine($"Hello, {name}! You are {age} years old and your height is {height} feet. And your status is {status}.");

// var name = "Swap";
// name = true; // error will fail, cannot change the variable value once it's set.

// Console.WriteLine(34.40M);

// Console.Write("Tell us your name: \t");
// string name = Console.ReadLine();

// if (name == "")
// {
//     Console.WriteLine("You did not enter a name.");
// }
// else
// {
//     Console.WriteLine($"Hello, {name}!");
// }

// for (int i = 2; i < 7; i++)
// {
//     Console.WriteLine("");
//     Console.WriteLine(i);
//     Console.WriteLine($"Just wrote {i}");
// }

// var health = 4;

// while (health > 0)
// {
//     Console.WriteLine($"Your health is {health}");
//     health--;
// }

// if (health == 0)
// {
//     Console.WriteLine("You are dead!");
// }

// int age = 20;

// do
// {
//     Console.WriteLine($"Your age is {age}");
//     age++;

// }

// while (age < 33);


// for (int body_count = 0; body_count < 9; body_count++)
// {
//     Console.WriteLine($"You have slept with {body_count} people. for now");
//     Console.WriteLine(" ");
//     Console.WriteLine("Added 1 to the body count");

//     if (body_count / 3 == 0)
//     {
//         continue;
//     }

// }

// while (true)
// {
//     Console.WriteLine("You are a fool trying to ruin your life\n");
//     Console.WriteLine("Write exit to exit the program\t");
//     string input = Console.ReadLine();
//     if (input.ToLower() == "exit")
//     {
//         Console.WriteLine("Exiting the program...");
//         break;
//     }
// }

// Guessing game

// Console.WriteLine("Welcome to the Guessing Game!");
// int target = new Random().Next(1, 41);

// int guesses = 5;

// do
// {
// Console.WriteLine($"The random number has been generated and it devided by 2 and + or - 1 is close to {target/2}");
// Console.Write("\nTake a shot friend, guess the mystry number:\t");
// int guess = Convert.ToInt32(Console.ReadLine());
// guesses--;

// if (guess == target)
// {
//     Console.WriteLine($"You guessed it right! You are a genius!,  and you too {5 - guesses} tries to guess it right!");
//     break;
// }
// else if (guess < target)
// {
//     Console.WriteLine("Your guess is too low! Try again.");
//     Console.WriteLine($"You have {guesses - 1} guesses left.");
// }
// else
// {
//     Console.WriteLine("Your guess is too high! Try again.");
//     Console.WriteLine($"You have {guesses - 1} guesses left.");
// }
// }

// while (guesses > 0);
// if (guesses == 0)
// {
//     Console.WriteLine($"You have run out of guesses! The number was {target}. Better luck next time!");
//}

// string[] names = { "Swapnanil", "Pussy", "Pussycat", "Pussycatty" };
// int[] nums = new int[5];

// Console.Write($"names as follows: {names[0]}, {names[1]}, {names[2]}, {names[3]}");
// Console.WriteLine(" ");
// Console.WriteLine(nums[2]);

// foreach (int num in nums)
// {
//     Console.Write($"{num} ");

// }
// Console.WriteLine(" ");

// List<string> names = new List<string> {"Abigal", "Rohana", "Shailey"};
// List<int> body_count = new List<int> {3,6,2};

// foreach (string name in names)
// {
//     Console.WriteLine($"Hello, {name}!, Your body count is {body_count[names.IndexOf(name)]}");
// }

// Console.WriteLine(names.Count);
// Console.WriteLine(body_count.Count);
// names.Add("Swapnanil");
// Console.WriteLine(names.Count);

// List<int> nums = new List<int> {5,2,3,7,1};
// foreach (int score in nums)
// {
//     Console.WriteLine($"The score is {score}");
// }


// List<int> Updatable_int_list = new List<int> {};
// int[] nums = new int[5];

// for (int i = 0; i < 4; i++)
// {
//     int j = 0;
//     do
//     {
//         nums[j] = new Random().Next(1, 101);
//         j++;
//     }while (j < 5);

//     foreach (int num in nums)
//     {
//         Updatable_int_list.Add(num);
//     }
//     Updatable_int_list.Sort();
//     Updatable_int_list.Reverse();

// }

// Console.WriteLine("The top 5 scores are as follows: ");
// for (int x = 0; x < 5; x++)
// {
//     Console.WriteLine(Updatable_int_list[x]);
// }

// SUFFIXES: no suffix = int (whole) or double (decimal point)
//   m -> decimal   d -> double   f -> float
// decimal a = 7;        // OK, int converts
// decimal b = 7.5m;     // OK
// // decimal c = 7.5;   // ERROR CS0664 — needs m

// Console.WriteLine(7m / 2m);              // 3.5

// // double = base 2, can't store 0.1 exactly. decimal = base 10, can.
// Console.WriteLine(0.1 + 0.2);            // 0.30000000000000004
// Console.WriteLine(0.1 + 0.2 == 0.3);     // False
// Console.WriteLine(0.1m + 0.2m == 0.3m);  // True

// double d = 0; decimal m = 0m;
// for (int i = 0; i < 10; i++) { d += 0.1; m += 0.1m; }
// Console.WriteLine(d);                    // 0.9999999999999999
// Console.WriteLine(m);                    // 1.0
// Console.WriteLine(1m / 3m);              // 0.3333...3333 — repeating still truncates
// Console.WriteLine(1.0 / 0.0);            // Infinity (decimal throws instead)

/*            double           decimal
   precision  ~15-17 digits    28-29 digits
   range      ±1.7e308         ±7.9e28
   speed      fast (hardware)  ~10-20x slower
   == safe    no, use epsilon  yes

   decimal -> money. double -> measurement. */

// Tip calultor

// Console.Write("Enter the bill amount: ");
// decimal billAmount = Convert.ToDecimal(Console.ReadLine());
// Console.WriteLine("");
// Console.Write("Enter the tip percentage (e.g., 15 for 15%): ");
// int tipPercentage = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("");
// Console.Write($"The tip amount is {((decimal)tipPercentage / 100) * billAmount}");
// Console.WriteLine("");

// Console.Write("Choose your desired temp metric: ('Celcius' or 'Fahrenheit') ->  ");
// string temp = Console.ReadLine();
// if (temp.ToLower() == "celcius"){
//     Console.Write("State in Celcius:");
//     decimal celcius = Convert.ToDecimal(Console.ReadLine());
//     decimal fahrenheit = (celcius * 9 / 5) + 32;
//     Console.WriteLine($"The temperature in Fahrenheit is {fahrenheit}°F");

// }
// else if (temp.ToLower() == "fahrenheit"){
//     Console.Write("State in Fahrenheit:");
//     decimal fahren = Convert.ToDecimal(Console.ReadLine());
//     decimal celci = (fahren - 32) * 5 / 9;
//     Console.WriteLine($"The temperature in Celcius is {celci}°C");
// }
// else{
//     Console.WriteLine("Invalid input. Please enter 'Celcius' or 'Fahrenheit'.");
// }

// Console.Write("Windows" + 1 + 1);
// Console.WriteLine();

// int age = 25;
// bool hasTicket = true;

// if (age >= 18 && hasTicket)
// {
//     Console.WriteLine("You are allowed to enter the concert.");
// }
// else
// {
//     Console.WriteLine("You are not allowed to enter the concert.");
// }

// string sex = "Female";

// if (sex.ToLower() == "female" || sex.ToLower() == "male" || sex.ToLower() == "other")
// {
//     Console.WriteLine($"You are a {sex}.");
// }
// else
// {
//     Console.WriteLine("Invalid input. Please enter 'Female', 'Male', or 'Other'.");
// }

// subscription rule

// Console.Write("Enter your subscription type (Basic, Premium, or VIP): ");
// string subscriptionType = Console.ReadLine();
// Console.WriteLine("");
// Console.Write("How long have you been subscribed? (in months): ");
// int subscriptionDuration = Convert.ToInt32(Console.ReadLine());
// if (subscriptionType.ToLower() == "basic" && subscriptionDuration >= 6)
// {
//     Console.WriteLine("Package Over.");
//     Console.WriteLine("You have been subscribed for a long time. Consider renewing your subscription.");
// }
// else if (subscriptionType.ToLower() == "premium" && subscriptionDuration >= 8)
// {
//     Console.WriteLine("Package Over.");
//     Console.WriteLine("You have been subscribed for a long time. Consider renewing your subscription.");
// }
// else if (subscriptionType.ToLower() == "vip" && subscriptionDuration >= 12)
// {
//     Console.WriteLine("Package Over.");
//     Console.WriteLine("You have been subscribed for a long time. Consider renewing your subscription.");
// }
// else
// {
//     Console.WriteLine("Invalid inputs.");
// }

// Console.Write("Enter your favourite number: (between 1 and 4)");
// int favouriteNumber = Convert.ToInt32(Console.ReadLine());
// switch(favouriteNumber)
// {
//     case 1 :
//         Console.WriteLine("Your favourite number is 1.");
//         break;
//     case 2 :
//         Console.WriteLine("Your favourite number is 2.");
//         break;
//     case 3 :
//         Console.WriteLine("Your favourite number is 3.");
//         break;
//     case 4 :
//         Console.WriteLine("Your favourite number is 4.");
//         break;
// }

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:

//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// string name = "Swap-na-nil";
// string[] splitname = name.Split('-');

// foreach (string part in splitname)
// {
//     Console.WriteLine(part);
// }

// string one = splitname[0];
// string two = splitname[1];
// string three = splitname[2];
// string first = "";
// string second = "";
// string third = "";

// switch(one)
// {
//     case "Swap":
//         first = "None";
//         break;
// }


// switch(two)
// {
//     case "na":
//         second = "None";
//         break;
// }

// switch(three)
// {
//     case "nil":
//         third = "None";
//         break;
// }


// Console.WriteLine($"\n The ones are {first} {second} {third}, there shoudl ahve been three");

// Console.Write("Pick a number between 1 and 4:\t");
// int number = Convert.ToInt32(Console.ReadLine());

// switch(number)
// {
//     case 1:
//     case 2:
//      number = 9;
//      break;

//     case 3:
//     break;

//     default:
//     number = 999;
//     break;
// }

// Console.WriteLine($"Okay so the number you are given is this: {number}");

// void greet(string name, int age)
// {
//    Console.Write($"Hey {name}, what is your height? :\t");
//    double height = Convert.ToDouble(Console.ReadLine());
//    Console.WriteLine();

//    bool answered = true;

//    while (age < 18 && answered) {
//       switch(height)
//       {
//          case >100:
//             Console.WriteLine($" Wow, {name}, {height} is a pretty good height at such an young age");
//             break;
//          case <100:
//             Console.WriteLine($"Hey {name}, you are {age}, still you are {height} tall, you are a midget");
//             break;


//       }
//       answered = false;
//       Console.WriteLine("");

//    }
//    Console.WriteLine($"Your details name,age,height as follows: {name} -> {age} -> {height}");
// }  


// greet("Swapnanil", 12);

// int Add(int a, int b)
// {
//    return (a+b);
// }

// Console.WriteLine($"The summation of 1 and 2 are {Add(1,2)}");

// (double x, double y) GetCoordinates()
// {
//     return (10.0, 20.0);
// }

// var (x, y) = GetCoordinates();
// Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 10, y: 20

// (string name, int age) GetDetails()
// {
//    return ("Swapnanil", 29);
// }

// var(a,b) = GetDetails();
// Console.WriteLine($"Name and age are as follows: {a} --> {b}");


// The code Block Below is Wrong -->

// using System.ComponentModel.DataAnnotations;

// void Swap(int[] arr, int a, int b)
// {
//  (arr[a], arr[b]) = (arr[b], arr[a]);  
// }

// int QuickSort(int[] arr, int low, int high)
// {
//    var kingpin = arr.Length - 1;
//    var i = low - 1;
//    var j = 0;
//    while (j < kingpin)
//    {
//       if (arr[j] < arr[kingpin])
//       {
//          Swap(arr, i, j);
//          j++;
//       }
//       j++;
//    }
//    Swap(arr,i+1,kingpin);
//    return (i+1);
// }

// int [] random_arr = [6,5,4,3,2,1];
// Console.WriteLine($"\n the Sorted array is: {QuickSort(random_arr,0,random_arr.Length)}")

// if (true)
// {
//     int message = 42;
//     Console.WriteLine(message); // OK: message exists in this block
// }

// Console.WriteLine(message); // Compile error: message doesn't exist here



// namespace MathsBasic
// {
//    class Calculator
//    {
//       public static int Add(int a, int b)
//       {
//          return (a+b);
//       }
//       public static int Multiply(int a, int b)
//       {
//          return(a*b);
//       }
//       public static int Substract(int a, int b)
//       {
//          return (a - b);
//       }
//       public static double Divide(double a, double b )
//       {
//          return (a/b);
//       }
//    }
// }

// namespace Greeting
// {
//    class Greet
//    {
//       public static string profession(string name, string profession)
//       {
//          return ($"Hey, {name} your profession is {profession}") ;
//       }

//       public static string food(string name, string food)
//       {
//          return ($"Yo, {name}, didn't know {food} was your favourite appetizer");
//       }


//    }
// };

// namespace Resturant
// {
//    class Ordering
//    {
//       public static double Order_details(int number, double price)
//       {
//          return (number * price);
//       }

//       public static double Tipping(double bill, double tip_percentage)
// {
//    return (bill * tip_percentage / 100);
// }

//    }
// }

// for (int i = 0; i < 7; i++)
// {
//    Console.Write($"{i} -> ");
// }

// for (int i = 2; i < 14; i+= 2)
// {
//    Console.WriteLine($"The number is {i}");
//    if (i == 8) break;
// }


// string [] names = {"Swapnanil","Priya","Cathleene"};
// foreach (string name in names)
// {
//    if (name.Length > 6)
//    {
//       continue;
//    }
//    Console.WriteLine($"The name is : {name}");

//    if (name == "Swapnanil")
//    {
//       // name = "Swap"; cannnot do this since it's a foreach variable
//    }
// }

// string [] hobbies = {"Football", "Lawn Tennis", "Guitar"};

// for (int i = 0; i < hobbies.Length; i++)
// {
//    if (hobbies[i].ToLower() == "football")
//    {
//       hobbies[i] = "One man, Three Woman";
//    }
// }



// foreach (string hobb in hobbies)
// {
//    Console.WriteLine(hobb);
// }

for (int i = 1; i < 101; i ++)
{
   if (i%3 == 0 && i%5 == 0) {
      Console.WriteLine($"{i} - FizzBuzz");
      }

   else if (i%3 == 0)
   {
      Console.WriteLine($"{i} - Fizz");
   }
   else if (i%5 == 0)
   {
      Console.WriteLine($"{i} - Buzz");
   }
   else {Console.WriteLine(i);
   }
}