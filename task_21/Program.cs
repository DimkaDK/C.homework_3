Console.Clear();

int coordinatesInput (string str)
{
    Console.Write (str);

    int coordinate = int.Parse(Console.ReadLine());

    return coordinate;
}

void findLength (int x1, int y1, int z1, int x2, int y2, int z2)
{
   double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

   Console.Write ($"Растояние между точками: {length}");   
}

int x1 = coordinatesInput ("Введите координату Х1: ");

int y1 = coordinatesInput ("Введите координату Y1: ");

int z1 = coordinatesInput ("Введите координату Z1: ");

int x2 = coordinatesInput ("Введите координату Х2: ");

int y2 = coordinatesInput ("Введите координату Y2: ");

int z2 = coordinatesInput ("Введите координату Z2: ");

findLength (x1, y1, z1, x2, y2, z2);