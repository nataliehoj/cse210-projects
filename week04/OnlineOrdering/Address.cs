using System;

public class Address
{
    private string Street;
    private string City;
    private string State;
    private string Country;

    private string Province;

    public Address(string _Street, string _City, string _State, string _Country, string _Province)
    {
        Street = _Street;
        City = _City;
        State = _State;
        Country = _Country;
        Province = _Province;
    }

    public bool USA()
    {
        return Country == "USA";
    }

    public string GetFullAddress()
    {
        if (USA())
        {
            return $"{Street}\n, {City}\n, {State}\n, {Country}";
        }
        else
        {
            return $"{Street}\n, {City}\n, {Province}\n, {Country}";
        }
    }

    public void DisplayFullAddress()
    {
        Console.WriteLine("Address:");
        Console.WriteLine(GetFullAddress());
    }
}