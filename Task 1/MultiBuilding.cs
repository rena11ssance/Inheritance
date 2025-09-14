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