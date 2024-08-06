using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Клас в якому є можливість додати нові методи, поля які потрібні тільки цьому класу.
    public class Client : Person
    {
        //Тестове поле для визначення чи є в клієнта водійське посвідчення
        public bool DrivingLicense { get; set; }
    }
}
