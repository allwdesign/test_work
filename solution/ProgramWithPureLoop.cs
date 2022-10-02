/// <summary>
/// Method for counting the number of rows of the source array that satisfy
/// given condition (their length is less than or equal to 3 characters).
/// Needed to determine the size of the new array.
/// </summary>
/// <param name="array">
/// Array of strings of different lengths that is specified at the beginning 
/// of the program execution.
/// </param>
/// <param name="requiredLength">
/// The length of the string. Used to compare with the length of each element
/// of the original array.
/// </param>
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
/// Метод из имеющегося массива строк формирует новый массив из строк,
/// длина которых меньше, либо равна 3 символам.
/// </summary>
/// <param name="array">
/// Array of strings of different lengths that is specified at the beginning 
/// of the program execution.
/// </param>
/// <param name="newArray">
/// A new array of strings that satisfy the given condition, their length
/// less than or equal to three.
/// </param>
/// <param name="requiredStringLength">
/// The length of the string. Used to compare with the length of each element
/// of the original array.
/// </param>
void FillArrayFromAnotherStringArray(
    string[] array, 
    string[] newArray,
    int requiredStringLength)
{
    int k = 0; 
    for (int i = 0; i < array.Length; i++)
    {     
        if (array[i].Length <= requiredStringLength)
        {
            newArray[k] = array[i];
            k += 1;
        }
    }
}

string GetStringWithArrayElements(string[] array)
{
    //Formatted output of array elements
    string stringWithArrayElements = string.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {     
        if (i!= array.Length-1) stringWithArrayElements += $"\"{array[i]}\", ";
        else stringWithArrayElements += $"\"{array[i]}\"";
    }
    return $"[{stringWithArrayElements}]";
}

void PrintResult(string[] arrayA, string[] arrayB)
{
    //Formatted result output
    Console.Write(
        GetStringWithArrayElements(arrayA) +
        " -> " +
        GetStringWithArrayElements(arrayB) +
        "\n");
    Console.WriteLine();
}

/// <summary>
/// The method tests the program with test data sets. 
/// </summary>
/// <param name="originalArray">
/// Array of strings of different lengths that is specified at the beginning 
/// of the program execution.
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

    if (newArraySize != 0)
    {
        FillArrayFromAnotherStringArray(originalArray, newArray, stringLength);
    }
    PrintResult(originalArray, newArray); 
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