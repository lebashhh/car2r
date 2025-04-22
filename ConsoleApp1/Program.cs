using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            // 3. Задание значений свойств
            myCar.Brand = "Жигули";
            myCar.LicensePlate = "Т144ТО";
            myCar.Mileage = 10350;

            // 4. Вывод значений свойств
            Console.WriteLine("Информация об автомобиле:");
            myCar.Show();

            // 5. Расчет среднего годового пробега
            int age = 5;
            double averageAnnualMileage = (double)myCar.Mileage / age;
            Console.WriteLine($"\nСредний годовой пробег за {age} лет: {averageAnnualMileage} км/год");
            Console.ReadKey();
        }
    }
}
