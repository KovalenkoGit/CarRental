using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Використано наслідування від класу Auto який в свою чергу наслідує абстрактний клас AutoItem (маємо доступ до його методів)
    internal class Car : Auto
    {
        //Додано поле для тесту (Легковий автомобіль може бути кабріолетом. Попереджаємо про це)
        public bool Cabriolet { get; set; }
        public override string GetDescription()
        {
            if (Cabriolet)
            {
                // Використовую базовий клас Auto та додаю до нього новий текст. Можна повністю переоприділити метот і вивести зовсім інший текст
                //наприклад return $"{BrandAuto} легковий автомобіль з відкидним верхом. Номерний знак {NumberAuto}";
                return base.GetDescription() + $" (Увага, кабріолет)";
            }
            else 
            {
                return base.GetDescription();
            }

        }
    }
}
