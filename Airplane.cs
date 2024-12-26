using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneAp
{
    public class Airplane
    {
        public string Model; // Модель самолета
        public int Range; // Дальность полета
        public string Company; // Авиакомпания
        public decimal FuelConsumption; // Потребление горючего

        public Airplane(string model, int range, string company, decimal fuelConsumption)
        {
            Model = model;
            Range = range;
            Company = company;
            FuelConsumption = fuelConsumption;
        }

        public override string ToString()
        {
            return $"Самолет: {Model} ({Company}), Дальность полета: {Range} км, Потребление горючего: {FuelConsumption} л/100км";
        }
    }

}






