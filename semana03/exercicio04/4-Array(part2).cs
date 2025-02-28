/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Deletando algo da Array

int[] intArray = new int[9];

int lenght = 0;

for(int i=0; i < 6; i++)
{
    intArray[lenght] = i;
    lenght++;
}
lenght--;

for(int i = 0; i < lenght; i++)
{
    Console.WriteLine(intArray[i]);
}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Deletando do inicio 

int[] intArray = new int[9];

int lenght = 0;

for(int i=0; i < 6; i++)
{
    intArray[lenght] = i;
    lenght++;
}

for(int i = 1; i < lenght; i++)
{
    intArray[i - 1] = intArray[i];
}

lenght--;

for(int i = 0; i < lenght; i++)
{
    Console.WriteLine(intArray[i]);
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Deletando em qualquer lugar

int[] intArray = new int[9];

int lenght = 0;

for(int i=0; i < 6; i++)
{
    intArray[lenght] = i;
    lenght++;
}

for(int i = 2; i < lenght; i++)
{
    intArray[i - 1] = intArray[i;] 
}

lenght--;

for(int i = 0; i < lenght; i++)
{
    Console.WriteLine(intArray[i]);
}
