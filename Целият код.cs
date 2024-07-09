using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var travelAgency = new TravelAgency("Sunny Tours", "София, България", "Ивайло Иванов");

            while (true)
            {
                Console.WriteLine("Главно меню:");
                Console.WriteLine("1. Добавяне на клиент");
                Console.WriteLine("2. Премахване на клиент");
                Console.WriteLine("3. Търсене на клиент по име");
                Console.WriteLine("4. Списък с всички клиенти");
                Console.WriteLine("5. Добавяне на туристически пакет");
                Console.WriteLine("6. Премахване на туристически пакет");
                Console.WriteLine("7. Търсене на туристически пакет по дестинация");
                Console.WriteLine("8. Списък с всички туристически пакети");
                Console.WriteLine("9. Добавяне на екскурзовод");
                Console.WriteLine("10. Премахване на екскурзовод");
                Console.WriteLine("11. Добавяне на резервация");
                Console.WriteLine("12. Отмяна на резервация");
                Console.WriteLine("13. Генериране на отчет за продажбите");
                Console.WriteLine("14. Генериране на отчет за екскурзоводите");
                Console.WriteLine("15. Изход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddClient(travelAgency);
                        break;
                    case "2":
                        RemoveClient(travelAgency);
                        break;
                    case "3":
                        SearchClientByName(travelAgency);
                        break;
                    case "4":
                        travelAgency.ListAllClients();
                        break;
                    case "5":
                        AddTourPackage(travelAgency);
                        break;
                    case "6":
                        RemoveTourPackage(travelAgency);
                        break;
                    case "7":
                        SearchTourPackageByDestination(travelAgency);
                        break;
                    case "8":
                        travelAgency.ListAllTourPackages();
                        break;
                    case "9":
                        AddGuide(travelAgency);
                        break;
                    case "10":
                        RemoveGuide(travelAgency);
                        break;
                    case "11":
                        AddReservation(travelAgency);
                        break;
                    case "12":
                        CancelReservation(travelAgency);
                        break;
                    case "13":
                        travelAgency.GenerateSalesReport();
                        break;
                    case "14":
                        travelAgency.GenerateGuideReport();
                        break;
                    case "15":
                        return;
                    default:
                        Console.WriteLine("Невалиден избор, моля опитайте отново.");
                        break;
                }
            }
        }

        static void AddClient(TravelAgency travelAgency)
        {
            Console.WriteLine("Въведете данни за клиента.");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("Име: ");
            string name = Console.ReadLine();
            Console.Write("Телефон: ");
            string phone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Предпочитания (разделени със запетаи): ");
            string preferencesInput = Console.ReadLine();
            List<string> preferences = preferencesInput.Split(',').ToList();

            var client = new Client(id, name, phone, email, preferences);
            travelAgency.AddClient(client);
        }

        static void RemoveClient(TravelAgency travelAgency)
        {
            Console.Write("Въведете ID на клиента за премахване: ");
            string id = Console.ReadLine();
            travelAgency.RemoveClient(id);
        }

        static void SearchClientByName(TravelAgency travelAgency)
        {
            Console.Write("Въведете име за търсене: ");
            string name = Console.ReadLine();
            var clients = travelAgency.SearchClientByName(name);
            foreach (var client in clients)
            {
                Console.WriteLine($"ID: {client.ClientID}, Име: {client.FullName}, Телефон: {client.PhoneNumber}, Email: {client.Email}");
            }
        }

        static void AddTourPackage(TravelAgency travelAgency)
        {
            Console.WriteLine("Въведете данни за туристическия пакет.");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("Дестинация: ");
            string destination = Console.ReadLine();
            Console.Write("Продължителност (дни): ");
            int duration = int.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Налични места: ");
            int spots = int.Parse(Console.ReadLine());
            Console.Write("ID на екскурзовод: ");
            string guideId = Console.ReadLine();

            var package = new TourPackage(id, destination, duration, price, spots, guideId);
            travelAgency.AddTourPackage(package);
        }

        static void RemoveTourPackage(TravelAgency travelAgency)
        {
            Console.Write("Въведете ID на туристическия пакет за премахване: ");
            string id = Console.ReadLine();
            travelAgency.RemoveTourPackage(id);
        }

        static void SearchTourPackageByDestination(TravelAgency travelAgency)
        {
            Console.Write("Въведете дестинация за търсене: ");
            string destination = Console.ReadLine();
            var packages = travelAgency.SearchTourPackageByDestination(destination);
            foreach (var package in packages)
            {
                Console.WriteLine($"ID: {package.PackageID}, Дестинация: {package.Destination}, Продължителност: {package.Duration} дни, Цена: {package.Price} лв.");
            }
        }

        static void AddGuide(TravelAgency travelAgency)
        {
            Console.WriteLine("Въведете данни за екскурзовода.");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("Име: ");
            string name = Console.ReadLine();
            Console.Write("Езици (разделени със запетаи): ");
            string languagesInput = Console.ReadLine();
            List<string> languages = languagesInput.Split(',').ToList();
            Console.Write("Години опит: ");
            int experience = int.Parse(Console.ReadLine());

            var guide = new Guide(id, name, languages, experience);
            travelAgency.AddGuide(guide);
        }

        static void RemoveGuide(TravelAgency travelAgency)
        {
            Console.Write("Въведете ID на екскурзовода за премахване: ");
            string id = Console.ReadLine();
            travelAgency.RemoveGuide(id);
        }

        static void AddReservation(TravelAgency travelAgency)
        {
            Console.WriteLine("Въведете данни за резервацията.");
            Console.Write("ID на резервация: ");
            string reservationId = Console.ReadLine();
            Console.Write("ID на клиент: ");
            string clientId = Console.ReadLine();
            Console.Write("ID на туристически пакет: ");
            string packageId = Console.ReadLine();
            Console.Write("Дата на резервация (гггг-мм-дд): ");
            DateTime reservationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Статус (Потвърдена/Чакаща/Отменена): ");
            string status = Console.ReadLine();

            var reservation = new Reservation(reservationId, clientId, packageId, reservationDate, status);
            travelAgency.AddReservation(reservation);
        }

        static void CancelReservation(TravelAgency travelAgency)
        {
            Console.Write("Въведете ID на резервацията за отмяна: ");
            string id = Console.ReadLine();
            travelAgency.CancelReservation(id);
        }
    }
}
