// using MathsBasic;

// using calc = MathsBasic.Calculator;

// Console.WriteLine(calc.Add(3,4));

// using Greeting;

// using greet_them = Greeting.Greet;

// Console.WriteLine(greet_them.profession("Swap","Data Something"));


// using Resturant;

// using Order_me = Resturant.Ordering;

// Console.Write("Welcome \n");
// Console.WriteLine("Here are the ordering Options along side price\n");

// Console.WriteLine("1.Juice-12.50$\n");
// Console.WriteLine("2.Eggs-3.50$\n");
// Console.WriteLine("3.Chicken-42.50$\n");

// double item_a = 12.50;
// double item_b = 3.50;
// double item_c = 42.50;

// List<double> prices = new List<double> {item_a,item_b, item_c};

// int Food_Option = 0;
// bool Ordered = false;

// while (Ordered == false)
// {
//     Console.WriteLine("Now Which one of the items would you like?\n (Please choose between 1/2/3)");
//     Food_Option = Convert.ToInt32(Console.ReadLine());

//     switch(Food_Option)
//     {
//         case 1:
//         case 2:
//         case 3:
//         Ordered = true;
//         break;

//         default:
//         Console.WriteLine("Not A valid Choice, please try again\n");
//         break;
//     }
// }

// int num_of_items = 0;
// bool Order_numbers_given = false;

// while (Order_numbers_given == false)
// {
//     Console.WriteLine("And how many of this item would you like to order? (1/2/3) -> \t");
//     num_of_items = Convert.ToInt32(Console.ReadLine());

//     switch(num_of_items)
//     {
//         case 1:
//         case 2:
//         case 3:
//         double val = Order_me.Order_details(num_of_items, prices[Food_Option-1]);
//         Console.WriteLine($"Your total price for the order is {val}$");
//         Order_numbers_given = true;
//         break;

//         default:
//         Console.WriteLine("Please Choose Between 1/2/3, thanks\n");
//         break;
//     }
// }


// StreamReader reader = new StreamReader("/Users/swapnaniru_sensei/Documents/Regular-Git-pushes/C#_Stuff/Learning_A_New_Thing/RT.txt");
// string contents = reader.ReadToEnd();
// Console.WriteLine(contents);
// reader.Close(); // Here we are manually closing it.


// using StreamReader reader = new StreamReader("/Users/swapnaniru_sensei/Documents/Regular-Git-pushes/C#_Stuff/Learning_A_New_Thing/RT.txt");
// string contents = reader.ReadToEnd();
// Console.WriteLine($"The contents are as followed: \t{contents}");
// // File is automatically closed at the end of this block


// string[] items = contents.Split(" ");
// foreach(string item in items)
// {
//     Console.Write($"{item} -> ");
// }

// using StreamReader reader = new StreamReader("/Users/swapnaniru_sensei/Documents/Regular-Git-pushes/C#_Stuff/Learning_A_New_Thing/RT.txt");
// string line;

// while ((line = reader.ReadLine()) != null)
// {
//     Console.WriteLine(line);
// }

// File.WriteAllText("/Users/swapnaniru_sensei/Documents/Regular-Git-pushes/C#_Stuff/Learning_A_New_Thing/RT.txt", "I do not like takking too much, it makes me feel too exhausted actually");

using StreamReader reader = new StreamReader("/Users/swapnaniru_sensei/Documents/Regular-Git-pushes/C#_Stuff/Learning_A_New_Thing/RT.txt");
string Line;


while((Line = reader.ReadLine()) != null) {
    Console.WriteLine(Line);
}