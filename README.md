# Наследование

Задача. Задан класс Building, который описывает здание. Класс содержит следующие элементы:

— адрес здания;

— длина здания;

— ширина здания;

— высота здания.

В классе Building нужно реализовать следующие методы:

— конструктор с 4 параметрами;

— свойства get/set для доступа к полям класса;

— метод Print(), который выводит информацию о здании.

Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

— конструктор с 5 параметрами – реализует вызов конструктора базового класса;

— свойство get/set доступа к внутреннему полю класса;

— метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.

Класс MultiBuilding сделать таким, что не может быть унаследован.

Решение.

> Building.cs
```
using System;

namespace Task_1
{
    public class Building
    {
        private string buildingAddress;
        private int buildingLength;
        private int buildingWidth;
        private int buildingHeight;

        public string BuildingAddress
        {
            get
            {
                return buildingAddress;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Адрес не может быть пустым или состоять только из пробелов.");
                }

                buildingAddress = value;
            }
        }

        public int BuildingLength
        {
            get
            {
                return buildingLength;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Длина здания должна быть положительным числом.");
                }

                buildingLength = value;
            }
        }

        public int BuildingWidth
        {
            get
            {
                return buildingWidth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ширина здания должна быть положительным числом.");
                }

                buildingWidth = value;
            }
        }

        public int BuildingHeight
        {
            get
            {
                return buildingHeight;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Высота здания должна быть положительным числом.");
                }

                buildingHeight = value;
            }
        }

        public Building(string buildingAddress, int buildingLength, int buildingWidth, int buildingHeight)
        {
            BuildingAddress = buildingAddress;
            BuildingLength = buildingLength;
            BuildingWidth = buildingWidth;
            BuildingHeight = buildingHeight;
        }

        public virtual string Print()
        {
            return $"Адрес здания - {buildingAddress}; \n Длина здания - {buildingLength}; \n Ширина здания - {buildingWidth}; \n Высота здания - {buildingHeight}; \n";
        }
    }
}
```
___

> MultiBuilding.cs
```
using System;

namespace Task_1
{
    public sealed class MultiBuilding : Building
    {
        private int numberStoreysBuilding;

        public int NumberStoreysBuilding
        {
            get
            {
                return numberStoreysBuilding;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество этажей не может быть меньше нуля.");
                }

                numberStoreysBuilding = value;
            }
        }

        public MultiBuilding(string buildingAddress, int buildingLength, int buildingWidth, int buildingHeight, int numberStoreysBuilding)
            : base(buildingAddress, buildingLength, buildingWidth, buildingHeight)
        {
            NumberStoreysBuilding = numberStoreysBuilding;
        }

        public override string Print()
        {
            return base.Print() + $" Этажность здания: {numberStoreysBuilding};";
        }
    }
}
```
___

> Program.cs
```
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
        }
    }
}
```
___
