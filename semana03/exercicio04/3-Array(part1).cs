//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Para criar a Array 

int [] intArray = new int[6];

//Fazendo uma variavel que mantém o lenght, pois ele é baseado na capacidade e acompanha o indice real.
int length = 0;

for (int i=0; i < 3; i ++)
{
    intArray[length] = i;
    length++;
}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Para inserir no fim da Array


int [] intArray = new int[6];

//Fazendo uma variavel que mantém o lenght, pois ele é baseado na capacidade e acompanha o indice real.
int length = 0;

for (int i=0; i < 3; i ++)
{
    intArray[length] = i;
    length++;
}

int [] intArray = 9;
length++;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Para inserir no inicio da Array 

int [] intArray = new int[6];

//Fazendo uma variavel que mantém o lenght, pois ele é baseado na capacidade e acompanha o indice real.
int length = 0;

for (int i=0; i < 3; i ++)
{
    intArray[length] = i;
    length++;
}

for (int i = 3; i >= 0; i --)
{
    intArray[i + 1] = intArray[i];
}
intArray[0] = 20;

int value = 0;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Para adicionar em qualquer lugar 


int [] intArray = new int[15];

//Fazendo uma variavel que mantém o lenght, pois ele é baseado na capacidade e acompanha o indice real.
int length = 0;

for (int i = 0; i < 15; i ++)
{
    intArray[length] = i;
    length++;
}

for (int i = 4; i >= 2; i --)
{
    /// Leva os elementos para a direita
    intArray[i + 1] = intArray[i];
}

intArray[2] = 8;
int value = 0;