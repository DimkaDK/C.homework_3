Console.Clear();

string numberInput (string str)
{
    Console.Write (str);

    string number = Console.ReadLine();

    return number;
}

void examination (string x)
{
    if (x.Length != 5)
    {
        Console.WriteLine ($"Число {x} не является пятизначным");
    }
    
    else if (x[0] == x[4] && x[1] == x[3]) 
    {
        Console.WriteLine ($"Число {x} является палиндромом");
    }

    else
    {
        Console.WriteLine ($"Число {x} не является палиндромом");
    }
   
}

string number = numberInput ("Введите пятизначное число: ");

examination (number);
