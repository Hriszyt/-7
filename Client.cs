using System;
using System.Collections.Generic;

public class Client
{
    public string ClientID { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public List<string> Preferences { get; set; } = new List<string>();

    public override string ToString()
    {
        return $"ID: {ClientID}, Name: {FullName}, Phone: {PhoneNumber}, Email: {Email}, Preferences: {string.Join(", ", Preferences)}";
    }
}