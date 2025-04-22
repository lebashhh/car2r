using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        private string mark;
        private string number;
        private int mileage;

        // Свойства для работы с полями
        public string Brand
        {
            get { return mark; }
            set { mark = value; }
        }

        public string LicensePlate
        {
            get { return number; }
            set { number = value; }
        }

        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        // Конструкторы
        public Car()
        {
            mark = "Не указано";
            number = "Не указан";
            mileage = 0;
        }

        public Car(string brand, string licensePlate, int mileage)
        {
            this.mark = brand;
            this.number = licensePlate;
            this.mileage = mileage;
        }

        // Метод для вывода данных об автомобиле
        public void Show()
        {
            Console.WriteLine($"Марка: {mark}");
            Console.WriteLine($"Гос. номер: {number}");
            Console.WriteLine($"Пробег: {mileage} км");
        }
    }
}
