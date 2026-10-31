using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Spravki;

public class Spravka83 : ISpravka
{
    public string SpravkaName { get; set; }
    public Patient Patient { get; set; }
    public decimal Price { get; set; }

    public Spravka83(Patient patient, decimal price)
    {
        SpravkaName = "Справка 083";
        Patient = patient;
        Price = price;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {SpravkaName}");
        Console.WriteLine($"Пациент: {Patient.Name} {Patient.Surname}");
        Console.WriteLine($"Группа крови: {Patient.BloodType}");
        Console.WriteLine($"Цена: {Price:F2}");
    }

    public decimal CalculatePrice()
    {
        return Price;
    }

    public string GetShortInfo()
    {
        return $"{SpravkaName}: {CalculatePrice():F2}";
    }
}