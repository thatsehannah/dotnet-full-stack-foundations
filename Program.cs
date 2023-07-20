// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Let's Learn C# Programming");

// Variable assignment
string name = "Elliot Hannah";
int age = 23;
float discount = 1000.50f;
double contactNumber = 12312.12;
char gender = 'M';
bool isValid = false;

Console.WriteLine("Name : " + name);
Console.WriteLine("Age : " + age);
Console.WriteLine("Discount : " + discount);
Console.WriteLine("Contact Number : " + contactNumber);
Console.WriteLine("Gender : " + gender);
Console.WriteLine("isValid : " + isValid);

//Arithmetic Operators
float baseSalary = 5000;
float hra = 0.30f;
float netSalary = (baseSalary - (baseSalary * hra));
Console.WriteLine("Base Salary : " + baseSalary);
Console.WriteLine("Net Salary : " + netSalary);

//Relational Operators
int temperature = 50;
if (temperature < 20) {
  Console.WriteLine("It's very cold outside");
} else {
  Console.WriteLine("It's moderate outside");
}

//Logical Operators
bool isLoggedIn = true;
bool isEmailVerified = true;
bool cardInfo = false;
if (isLoggedIn && isEmailVerified && cardInfo) {
  Console.WriteLine("Allowed to make a purchase");
} else {
  Console.WriteLine("Stop Purchase");
}

//Ternary Operator
bool isAuthenticated = false;
string result = isAuthenticated ? "You are logged in" : "You are not logged in";
Console.WriteLine(result);

//Conditional Statements
int gas = 4;
if (gas < 2) {
  Console.WriteLine("You need to go get some gas before we hit the road.");
} else if (gas >= 2 && gas <= 8) {
  Console.WriteLine("You may need to get some gas soon.");
} else {
  Console.WriteLine("You are good on gas. Let's hit the road");
}

int torborgee = 12;
if (torborgee < 2) {
  Console.WriteLine("Ask mom for more torborgee");
}else {
  Console.WriteLine("You're good greedy gut");
}

//Switch Statement
string userType = "admin";
switch (userType) {
  case "admin":
    Console.WriteLine("You have full access.");
    break;
  case "subadmin":
    Console.WriteLine("You can create or delete courses.");
    break;
  case "user":
    Console.WriteLine("You can access the courses.");
    break;
  default:
    Console.WriteLine("Trial User");
    break;
}

Console.WriteLine("");

//Do-while Loop
int i = 100;
do {
  Console.WriteLine(i);
  i++;
} while (i < 6);

Console.WriteLine("");

//Foreach Loop
string[] cars = { "Tesla", "Toyota", "Nissan", "Lambo"};
foreach (string car in cars) {
  Console.WriteLine(car);
}

Console.WriteLine("");

//For Loop
string[] names = new string[] { "Elliot III", "Wilma", "Ezra", "Sanji", "Cristal", "Elliot Jr", "Boe", "Mama Felicia"};
for (int j = 0; j < names.Length; j++) {
  Console.WriteLine(names[j]);
}

Console.WriteLine("");

for (int j = 4; j >= 0; j--) {
  Console.WriteLine(names[j]);
}

Console.WriteLine("");

//While loop
int k = 0;
while (k < 10) {
  Console.WriteLine(k);
  k++;
}

Console.WriteLine("");

//Jump statements - break
for (int m = 0; m < 20; m++) {
  if (m == 12) {
    break;
  }
  Console.WriteLine(m);
}

Console.WriteLine("");

//Jump statements - continue
for (int m = 0; m < 20; m++) {
  if (m % 2 == 1) {
    continue;
  }
  Console.WriteLine(m);
}

Console.WriteLine("");

//Jump statements - goto
switch (userType) {
  case "admin":
    Console.WriteLine("You have full access.");
    goto case "user";
  case "subadmin":
    Console.WriteLine("You can create or delete courses.");
    break;
  case "user":
    Console.WriteLine("You can access the courses.");
    break;
  default:
    Console.WriteLine("Trial User");
    break;
}



