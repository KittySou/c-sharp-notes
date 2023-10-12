// See https://aka.ms/new-console-template for more information

// --------- COMMON DATA TYPES -----------
string stringDataType = "Hello, World!";
Console.WriteLine(stringDataType);

int intDataType = 1;
Console.WriteLine(intDataType);

double doubleDataType = 239.43909;
Console.WriteLine(doubleDataType);

char charDataType = 'a';
Console.WriteLine(charDataType);
// make sure to use single quotes when using char,
// double quotes "" are for strings

bool boolDataType = true;
Console.WriteLine(boolDataType);


//  ----------- DATA CONVERSION -----------
// Implicit conversion
int myInt = 5;
double myDouble = myInt;
Console.WriteLine(myDouble);
// The opposite cannot be done (convert double to int).
// C# checks to make sure that when we convert data types 
// from one to another that we’re not losing any data, 
// because that could cause problems in our code.

//Explicit conversion
double myDoubleDouble = 4.5;
int myIntInt = (int)myDoubleDouble;
Console.WriteLine(myIntInt);

//Also possible to use built-in methods like :
string myString = "u";
Console.WriteLine(Convert.ToChar(myString));