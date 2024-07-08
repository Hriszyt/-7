using System;
using System.Collections.Generic;
using System.Linq;

public class TravelAgency
{
    public string AgencyName { get; set; }
    public string Address { get; set; }
    public string Manager { get; set; }

    public List<Client> Clients { get; set; } = new List<Client>();
    public List<TourPackage> TourPackages { get; set; } = new List<TourPackage>();
    public List<Guide> Guides { get; set; } = new List<Guide>();
    public List<Reservation> Reservations { get; set; } = new List<Reservation>();

    // Client management
    public void AddClient(Client client)
    {
        Clients.Add(client);
        Console.WriteLine("Client added successfully.");
    }

    public void RemoveClient(string clientID)
    {
        var client = Clients.FirstOrDefault(c => c.ClientID == clientID);
        if (client != null)
        {
            Clients.Remove(client);
            Console.WriteLine("Client removed successfully.");
        }
        else
        {
            Console.WriteLine("Client not found.");
        }
    }

    public List<Client> SearchClientByName(string name)
    {
        return Clients.Where(c => c.FullName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void ListAllClients()
    {
        if (Clients.Any())
        {
            Clients.ForEach(c => Console.WriteLine(c));
        }
        else
        {
            Console.WriteLine("No clients found.");
        }
    }

    // TourPackage management
    public void AddTourPackage(TourPackage tourPackage)
    {
        TourPackages.Add(tourPackage);
        Console.WriteLine("Tour package added successfully.");
    }

    public void RemoveTourPackage(string packageID)
    {
        var tourPackage = TourPackages.FirstOrDefault(tp => tp.PackageID == packageID);
        if (tourPackage != null)
        {
            TourPackages.Remove(tourPackage);
            Console.WriteLine("Tour package removed successfully.");
        }
        else
        {
            Console.WriteLine("Tour package not found.");
        }
    }

    public List<TourPackage> SearchTourPackageByDestination(string destination)
    {
        return TourPackages.Where(tp => tp.Destination.Contains(destination, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void ListAllTourPackages()
    {
        if (TourPackages.Any())
        {
            TourPackages.ForEach(tp => Console.WriteLine(tp));
        }
        else
        {
            Console.WriteLine("No tour packages found.");
        }
    }

    // Guide management
    public void AddGuide(Guide guide)
    {
        Guides.Add(guide);
        Console.WriteLine("Guide added successfully.");
    }

    public void RemoveGuide(string guideID)
    {
        var guide = Guides.FirstOrDefault(g => g.GuideID == guideID);
        if (guide != null)
        {
            Guides.Remove(guide);
            Console.WriteLine("Guide removed successfully.");
        }
        else
        {
            Console.WriteLine("Guide not found.");
        }
    }

    // Reservation management
    public void AddReservation(Reservation reservation)
    {
        Reservations.Add(reservation);
        Console.WriteLine("Reservation added successfully.");
    }

    public void CancelReservation(string reservationID)
    {
        var reservation = Reservations.FirstOrDefault(r => r.ReservationID == reservationID);
        if (reservation != null)
        {
            reservation.Status = "Cancelled";
            Console.WriteLine("Reservation cancelled successfully.");
        }
        else
        {
            Console.WriteLine("Reservation not found.");
        }
    }

    // Reports
    public void GenerateSalesReport()
    {
        Console.WriteLine("Generating sales report...");
        var confirmedReservations = Reservations.Where(r => r.Status == "Confirmed").ToList();
        if (confirmedReservations.Any())
        {
            foreach (var reservation in confirmedReservations)
            {
                var client = Clients.FirstOrDefault(c => c.ClientID == reservation.ClientID);
                var tourPackage = TourPackages.FirstOrDefault(tp => tp.PackageID == reservation.PackageID);
                Console.WriteLine($"Reservation ID: {reservation.ReservationID}, Client: {client.FullName}, Package: {tourPackage.Destination}, Date: {reservation.ReservationDate}");
            }
        }
        else
        {
            Console.WriteLine("No confirmed reservations found.");
        }
    }

    public void GenerateGuideReport()
    {
        Console.WriteLine("Generating guide report...");
        foreach (var guide in Guides)
        {
            var guideReservations = Reservations.Where(r => r.Status == "Confirmed" && r.PackageID == guide.GuideID).Count();
            Console.WriteLine($"Guide ID: {guide.GuideID}, Name: {guide.FullName}, Number of Tours: {guideReservations}");
        }
    }
}
