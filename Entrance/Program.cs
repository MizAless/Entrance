using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество этажей:");
        int floors = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите количество подъездов:");
        int entrances = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Введите номер квартиры:");
        int apartmentNumber = int.Parse(Console.ReadLine()!);

        int apartmentsPerFloor = 4;
        int apartmentsPerEntrance = apartmentsPerFloor * floors;

        int entranceNumber = apartmentNumber / apartmentsPerEntrance + 1;
        int floorNumber = apartmentNumber % apartmentsPerEntrance / apartmentsPerFloor + 1;
        int positionOnLanding = apartmentNumber % apartmentsPerFloor;

        if (apartmentNumber <= entrances * floors * apartmentsPerFloor)
        {
            Console.WriteLine($"Квартира №{apartmentNumber} находится в подъезде №{entranceNumber}, на {floorNumber} этаже, положение на лестничной площадке: {GetPositionName(positionOnLanding)}");
        }
        else
        {
            Console.WriteLine("Квартиры с таким номером нет в доме");
        }
    }

    static string GetPositionName(int position)
    {
        switch (position)
        {
            case 1:
                return "ближняя слева";
            case 2:
                return "дальняя слева";
            case 3:
                return "дальняя справа";
            case 4:
                return "ближняя справа";
            default:
                return "";
        }
    }
}