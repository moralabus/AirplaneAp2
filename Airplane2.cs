using System;
using System.Drawing;

namespace AirplaneAp2
{
    public class Airplane
    {
        public string Name { get; set; } // Имя самолета
        public string Model { get; set; } // Модель самолета
        public int Range { get; set; } // Дальность полета
        public string Company { get; set; } // Авиакомпания
        public decimal FuelConsumption { get; set; } // Потребление горючего
        public DateTime ManufactureDate { get; set; } // Дата производства

        // Статическое поле для смены цвета фона
        public static Color BackColor
        {
            get
            {
                int currentDay = DateTime.Now.DayOfWeek.GetHashCode();
                return (currentDay % 2 == 1) ? Color.LightPink : Color.LightBlue;
            }
        }

        // Конструктор с шестью параметрами
        public Airplane(string name, string model, int range, string company, decimal fuelConsumption, DateTime manufactureDate)
        {
            Name = name;
            Model = model;
            Range = range;
            Company = company;
            FuelConsumption = fuelConsumption;
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return $"Самолет: {Name}, Модель: {Model} ({Company}), Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км, Дата производства: {ManufactureDate.ToShortDateString()}";
        }
    }
}