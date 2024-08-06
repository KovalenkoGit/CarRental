using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    //Клас в якому описано користувачів. В майбутньому можна зробити наслідником нового класу VipUser
    public class Client : Person
    {
        public bool DrivingLicense { get; set; }
        public List<Auto> autos = new List<Auto>();
    }
}
