using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRental
{
    //Використано абстрактний клас. Його наслідує клас Auto для виводу інформації про автомобіль
    public abstract class AutoItem
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
        public abstract string GetDescription();
    }
}
