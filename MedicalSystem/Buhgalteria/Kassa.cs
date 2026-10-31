using MedicalSystem.Interfaces;

namespace MedicalSystem;

public class Kassa
{
    public decimal Total(List<ISpravka> spravki)
    {
        decimal sum = 0;

        foreach (ISpravka spravka in spravki)
        {
            sum += spravka.CalculatePrice();
        }

        return sum;
    }

    public void PrintCheck(List<ISpravka> spravki)
    {
        Console.WriteLine("\n========== ЧЕК ==========");

        foreach (ISpravka spravka in spravki)
        {
            Console.WriteLine(spravka.GetShortInfo());
        }

        Console.WriteLine("-------------------------");
        Console.WriteLine($"Итого: {Total(spravki):F2}");
        Console.WriteLine("=========================");
    }
}