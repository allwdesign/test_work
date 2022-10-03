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
/// The method from the original array of strings will form a new array of 
/// strings whose length is less than or equal to 3 characters.
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
void FillArrayWithStrings(
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
    string resultStr = string.Empty;
    resultStr = GetStringWithArrayElements(arrayA) + " -> " +
                GetStringWithArrayElements(arrayB) + "\n";
    Console.Write(resultStr);
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
        FillArrayWithStrings(originalArray, newArray, stringLength);
    }
    PrintResult(originalArray, newArray); 
}

/// <summary>
/// The method prints test information to the console. 
/// </summary>
void ProgramCheck()
{  
    int stringLength = 3;

    string[] testArray1 = {"Hello", "2", "world", ":-)"};
    string[] testArray2 = {"1234", "1567", "-2", "computer science"};
    string[] testArray3 = {"Russia", "Denmark", "Kazan"};

    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    Test(testArray1, stringLength);   
   
    Test(testArray2, stringLength);
   
    Test(testArray3, stringLength);        
    
    Console.WriteLine("---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    int stringLength = 3;
    
    string[] originalArray = {"1567", "0", "Hello", "lk[2rkl515r", "@3@", ""};
	
    //Before using, the array must be initialized.
    //To do this, you need to know its size and it will be equal to the number
    //of strings with a length less than or equal to 3 characters of the 
    //original array.
    int newArraySize = CountStringsRequiredLength(
        originalArray,
        stringLength);
    
    string[] newArray = new string[newArraySize];
    
    if (newArraySize != 0)
    {
        FillArrayWithStrings(originalArray, newArray, stringLength);
    }
    PrintResult(originalArray, newArray);
}
catch (IndexOutOfRangeException)
{
    Console.Write("Index was outside the bounds of the array.");
}    
catch
{
    Console.WriteLine("Something went wrong");
}
