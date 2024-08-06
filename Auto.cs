using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Використано загальний абстрактний клас. Його наслідують клас для різних автомобілів: легкові, вантажні, спецтехніка, автобудинки, пікапи.........
    public abstract class Auto
    {
        public string BrandAuto { get; set; }
        public string ModelAuto { get; set; }
        public string NumberAuto { get; set; }
        private bool isAvailable = true;
        public bool IsAvailable
        {
            get => isAvailable;
            set => isAvailable = value;
        }
        private bool isUnderRepair = false;
        public bool IsUnderRepair
        {
            get => isUnderRepair;
            set => isUnderRepair = value;
        }
        //Абстрактний метод для опису авто
        public abstract string GetDescription();

    }
}
