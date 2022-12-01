Console.Clear();

int numberInput (string str)
{
    Console.Write (str);

    int number = int.Parse(Console.ReadLine());

    return number;
}

void findCube (int x)
{
    if (x <= 1)
    {
        Console.WriteLine ($"Число {x} задано не верно");
    }
    
    else
    {
        int index = 1;

        while (index <= x)
        {
           Console.Write (Math.Pow(index, 3)); 

            if (index < x) Console.Write (", ");

            index++;
        }
    }
}

int number = numberInput ("Введите число, больше еденицы: ");

findCube (number);
