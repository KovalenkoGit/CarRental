using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CarRentalSalon carRentalSalon = new CarRentalSalon();
            //Для теста додаємо користувачів (масивом)
            Client[] users = new Client[]
            {
                new Client
                {
                    Name = "Johan",
                    UserId = "UA-0020002",
                    DrivingLicense = true
                },
                new Client
                {
                    Name = "Michelle",
                    UserId = "UA-0020003",
                    DrivingLicense = true
                }
            };
            //Для теста додаємо легкові автомобілі (масивом)
            Car[] cars = new Car[]
            {
                new Car
                {
                    BrandAuto = "BMW",
                    ModelAuto = "E60",
                    NumberAuto = "AA1001BB",
                    Cabriolet = false
                },
                new Car
                {
                    BrandAuto = "Opel",
                    ModelAuto = "Astra",
                    NumberAuto = "CA1909CB",
                    Cabriolet = false
                }
            };
            //Для теста додаємо вантажні автомобілі (додано без масива)
            Truck truck = new Truck
            {
                BrandAuto = "MAN",
                ModelAuto = "DF-345",
                NumberAuto ="BI2020HO",
                Trailer = true
            };
            //Записуємо користувачів в List
            foreach (var user in users)
            {
                carRentalSalon.AddUsers(user);
            }
            //Записуємо автомобілі в List
            foreach (var car in cars)
            {
                carRentalSalon.AddAuto(car);
            }
            carRentalSalon.AddAuto(truck);
            Console.WriteLine("------------Всі авто компанії------------");
            carRentalSalon.PrintListAuto();
            //Беремо автомобілі в оренду
            Console.WriteLine("------------Видаємо авто клієнтам------------");
            carRentalSalon.GiveTheCar(cars[0].NumberAuto, users[0].UserId);
            carRentalSalon.GiveTheCar(cars[1].NumberAuto, users[1].UserId);
            carRentalSalon.GiveTheCar(truck.NumberAuto, users[1].UserId);
            //Повертаємо авто з перевіркою чи брав користувач саме таке авто
            Console.WriteLine("------------Приймаємо авто від клієнтів------------");
            carRentalSalon.ReturnCar(cars[0].NumberAuto, users[0].UserId);
            //Пробуємо повторно взяти автомобіль який уже орендовано
            Console.WriteLine("------------Спроба взяти авто якого нема в наявності------------");
            carRentalSalon.GiveTheCar(cars[1].NumberAuto, users[0].UserId);
            //Відправляємо авто на ремонт
            Console.WriteLine("------------Відправляємо авто на ремонт------------");
            carRentalSalon.GiveCarForRepair(cars[0].NumberAuto);
            carRentalSalon.GiveCarForRepair(cars[1].NumberAuto);
            //Пробуємо орендувати авто яке в ремонті
            Console.WriteLine("------------Спроба взяти авто яке знаходиться на ремонті------------");
            carRentalSalon.GiveTheCar(cars[0].NumberAuto, users[0].UserId);
            //Забираємо авто з ремонту
            Console.WriteLine("------------Забираємо авто з ремонту------------");
            carRentalSalon.ReturnCarForRepair(cars[0].NumberAuto);
            carRentalSalon.ReturnCarForRepair(cars[1].NumberAuto);
            //Виводимо список всих автомобілів компанії з приміткою який доступний а який в оренді
            Console.WriteLine("------------Виводимо список всих автомобілів компанії з урахуванням доступності------------");
            carRentalSalon.PrintListAuto();
        }
    }
}
