/// <summary>
/// Method for counting the number of rows of the source array that satisfy
/// given condition (their length is less than or equal to 3 characters).
/// Needed to determine the size of the new array.
/// </summary>
int CountStringRequiredLength(string[] arrayA, int requiredLength)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {     
        if (arrayA[i].Length <= requiredLength) count += 1;
    }
    return count;
}

int GetNewArraySize(string[] array, int requiredLength)
{
    return CountStringRequiredLength(array, requiredLength); 
}

/// <summary>
/// The method prints test information to the console. 
/// </summary>
void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    int stringLength = 3;

    string[] testArray1 = {"Hello", "2", "world", ":-)"}; 
    
    Console.WriteLine(GetNewArraySize(testArray1, stringLength)); 

    string[] testArray2 = {"1234", "1567", "-2", "computer science"};
    Console.WriteLine(GetNewArraySize(testArray2, stringLength));

    string[] testArray3 = {"Russia", "Denmark", "Kazan"};
    Console.WriteLine(GetNewArraySize(testArray3, stringLength));    
    
    Console.WriteLine("---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();