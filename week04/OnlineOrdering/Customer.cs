using System;
using System.Diagnostics.Contracts;
using System.Net.Sockets;


public class Customer
{
    private string Name;
    private Address _Address;


    public Customer(string customerName, Address __Address)
    {
        Name = customerName;
        _Address = __Address;
    }

    public string GetCustomerName()
    {
        return Name;
    }

    public Address GetAddress()
    {
        return _Address;
    }

    public void DisplayAll()
    {
        Console.WriteLine("Order for:");
        Console.WriteLine($"{Name}");
    }

}