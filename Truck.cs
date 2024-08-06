using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Використано наслідування від класу Auto який в свою чергу наслідує абстрактний клас AutoItem (маємо доступ до його методів)
    public class Truck : Auto
    {
        //Додано поле для тесту (Вантажний автомобіль може здаватися в оренду з причепом. Попереджаємо про це)
        public bool Trailer { get; set; }
        public override string GetDescription()
        {
            if (Trailer) 
            {
                // Використовую базовий клас Auto та додаю до нього новий текст. Можна повністю переоприділити метот і вивести зовсім інший текст
                //наприклад return $"{BrandAuto} грузовий автомобіль з причепом. Номерний знак {NumberAuto}";
                return base.GetDescription() + $" (Увага, автомобiль з причепом)";
            }
            else
            {
                return base.GetDescription();
            }
        }
    }
}
