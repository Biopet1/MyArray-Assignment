
// Q1:      Creating a 4 dimensional Array

int[,,,] my4DArray = new int[2, 3, 5, 4]
{   {
        { {1,2,3,4 },{2,4,5,6 },{6,7,8,9 },{1,4,5,7 },{1,6,7,8 } },
        { {1,5,6,7 },{5,7,8,9 },{ 1,2,5,7},{1,3,4,5 },{1,4,5,6 } },
        { {1,2,3,4 },{ 2,4,5,6 },{6,7,8,9 },{1,4,5,7 },{1,6,7,8 } }
    },
    {
        { { 1,2,3,4 },{ 2,4,5,6 },{ 6,7,8,9 },{ 1,4,5,7 },{ 1,6,7,8 } },
        { { 1,5,6,7 },{ 5,7,8,9 },{ 1,2,5,7},{ 1,3,4,5 },{ 1,4,5,6 } },
        { { 1,2,3,4 },{ 2,4,5,6 },{ 6,7,8,9 },{ 1,4,5,7 },{ 1,6,7,8 } }
    }
};


// Q2:      Creating two 3x3 matrixA and MatrixB.
int num;
Console.WriteLine("The matrices you are about to created is for only 3x3 matrices");
int[,] matrixA = new int[3, 3];
int[,] matrixB = new int[3, 3];
int[,] matrixAddition = new int[3, 3];
int det = 0;
Console.WriteLine("Enter the element of matrixA of the matrices");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        try
        {
            Console.Write("matrixA[{0},{1}]:", i, j);
            matrixA[i, j] = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("you enter an alphabet instead of an integer");
        }

    }
}
Console.WriteLine("Enter the element of matrixB of the matrices");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write("matrixB[{0},{1}]:", i, j);
        matrixB[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Please select the operation yuo want to perform");
Console.WriteLine("Addition: 1");
Console.WriteLine("Subtraction: 2");
Console.WriteLine("Multiplication: 3");
Console.WriteLine("Enter any of the above number");
int myChoiceofOperation = int.Parse(Console.ReadLine());
switch (myChoiceofOperation)
{
    case 1:
        Console.WriteLine("The result is");
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                matrixAddition[i, j] = matrixA[i, j] + matrixB[i, j];

            }
        for (int i = 0; i < matrixAddition.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAddition.GetLength(1); j++)
            {
                Console.Write(" " + matrixAddition[i, j]);
            }
            Console.WriteLine("\n");

        }
        break;
    case 2:
        // Console.WriteLine("The result ");
        for (int i = 0; i < matrixA.GetLength(0); i++)
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixAddition[i, j] = matrixA[i, j] - matrixB[i, j];

            }
        for (int i = 0; i < matrixAddition.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAddition.GetLength(1); j++)
            {
                Console.Write(" " + matrixAddition[i, j]);
            }
            Console.WriteLine("\n");
        }
        break;
    case 3:
        for (int i = 0; i < matrixA.GetLength(0); i++)
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixAddition[i, j] = matrixA[i, j] * matrixB[i, j];

            }
        for (int i = 0; i < matrixAddition.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAddition.GetLength(1); j++)
            {
                Console.Write(" " + matrixAddition[i, j]);
            }
            Console.WriteLine("\n");
        }
        break;
    default:
        Console.WriteLine("You entered the wrong Number");
        break;

}



// Solution to Chapter 7 Exercises

//Exercise 1

int[] myArray = new int[20];
for (int i = 0; i < 20; i++)
{
    myArray[i] = i * 5;
}

foreach (int myarray in myArray)
{
    Console.WriteLine(myarray);
}


// Exercise 2
Console.Write(" Please enter a positive integer for the number of element for the first array:");
int x = int.Parse(Console.ReadLine());
Console.Write(" Please enter a positive integer for the number of element for the second array:");
int y = int.Parse(Console.ReadLine());
int[] myFirstArray = new int[x];
int[] mySecondArray = new int[y];
bool isArrayEqual = false;

if (x == y)
{
    Console.WriteLine(" Enter the {0} elements of the first array:", x);
    for (int z = 0; z < x; z++)
    {
        myFirstArray[z] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine(" Enter the {0} elememts of the second array:", y);
    for (int m = 0; m < y; m++)
    {
        mySecondArray[m] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < mySecondArray.Length; i++)
    {
        isArrayEqual = true;
        if (myFirstArray[i] != mySecondArray[i])
        {
            isArrayEqual = false;
        }
        else
        {
            isArrayEqual = true;
        }

    }
    if (isArrayEqual)
    {
        Console.WriteLine("The array are equal");
    }
    else
    {
        Console.WriteLine("The array are not thesame");
    }
}
else
{
    Console.WriteLine("for you to compare if to array are equal you must enter thesame number of element for the arrays");
}


//Exercise 3
//Similar to above question 2

Console.Write(" Please enter a positive integer for the number of element for the first array of character:");
int a = int.Parse(Console.ReadLine());
Console.Write(" Please enter a positive integer for the number of element for the second array of character:");
int b = int.Parse(Console.ReadLine());
char[] myFirstCharArray = new char[a];
char[] mySecondCharArray = new char[b];

bool isCharacterArrayEqual = false;

if (a == b)
{
    Console.WriteLine(" Enter the {0} elements of the first array:", a);
    for (int w = 0; w < a; w++)
    {
        myFirstArray[w] = char.Parse(Console.ReadLine());
    }
    Console.WriteLine(" Enter the {0} elememts of the second array:", b);
    for (int m = 0; m < b; m++)
    {
        mySecondArray[m] = char.Parse(Console.ReadLine());
    }
    for (int i = 0; i < mySecondArray.Length; i++)
    {
        isCharacterArrayEqual = true;
        if (myFirstCharArray[i] != mySecondCharArray[i])
        {
            isCharacterArrayEqual = false;
        }
        else
        {
            isCharacterArrayEqual = true;
        }

    }
    if (isCharacterArrayEqual)
    {
        Console.WriteLine("The array are equal");
    }
    else
    {
        Console.WriteLine("The array are not thesame");
    }
}
else
{
    Console.WriteLine("for you to compare if to array are equal you must enter thesame number of element for the arrays");
}

// Exercise 4
Console.WriteLine("Enter number of the array elements:");
int n = int.Parse(Console.ReadLine());





//Exercise 8 Selection Sort algorithm

Console.WriteLine("Enter the number of element you want to sort");
int Num = int.Parse(Console.ReadLine());
int[] mySortingArray = new int[Num];
Console.WriteLine("Enter {0} element", Num);
for (int i = 0; i < mySortingArray.Length; i++)
{

    mySortingArray[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < mySortingArray.Length - 1; i++)
{
    int minValue = i;
    for (int j = i + 1; j < mySortingArray.Length; j++)
    {
        if (mySortingArray[j] < mySortingArray[minValue])
        {
            minValue = j;
        }
    }
    int newVaraible = mySortingArray[i];
    mySortingArray[i] = mySortingArray[minValue];
    mySortingArray[minValue] = newVaraible;
}
Console.WriteLine("The sorting is show below");
foreach (int MySortingArray in mySortingArray)
{
    Console.WriteLine(MySortingArray);
}








// 1, 1, 2, 3, 2, 2, 2, 1

int[] myMaxArray = { 1, 1, 2, 3, 2, 2, 2, 1 };
for (int i = 0; i < myMaxArray.Length - 1; i++)
{
    for (int j = 0; j < myMaxArray.Length - 1; j++)
    {
        if (myMaxArray[j] != myMaxArray[j + 1])
        {
            break;
            myMaxArray[j + 1] = myMaxArray[j];
        }
        else
        {

            break;

        }
    }
}
Console.WriteLine(" The sorted numbers :");
foreach (int myMaxArrays in myMaxArray)
{
    Console.WriteLine(myMaxArrays);
}


//Exercise 19;
Console.WriteLine("Prime number between 1 t0 10000000");
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

