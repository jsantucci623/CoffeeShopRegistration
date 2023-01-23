// Basic Loops Lab 
// Jeff Santucci
bool question = false;
do
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string decision = Console.ReadLine();

    if (decision == "y")
        question = true;

    else
        question = false;
}
while (question);

Console.WriteLine("Goodbye!");

bool question2 = false;
do
{

    int num;
    Console.WriteLine("Enter a number");
    string cnum = Console.ReadLine();
    num = int.Parse(cnum);
    for (int i = num; i >= 0; i--)
        Console.WriteLine(i);

    for (int j = 0; j <= num; j++)
        Console.WriteLine(j);

    Console.WriteLine("Would you like to continue (y/n)?");
    string decision2 = Console.ReadLine();

    if (decision2 == "y")
        question2 = true;

    else
        question2 = false;

}
while (question2);
Console.WriteLine("Goodbye!");

