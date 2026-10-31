using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Spravki;

public class SpravkaBassein : ISpravka
{
    public string SpravkaName { get; set; }
    public Patient Patient { get; set; }
    public decimal Price { get; set; }

    public DateTime Date { get; set; }
    public int ValidMonths { get; set; }

    public DateTime ExpirationDate
    {
        get { return Date.AddMonths(ValidMonths); }
    }

    public SpravkaBassein(Patient patient, decimal price,
        int validMonths)
    {
        SpravkaName = "Справка в бассейн";
        Patient = patient;
        Price = price;
        Date = DateTime.Now;
        ValidMonths = validMonths;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {SpravkaName}");
        Console.WriteLine($"Пациент: {Patient.Name} {Patient.Surname}");
        Console.WriteLine($"Группа крови: {Patient.BloodType}");
        Console.WriteLine($"Цена: {Price:F2}");
        Console.WriteLine($"Дата выдачи: {Date.ToShortDateString()}");
        Console.WriteLine($"Срок действия: {ValidMonths} месяцев");
        Console.WriteLine($"Действительна до: {ExpirationDate.ToShortDateString()}");
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