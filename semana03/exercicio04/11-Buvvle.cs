int[] intArray = new int[] {6, 5, 1, 7, 2, 4};

Console.WriteLine(BubbleSort(intArray));
int[] value = BubbleSort(intArray);
int joker = 0;

int[] BubbleSort(int[] array)
{
    int temp = 0;

    for(int pointer = 0; pointer < array.Length; pointer++)
    {
        for(int sort = 0; sort < array.Length -1; sort++)
        {
            if(array[sort] > array[sort + 1])
            {
                temp = array[sort +1];
                array[sort + 1] = array[sort];
                array[sort] = temp;
            }
        }
    }
    return array;
}