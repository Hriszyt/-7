using System;
using System.Collections.Generic;

public class Guide
{
    public string GuideID { get; set; }
    public string FullName { get; set; }
    public List<string> Languages { get; set; } = new List<string>();
    public int Experience { get; set; } // in years

    public override string ToString()
    {
        return $"ID: {GuideID}, Name: {FullName}, Languages: {string.Join(", ", Languages)}, Experience: {Experience} years";
    }
}
