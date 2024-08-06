using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Клас наслідує абстрактний клас AutoItem
    public class Auto : AutoItem
    {
        //Використано абстрактний метод. Для виводу інформації про автомобіль - опис (наслідувано від абстрактного класу AutoItem)
        public override string GetDescription()
        {
            return $"Марка: {BrandAuto} | Модель:{ModelAuto} | Номер: {NumberAuto} | Доступно: {IsAvailable}";
        }

    }
}
