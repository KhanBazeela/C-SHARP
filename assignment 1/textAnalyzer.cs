// ### 4: Advanced Text Analyzer
//  Write a C# program that acts as a basic text analyzer. 
//  - It should Accept user input. Allow the user to enter a string (paragraph or text).
//  - Analyze and report statistics:
//     - Count the total number of words (consider spaces as word separators).
//     - Calculate the average word length. [Hint. Average word length = Summation of all letters in each word / Total number of words]

Console.WriteLine("Enter the text here:");
string strParagraph = Console.ReadLine();

//Total number of words in a paragraph
int countWords = strParagraph.Split(' ').Length;
Console.WriteLine($"Total No of words are : {countWords}");

//Calculating average word Length
int avgWordLength = strParagraph.Replace(" ", "").Count()/countWords;
Console.WriteLine($"Average word length is : {avgWordLength}");