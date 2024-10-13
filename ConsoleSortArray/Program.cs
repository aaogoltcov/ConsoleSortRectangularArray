int[,] numbers = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

int[,] SortRectangularArray(int[,] numbersArray)
{
    var mutableArray = numbersArray;
    var interimArray = new int[numbersArray.GetLength(0) * numbersArray.GetLength(1)];

    for (int row = 0; row < numbersArray.GetLength(0); row++)
    {
        for (int column = 0; column < numbersArray.GetLength(1); column++)
        {
            interimArray[row * numbersArray.GetLength(0) + column] = numbersArray[row, column];
        }
    }

    Array.Sort(interimArray);

    for (int row = 0; row < numbersArray.GetLength(0); row++)
    {
        for (int column = 0; column < numbersArray.GetLength(1); column++)
        {
            mutableArray[row, column] = interimArray[row * numbersArray.GetLength(0) + column];
        }
    }

    return mutableArray;
}

var sortedArray = SortRectangularArray(numbers);

for (int row = 0; row < sortedArray.GetLength(0); row++)
{
    for (int column = 0; column < sortedArray.GetLength(1); column++)
    {
        Console.WriteLine(sortedArray[row, column]);
    }
}
