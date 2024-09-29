//Task 1 ---------------------------

//Console.WriteLine("Hello World!");

//Task 2 ---------------------------

/*
string name = "Bob";
int number = 3;
float floatNumber = 34.4f;

Console.Write("Hello " + name + "! You have " +  number + " messages in your inbox. The temperature is " + floatNumber + " celsius.");
*/

// string interpolination example

/*
string firstName = "Bob";
string lastName = "Bobson";
Console.WriteLine($"{firstName} {lastName}");
*/

// interpolation + varbatim literal

/*
string projectName = "My-first-project";
Console.WriteLine($@"c:\{projectName}");
*/

// Task 3 ---------------------------

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output: 
   c:\Excersise\{projectName}\data.txt");
Console.WriteLine($@"{russianMessage} 
   c:\Excersise\{projectName}\ru-RU\data.txt");