namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Car
            Car myCar = new Car("Toyota", "Corolla", 2006, 50000, 60);
            // Вывод информации о машине
            Console.WriteLine(myCar);
            // Поездка на 120 км
            myCar.Drive(120);
            // Вывод обновленной информации о машине
            Console.WriteLine(myCar);
            Console.WriteLine("Please enter the number of liters of refuel:");
            if (double.TryParse(Console.ReadLine(), out double liters))
            {
                try
                {
                    myCar.Refuel(liters);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}