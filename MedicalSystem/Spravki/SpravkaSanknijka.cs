using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Spravki;

public class SpravkaSanknijka : ISpravka
{
    public string SpravkaName { get; set; }
    public Patient Patient { get; set; }
    public decimal Price { get; set; }

    public int AnalysesCount { get; set; }

    public SpravkaSanknijka(Patient patient, decimal price,
        int analysesCount)
    {
        SpravkaName = "Санитарная книжка";
        Patient = patient;
        Price = price;
        AnalysesCount = analysesCount;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {SpravkaName}");
        Console.WriteLine($"Пациент: {Patient.Name} {Patient.Surname}");
        Console.WriteLine($"Группа крови: {Patient.BloodType}");
        Console.WriteLine($"Основная цена: {Price:F2}");
        Console.WriteLine($"Количество анализов: {AnalysesCount}");
    }

    public decimal CalculatePrice()
    {
        return Price + AnalysesCount * 150m;
    }

    public string GetShortInfo()
    {
        return $"{SpravkaName}: {CalculatePrice():F2}";
    }
}