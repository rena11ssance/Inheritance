using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите адрес здания: ");
                string buildingAddress = Console.ReadLine();

                Console.Write("Введите длину здания: ");
                int buildingLength = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите ширину здания: ");
                int buildingWidth = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите высоту здания: ");
                int buildingHeight = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите этажность здания: ");
                int numberStoreysBuilding = Convert.ToInt32(Console.ReadLine());

                MultiBuilding multiBuilding = new MultiBuilding(buildingAddress, buildingLength, buildingWidth, buildingHeight, numberStoreysBuilding);
                Console.WriteLine(multiBuilding.Print());
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}