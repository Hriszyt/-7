using System;

public class Reservation
{
    public string ReservationID { get; set; }
    public string ClientID { get; set; }
    public string PackageID { get; set; }
    public DateTime ReservationDate { get; set; }
    public string Status { get; set; } // Confirmed, Pending, Cancelled

    public override string ToString()
    {
        return $"ID: {ReservationID}, Client ID: {ClientID}, Package ID: {PackageID}, Date: {ReservationDate}, Status: {Status}";
    }
}
