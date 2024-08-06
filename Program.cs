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
            //Беремо автомобілі в оренду
            carRentalSalon.GiveTheCar(cars[0].NumberAuto, users[0].UserId);
            carRentalSalon.GiveTheCar(cars[1].NumberAuto, users[1].UserId);
            carRentalSalon.GiveTheCar(truck.NumberAuto, users[1].UserId);
            //Повертаємо авто з перевіркою чи брав користувач саме таке авто
            carRentalSalon.ReturnCar(cars[0].NumberAuto, users[0].UserId);
            //Пробуємо повторно взяти автомобіль який уже орендовано
            carRentalSalon.GiveTheCar(cars[1].NumberAuto, users[0].UserId);
            //відправляємо авто на ремонт
            carRentalSalon.GiveCarForRepair(cars[0].NumberAuto);
            carRentalSalon.GiveCarForRepair(cars[1].NumberAuto);
            //Пробуємо орендувати авто яке в ремонті
            carRentalSalon.GiveTheCar(cars[0].NumberAuto, users[0].UserId);
            //Забираємо авто з ремонту
            carRentalSalon.ReturnCarForRepair(cars[0].NumberAuto);
            carRentalSalon.ReturnCarForRepair(cars[1].NumberAuto);
            //Виводимо список всих автомобілів компанії з приміткою який доступний а який в оренді
            carRentalSalon.PrintListAuto();
        }
    }
}
