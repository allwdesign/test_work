﻿/// <summary>
/// Method for counting the number of rows of the source array that satisfy
/// given condition (their length is less than or equal to 3 characters).
/// Needed to determine the size of the new array.
/// </summary>
int CountStringsRequiredLength(string[] array, int requiredLength)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {     
        if (array[i].Length <= requiredLength) count += 1;
    }
    return count;
}

/// <summary>
/// The method tests the program with test data sets. 
/// </summary>
/// <param name="originalArray">
/// An array of strings that is specified at the beginning of the program
/// execution.
/// </param>
/// <param name="stringLength">
/// The length of the string. Used to compare with the length of each element
/// of the original array.
/// </param>
void Test(string[] originalArray, int stringLength)
{
    int newArraySize = CountStringsRequiredLength(
        originalArray,
        stringLength);

    string[] newArray = new string[newArraySize];

    Console.WriteLine(newArraySize); 
}

/// <summary>
/// The method prints test information to the console. 
/// </summary>
void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    int stringLength = 3;

    string[] testArray1 = {"Hello", "2", "world", ":-)"};
    Test(testArray1, stringLength);   

    string[] testArray2 = {"1234", "1567", "-2", "computer science"};
    Test(testArray2, stringLength);

    string[] testArray3 = {"Russia", "Denmark", "Kazan"};
    Test(testArray3, stringLength);        
    
    Console.WriteLine("---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();