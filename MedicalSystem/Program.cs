using System.Globalization;
using MedicalSystem;
using MedicalSystem.Interfaces;
using MedicalSystem.Users;
using MedicalSystem.Spravki;
using MedicalSystem.Notifications;

CultureInfo.CurrentCulture = new CultureInfo("ru-RU");

Console.WriteLine("===== MEDICAL SYSTEM =====");

Console.Write("Имя пациента: ");
string name = Console.ReadLine()!;

Console.Write("Фамилия пациента: ");
string surname = Console.ReadLine()!;

Console.Write("Номер телефона: ");
string phone = Console.ReadLine()!;

Console.Write("Email: ");
string email = Console.ReadLine()!;

Console.Write("Группа крови: ");
string bloodType = Console.ReadLine()!;

Patient patient = new Patient(
    name, surname, phone, email, bloodType);

Spravka83 spravka83 = new Spravka83(patient, 100);

SpravkaSanknijka sanknijka =
    new SpravkaSanknijka(patient, 300, 3);

SpravkaBassein bassein =
    new SpravkaBassein(patient, 200, 6);

List<ISpravka> spravki = new List<ISpravka>
{
    spravka83,
    sanknijka,
    bassein
};

Console.WriteLine("\n===== СПИСОК СПРАВОК =====");

foreach (ISpravka spravka in spravki)
{
    spravka.DisplayInfo();
    Console.WriteLine($"К оплате: {spravka.CalculatePrice():F2}");
    Console.WriteLine();
}

Console.WriteLine("===== КРАТКАЯ ИНФОРМАЦИЯ =====");

foreach (ISpravka spravka in spravki)
{
    Console.WriteLine(spravka.GetShortInfo());
}

Kassa kassa = new Kassa();

kassa.PrintCheck(spravki);

Console.WriteLine("\n===== УВЕДОМЛЕНИЕ =====");
Console.WriteLine("1 - SMS");
Console.WriteLine("2 - Email");
Console.WriteLine("3 - Telegram");

Console.Write("Выберите способ уведомления: ");
string choice = Console.ReadLine()!;

INotifier notifier;

if (choice == "1")
{
    notifier = new SmsNotifier();
}
else if (choice == "2")
{
    notifier = new EmailNotifier();
}
else if (choice == "3")
{
    notifier = new TelegramNotifier();
}
else
{
    Console.WriteLine("Неверный выбор!");
    return;
}

notifier.Send(patient, "Ваша справка готова");

Console.WriteLine("\nПрограмма завершена.");