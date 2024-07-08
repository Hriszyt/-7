using System;
using System.Collections.Generic;

public class Program
{
    private static TravelAgency travelAgency = new TravelAgency
    {
        AgencyName = "Best Travel Agency",
        Address = "123 Main St, Sofia",
        Manager = "John Doe"
    };

    public static void Main()
    {
        string choice;
        do
        {
            Console.WriteLine("\nTravel Agency Management System");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. Remove Client");
            Console.WriteLine("3. Search Client by Name");
            Console.WriteLine("4. List All Clients");
            Console.WriteLine("5. Add Tour Package");
            Console.WriteLine("6. Remove Tour Package");
            Console.WriteLine("7. Search Tour Package by Destination");
            Console.WriteLine("8. List All Tour Packages");
            Console.WriteLine("9. Add Guide");
            Console.WriteLine("10. Remove Guide");
            Console.WriteLine("11. Add Reservation");
            Console.WriteLine("12. Cancel Reservation");
            Console.WriteLine("13. Generate Sales Report");
            Console.WriteLine("14. Generate Guide Report");
            Console.WriteLine("15. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddClient();
                    break;
                case "2":
                    RemoveClient();
                    break;
                case "3":
                    SearchClientByName();
                    break;
                case "4":
                    ListAllClients();
                    break;
                case "5":
                    AddTourPackage();
                    break;
                case "6":
                    RemoveTourPackage();
                    break;
                case "7":
                    SearchTourPackageByDestination();
                    break;
                case "8":
                    ListAllTourPackages();
                    break;
                case "9":
                    AddGuide();
                    break;
                case "10":
                    RemoveGuide();
                    break;
                case "11":
                    AddReservation();
                    break;
                case "12":
                    CancelReservation();
                    break;
                case "13":
                    GenerateSalesReport();
                    break;
                case "14":
                    GenerateGuideReport();
                    break;
                case "15":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try
