using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public class Person
    {
        //Клас з полями користувачів. Може бути наслідником класів Клієнт, VipClient....
        public string UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        //List для взятих авто певним клієнтом
        public List<Auto> autos = new List<Auto>();
    }
}
