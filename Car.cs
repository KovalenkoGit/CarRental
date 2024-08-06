using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Використано наслідування від класу Auto (маємо доступ до його методів. в даному випадку абстрактний метод)
    internal class Car : Auto
    {
        //Додано поле для тесту (Легковий автомобіль може бути кабріолетом. Попереджаємо про це)
        public bool Cabriolet { get; set; }
        public override string GetDescription()
        {
            if (Cabriolet)
            {
                // Використовую базовий клас Auto та додаю до нього новий текст. Можна повністю переоприділити метот і вивести зовсім інший текст
                return $"Марка: {BrandAuto} | Модель:{ModelAuto} | Номер: {NumberAuto}. (Увага, кабріолет)";
            }
            else 
            {
                return $"Марка: {BrandAuto} | Модель:{ModelAuto} | Номер: {NumberAuto}. (Увага, автомобiль з причепом)";
            }

        }
    }
}
