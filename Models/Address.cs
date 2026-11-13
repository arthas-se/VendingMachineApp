using System;

namespace Task2;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public string BuildingNumber { get; set; }

    public Address(string city, string street, string buildingNumber)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(city);
        ArgumentException.ThrowIfNullOrWhiteSpace(street);
        ArgumentException.ThrowIfNullOrWhiteSpace(buildingNumber);

        City = city;
        Street = street;
        BuildingNumber = buildingNumber;
    }

    public override string ToString() => $"{City}, {Street}, {BuildingNumber}";
}
