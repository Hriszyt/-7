using System;

public class TourPackage
{
    public string PackageID { get; set; }
    public string Destination { get; set; }
    public int Duration { get; set; }
    public decimal Price { get; set; }
    public int AvailableSpots { get; set; }
    public string GuideID { get; set; }

    public override string ToString()
    {
        return $"ID: {PackageID}, Destination: {Destination}, Duration: {Duration} days, Price: {Price:C}, Available Spots: {AvailableSpots}, Guide ID: {GuideID}";
    }
}
