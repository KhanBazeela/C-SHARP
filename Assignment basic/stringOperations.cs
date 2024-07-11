// // ### 3: Text Manipulation Challenge
// // Write a C# program that modifies a given string by:
// // - Removing leading and trailing whitespace characters.
// // - Converting the entire string to uppercase or lowercase (user's choice).
// // - Extracting a specified substring based on user input (start and end indices).


// string textManupilation="   Write a C# program that modifies a given string by Removing leading and trailing whitespace characters     ";
// Console.WriteLine($"Origional String : {textManupilation}");
// Console.WriteLine("***********************\n");

// string modifiedString=textManupilation.Trim();
// Console.WriteLine($"Modified string : { modifiedString}");
// Console.WriteLine("***********************\n");

// string strUppperCase=textManupilation.ToUpper();
// Console.WriteLine($"String in Upper case: { strUppperCase}");
// Console.WriteLine("***********************\n");

// string strLowerCase=textManupilation.ToLower();
// Console.WriteLine($"String in Lower case: { strLowerCase}");
// Console.WriteLine("***********************\n");

// Console.WriteLine("Enter the start index");
// int startIndex;
// string strStartIndex=Console.ReadLine();
// int.TryParse(strStartIndex, out startIndex);

// Console.WriteLine("Enter the End index");
// int endIndex;
// string strEndIndex=Console.ReadLine();
// int.TryParse(strEndIndex, out endIndex);

// string extractSubString=textManupilation.Substring(startIndex, endIndex);
// Console.WriteLine($"The extracted substring is : {extractSubString}");