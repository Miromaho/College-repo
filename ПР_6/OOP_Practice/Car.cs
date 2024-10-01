using System;

namespace OOP_Practice
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double FuelLevel { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public class Fuellevel
        {
            public double CurrentLevel { get; set; }
            public double Capacity { get; set; }
            public Fuellevel(double capacity)
            {
                Capacity = capacity;
                CurrentLevel = 0;
            }
            public void Refuel(double liters)
            {
                if(liters < 0)
                {
                    throw new ArgumentException("The quantity of fuel cannot be negative.");
                }
                if(liters == 0)
                {
                    return;
                }
                if(CurrentLevel + liters > Capacity)
                {
                    CurrentLevel = Capacity;
                    Console.WriteLine("The tank is filled to the maximum");
                }
                else
                {
                    CurrentLevel += liters;
                    Console.WriteLine($"Added {liters} liters. Current fuel level:{CurrentLevel} liters.");
                }
                Refuel(liters);
            }
        }
        // Конструктор класса
        public Car(string brand, string model, int year, double mileage, double Fuellevel)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
            FuelLevel = Fuellevel;
        }
        public void Refuel(double liters)
        {
            
        }
        // Метод для увеличения пробега
        public void Drive(double distance)
        {
            if (FuelLevel > distance * 0.09)
            {
                FuelLevel -= distance * 0.09;
                Mileage += distance;
            }
            else 
            {
                Console.WriteLine("Not enough fuel");
            }
        }
        // Переопределение метода ToString
        public override string ToString()
        {
            return ($"Марка: {Brand}, Модель: {Model}, Год: {Year}, Пробег: {Mileage} км, Запас топлива: {FuelLevel}");
        }
    }
}
