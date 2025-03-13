// See https://aka.ms/new-console-template for more information


//String FullName = "Nirmalya Raja";
//String PhoneNumber = "9932218464";

//FullName = FullName.ToLower();
//Console.WriteLine(FullName);
//FullName = FullName.ToUpper();
//Console.WriteLine(FullName);

//PhoneNumber = PhoneNumber.Replace("9", "1");
//Console.WriteLine(PhoneNumber);

//String UserName = FullName.Insert(0, "Mr.");
//Console.WriteLine(UserName);
//Console.WriteLine(FullName.Length);


//If Else Condition

Console.WriteLine("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age >= 18 && age <= 65)
{
    Console.WriteLine("You can Drive..");
}
else if (age >= 12 && age <= 17)
{
    Console.WriteLine("You can Drive E-Scooter");

}
else if (age < 12)
{
    Console.WriteLine("You can only drive cycle");

}
else
{
    Console.WriteLine("You can't Drive Anything");
}
