using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Інтерфейс видачі автомобіля в прокат та отримання автомобіля з прокату (використовуємо в класі CarRentalSalon)
    public interface ICarRentalService
    {
        void GiveTheCar(string NumberAuto, string UserId);
        void ReturnCar(string NumberAuto, string UserId);
    }
}
