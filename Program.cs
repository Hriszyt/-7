namespace ConsoleApp3
using System;
using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)

        class Client
        {
            public string ClientID { get; set; }
            public string FullName { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public List<string> Preferences { get; set; }

            public Client(string clientID, string fullName, string phoneNumber, string email, List<string> preferences)
            {
                ClientID = clientID;
                FullName = fullName;
                PhoneNumber = phoneNumber;
                Email = email;
                Preferences = preferences;
            }
        }

    }
}