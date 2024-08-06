using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public interface IPerson
    {
        //Інтерфейс для Person. Обов'язкове заповнення імені користувача
        string Name { get; set; }
    }
}
