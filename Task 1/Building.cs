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