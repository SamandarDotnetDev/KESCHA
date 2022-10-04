using KESCHA.Classes;
// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Salom,Yangi foydalanuvchi!");
// string password = "";
// do
// {
//   System.Console.Write("Enter you're password :");
//   password = Console.ReadLine();
// } while (password != "s@m@4dar");

// Console.Write("Iltimos,buyerga ismingni kirit : ");
// string username = Console.ReadLine();
// Console.WriteLine("Qoyilmaqom ,endi biz seni ismingn bilamiz ...");
// // Console.WriteLine(username);

// string greeting = "Salom ,\"Samandar\"";

// Console.WriteLine(greeting);

// // short, int, long
// //syntax 
// short studentsCount = 30;
// int populationCount = 40_000;
// long worldPopulation = 7_000_000_000;
// // size 
// Console.WriteLine(sizeof(short));
// Console.WriteLine(sizeof(int));
// Console.WriteLine(sizeof(long));
// //range
// Console.WriteLine(short.MinValue);
// Console.WriteLine(short.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(long.MinValue);
// Console.WriteLine(long.MaxValue);

// decimal height = 0.3m;
// decimal lenght = 1.1m;
// decimal sum = 1.4m;

// System.Console.WriteLine(height + lenght == sum);

// bool isBoy = true;
// bool isGirl = false;

// System.Console.WriteLine(isBoy);


Console.Write("Enter your name: ");
string name = Console.ReadLine();
// string greeting = $"Hello,{name}";
// Console.WriteLine(greeting);

Console.Write("Enter your age: ");
int myAge = Convert.ToInt32(Console.ReadLine());
int keschaAgeAs = 4;

Animal kescha = new Animal();
Car Bmw = new Car();

// if (myAge < keschaAgeAs)
// {
//   System.Console.WriteLine("You are youngen");
// }
// else if (myAge == keschaAgeAs)
// {
//   System.Console.WriteLine("You are equal");
// }
// else
// {
//   System.Console.WriteLine("You are older");
// }


// Console.WriteLine($"Yosh o'rtasidagi farq! {myAge - keschaAgeAs}");
// Console.WriteLine($"You are older then KESCHA! {myAge > keschaAgeAs}");
// Console.WriteLine($"You are youngen then KESCHA! {myAge < keschaAgeAs}");
// Console.WriteLine($"You are equal then KESCHA! {myAge == keschaAgeAs}");
// Console.WriteLine($"You are older then or equal to KESCHA! {myAge >= keschaAgeAs}");

//Ternary operator
// string massage = myAge >= keschaAgeAs
//    ? "You are older or equal"
//    : "You are youngen";
// System.Console.WriteLine(massage);

//logical operator
string agePosition = (myAge > 0 && keschaAgeAs > 0)
  ? "You're and KESCHA age is positive"
  : "You're and KESCHA age is negative";
System.Console.WriteLine(agePosition);

string ageDifferense = (myAge > 0 || keschaAgeAs > 0)
  ? "You're or KESCHA age is positive"
  : "You're or KESCHA age is negative";

System.Console.WriteLine(ageDifferense);

string ageKescha = !(keschaAgeAs > 0)
  ? "KESCHA age is not positive"
  : "KESCHA age is not negative";
System.Console.WriteLine(ageKescha);





// System.Console.WriteLine(sizeof(char));
// char smallA = '&';
// char capitalA = '$';

// System.Console.WriteLine((int)smallA);
// System.Console.WriteLine((int)capitalA);

System.Console.WriteLine("Let me tell you about my friends");
string[] friendsName = new string[3];
friendsName[0] = "Vasya";
friendsName[1] = "Katya";
friendsName[2] = name;



int[] friendsAge = { 12, 15, myAge };
string[] address = { "Moskow", "Tashkent", "Samarkand" };
System.Console.WriteLine($"{friendsName[0]} is {friendsAge[0]} year old and location {address[0]}");
System.Console.WriteLine($"{friendsName[1]} is {friendsAge[1]} year old and location {address[1]}");
System.Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} year old and location {address[2]}");


