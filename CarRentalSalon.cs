using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    // Виконуємо інструкцію інтерфейсу ICarRentalService (обов'язкова наявність в класі GiveTheCar та ReturnCar)
    public class CarRentalSalon : ICarRentalService
    {
        //List з автомобілями
        private readonly List<Auto> autoList = new List<Auto>();
        //List з користувачами
        private readonly List<Client> userList = new List<Client>();
        //Додаємо авто до List
        public void AddAuto(Auto auto)
        {
            this.autoList.Add(auto);
        }
        //Додаємо користувача до List
        public void AddUsers(Client user)
        {
            this.userList.Add(user);
        }
        //Видаємо авто користувачу
        public void GiveTheCar(string NumberAuto, string UserId)
        {
            // Приклад розширеного запису пошуку в списку
            //User user = null;
            //foreach (var u in userList)
            //{
            //    if (u.UserId == UserId)
            //    {
            //        user = u;
            //        break; 
            //    }
            //}
            var user = userList.FirstOrDefault(u => u.UserId == UserId);
            var auto = autoList.FirstOrDefault(a => a.NumberAuto == NumberAuto);
            //Перевірити чи авто доступне і чи не в ремонті
            if (auto.IsAvailable == true && auto.IsUnderRepair == false)
            {
                user.autos.Add(auto);
                auto.IsAvailable = false;
                //Виводим список автомобілів які взяв користувач в оренду
                Console.WriteLine($"Користувач {user.Name} взяв в оренду {user.autos.Count} автомобiль.");
                foreach (var item in user.autos)
                {
                    Console.WriteLine(item.GetDescription());
                }
            }
            else
            {
                    Console.WriteLine("Автомобiль вiдсутнiй (Орендований, або в ремонті)");
            }
        }
        //Забираємо авто у користувача
        public void ReturnCar(string NumberAuto, string UserId)
        {
            var user = userList.FirstOrDefault(u => u.UserId == UserId);
            var auto = autoList.FirstOrDefault(a => a.NumberAuto == NumberAuto);

            if (auto != null)
            {
                user.autos.Remove(auto);
                auto.IsAvailable = true;
                Console.WriteLine($"Користувач {user.Name} повернув автомобiль {auto.BrandAuto} {auto.ModelAuto} | {auto.NumberAuto}.");
            }
            else
            {
                Console.WriteLine($"Користувач {user.Name} НE брав в оренду {auto.BrandAuto} {auto.ModelAuto} | {auto.NumberAuto}.");
            }
            }
        //Отримуємо весь список автомобілів які є в компанії
        public List<Auto> GetAllCars()
        {
            return autoList;
        }
        //Виводимо перелік автомобілів компанії в Console
        public void PrintListAuto()
        {
            Console.WriteLine("Перелiк автомобiлiв компанiї:");
            foreach (var item in GetAllCars())
            {
                Console.WriteLine($"Марка: {item.BrandAuto} | Модель:{item.ModelAuto} | Номер: {item.NumberAuto} | Доступно: {item.IsAvailable}.");
            }
        }
        //Віддаємо авто в ремонт
        public void GiveCarForRepair(string NumberAuto)
        {
            var auto = autoList.FirstOrDefault(a => a.NumberAuto == NumberAuto);
            if (auto.IsAvailable == true)
            {
                auto.IsUnderRepair = true;
                auto.IsAvailable = false;
                Console.WriteLine($"Автомобiль {auto.BrandAuto} | {auto.NumberAuto} відправлено на ремонт");
            }
            else
            {
                Console.WriteLine($"Неможливо відправити на ремонт автомобiль {auto.BrandAuto} | {auto.NumberAuto}. Автомобіль в оренді");
            }
        }
        //Забираємо авто з ремонту
        public void ReturnCarForRepair(string NumberAuto)
        {
            var auto = autoList.FirstOrDefault(a => a.NumberAuto == NumberAuto);
            if (auto.IsUnderRepair == true)
            {
                auto.IsUnderRepair = false;
                auto.IsAvailable = true;
                Console.WriteLine($"Автомобiль {auto.BrandAuto} | {auto.NumberAuto} повернуто з ремонту");
            }
            else
            {
                Console.WriteLine($"Автомобiль {auto.BrandAuto} | {auto.NumberAuto} НЕ був в ремонті");
            }
        }
    }
}
